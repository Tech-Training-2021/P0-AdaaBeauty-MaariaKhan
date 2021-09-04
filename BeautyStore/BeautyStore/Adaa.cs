using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text;

namespace BeautyStore
{
    class RegisterUser1
    {
        public static int idn = 0;
        public string username { get; set; }
        public string password { get; set; }
        public string registertime { get; set; }
        public string contact { get; set; }
        public string location { get; set; }
        public string email { get; set; }
        public string id { get; set; }
    }

    class LoginUser1
    {
        public string username { get; set; }
        public string password { get; set; }
        public string logintime { get; set; }
    }

    class Admin
    {
        private string username = "admin";
        private string password = "admin";

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }

    /*class GetPrices : Skincareitem
    {
        public void getPrice()
        {
            StoreSkincareitem();
            double price = toner1price;
        }
    }*/

    class Adaa
    {
        static string input;

        protected static string ad_usr;
        protected static string ad_pd;
        protected static Regex regex;
        protected static string usrname = "";
        protected static string email = "";
        protected static string dt = "";
        protected static Match match;
        protected static string pass = "";

        static ArrayList password;
        static string[] passwordArray;
        static ArrayList username;
        static string[] usernameArray;
        static ArrayList contactt;
        static string[] contactArray;
        static ArrayList maill;
        static string[] maillArray;
        static ArrayList locationn;
        static string[] locationArray;
        static ArrayList firstname;
        static string[] fnameArray;
        static ArrayList lastname;
        static string[] lnameArray;
        static int ID;
        static bool login = false;
        StoreAdaa sa=new StoreAdaa();
        static void Main(string[] args)
        {
            StoreAdaa mystore = new StoreAdaa();

            //string savePath = (@"C:\Users\Lenovo\source\repos\userdemo");
            string currUser = "";
            ID = 0;
            login = false;
            //bool adminLogin = false;

            maillArray = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\email.txt");//loads a text file and sets it to an array
            maill = new ArrayList(maillArray);
            contactArray = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\contact.txt");//loads a text file and sets it to an array
            contactt = new ArrayList(contactArray);//sets the array to an array list
            locationArray = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\location.txt");//loads a text file and sets it to an array
            locationn = new ArrayList(locationArray);//sets the array to an array list
            usernameArray = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\username.txt");//loads a text file and sets it to an array
            username = new ArrayList(usernameArray);//sets the array to an array list
            passwordArray = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\password.txt");
            password = new ArrayList(passwordArray);
            fnameArray = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\password.txt");
            firstname = new ArrayList(fnameArray);
            lnameArray = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\password.txt");
            lastname = new ArrayList(lnameArray);
            string[] timeArray = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\time.txt");
            ArrayList time = new ArrayList(timeArray);

        ROLE:
            Console.WriteLine("Select your role :");
            Console.WriteLine("Enter 'a' for admin or 'u' for user");
            string role = Console.ReadLine();
            Console.WriteLine();

            if (role == "U" || role == "u")
            {
                goto start;
            }
            else if (role == "A" || role == "a")
            {
                int total_attempt = 0;
                int attempt_limit = 3;


            getAdminDetails:
                Admin ad = new Admin();
                Console.WriteLine("Enter username for admin :");
                ad_usr = Console.ReadLine();
                string usr = ad.Username;
                Console.WriteLine();
                Console.WriteLine("Enter password for admin :");
                ad_pd = Console.ReadLine();
                string pd = ad.Password;

                if (ad_usr == usr && ad_pd == pd)
                {
                    Console.WriteLine("\nWelcome admin! You have logged in successfully\n");
                //adminLogin = true;

                adminDashboard:
                    Console.WriteLine(@"Admin Dashboard");
                    Console.WriteLine("________________");
                    Console.WriteLine(@"
1 Logout
2 Show User Registration Details
3 Delete customer
4 Search for a customer
5 View inventory
6 Shutdown");

                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Logged out successfully!");
                            Console.WriteLine("Redirecting to main page...\n");
                            Thread.Sleep(2000);
                            goto ROLE;

                        /*case "2":
                            //Admin admin = new Admin();
                            Console.WriteLine("Enter new username for admin :");
                            string new_adm_usr = Console.ReadLine();
                            Console.WriteLine("Enter new Password for admin :");
                            string new_adm_pd = Console.ReadLine();
                            usr = new_adm_usr;
                            pd = new_adm_pd;
                            Console.WriteLine(ad.Username);
                            Console.WriteLine(ad.Password);
                            Console.WriteLine("Setting new Usename and Password. Please wait...");
                            Thread.Sleep(3000);
                            Console.WriteLine("New username and password set successfully!");
                            goto adminDashboard;*/

                        case "2":
                            string[] usernames = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\username.txt");
                            string[] logintimes = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\time.txt");
                            string[] emails = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\email.txt");
                            string[] locations = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\location.txt");
                            string[] contacts = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\contact.txt");

                            Console.WriteLine("Registration Details of users\n");
                            Console.WriteLine("_______________________________________________________________________________________________________________________________");
                            Console.WriteLine("Username                 |          Registration Time        |         Email       |       Location      |       Contact      ");
                            Console.WriteLine("_________________________|___________________________________|_____________________|_____________________|_____________________");
                            //Console.Write($@"{usernames}      |      {logintimes}");
                            for (int i = 0; i < usernames.Length; i++)
                            {
                                Console.WriteLine($@"{usernames[i]}                   {logintimes[i]}                      {emails[i]}            {locations[i]}       {contacts[i]} ");
                            }
                            Console.WriteLine();
                            goto adminDashboard;

                        case "3":
                            /*Console.WriteLine(maill.Count);
                            Console.WriteLine(password.Count);
                            Console.WriteLine(username.Count);
                            Console.WriteLine(contactt.Count);
                            Console.WriteLine(locationn.Count);*/

                            Console.WriteLine("Enter email id for user:");
                            string emailToDelete = Console.ReadLine();

                            List<string> emaillist = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\email.txt").ToList();
                            string filepath1 = @"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\email.txt";

                            List<string> userlist = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\username.txt").ToList();
                            string filepath2 = @"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\username.txt";

                            List<string> passwordlist = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\password.txt").ToList();
                            string filepath3 = @"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\password.txt";

                            List<string> contactlist = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\contact.txt").ToList();
                            string filepath4 = @"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\contact.txt";

                            List<string> locationlist = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\location.txt").ToList();
                            string filepath5 = @"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\location.txt";


                            //string firstItem = quotelist[0];
                            //quotelist.RemoveAt(0);

                            for (int i = 0; i < emaillist.Count; i++)
                            {
                                if (emaillist[i] == emailToDelete)
                                {
                                    emaillist.RemoveAt(i);
                                    userlist.RemoveAt(i);
                                    passwordlist.RemoveAt(i);
                                    contactlist.RemoveAt(i);
                                    locationlist.RemoveAt(i);
                                }
                            }

                            Console.WriteLine("after" + maill.Count);

                            for (int i = 0; i < maill.Count; i++)
                            {
                                if (maill[i].ToString() == emailToDelete)
                                {
                                    maill.RemoveAt(i);
                                    username.RemoveAt(i);
                                    password.RemoveAt(i);
                                    locationn.RemoveAt(i);
                                    contactt.RemoveAt(i);
                                    firstname.RemoveAt(i);
                                    lastname.RemoveAt(i);
                                }
                            }

                            Console.WriteLine("after" + maill.Count);


                            Console.WriteLine("User deleted successfully!");
                            File.WriteAllLines(filepath1, emaillist.ToArray());
                            File.WriteAllLines(filepath2, userlist.ToArray());
                            File.WriteAllLines(filepath3, passwordlist.ToArray());
                            File.WriteAllLines(filepath4, contactlist.ToArray());
                            File.WriteAllLines(filepath5, locationlist.ToArray());

                            goto adminDashboard;

                        /*if(e == el)
                        {
                            Console.WriteLine("before deletion " + mail.Count);


                            Console.WriteLine("after deletion "+mail.Count);



                            /*string jsonPath = @"C:\Users\User\Downloads\P0-AdaaBeauty-MaariaKhan-master\P0-AdaaBeauty-MaariaKhan-master\BeauutyStore\BeautyStore\bin\Debug\netcoreapp3.1\userregisternew.json";


                            string strJson = JsonConvert.DeserializeObject<dynamic>(jsonPath);
                            var jObject = JObject.Parse(strJson);
                            //JArray usersArray = (JArray)jObject["User"];



                            foreach(var item in jObject)
                            {
                                foreach(var i in item)
                                {
                                    i.Property("email").Remove();
                                }

                            }*/

                        /*var strJson = File.ReadAllText(jsonPath);
                        var jObject = JObject.Parse(strJson);

                        JArray userArrray = (JArray)jObject["Users"];

                        var userToBeDeleted = userArrray.FirstOrDefault(object => object["email"].Value<string>() == e);

                        foreach(var item in userArrray)
                        {
                            Console.WriteLine(item);
                        }*/



                        case "4":

                            int counter = 0;
                            string line;

                        emailToDisplay:
                            Console.Write("Input the email of user:");
                            var emailToDisplay = Console.ReadLine();

                            string[] usernames1 = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\username.txt");
                            string[] logintimes1 = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\time.txt");
                            string[] emails1 = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\email.txt");
                            string[] locations1 = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\location.txt");
                            string[] contacts1 = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\contact.txt");

                            //StoreSkincareitem();

                            System.IO.StreamReader file =
                                new System.IO.StreamReader(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\email.txt");

                            while ((line = file.ReadLine()) != null)
                            {
                                if (line.Contains(emailToDisplay))
                                {
                                    Console.WriteLine("_______________________________________________________________________________________________________________________________");
                                    Console.WriteLine("Username                 |          Registration Time        |         Email       |       Location      |       Contact      ");
                                    Console.WriteLine("_________________________|___________________________________|_____________________|_____________________|_____________________");
                                    //Console.Write($@"{usernames}      |      {logintimes}");

                                    Console.WriteLine($@"{usernames1[counter]}                   {logintimes1[counter]}                      {emails1[counter]}            {locations1[counter]}       {contacts1[counter]} ");

                                    Console.WriteLine();
                                    goto adminDashboard;
                                }

                                counter++;
                            }

                            file.Close();

                            Console.WriteLine("Could not find the user you are searching for! Try entering a valid email id..");

                            goto emailToDisplay;

                        case "5":

                            //var inventory = new List<object>();
                            /* using (StreamReader r = new StreamReader(jsonPath))
                             {
                                 string json = r.ReadToEnd();
                                 var inventory = JsonConvert.DeserializeObject<List<MoisturizerDetails>>(json);

                                 foreach (var p in inventory)
                                 {
                                     Console.WriteLine(p);
                                 }
                             }*/

                            /*var stream = File.OpenText(jsonPath);
                            //Read the file              
                            string st = stream.ReadToEnd();
                            var jsonArray = JsonArray.Parse(st);
                            foreach (var item in jsonArray)
                            {


                            }*/

                            //products name
                            string[] skincare = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\skincare.txt");
                            string[] haircare = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\Hair.txt");
                            string[] makeup = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\makeup.txt");
                            string[] appliance = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\appliance.txt");

                            //products price
                            string[] skincareprice = File.ReadAllLines(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\skincareprices.txt");


                        opt1:
                            Console.WriteLine("Choose a product category");
                            Console.WriteLine(@"1. Makeup
2. Skincare
3. Haircare
4. Appliances");
                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                                    Console.WriteLine("_________________________________________________________________");
                                    Console.WriteLine("Makeup Product Name                      |          Price        ");
                                    Console.WriteLine("_________________________________________|_______________________");

                                    for (int i = 0; i < makeup.Length; i++)
                                    {
                                        if(i % 6 == 0)
                                        {
                                            Console.WriteLine("__________________________________________________________");
                                            Console.WriteLine($@"{makeup[i]}                          {skincareprice[i]}");
                                        }
                                        else
                                        {
                                            Console.WriteLine($@"{makeup[i]}                           {skincareprice[i]}");

                                        }
                                    }
                                    Console.WriteLine();
                                    goto adminDashboard;

                                case "2":
                                    
                                        Console.WriteLine("_______________________________________________________________");
                                        Console.WriteLine("Skincare Product Name                    |          Price        ");
                                        Console.WriteLine("_________________________________________|_____________________");

                                    for (int i = 0; i < skincare.Length; i++)
                                    {
                                        if (i % 6 == 0)
                                        {
                                            Console.WriteLine("______________________________________________________________");
                                            Console.WriteLine($@"{skincare[i]}                              {skincareprice[i]}");
                                        }
                                        else
                                        {
                                            Console.WriteLine($@"{skincare[i]}                             {skincareprice[i]}");

                                        }
                                    }
                                    Console.WriteLine();
                                        goto adminDashboard;

                                case "3":

                                    Console.WriteLine("___________________________________________________________________________");
                                    Console.WriteLine("Haicare Product Name                               |          Price        ");
                                    Console.WriteLine("___________________________________________________|_______________________");

                                    for (int i = 0; i < haircare.Length; i++)
                                    {
                                        if (i % 6 == 0)
                                        {
                                            Console.WriteLine("_________________________________________________________________");
                                            Console.WriteLine($@"{haircare[i]}                               {skincareprice[i]} ");
                                        }
                                        else
                                        {
                                            Console.WriteLine($@"{haircare[i]}                               {skincareprice[i]}");

                                        }
                                    }
                                    Console.WriteLine();
                                    goto adminDashboard;

                                case "4":
                                    Console.WriteLine("_______________________________________________________________________");
                                    Console.WriteLine("Appliance Name                                 |          Price        ");
                                    Console.WriteLine("_______________________________________________|_______________________");

                                    for (int i = 0; i < appliance.Length; i++)
                                    {
                                        if (i % 6 == 0)
                                        {
                                            Console.WriteLine("_________________________________________________________________");
                                            Console.WriteLine($@"{appliance[i]}                             {skincareprice[i]}  ");
                                        }
                                        else
                                        {
                                            Console.WriteLine($@"{appliance[i]}                             {skincareprice[i]} ");

                                        }
                                    }
                                    Console.WriteLine();
                                    goto adminDashboard;

                                default:
                                    Console.WriteLine("Invalid option!");
                                    goto opt1;
                            }


                            goto adminDashboard;

                        case "6":
                            Console.Clear();
                            Console.WriteLine("Shutting down");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Please select a valid option!");
                            goto adminDashboard;
                    }

                }

                else
                {
                    total_attempt++;
                    if (total_attempt == attempt_limit)
                    {
                        Console.WriteLine("3 Unsuccessful Attempts! Permission denied as Admin.");
                        Console.WriteLine("Your role is : 'User'\n");
                        goto usermode;
                    }
                    else
                    {
                        Console.WriteLine("Username or password does not match! Try again");
                        goto getAdminDetails;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input!\n");
                goto ROLE;
            }


        start:
            if (login == true)
            {
                goto menu;
            }
            Console.Clear();
        usermode:
            Console.WriteLine(@"What would you like to do?
1 Login
2 Register
3 Shut Down");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                case "login":
                    Console.WriteLine("What is your user name?");
                    input = Console.ReadLine();
                    input = input.ToLower();
                    if (input == "default")
                    {
                        Console.WriteLine("Please try another user name");
                        Console.ReadKey();
                        goto start;
                    }
                    foreach (string name in username)//runs through the username list
                    {
                        if (name == input)//returns true if it finds a match in the list
                        {
                            currUser = input;
                            int listNo = username.IndexOf(input);//sets the listNo to the index number of the password list that matched
                            Console.WriteLine("What is your password?");
                            input = Console.ReadLine();
                            string passCheck = Convert.ToString(password[listNo]);//sets the passCheck var to the string index no found at the same index as the user name
                          
                            if (input == passCheck) //if the input and the passCheck are the same you logged in
                            {
                                ID = listNo;//sets the ID for the user
                                string lastLogin = Convert.ToString(time[ID]);//gets the last login from the time list
                                Console.WriteLine(@"You logged in!
You last logged in at " + lastLogin);
                                time[ID] = (Convert.ToString(DateTime.Now));//sets a new login time
                                using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\time.txt"))//creates a txt file called time
                                {
                                    foreach (string date in time)
                                    {
                                        writer.WriteLine(date);//adds a new line to the txt file for time
                                    }
                                }


                                LoginUser1 myuser = new LoginUser1()
                                {
                                    username = Convert.ToString(username[listNo]),
                                    password = Convert.ToString(passCheck),
                                    logintime = Convert.ToString(time[ID])
                                };

                                string jsonResultAsStr1 = JsonConvert.SerializeObject(myuser);
                                //Console.WriteLine(jsonResultAsStr);

                                File.AppendAllText(@"userlogin.json", jsonResultAsStr1);
                                //Console.WriteLine("Stored!");


                                Console.ReadKey();
                                login = true;
                                goto start;
                            }
                        }
                    }
                    Console.WriteLine("Sorry there was some error!");
                    Console.ReadKey();
                    goto start;

                case "2":
                case "register":


                registeremail:
                    //int id = RegisterUser1.idn + 1;
                    Console.WriteLine("Enter your email for registration :");
                    email = Console.ReadLine();

                    bool val = File.ReadAllText(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\email.txt").Contains(email);

                    regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                    match = regex.Match(email);

                    if (match.Success)
                    {
                        if (val)
                        {
                            Console.WriteLine("Sorry! This email is already registered.");
                            Console.WriteLine("Try using different email for signing up..");
                            goto registeremail;
                        }
                        else if (string.IsNullOrWhiteSpace(email))
                        {
                            Console.WriteLine("Blank input(s) not allowed!");
                            goto registeremail;
                        }
                        else
                        {
                            maill.Add(email);
                            Console.WriteLine("Email registered successfully!");
                        //code for accepting username and password
                        username:
                            Console.WriteLine("What would you like your user name to be? (Please set username length under 25 characters)");
                            input = Console.ReadLine();
                            input = input.ToLower();

                            if (input == "")
                            {
                                Console.WriteLine("Username cannot be blank!");
                                goto username;
                            }
                            else if (input.Length > 25)
                            {
                                Console.WriteLine("Please set a username not more than maximum 25 characters!");
                                goto username;
                            }
                            foreach (string name in username)
                            {
                                if (name == input)//checks if there is a user name called that already
                                {
                                    Console.WriteLine("Sorry this username is already taken");
                                    Console.ReadKey();
                                    goto username;
                                }
                            }
                            usrname = input;
                            username.Add(usrname);//adds the username to the username list
                            Console.WriteLine("Username registered successfully!");

                        password:
                            Console.WriteLine("Please set your password\n");
                            Console.WriteLine(@"Note:  Your password can be 8-32 characters long and it must include at least two of the following characters:

1. At least one letter (uppercase or lowercase)
2. At least one number
3. At least one special character");
                            pass = Console.ReadLine();

                            if (pass.Length >= 8 && pass.Length <= 32)
                            {
                                var hasNumber = new Regex(@"[0-9]+");
                                var hasUpperChar = new Regex(@"[A-Z]+");
                                var hasMiniMaxChars = new Regex(@".{8,15}");
                                var hasLowerChar = new Regex(@"[a-z]+");
                                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");


                                if (string.IsNullOrWhiteSpace(pass))
                                {
                                    Console.WriteLine("Blank input(s) not allowed!");
                                    goto password;
                                }
                                else if (hasLowerChar.IsMatch(pass) && hasUpperChar.IsMatch(pass) && hasMiniMaxChars.IsMatch(pass) && hasNumber.IsMatch(pass) && hasSymbols.IsMatch(pass))
                                {
                                    password.Add(pass);
                                    Console.WriteLine("Great! Few more details...");
                                location:
                                    Console.WriteLine("Enter your current location:");
                                    string loc = Console.ReadLine();

                                    if (loc == "")
                                    {
                                        Console.WriteLine("Please enter a location!");
                                        goto location;
                                    }
                                    else
                                    {
                                        locationn.Add(loc);
                                    contact:
                                        Console.WriteLine("Please provide your contact number:");
                                        string cnt = Console.ReadLine();

                                        if (cnt.Length != 10)
                                        {
                                            Console.WriteLine("Please provide a valid contact number!");
                                            goto contact;
                                        }
                                        else
                                        {
                                            contactt.Add(cnt);//adds the password to the password list

                                            using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\email.txt"))//creates a txt file called username
                                            {
                                                foreach (string m in maill)
                                                {
                                                    writer.WriteLine(m);//adds a new line to the txt file for the user
                                                }
                                            }

                                            using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\username.txt"))//creates a txt file called username
                                            {
                                                foreach (string name in username)
                                                {
                                                    writer.WriteLine(name);//adds a new line to the txt file for the user
                                                }
                                            }

                                            using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\password.txt"))
                                            {
                                                foreach (string p in password)
                                                {
                                                    writer.WriteLine(p);
                                                }
                                            }

                                            using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\location.txt"))
                                            {
                                                foreach (string l in locationn)
                                                {
                                                    writer.WriteLine(l);
                                                }
                                            }

                                            using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\contact.txt"))
                                            {
                                                foreach (string c in contactt)
                                                {
                                                    writer.WriteLine(c);
                                                }
                                            }

                                            using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\firstnames.txt"))
                                            {
                                                foreach (string fn in firstname)
                                                {
                                                    writer.WriteLine(fn);
                                                }
                                            }

                                            using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\lastnames.txt"))
                                            {
                                                foreach (string ln in lastname)
                                                {
                                                    writer.WriteLine(ln);
                                                }
                                            }

                                            dt = Convert.ToString(DateTime.Now);
                                            //time.Add(Convert.ToString(DateTime.Now));
                                            time.Add(dt);
                                            using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\time.txt"))//creates a txt file called username
                                            {
                                                foreach (string date in time)
                                                {
                                                    writer.WriteLine(date);//adds a new line to the txt file for the user
                                                }
                                            }


                                            /*RegisterUser1 u = new RegisterUser1()
                                            {
                                                email = email,
                                                username = usrname,
                                                password = pwd,
                                                location = loc,
                                                contact = cnt,
                                                registertime = dt
                                                //id = RegisterUser1.idn.ToString()
                                            };

                                            string jsonResultAsStr2 = JsonConvert.SerializeObject(u);

                                            File.AppendAllText(@"userregister.json", jsonResultAsStr2);

                                            Console.WriteLine("User created successfully!");
                                            Console.ReadKey();
                                            goto start;*/

                                            /*RegisterUser1 u = new RegisterUser1();
                                            u.email = email;
                                            u.username = usrname;
                                            u.password = pwd;
                                            u.location = loc;
                                            u.contact = cnt;
                                            u.registertime = dt;

                                            List<RegisterUser1> userArr = new List<RegisterUser1>
                                            {
                                                u,u
                                            };

                                            var userObj = new
                                            {
                                                User = userArr
                                            };

                                            string json = JsonConvert.SerializeObject(userObj);

                                            File.AppendAllText(@"userregisternew.json", json);

                                            Console.WriteLine("User created successfully!");
                                            Console.ReadKey();
                                            goto start;*/
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid password format!");
                                    goto password;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Invalid password format!");
                                goto password;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid email format!");
                        goto registeremail;
                    }
                    break;

                case "3":
                case "shutdown":
                    Console.Clear();
                    Console.WriteLine("Shutting down");
                    Console.ReadKey();
                    Environment.Exit(0);//closes down the console
                    break;

                default:
                    Console.WriteLine("Unexpected input");
                    Console.ReadKey();
                    break;
            }
            goto start;

        menu:
            Console.Clear();

            string user = Convert.ToString(username[ID]);
            Console.WriteLine(@"Main menu 
Welcome back " + currUser);
            mystore.MyStore();


        }
        public void LogoutAdaa()
        {
            Console.WriteLine(@"
1 logout
2 ChangePassword
3 Shutdown");
            input = Console.ReadLine();
            input.ToLower();
            switch (input)
            {
                case "1":
                case "logout":
                    Console.WriteLine("Would you like to logout? y/n");
                    input = Console.ReadLine();
                    if (input == "y")
                    {
                        login = false;
                        ID = 0;
                        Console.WriteLine("Logged out");
                        Console.ReadKey();
                    }
                    else if (input == "n")
                    {
                        login = true;
                        sa.MyStore();

                    }
                    break;

                case "2":
                case "changepassword":
                    Console.WriteLine("What would you like your new password to be?");
                    input = Console.ReadLine();
                    password[ID] = input;
                    using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\myproj\P0-AdaaBeauty-MaariaKhan\BeautyStore\BeautyStore\password.txt"))
                    {
                        foreach (string pass in password)
                        {
                            writer.WriteLine(pass);
                        }
                    }
                    Console.WriteLine("Password changed!");
                    Console.ReadKey();
                    break;

                case "3":
                case "shutdown":
                    Console.Clear();
                    Console.WriteLine("Shutting down");
                    Console.ReadKey();
                    Environment.Exit(0);//closes down the console
                    break;

                default:
                    Console.WriteLine("Unexpected input");
                    Console.ReadKey();
                    break;
            }

        }


    }
}
