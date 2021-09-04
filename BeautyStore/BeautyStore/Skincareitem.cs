using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;
using System.IO;
using SkinCareDb;

namespace BeautyStore
{
    public class Skincareitem
    {
        Adaa adaa = new Adaa();
        StoreAdaa mystore = new StoreAdaa();
        Orders order;
        Orders cart;
        HistoryCart placedorder;
        HistoryCart history;

        public string conString;
        public SqlConnection connection;
        public SqlCommand command;

        public string opt3 = "";
        public string opt4 = "";
        public string opt5 = "";
        public int qnty = 0;
        public int counter = 0;
        string mykey = "";
        int myvalue = 0;
        double price;
        double grandtotal = 0;

        TonerDetails t1;
        TonerDetails t2;
        TonerDetails t3;
        TonerDetails t4;
        TonerDetails t5;
        TonerDetails t6;

        CleanserDetails c1;
        CleanserDetails c2;
        CleanserDetails c3;
        CleanserDetails c4;
        CleanserDetails c5;
        CleanserDetails c6;


        MoisturizerDetails mo1;
        MoisturizerDetails mo2;
        MoisturizerDetails mo3;
        MoisturizerDetails mo4;
        MoisturizerDetails mo5;
        MoisturizerDetails mo6;

        MaskDetails ma1;
        MaskDetails ma2;
        MaskDetails ma3;
        MaskDetails ma4;
        MaskDetails ma5;
        MaskDetails ma6;


        //Names
        protected string tone1 = "";
        protected string tone2="";
        protected string tone3="";
        protected string tone4="";
        protected string tone5 ="";
        protected string tone6 ="";

        protected string cleanse1 ="";
        protected string cleanse2 ="";
        protected string cleanse3 ="";
        protected string cleanse4 ="";
        protected string cleanse5 ="";
        protected string cleanse6 ="";

        protected string moisturize1 = "";
        protected string moisturize2 = "";
        protected string moisturize3 = "";
        protected string moisturize4 = "";
        protected string moisturize5 = "";
        protected string moisturize6 = "";

        protected string mas1 = "";
        protected string mas2 = "";
        protected string mas3 = "";
        protected string mas4 = "";
        protected string mas5 = "";
        protected string mas6 = "";

        //prices
        protected double toner1price = 0;
        protected double toner2price = 0;
        protected double toner3price = 0;
        protected double toner4price = 0;
        protected double toner5price = 0;
        protected double toner6price = 0;

        protected double cleanser1price = 0;
        protected double cleanser2price = 0;
        protected double cleanser3price = 0;
        protected double cleanser4price = 0;
        protected double cleanser5price = 0;
        protected double cleanser6price = 0;

        protected double moisturizer1price = 0;
        protected double moisturizer2price = 0;
        protected double moisturizer3price = 0;
        protected double moisturizer4price = 0;
        protected double moisturizer5price = 0;
        protected double moisturizer6price = 0;

        protected double mask1price = 0;
        protected double mask2price = 0;
        protected double mask3price = 0;
        protected double mask4price = 0;
        protected double mask5price = 0;
        protected double mask6price = 0;


        string myorder = "";
        string myplacedorder = "";
        string historycart = ""; 
        string cartitems = "";
        string cartquantity = "";

        Dictionary<string, int> items = new Dictionary<string, int>();
        List<string> itemnamecart = new List<string>();
        List<int> itemquantitycart = new List<int>();
        List<double> itempricecart = new List<double>();

        List<string> itemnamehistory = new List<string>();
        List<int> itemquantityhistory = new List<int>();
        List<double> itempricehistory = new List<double>();

        char ch1;
        char ch2;
        char ch3;
        public void StoreSkincareitem()
        {
            conString= "Server = tcp:marizserver.database.windows.net,1433; Initial Catalog = BeautyStore; Persist Security Info = False; User ID = mariz; Password = Maggi123; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";
           
        }

        public void MySkin(string opt2)
        {

            switch (opt2)
            {
                case "1":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    SkinData.GetToner(conString, out connection, out command);
                    
                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    TonerCart(opt3, qnty);
                    break;
                case "2":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    SkinData.GetCleanser(conString, out connection, out command);

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    CleanserCart(opt3, qnty);
                    break;
                case "3":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    SkinData.GetMoisturizer(conString, out connection, out command);
                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    MoisturizerCart(opt3, qnty);
                    break;
                case "4":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    SkinData.GetMask(conString, out connection, out command);

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    MaskCart(opt3, qnty);
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;

            }
        }
        public void TonerCart(string opt3,int qnty)
        {
                Console.WriteLine("Press 'y' to add product in cart:");
                Console.WriteLine("Press 'e' character to go exit:");
                Console.WriteLine("Press 'm' character to go back to main menu:");
                ch1 = Convert.ToChar(Console.ReadLine());

                if (ch1 == 'y')
                {
                    
                    switch (opt3)
                    {
                        case "1":
                            items.Add(tone1, qnty);
                            price = 0;
                            if (qnty > 1)
                            {
                                for (int i = 0; i < qnty; i++)
                                {
                                    price = price + toner1price;

                                }

                            }
                            else if (qnty == 1)
                            {
                                price += toner1price;


                            }

                            counter++;
                            break;
                        case "2":
                            items.Add(tone2, qnty);
                            price = 0;
                            if (qnty > 1)
                            {
                                for (int i = 0; i < qnty; i++)
                                {
                                    price = price + toner2price;

                                }
                            }
                            else if (qnty == 1)
                            {
                                price += toner2price;

                            }
                        
                            counter++;
                            break;
                        case "3":
                            items.Add(tone3, qnty);
                            price = 0;
                            if (qnty > 1)
                            {
                                for (int i = 0; i < qnty; i++)
                                {
                                    price = price + toner3price;

                                }

                            }
                            else if (qnty == 1)
                            {
                                price += toner3price;


                            }
                           
                            counter++;
                            break;
                        case "4":
                            items.Add(tone4, qnty);
                            price = 0;
                            if (qnty > 1)
                            {
                                for (int i = 0; i < qnty; i++)
                                {
                                    price = price + toner4price;

                                }

                            }
                            else if (qnty == 1)
                            {
                                price += toner4price;
                            }

                        counter++;
                            break;
                        case "5":
                            items.Add(tone5, qnty);
                            price = 0;
                            if (qnty > 1)
                            {
                                for (int i = 0; i < qnty; i++)
                                {
                                   price = price + toner5price;

                                }

                            }
                            else if (qnty == 1)
                            {
                                price += toner5price;

                            }

                        counter++;
                            break;
                        case "6":
                            items.Add(tone6, qnty);
                            price = 0;
                            if (qnty > 1)
                            {
                                for (int i = 0; i < qnty; i++)
                                {
                                    price = price + toner6price;

                                }

                            }
                            else if (qnty == 1)
                            {
                                price += toner6price;
                            }
                            counter++;
                            break;
                    }
                    
                    if (qnty == 0)
                    {
                        //if quantity not set means asked quantity is greater than available
                        Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                        MySkin(opt3);

                    }
                    else
                    {
                        
                        foreach(KeyValuePair<string,int> product in items)
                        {
                            mykey=product.Key;
                            myvalue=product.Value;

                            order = new Orders()
                            {
                                Productname = mykey,
                                Quantity = myvalue,
                                Price = price

                            };
                            myorder = JsonConvert.SerializeObject(order);
                            if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                            else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }
                            cart = JsonConvert.DeserializeObject<Orders>(myorder);


                        }
                        itemnamecart.Add(cart.Productname);
                        itemquantitycart.Add(cart.Quantity);
                        itempricecart.Add(cart.Price);
                        grandtotal = grandtotal + cart.Price;


                        Console.WriteLine();
                       


                        //quantity asked is within or equal to available quantity
                        Console.WriteLine("Hurrah! Item added successfully in cart!");
                        Console.WriteLine("Press 'y' to view cart or press 'c' to continue shopping:"); 
                        ch2 = Convert.ToChar(Console.ReadLine());
                        if (ch2 == 'y')
                        {
                            Console.WriteLine("**************CART ITEMS******************");
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine();
                            Console.WriteLine("                     Item Name                   |         Item quantity         |         Item Price   ");
                            Console.WriteLine();
                            for(int i = 0; i < itemnamecart.Count; i++)
                            {
                                Console.WriteLine($"                   {itemnamecart[i]}           |                {itemquantitycart[i]}             |           {itempricecart[i]} ");
                                Console.WriteLine();
                            }
                            Console.WriteLine($"                       GRAND TOTAL                  |                  {grandtotal}");
                            
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("If you want to remove item from cart press r:");
                            Console.WriteLine("If you want to place order press p:");
                            Console.WriteLine("If you want to continue shopping press c:");
                            Console.WriteLine("If you want to back to main menu press m:");
                            Console.WriteLine("If you want to go exit press e:");
                            ch3 = Convert.ToChar(Console.ReadLine());
                            if (ch3 == 'p')
                            {
                                for(int i = 0; i < itemnamecart.Count; i++)
                                {
                                    placedorder = new HistoryCart()
                                    {
                                        Productname = itemnamecart[i],
                                        Quantity=itemquantitycart[i],
                                        Price=itempricecart[i]
                                    };
                                    myplacedorder = JsonConvert.SerializeObject(placedorder);

                                    if (i == 0) { File.WriteAllText(@"historyorder.json", myorder); }
                                    else if (i > 0) { File.AppendAllText(@"historyorder.json", myorder); }

                                    history = JsonConvert.DeserializeObject<HistoryCart>(myplacedorder);

                                    itemnamehistory.Add(history.Productname);
                                    itemquantityhistory.Add(history.Quantity);
                                    itempricehistory.Add(history.Price);

                                }

                                Console.WriteLine();

                                Console.WriteLine("Congratulations ur order has been placed!");
                                Console.WriteLine("Press the appropriate option:");
                                Console.WriteLine("__________________________________________");
                                Console.WriteLine();
                                repeat:
                                Console.WriteLine("       1.View Order History!      ");
                                Console.WriteLine("       2.Go to main menu         ");
                                Console.WriteLine("       3.Continue shopping       ");
                                Console.WriteLine("__________________________________________");
                                opt5 = Console.ReadLine();
                                switch (opt5)
                                {
                                     case "1":
                                         Console.WriteLine("**************ORDER HISTORY******************");
                                         Console.WriteLine("_______________________________________________________________________________");
                                         Console.WriteLine();
                                         Console.WriteLine("                     Item Name                   |         Item quantity         |         Item Price   ");
                                         Console.WriteLine();
                                         for (int i = 0; i < itemnamecart.Count; i++)
                                         {
                                              Console.WriteLine($"                   {itemnamecart[i]}           |                {itemquantitycart[i]}             |           {itempricecart[i]} ");
                                              Console.WriteLine();
                                         }

                                         Console.WriteLine("_______________________________________________________________________________");
                                         goto repeat;
                                     case "2":
                                         mystore.MyStore();
                                         break;
                                     case "3":
                                         MySkin("1");
                                         break;

                                }
                               
                            }
                            else if (ch3 == 'r')
                            {
                                File.WriteAllText(@"order.json","");
                                Console.WriteLine("Your cart is successfully empty now!!!!");
                                Console.WriteLine("Press the appropriate option:");
                                Console.WriteLine("__________________________________________");
                                Console.WriteLine();
                                Console.WriteLine("       1.Go back to main menu      ");
                                Console.WriteLine("       2.Continue shopping         ");
                                Console.WriteLine("__________________________________________");
                                opt4 = Console.ReadLine();
                                if (opt4 == "1")
                                {
                                    mystore.MyStore();

                                }
                                else if (opt4 == "2")
                                {
                                    MySkin("1");

                                }

                            }
                            else if(ch3=='c')
                            {
                                MySkin("1");


                            }
                            else if (ch3 == 'm')
                            {
                                mystore.MyStore();

                            }
                            else if (ch3 == 'e')
                            {
                               adaa.LogoutAdaa();

                            }

                            else
                            {
                                Console.WriteLine("Incorrect character!");

                            }

                        }
                        else if (ch2 == 'c')
                        {
                            MySkin("1");

                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    
                    
                }
                else if(ch1=='m')
                {
                    mystore.MyStore();

                }
                else if(ch1=='e')
                {
                    adaa.LogoutAdaa();
                }

        }


        public void CleanserCart(string opt3, int qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart:");
            Console.WriteLine("Press 'e' character to go exit:");
            Console.WriteLine("Press 'm' character to go back to main menu:");
            ch1 = Convert.ToChar(Console.ReadLine());

            if (ch1 == 'y')
            {

                switch (opt3)
                {
                    case "1":
                        items.Add(cleanse1, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + cleanser1price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += cleanser1price;


                        }

                        counter++;
                        break;
                    case "2":
                        items.Add(cleanse2, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + cleanser2price;

                            }
                        }
                        else if (qnty == 1)
                        {
                            price += cleanser2price;

                        }

                        counter++;
                        break;
                    case "3":
                        items.Add(cleanse3, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + cleanser3price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += cleanser3price;


                        }

                        counter++;
                        break;
                    case "4":
                        items.Add(cleanse4, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + cleanser4price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += cleanser4price;
                        }

                        counter++;
                        break;
                    case "5":
                        items.Add(cleanse5, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + cleanser5price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += cleanser5price;

                        }

                        counter++;
                        break;
                    case "6":
                        items.Add(cleanse6, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + cleanser6price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += cleanser6price;
                        }
                        counter++;
                        break;
                }

                if (qnty == 0)
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MySkin(opt3);

                }
                else
                {

                    foreach (KeyValuePair<string, int> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                        order = new Orders()
                        {
                            Productname = mykey,
                            Quantity = myvalue,
                            Price = price

                        };
                        myorder = JsonConvert.SerializeObject(order);
                        if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                        else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }
                        cart = JsonConvert.DeserializeObject<Orders>(myorder);


                    }
                    

                    itemnamecart.Add(cart.Productname);
                    itemquantitycart.Add(cart.Quantity);
                    itempricecart.Add(cart.Price);
                    grandtotal = grandtotal + cart.Price;

                    Console.WriteLine();


                    //quantity asked is within or equal to available quantity
                    Console.WriteLine("Hurrah! Item added successfully in cart!");
                    Console.WriteLine("Press 'y' to view cart or press 'c' to continue shopping:");
                    Console.WriteLine("Press 'm' Go back to main menu:");
                    ch2 = Convert.ToChar(Console.ReadLine());
                    if (ch2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                     Item Name                   |         Item quantity         |         Item Price   ");
                        Console.WriteLine();
                        for (int i = 0; i < itemnamecart.Count; i++)
                        {
                            Console.WriteLine($"                   {itemnamecart[i]}           |                {itemquantitycart[i]}             |           {itempricecart[i]} ");
                            Console.WriteLine();
                        }
                        Console.WriteLine($"                       GRAND TOTAL                  |                  {grandtotal}");

                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine("If you want to remove item from cart press r:");
                        Console.WriteLine("If you want to place order press p:");
                        Console.WriteLine("If you want to continue shopping press c:");
                        Console.WriteLine("If you want to back to main menu press m:");
                        Console.WriteLine("If you want to go exit press e:");
                        ch3 = Convert.ToChar(Console.ReadLine());
                        if (ch3 == 'p')
                        {
                            for (int i = 0; i < itemnamecart.Count; i++)
                            {
                                placedorder = new HistoryCart()
                                {
                                    Productname = itemnamecart[i],
                                    Quantity = itemquantitycart[i],
                                    Price = itempricecart[i]
                                };
                                myplacedorder = JsonConvert.SerializeObject(placedorder);

                                if (i == 0) { File.WriteAllText(@"historyorder.json", myorder); }
                                else if (i > 0) { File.AppendAllText(@"historyorder.json", myorder); }

                                history = JsonConvert.DeserializeObject<HistoryCart>(myplacedorder);

                                itemnamehistory.Add(history.Productname);
                                itemquantityhistory.Add(history.Quantity);
                                itempricehistory.Add(history.Price);

                            }

                            Console.WriteLine();

                            Console.WriteLine("Congratulations ur order has been placed!");
                            Console.WriteLine("Press the appropriate option:");
                            Console.WriteLine("__________________________________________");
                            Console.WriteLine();
                        repeat:
                            Console.WriteLine("       1.View Order History!      ");
                            Console.WriteLine("       2.Go to main menu         ");
                            Console.WriteLine("       3.Continue shopping       ");
                            Console.WriteLine("__________________________________________");
                            opt5 = Console.ReadLine();
                            switch (opt5)
                            {
                                case "1":
                                    Console.WriteLine("**************CART ITEMS******************");
                                    Console.WriteLine("_______________________________________________________________________________");
                                    Console.WriteLine();
                                    Console.WriteLine("                     Item Name                   |         Item quantity         |         Item Price   ");
                                    Console.WriteLine();
                                    for (int i = 0; i < itemnamecart.Count; i++)
                                    {
                                        Console.WriteLine($"                   {itemnamecart[i]}           |                {itemquantitycart[i]}             |           {itempricecart[i]} ");
                                        Console.WriteLine();
                                    }

                                    Console.WriteLine("_______________________________________________________________________________");
                                    goto repeat;
                                case "2":
                                    mystore.MyStore();
                                    break;
                                case "3":
                                    MySkin("2");
                                    break;

                            }

                        }
                        else if (ch3 == 'r')
                        {
                            File.WriteAllText(@"order.json", "");
                            Console.WriteLine("Your cart is successfully empty now!!!!");
                            Console.WriteLine("Press the appropriate option:");
                            Console.WriteLine("__________________________________________");
                            Console.WriteLine();
                            Console.WriteLine("       1.Go back to main menu      ");
                            Console.WriteLine("       2.Continue shopping         ");
                            Console.WriteLine("__________________________________________");
                            opt4 = Console.ReadLine();
                            if (opt4 == "1")
                            {
                                mystore.MyStore();

                            }
                            else if (opt4 == "2")
                            {
                                MySkin("2");

                            }

                        }
                        else if (ch3 == 'c')
                        {
                            MySkin("2");


                        }
                        else if (ch3 == 'm')
                        {
                            mystore.MyStore();

                        }
                        else if (ch3 == 'e')
                        {
                            adaa.LogoutAdaa();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (ch2 == 'c')
                    {
                        MySkin("2");

                    }
                    else if (ch2 == 'm')
                    {
                        mystore.MyStore();

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else if (ch1 == 'm')
            {
                mystore.MyStore();
            }
            else if(ch1=='e')
            {
                adaa.LogoutAdaa();
            }

        }

        public void MoisturizerCart(string opt3, int qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart:");
            Console.WriteLine("Press 'e' character to go exit:");
            Console.WriteLine("Press 'm' character to go to main menu:");

            ch1 = Convert.ToChar(Console.ReadLine());

            if (ch1 == 'y')
            {

                switch (opt3)
                {
                    case "1":
                        items.Add(moisturize1, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + moisturizer1price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += moisturizer1price;


                        }

                        counter++;
                        break;
                    case "2":
                        items.Add(moisturize2, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + moisturizer2price;

                            }
                        }
                        else if (qnty == 1)
                        {
                            price += moisturizer2price;

                        }

                        counter++;
                        break;
                    case "3":
                        items.Add(moisturize3, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + moisturizer3price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += moisturizer3price;


                        }

                        counter++;
                        break;
                    case "4":
                        items.Add(moisturize4, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + moisturizer4price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += moisturizer4price;
                        }

                        counter++;
                        break;
                    case "5":
                        items.Add(moisturize5, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + moisturizer5price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += moisturizer5price;

                        }

                        counter++;
                        break;
                    case "6":
                        items.Add(moisturize6, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + moisturizer6price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += moisturizer6price;
                        }
                        counter++;
                        break;
                }

                if (qnty == 0)
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MySkin(opt3);

                }
                else
                {

                    foreach (KeyValuePair<string, int> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                        order = new Orders()
                        {
                            Productname = mykey,
                            Quantity = myvalue,
                            Price = price

                        };
                        myorder = JsonConvert.SerializeObject(order);
                        if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                        else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }
                        cart = JsonConvert.DeserializeObject<Orders>(myorder);

                    }
                    
                    //cartitems = cart.Productname;
                    //cartquantity = cart.Quantity;
                    itemnamecart.Add(cart.Productname);
                    itemquantitycart.Add(cart.Quantity);
                    itempricecart.Add(cart.Price);
                    grandtotal = grandtotal + cart.Price;

                    Console.WriteLine();


                    //quantity asked is within or equal to available quantity
                    Console.WriteLine("Hurrah! Item added successfully in cart!");
                    Console.WriteLine("Press 'y' to view cart or press 'c' to continue shopping:");
                    ch2 = Convert.ToChar(Console.ReadLine());
                    if (ch2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                     Item Name                   |         Item quantity         |         Item Price   ");
                        Console.WriteLine();
                        for (int i = 0; i < itemnamecart.Count; i++)
                        {
                            Console.WriteLine($"                   {itemnamecart[i]}           |                {itemquantitycart[i]}             |           {itempricecart[i]} ");
                            Console.WriteLine();
                        }
                        Console.WriteLine($"                       GRAND TOTAL                  |                  {grandtotal}");

                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine("If you want to remove item from cart press r:");
                        Console.WriteLine("If you want to place order press p:");
                        Console.WriteLine("If you want to continue shopping press c:");
                        Console.WriteLine("If you want to go to main menu press m:");
                        Console.WriteLine("If you want to go exit press e:");
                        ch3 = Convert.ToChar(Console.ReadLine());
                        if (ch3 == 'p')
                        {
                            for (int i = 0; i < itemnamecart.Count; i++)
                            {
                                placedorder = new HistoryCart()
                                {
                                    Productname = itemnamecart[i],
                                    Quantity = itemquantitycart[i],
                                    Price = itempricecart[i]
                                };
                                myplacedorder = JsonConvert.SerializeObject(placedorder);

                                if (i == 0) { File.WriteAllText(@"historyorder.json", myorder); }
                                else if (i > 0) { File.AppendAllText(@"historyorder.json", myorder); }

                                history = JsonConvert.DeserializeObject<HistoryCart>(myplacedorder);

                                itemnamehistory.Add(history.Productname);
                                itemquantityhistory.Add(history.Quantity);
                                itempricehistory.Add(history.Price);

                            }

                            Console.WriteLine();

                            Console.WriteLine("Congratulations ur order has been placed!");
                            Console.WriteLine("Press the appropriate option:");
                            Console.WriteLine("__________________________________________");
                            Console.WriteLine();
                        repeat:
                            Console.WriteLine("       1.View Order History!      ");
                            Console.WriteLine("       2.Go to main menu         ");
                            Console.WriteLine("       3.Continue shopping       ");
                            Console.WriteLine("__________________________________________");
                            opt5 = Console.ReadLine();
                            switch (opt5)
                            {
                                case "1":
                                    Console.WriteLine("**************CART ITEMS******************");
                                    Console.WriteLine("_______________________________________________________________________________");
                                    Console.WriteLine();
                                    Console.WriteLine("                     Item Name                   |         Item quantity         |         Item Price   ");
                                    Console.WriteLine();
                                    for (int i = 0; i < itemnamecart.Count; i++)
                                    {
                                        Console.WriteLine($"                   {itemnamecart[i]}           |                {itemquantitycart[i]}             |           {itempricecart[i]} ");
                                        Console.WriteLine();
                                    }

                                    Console.WriteLine("_______________________________________________________________________________");
                                    goto repeat;
                                case "2":
                                    mystore.MyStore();
                                    break;
                                case "3":
                                    MySkin("3");
                                    break;

                            }

                        }
                        else if (ch3 == 'r')
                        {
                            File.WriteAllText(@"order.json", "");
                            Console.WriteLine("Your cart is successfully empty now!!!!");
                            Console.WriteLine("Press the appropriate option:");
                            Console.WriteLine("__________________________________________");
                            Console.WriteLine();
                            Console.WriteLine("       1.Go back to main menu      ");
                            Console.WriteLine("       2.Continue shopping         ");
                            Console.WriteLine("__________________________________________");
                            opt4 = Console.ReadLine();
                            if (opt4 == "1")
                            {
                                mystore.MyStore();

                            }
                            else if (opt4 == "2")
                            {
                                MySkin("3");

                            }

                        }
                        else if (ch3 == 'c')
                        {
                            MySkin("3");


                        }
                        else if (ch3 == 'm')
                        {
                            mystore.MyStore();
                        }
                        else if (ch3 == 'e')
                        {
                            adaa.LogoutAdaa();

                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (ch2 == 'c')
                    {
                        MySkin("3");

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else if (ch1 == 'm')
            {
                mystore.MyStore();
            }

            else if (ch1 == 'e')
            {
                adaa.LogoutAdaa();
            }

        }

        public void MaskCart(string opt3, int qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart:");
            Console.WriteLine("Press 'e' character to go exit:");
            Console.WriteLine("Press 'm' character to go to main menu:");
            ch1 = Convert.ToChar(Console.ReadLine());

            if (ch1 == 'y')
            {

                switch (opt3)
                {
                    case "1":
                        items.Add(mas1, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + mask1price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += mask1price;


                        }

                        counter++;
                        break;
                    case "2":
                        items.Add(mas2, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + mask2price;

                            }
                        }
                        else if (qnty == 1)
                        {
                            price += mask2price;

                        }

                        counter++;
                        break;
                    case "3":
                        items.Add(mas3, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + mask3price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += mask3price;


                        }

                        counter++;
                        break;
                    case "4":
                        items.Add(mas4, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + mask4price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += mask4price;
                        }

                        counter++;
                        break;
                    case "5":
                        items.Add(mas5, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + mask5price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += mask5price;

                        }

                        counter++;
                        break;
                    case "6":
                        items.Add(mas6, qnty);
                        price = 0;
                        if (qnty > 1)
                        {
                            for (int i = 0; i < qnty; i++)
                            {
                                price = price + mask6price;

                            }

                        }
                        else if (qnty == 1)
                        {
                            price += mask6price;
                        }
                        counter++;
                        break;
                }

                if (qnty == 0)
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MySkin(opt3);

                }
                else
                {

                    foreach (KeyValuePair<string, int> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                        order = new Orders()
                        {
                            Productname = mykey,
                            Quantity = myvalue,
                            Price = price

                        };
                        myorder = JsonConvert.SerializeObject(order);
                        if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                        else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }
                        cart = JsonConvert.DeserializeObject<Orders>(myorder);



                    }
                    

                    //cartitems = cart.Productname;
                    //cartquantity = cart.Quantity;
                    itemnamecart.Add(cart.Productname);
                    itemquantitycart.Add(cart.Quantity);
                    itempricecart.Add(cart.Price);
                    grandtotal = grandtotal + cart.Price;

                    Console.WriteLine();


                    //quantity asked is within or equal to available quantity
                    Console.WriteLine("Hurrah! Item added successfully in cart!");
                    Console.WriteLine("Press 'y' to view cart or press 'c' to continue shopping:");
                    ch2 = Convert.ToChar(Console.ReadLine());
                    if (ch2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                     Item Name                   |         Item quantity         |         Item Price   ");
                        Console.WriteLine();
                        for (int i = 0; i < itemnamecart.Count; i++)
                        {
                            Console.WriteLine($"                   {itemnamecart[i]}           |                {itemquantitycart[i]}             |           {itempricecart[i]} ");
                            Console.WriteLine();
                        }
                        Console.WriteLine($"                       GRAND TOTAL                  |                  {grandtotal}");

                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine("If you want to remove item from cart press r:");
                        Console.WriteLine("If you want to place order press p:");
                        Console.WriteLine("If you want to continue shopping press c:");
                        Console.WriteLine("If you want to go to main menu press m:");
                        Console.WriteLine("If you want to go exit press e:");
                        ch3 = Convert.ToChar(Console.ReadLine());
                        if (ch3 == 'p')
                        {
                            for (int i = 0; i < itemnamecart.Count; i++)
                            {
                                placedorder = new HistoryCart()
                                {
                                    Productname = itemnamecart[i],
                                    Quantity = itemquantitycart[i],
                                    Price = itempricecart[i]
                                };
                                myplacedorder = JsonConvert.SerializeObject(placedorder);

                                if (i == 0) { File.WriteAllText(@"historyorder.json", myorder); }
                                else if (i > 0) { File.AppendAllText(@"historyorder.json", myorder); }

                                history = JsonConvert.DeserializeObject<HistoryCart>(myplacedorder);

                                itemnamehistory.Add(history.Productname);
                                itemquantityhistory.Add(history.Quantity);
                                itempricehistory.Add(history.Price);

                            }

                            Console.WriteLine();

                            Console.WriteLine("Congratulations ur order has been placed!");
                            Console.WriteLine("Press the appropriate option:");
                            Console.WriteLine("__________________________________________");
                            Console.WriteLine();
                        repeat:
                            Console.WriteLine("       1.View Order History!      ");
                            Console.WriteLine("       2.Go to main menu         ");
                            Console.WriteLine("       3.Continue shopping       ");
                            Console.WriteLine("__________________________________________");
                            opt5 = Console.ReadLine();
                            switch (opt5)
                            {
                                case "1":
                                    Console.WriteLine("**************CART ITEMS******************");
                                    Console.WriteLine("_______________________________________________________________________________");
                                    Console.WriteLine();
                                    Console.WriteLine("                     Item Name                   |         Item quantity         |         Item Price   ");
                                    Console.WriteLine();
                                    for (int i = 0; i < itemnamecart.Count; i++)
                                    {
                                        Console.WriteLine($"                   {itemnamecart[i]}           |                {itemquantitycart[i]}             |           {itempricecart[i]} ");
                                        Console.WriteLine();
                                    }

                                    Console.WriteLine("_______________________________________________________________________________");
                                    goto repeat;
                                case "2":
                                    mystore.MyStore();
                                    break;
                                case "3":
                                    MySkin("4");
                                    break;

                            }

                        }
                        else if (ch3 == 'r')
                        {
                            File.WriteAllText(@"order.json", "");
                            Console.WriteLine("Your cart is successfully empty now!!!!");
                            Console.WriteLine("Press the appropriate option:");
                            Console.WriteLine("__________________________________________");
                            Console.WriteLine();
                            Console.WriteLine("       1.Go back to main menu      ");
                            Console.WriteLine("       2.Continue shopping         ");
                            Console.WriteLine("__________________________________________");
                            opt4 = Console.ReadLine();
                            if (opt4 == "1")
                            {
                                mystore.MyStore();

                            }
                            else if (opt4 == "2")
                            {
                                MySkin("4");

                            }

                        }
                        else if (ch3 == 'c')
                        {
                            MySkin("4");


                        }
                        else if (ch3 == 'm')
                        {
                            mystore.MyStore();
                        }
                        else if (ch3 == 'e')
                        {
                            adaa.LogoutAdaa();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (ch2 == 'c')
                    {
                        MySkin("4");

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else if (ch1 == 'm')
            {
                mystore.MyStore();
            }

            else if (ch1 == 'e')
            {
                adaa.LogoutAdaa();
            }

        }
    }

}

