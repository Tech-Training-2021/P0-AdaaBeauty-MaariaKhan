using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections;
using System.Threading;


namespace BeautyStore
{
    class RegisterUser1
    {
        public string username { get; set; }
        public string password { get; set; }
        public string registertime { get; set; }
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

    class Adaa
    {
        static void Main(string[] args)
        {
            StoreAdaa mystore = new StoreAdaa();
            string input;
            //string savePath = (@"C:\Users\Lenovo\source\repos\userdemo");
            int ID = 0;
            bool login = false;
            //bool adminLogin = false;

            string[] usernameArray = File.ReadAllLines(@"C:\Users\Maaria Khan\OneDrive\Documents\BeautyStore\BeautyStore\username.txt");//loads a text file and sets it to an array
            ArrayList username = new ArrayList(usernameArray);//sets the array to an array list
            string[] passwordArray = File.ReadAllLines(@"C:\Users\Maaria Khan\OneDrive\Documents\BeautyStore\BeautyStore\password.txt");
            ArrayList password = new ArrayList(passwordArray);
            string[] timeArray = File.ReadAllLines(@"C:\Users\Maaria Khan\OneDrive\Documents\BeautyStore\BeautyStore\time.txt");
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
                string ad_usr = Console.ReadLine();
                string usr = ad.Username;
                Console.WriteLine();
                Console.WriteLine("Enter password for admin :");
                string ad_pd = Console.ReadLine();
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
3 Shutdown");

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
                            string[] usernames = File.ReadAllLines(@"C:\Users\Maaria Khan\OneDrive\Documents\BeautyStore\BeautyStore\username.txt");
                            //string passwords = File.ReadAllText(@"C:\Users\User\Downloads\userdemonew\userdemo\userdemo\password.txt");
                            string[] logintimes = File.ReadAllLines(@"C:\Users\Maaria Khan\OneDrive\Documents\BeautyStore\BeautyStore\time.txt");

                            Console.WriteLine("Registration Details of users\n");
                            Console.WriteLine("______________________________________________________");
                            Console.WriteLine("Username                 |             Registration Time");
                            Console.WriteLine("_________________________|____________________________");
                            //Console.Write($@"{usernames}      |      {logintimes}");
                            for (int i = 0; i < usernames.Length; i++)
                            {
                                Console.WriteLine($@"{usernames[i]}                             {logintimes[i]}");
                            }
                            Console.WriteLine();
                            goto adminDashboard;


                        case "3":
                            Console.Clear();
                            Console.WriteLine("Shutting down");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                        default:
                            break;
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
                                using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\OneDrive\Documents\BeautyStore\BeautyStore\time.txt"))//creates a txt file called time
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


                    string usrname = "";
                    string pwd = "";
                    string dt = "";

                    Console.WriteLine("What would you like your user name to be?");
                    username:
                    input = Console.ReadLine();
                    input = input.ToLower();
                    if (input == "")
                    {
                        Console.WriteLine("Please enter a username");
                        goto username;
                    }
                    foreach (string name in username)
                    {
                        if (name == input)//checks if there is a user name called that already
                        {
                            Console.WriteLine("Sorry this username is already taken");
                            Console.ReadKey();
                            goto start;
                        }
                    }
                    usrname = input;
                    username.Add(input);//adds the username to the username list
                    Console.WriteLine("What would you like your password to be?");
                    password:
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        Console.WriteLine("Please enter a password");
                        goto password;
                    }
                    pwd = input;
                    password.Add(input);//adds the password to the password list
                    using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\OneDrive\Documents\BeautyStore\BeautyStore\username.txt"))//creates a txt file called username
                    {
                        foreach (string name in username)
                        {
                            writer.WriteLine(name);//adds a new line to the txt file for the user
                        }
                    }
                    using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\OneDrive\Documents\BeautyStore\BeautyStore\password.txt"))
                    {
                        foreach (string pass in password)
                        {
                            writer.WriteLine(pass);
                        }
                    }
                    dt = Convert.ToString(DateTime.Now);
                    //time.Add(Convert.ToString(DateTime.Now));
                    time.Add(dt);
                    using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\OneDrive\Documents\BeautyStore\BeautyStore\time.txt"))//creates a txt file called username
                    {
                        foreach (string date in time)
                        {
                            writer.WriteLine(date);//adds a new line to the txt file for the user
                        }
                    }


                    RegisterUser1 u = new RegisterUser1()
                    {
                        username = usrname,
                        password = pwd,
                        registertime = dt
                    };

                    string jsonResultAsStr2 = JsonConvert.SerializeObject(u);
                    //Console.WriteLine(jsonResultAsStr);

                    File.AppendAllText(@"userregister.json", jsonResultAsStr2);
                    //Console.WriteLine("Stored!");
                    Console.WriteLine("User created!");
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
            goto start;

            menu:
            Console.Clear();

            string user = Convert.ToString(username[ID]);
            Console.WriteLine(@"Main menu 
Welcome back " + user);
            mystore.MyStore();
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
                    break;

                case "2":
                case "changepassword":
                    Console.WriteLine("What would you like your new password to be?");
                    input = Console.ReadLine();
                    password[ID] = input;
                    using (TextWriter writer = File.CreateText(@"C:\Users\Maaria Khan\OneDrive\Documents\BeautyStore\BeautyStore\password.txt"))
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
            goto start;
        }
    
    
    }
}
