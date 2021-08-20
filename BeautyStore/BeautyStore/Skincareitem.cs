using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace BeautyStore
{
    public class Skincareitem
    {
        Adaa adaa = new Adaa();
        StoreAdaa mystore = new StoreAdaa();
        Orders order;
        string orderfile = "";

        public string opt3 = "";
        public string qnty = "";
        public string opt4 = "";
        public int counter = 0;
        string mykey = "";
        string myvalue = "";

        string toner1="";
        string toner2="";
        string toner3="";
        string toner4="";
        string toner5="";
        string toner6="";

        string cleanser1="";
        string cleanser2="";
        string cleanser3="";
        string cleanser4="";
        string cleanser5="";
        string cleanser6="";

        string moisturizer1 = "";
        string moisturizer2 = "";
        string moisturizer3 = "";
        string moisturizer4 = "";
        string moisturizer5 = "";
        string moisturizer6 = "";

        string mask1 = "";
        string mask2 = "";
        string mask3 = "";
        string mask4 = "";
        string mask5 = "";
        string mask6 = "";


        string myorder = "";
        string cartitems = "";
        string cartquantity = "";

        Dictionary<string, string> items = new Dictionary<string, string>();

        char c1;
        char c2;
        char c3;
        public void StoreSkincareitem()
        {
            SkinCare skincare1 = new SkinCare()
            {
                Toner = "Forest Essentials",
                Cleanser = "Micellar",
                Moisturizer = "Simple Kind",
                Mask = "Snail Sheet Mask"

            };
            SkinCare skincare2 = new SkinCare()
            {
                Toner = "Tea Tree",
                Cleanser = "Moms Co.Natural",
                Moisturizer = "Revitalift",
                Mask = "TonyMolly Mask"


            };
            SkinCare skincare3 = new SkinCare()
            {
                Toner = "Mamaearth Vitamin C",
                Cleanser = "Neutrogena",
                Moisturizer = "Estee Lauder",
                Mask = "Innisfree Volcanic Pore Clay"


            };
            SkinCare skincare4 = new SkinCare()
            {
                Toner = "PIXI Glow Tonic",
                Cleanser = "Cetaphil",
                Moisturizer = "Minimalist",
                Mask = "The Face Shop Real Nature Red Ginseng Face Mask"


            };
            SkinCare skincare5 = new SkinCare()
            {
                Toner = "Lakme Absolute Pore Fix Toner",
                Cleanser = "Plum Green tree",
                Moisturizer = "Klairs Freshly Juiced",
                Mask = "Prolixr Detoxifying Sea Algae Mask"


            };
            SkinCare skincare6 = new SkinCare()
            {
                Toner = "PIXI Glow Tonic",
                Cleanser = "Garnier Skin Naturals",
                Moisturizer = "Clinique Moisture Surge",
                Mask = "MCaffeine Deep Pore Cleansing Regime"


            };
            //skincare file objects serializing 
            string myskincare1 = JsonConvert.SerializeObject(skincare1);
            File.WriteAllText(@"skincare.json", myskincare1);
            string myskincare2 = JsonConvert.SerializeObject(skincare2);
            File.AppendAllText(@"skincare.json", myskincare2);
            string myskincare3 = JsonConvert.SerializeObject(skincare3);
            File.AppendAllText(@"skincare.json", myskincare3);
            string myskincare4 = JsonConvert.SerializeObject(skincare4);
            File.AppendAllText(@"skincare.json", myskincare4);
            string myskincare5 = JsonConvert.SerializeObject(skincare5);
            File.AppendAllText(@"skincare.json", myskincare5);
            string myskincare6 = JsonConvert.SerializeObject(skincare6);
            File.AppendAllText(@"skincare.json", myskincare6);

            //desrializing skincare file objects
            SkinCare sk1 = JsonConvert.DeserializeObject<SkinCare>(myskincare1);
            SkinCare sk2 = JsonConvert.DeserializeObject<SkinCare>(myskincare2);
            SkinCare sk3 = JsonConvert.DeserializeObject<SkinCare>(myskincare3);
            SkinCare sk4 = JsonConvert.DeserializeObject<SkinCare>(myskincare4);
            SkinCare sk5 = JsonConvert.DeserializeObject<SkinCare>(myskincare5);
            SkinCare sk6 = JsonConvert.DeserializeObject<SkinCare>(myskincare6);

            //accessing toners
            toner1 = sk1.Toner;
            toner2 = sk2.Toner;
            toner3 = sk3.Toner;
            toner4 = sk4.Toner;
            toner5 = sk5.Toner;
            toner6 = sk6.Toner;


            //accessing cleansers
            cleanser1 = sk1.Cleanser;
            cleanser2 = sk2.Cleanser;
            cleanser3 = sk3.Cleanser;
            cleanser4 = sk4.Cleanser;
            cleanser5 = sk5.Cleanser;
            cleanser6 = sk6.Cleanser;

            //accessing moisturizer
            moisturizer1 = sk1.Moisturizer;
            moisturizer2 = sk2.Moisturizer;
            moisturizer3 = sk3.Moisturizer;
            moisturizer4 = sk4.Moisturizer;
            moisturizer5 = sk5.Moisturizer;
            moisturizer6 = sk6.Moisturizer;

            //accessing mask
            mask1 = sk1.Mask;
            mask2 = sk2.Mask;
            mask3 = sk3.Mask;
            mask4 = sk4.Mask;
            mask5 = sk5.Mask;
            mask6 = sk6.Mask;






        }

        public void MySkin(string opt2)
        {

            switch (opt2)
            {
                case "1":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Forest Essentials      ");
                    Console.WriteLine("     2.Tea Tree       ");
                    Console.WriteLine("     3.Mamaearth Vitamin C       ");
                    Console.WriteLine("     4.PIXI Glow Tonic      ");
                    Console.WriteLine("     5.Lakme Absolute Pore Fix Toner      ");
                    Console.WriteLine("     6.Kama Ayurveda      ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    TonerCart(opt3, qnty);
                    break;
                case "2":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Micellar      ");
                    Console.WriteLine("     2.Moms Co.Natural   ");
                    Console.WriteLine("     3.Neutrogena    ");
                    Console.WriteLine("     4.Cetaphil    ");
                    Console.WriteLine("     5.Plum Green tree    ");
                    Console.WriteLine("     6.Garnier Skin Naturals    ");
                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    CleanserCart(opt3, qnty);
                    break;
                case "3":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Simple Kind      ");
                    Console.WriteLine("     2.Revitalift   ");
                    Console.WriteLine("     3.Estee Lauder    ");
                    Console.WriteLine("     4.Minimalist      ");
                    Console.WriteLine("     5.Klairs Freshly Juiced   ");
                    Console.WriteLine("     6.Clinique Moisture Surge    ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    MoisturizerCart(opt3, qnty);
                    break;
                case "4":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Snail Sheet Mask     ");
                    Console.WriteLine("     2.TonyMolly Mask   ");
                    Console.WriteLine("     3.Innisfree Volcanic Pore Clay   ");
                    Console.WriteLine("     4.The Face Shop Real Nature Red Ginseng Face Mask     ");
                    Console.WriteLine("     5.Prolixr Detoxifying Sea Algae Mask   ");
                    Console.WriteLine("     6.MCaffeine Deep Pore Cleansing Regime   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    MaskCart(opt3, qnty);
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;

            }
        }
        public void TonerCart(string opt3,string qnty)
        {
                Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
                c1 = Convert.ToChar(Console.ReadLine());

                if (c1 == 'y')
                {
                    switch (opt3)
                    {
                        case "1":
                            items.Add(toner1, qnty);
                            counter++;
                            break;
                        case "2":
                            items.Add(toner2, qnty);
                            counter++;
                            break;
                        case "3":
                            items.Add(toner3, qnty);
                            counter++;
                            break;
                        case "4":
                            items.Add(toner4, qnty);
                            counter++;
                            break;
                        case "5":
                            items.Add(toner5, qnty);
                            counter++;
                            break;
                        case "6":
                            items.Add(toner6, qnty);
                            counter++;
                            break;
                    }
                    
                    if (qnty == "")
                    {
                        //if quantity not set means asked quantity is greater than available
                        Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                        MySkin(opt3);

                    }
                    else
                    {
                        foreach(KeyValuePair<string,string> product in items)
                        {
                            mykey=product.Key;
                            myvalue=product.Value;

                            Orders order = new Orders()
                            {
                                Productname = mykey,
                                Quantity = myvalue

                            };
                            myorder = JsonConvert.SerializeObject(order);

                        }

                         

                         if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                         else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }
                         
                         
                         Orders cart = JsonConvert.DeserializeObject<Orders>(myorder);
                         
                         cartitems = cart.Productname;
                         cartquantity = cart.Quantity;
                         //Console.WriteLine(cartitems);
                         //Console.WriteLine(cartquantity);
                         orderfile = File.ReadAllText(@"order.json");


                        //quantity asked is within or equal to available quantity
                        Console.WriteLine("Hurrah! Item added successfully in cart!");
                        Console.WriteLine("Press 'y' to view cart or press 'c' to continue shopping:");
                        c2 = Convert.ToChar(Console.ReadLine());
                        if (c2 == 'y')
                        {
                            Console.WriteLine("**************CART ITEMS******************");
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine();
                            Console.WriteLine("                   Item Name                   Item quantity                   ");
                            Console.WriteLine($"                {orderfile} ");
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("If you want to remove item from cart press r:");
                            Console.WriteLine("If you want to place order press p:");
                            Console.WriteLine("If you want to continue shopping press c:");
                            c3 = Convert.ToChar(Console.ReadLine());
                            if (c3 == 'p')
                            {
                                Console.WriteLine("Congratulations ur order has been placed!");
                                mystore.MyStore();
                               
                            }
                            else if (c3 == 'r')
                            {
                                cartitems = "";
                                cartquantity = "";


                            }
                            else if(c3=='c')
                            {
                                MySkin(opt3);


                            }
                            else
                            {
                                Console.WriteLine("Incorrect character!");

                            }

                        }
                        else if (c2 == 'c')
                        {
                            MySkin(opt3);

                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    
                    
                }
                else
                {
                    MySkin(opt3);
                }

        }

        public void CleanserCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(cleanser1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(cleanser2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(cleanser3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(cleanser4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(cleanser5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(cleanser6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MySkin(opt3);

                }
                else
                {
                    foreach (KeyValuePair<string, string> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                        order = new Orders()
                        {
                            Productname = mykey,
                            Quantity = myvalue

                        };
                        myorder = JsonConvert.SerializeObject(order);

                    }

                    

                    if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                    else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }

                    Orders cart = JsonConvert.DeserializeObject<Orders>(myorder);
                    cartitems = cart.Productname;
                    cartquantity = cart.Quantity;
                    //Console.WriteLine(cartitems);
                    //Console.WriteLine(cartquantity);
                    orderfile = File.ReadAllText(@"order.json");


                    //quantity asked is within or equal to available quantity
                    Console.WriteLine("Hurrah! Item added successfully in cart!");
                    Console.WriteLine("Press 'y' to view cart or press 'c' to continue shopping:");
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"                {orderfile}");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine("If you want to remove item from cart press r:");
                        Console.WriteLine("If you want to place order press p:");
                        Console.WriteLine("If you want to continue shopping press c:");
                        c3 = Convert.ToChar(Console.ReadLine());
                        if (c3 == 'p')
                        {
                            Console.WriteLine("Congratulations ur order has been placed!");
                            mystore.MyStore();

                        }
                        else if (c3 == 'r')
                        {
                            cartitems = "";
                            cartquantity = "";


                        }
                        else if (c3 == 'c')
                        {
                            MySkin(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MySkin(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MySkin(opt3);
            }

        }

        public void MoisturizerCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(moisturizer1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(moisturizer2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(moisturizer3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(moisturizer4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(moisturizer5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(moisturizer6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MySkin(opt3);

                }
                else
                {
                    foreach (KeyValuePair<string, string> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                        Orders order = new Orders()
                        {
                            Productname = mykey,
                            Quantity = myvalue

                        };
                        myorder = JsonConvert.SerializeObject(order);

                    }

                    

                    if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                    else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }

                    Orders cart = JsonConvert.DeserializeObject<Orders>(myorder);
                    cartitems = cart.Productname;
                    cartquantity = cart.Quantity;
                    //Console.WriteLine(cartitems);
                    //Console.WriteLine(cartquantity);
                    orderfile = File.ReadAllText(@"order.json");


                    //quantity asked is within or equal to available quantity
                    Console.WriteLine("Hurrah! Item added successfully in cart!");
                    Console.WriteLine("Press 'y' to view cart or press 'c' to continue shopping:");
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"                {orderfile}");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine("If you want to remove item from cart press r:");
                        Console.WriteLine("If you want to place order press p:");
                        Console.WriteLine("If you want to continue shopping press c:");
                        c3 = Convert.ToChar(Console.ReadLine());
                        if (c3 == 'p')
                        {
                            Console.WriteLine("Congratulations ur order has been placed!");
                            mystore.MyStore();

                        }
                        else if (c3 == 'r')
                        {
                            cartitems = "";
                            cartquantity = "";


                        }
                        else if (c3 == 'c')
                        {
                            MySkin(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MySkin(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MySkin(opt3);
            }

        }


        public void MaskCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(mask1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(mask2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(mask3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(mask4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(mask5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(mask6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MySkin(opt3);

                }
                else
                {
                    foreach (KeyValuePair<string, string> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                        order = new Orders()
                        {
                            Productname = mykey,
                            Quantity = myvalue

                        };
                        myorder = JsonConvert.SerializeObject(order);

                    }

                    

                    if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                    else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }

                    Orders cart = JsonConvert.DeserializeObject<Orders>(myorder);
                    cartitems = cart.Productname;
                    cartquantity = cart.Quantity;

                    //Console.WriteLine(cartitems);
                    //Console.WriteLine(cartquantity);
                    orderfile = File.ReadAllText(@"order.json");


                    //quantity asked is within or equal to available quantity
                    Console.WriteLine("Hurrah! Item added successfully in cart!");
                    Console.WriteLine("Press 'y' to view cart or press 'c' to continue shopping:");
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"                {orderfile}");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine("If you want to remove item from cart press r:");
                        Console.WriteLine("If you want to place order press p:");
                        Console.WriteLine("If you want to continue shopping press c:");
                        c3 = Convert.ToChar(Console.ReadLine());
                        if (c3 == 'p')
                        {
                            Console.WriteLine("Congratulations ur order has been placed!");
                            mystore.MyStore();

                        }
                        else if (c3 == 'r')
                        {
                            cartitems = "";
                            cartquantity = "";


                        }
                        else if (c3 == 'c')
                        {
                            MySkin(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MySkin(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MySkin(opt3);
                
            }

        }
    }

}

