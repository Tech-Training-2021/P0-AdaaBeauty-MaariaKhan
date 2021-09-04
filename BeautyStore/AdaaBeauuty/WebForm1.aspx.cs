using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace AdaaBeauuty
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadGridView(string conString)
        {
            string reg_query = "select mr.RegisterId,mr.UserName,mr.RegisterPwd,mr.RegisterContact,rl.EmailId,rl.UserLocation from myregister as mr inner join registerlocation as rl on mr.RegisterId = rl.RegisterId";
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(reg_query, connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gv_cats.DataSourceID = null;
                    gv_cats.DataSource = dt;
                    gv_cats.DataBind();

                }
            }

        }




        protected void btn_register_Click(object sender, EventArgs e)
        {
            string myemail = tb_email.Text.ToString();
            string mypassword = tb_password.Text.ToString();
            string myusername = tb_username.Text.ToString();
            string mylocation = tb_location.Text.ToString();
            string myphone = tb_phone.Text.ToString();
            string myconstring = ConfigurationManager.ConnectionStrings["AdaaConString"].ConnectionString;
            string insertregquery = "insert into myregister values(@UserName,@RegisterPwd,@RegisterContact)";
            string selectregid = "select * from myregister";
            string insertregloc = "insert into registerlocation values(@RegisterId,@EmailId,@UserLocation)";
            
            
            using(SqlConnection connection=new SqlConnection(myconstring))
            {
                using(SqlCommand command=new SqlCommand(insertregquery,connection))
                {
                    command.Parameters.AddWithValue("@UserName",myusername);
                    command.Parameters.AddWithValue("@RegisterPwd", mypassword);
                    command.Parameters.AddWithValue("@RegisterContact", myphone);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    
                }
            }

            using(SqlConnection connection=new SqlConnection(myconstring))
            {
                using(SqlDataAdapter adapter=new SqlDataAdapter(selectregid, connection))
                {
                    
                    int regid=0;
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["UserName"].ToString() == myusername)
                        {
                            regid = Convert.ToInt32(row["RegisterId"]);
                            
                        } 
                        
                    }

                   

                    using(SqlCommand command=new SqlCommand(insertregloc, connection))
                    {
                        command.Parameters.AddWithValue("@RegisterId", regid);
                        command.Parameters.AddWithValue("@EmailId", myemail);
                        command.Parameters.AddWithValue("@UserLocation", mylocation);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                

                }
            }
            LoadGridView(myconstring);

        }

       
    }
}