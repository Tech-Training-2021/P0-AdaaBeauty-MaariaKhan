<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AdaaBeauuty.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Register Yourself to buy products at Adaa</h1>
    </div>
    <div>
        
        <form>
  <div class="form-group row">
      
  
    <asp:Label ID="lb_email" for="tb_email" Text="Label" class="col-sm-2 col-form-label" runat="server">Email:</asp:Label>
    <div class="col-sm-10">
      
        <asp:TextBox ID="tb_email" class="form-control" placeholder="Please enter your valid email" runat="server"></asp:TextBox>
    </div>
  </div>


  <div class="form-group row">
  
    <asp:Label ID="lb_password" for="tb_password" class="col-sm-2 col-form-label" runat="server" Text="Label">Password:</asp:Label>
    <div class="col-sm-10">
      
        <asp:TextBox ID="tb_password" class="form-control" placeholder="Please set your password" TextMode="Password" runat="server" ToolTip="Password should be: 8-32 char,1 special char,1 number,1 lowercase,1 uppercase"></asp:TextBox>
    </div>
  </div>

  <div class="form-group row">
  
    <asp:Label ID="lb_username" for="tb_username" class="col-sm-2 col-form-label" runat="server" Text="Label">Username:</asp:Label>
    <div class="col-sm-10">
      
        <asp:TextBox ID="tb_username" class="form-control" placeholder="Please set a valid username" runat="server" ToolTip="Please keep it within 25 characters"></asp:TextBox>
    </div>
  </div>

  <div class="form-group row">
  
    <asp:Label ID="lb_location" for="tb_location" class="col-sm-2 col-form-label" runat="server" Text="Label">Location:</asp:Label>
    <div class="col-sm-10">
      
        <asp:TextBox ID="tb_location" class="form-control" placeholder="Please enter your location" runat="server"></asp:TextBox>
    </div>
  </div>

  <div class="form-group row">
  
    <asp:Label ID="lb_phone" for="tb_phone" class="col-sm-2 col-form-label" runat="server" Text="Label">Phone:</asp:Label>
    <div class="col-sm-10">
      
        <asp:TextBox ID="tb_phone" class="form-control" placeholder="Please enter a valid phone number" runat="server" ToolTip="Please keep it exact 10 numbers"></asp:TextBox>
    </div>
  </div>

  <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button ID="Button1" OnClick="btn_register_Click" runat="server" class="btn bg-primary" Text="REGISTER"/>
                
                <div>
          <asp:GridView ID="gv_cats" runat="server" BackColor="WhiteSmoke" AutoGenerateColumns="False" DataKeyNames="RegisterId" DataSourceID="SqlDataSource1" ViewStateMode="Enabled">
              <Columns>
                  <asp:BoundField DataField="RegisterId" HeaderText="RegisterId" InsertVisible="False" ReadOnly="True" SortExpression="RegisterId" />
                  <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                  <asp:BoundField DataField="RegisterPwd" HeaderText="RegisterPwd" SortExpression="RegisterPwd" />
                  <asp:BoundField DataField="RegisterContact" HeaderText="RegisterContact" SortExpression="RegisterContact" />
                  <asp:BoundField DataField="EmailId" HeaderText="EmailId" SortExpression="EmailId" />
                  <asp:BoundField DataField="UserLocation" HeaderText="UserLocation" SortExpression="UserLocation" />
              </Columns>
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdaaConString %>" SelectCommand="SELECT mr.RegisterId, mr.UserName, mr.RegisterPwd, mr.RegisterContact, rl.EmailId, rl.UserLocation FROM myregister AS mr INNER JOIN registerlocation AS rl ON mr.RegisterId = rl.RegisterId"></asp:SqlDataSource>
      </div>
            </div>
              
              
          </div>

</form>
    
    </div>
</asp:Content>
