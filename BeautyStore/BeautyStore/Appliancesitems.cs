using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace BeautyStore
{ 
    public class Appliancesitems
    {
        /*StoreAdaa mystore = new StoreAdaa();

        public string opt3 = "";
        public string qnty = "";
        public string opt4 = "";
        public int counter = 0;
        string mykey = "";
        string myvalue = "";

        string hairstraightner1 = "";
        string hairstraightner2 = "";
        string hairstraightner3 = "";
        string hairstraightner4 = "";
        string hairstraightner5 = "";
        string hairstraightner6 = "";

        string hairdryer1 = "";
        string hairdryer2 = "";
        string hairdryer3 = "";
        string hairdryer4 = "";
        string hairdryer5 = "";
        string hairdryer6 = "";

        string faceepilator1 = "";
        string faceepilator2 = "";
        string faceepilator3 = "";
        string faceepilator4 = "";
        string faceepilator5 = "";
        string faceepilator6 = "";

        string shavers1 = "";
        string shavers2 = "";
        string shavers3 = "";
        string shavers4 = "";
        string shavers5 = "";
        string shavers6 = "";

        string trimmers1 = "";
        string trimmers2 = "";
        string trimmers3 = "";
        string trimmers4 = "";
        string trimmers5 = "";
        string trimmers6 = "";

        string haircurler1 = "";
        string haircurler2 = "";
        string haircurler3 = "";
        string haircurler4 = "";
        string haircurler5 = "";
        string haircurler6 = "";


        string myorder = "";
        string cartitems = "";
        string cartquantity = "";

        Dictionary<string, string> items = new Dictionary<string, string>();

        char c1;
        char c2;
        char c3;

        public void StoreApplianceitems()
        {
            Appliances appliance1 = new Appliances()
            {
                Hairstraightner = "Philips Selfie Straightner",
                Hairdryer = "Ikonic Professional Superstar Hair Dryer",
                Faceepilator = "Mamaearth Rice Hair Oil",
                Shavers = "Philips Cordless Grooming Kit",
                Trimmers = "Philips OneBlade Hybrid Trimmer",
                Haircurler = "Biotique Herb Hair Color"
            };

            Appliances appliance2 = new Appliances()
            {
                Hairstraightner = "VEGA Adore Flat Hair Straightner",
                Hairdryer = "Agaro Salon Style Hair Dryer",
                Faceepilator = "Moroccanoil Treatment Oil",
                Shavers = "Philips Multigroom Kit",
                Trimmers = "Philips Showerproof Body Groomer",
                Haircurler = "Streax Coffee Collection"
            };

            Appliances appliance3 = new Appliances()
            {
                Hairstraightner = "Babyliss Hair Straightner",
                Hairdryer = "Philips Hair Dryer",
                Faceepilator = "Forest Essential Oil",
                Shavers = "Braun Series Electric Shaver",
                Trimmers = "Alan Truman Atom 510 Home Grooming Kit",
                Haircurler = "Revlon Colorsilk Hair Color"
            };

            Appliances appliance4 = new Appliances()
            {
                Hairstraightner = "Agaro Instastraight Hair Straightner",
                Hairdryer = "VEGA Blooming Hair Dryer",
                Faceepilator = "Indulekha Bringha Hair Oil",
                Shavers = "Remington All in One Grooming Kit",
                Trimmers = "Gorgia Professional Trimmer",
                Haircurler = "Godrej Nupur Henna "
            };

            Appliances appliance5 = new Appliances()
            {
                Hairstraightner = "Dyson Coralle Hair Straightner",
                Hairdryer = "Dyson Supersonic Hair Dryer",
                Faceepilator = "Max Care Virgin Coconut Oil",
                Shavers = "Panasonic Spinet Shaver",
                Trimmers = "Ustraa Chome Lithium Powered Trimmer ",
                Haircurler = "Nova NHT-1073 Pofessional Cordless Trimmer"
            };

            Appliances appliance6 = new Appliances()
            {
                Hairstraightner = "Philips Advanced KeraShine Straightner",
                Hairdryer = "BaByliss Hair Dryerr",
                Faceepilator = "Wella Professional Luminous Oil",
                Shavers = "Wahl Lihium Ion All in One Grooming Kit",
                Trimmers = "Matrix Biolage Serum",
                Haircurler = "LOreal Paris Casting Creme Gloss "
            };
            //appliances file objects serializing
            string myappliance1 = JsonConvert.SerializeObject(appliance1);
            File.WriteAllText(@"appliance.json", myappliance1);
            string myappliance2 = JsonConvert.SerializeObject(appliance2);
            File.AppendAllText(@"appliance.json", myappliance2);
            string myappliance3 = JsonConvert.SerializeObject(appliance3);
            File.AppendAllText(@"appliance.json", myappliance3);
            string myappliance4 = JsonConvert.SerializeObject(appliance4);
            File.AppendAllText(@"appliance.json", myappliance4);
            string myappliance5 = JsonConvert.SerializeObject(appliance5);
            File.AppendAllText(@"appliance.json", myappliance5);
            string myappliance6 = JsonConvert.SerializeObject(appliance6);
            File.AppendAllText(@"appliance.json", myappliance6);

            //desrializing Appliances file objects
            Appliances ap1 = JsonConvert.DeserializeObject<Appliances>(myappliance1);
            Appliances ap2 = JsonConvert.DeserializeObject<Appliances>(myappliance2);
            Appliances ap3 = JsonConvert.DeserializeObject<Appliances>(myappliance3);
            Appliances ap4 = JsonConvert.DeserializeObject<Appliances>(myappliance4);
            Appliances ap5 = JsonConvert.DeserializeObject<Appliances>(myappliance5);
            Appliances ap6 = JsonConvert.DeserializeObject<Appliances>(myappliance6);

            //accessing hairstraightners
            hairstraightner1 = ap1.Hairstraightner;
            hairstraightner2 = ap2.Hairstraightner;
            hairstraightner3 = ap3.Hairstraightner;
            hairstraightner4 = ap4.Hairstraightner;
            hairstraightner5 = ap5.Hairstraightner;
            hairstraightner6 = ap6.Hairstraightner;


            //accessing hairdryers
            hairdryer1 = ap1.Hairstraightner;
            hairdryer2 = ap2.Hairstraightner;
            hairdryer3 = ap3.Hairstraightner;
            hairdryer4 = ap4.Hairstraightner;
            hairdryer5 = ap5.Hairstraightner;
            hairdryer6 = ap6.Hairstraightner;

            //accessing faceepilators
            faceepilator1 = ap1.Faceepilator;
            faceepilator2 = ap2.Faceepilator;
            faceepilator3 = ap3.Faceepilator;
            faceepilator4 = ap4.Faceepilator;
            faceepilator5 = ap5.Faceepilator;
            faceepilator6 = ap6.Faceepilator;

            //accessing  shavers
            shavers1 = ap1.Shavers;
            shavers2 = ap2.Shavers;
            shavers3 = ap3.Shavers;
            shavers4 = ap4.Shavers;
            shavers5 = ap5.Shavers;
            shavers6 = ap6.Shavers;

            //accessing Trimmers
            trimmers1 = ap1.Trimmers;
            trimmers2 = ap2.Trimmers;
            trimmers3 = ap3.Trimmers;
            trimmers4 = ap4.Trimmers;
            trimmers5 = ap5.Trimmers;
            trimmers6 = ap6.Trimmers;

            //accessing  Haircurlers
            haircurler1 = ap1.Haircurler;
            haircurler2 = ap2.Haircurler;
            haircurler3 = ap3.Haircurler;
            haircurler4 = ap4.Haircurler;
            haircurler5 = ap5.Haircurler;
            haircurler6 = ap6.Haircurler;


        }



        public void MyAppliances(string opt2)
        {
            switch (opt2)
            {
                case "1":
                    //Hair straightner
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Philips Selfie Straightner      ");
                    Console.WriteLine("     2.VEGA Adore Flat Hair Straightner       ");
                    Console.WriteLine("     3.Babyliss Hair Straightner       ");
                    Console.WriteLine("     4.Agaro Instastraight Hair Straightner      ");
                    Console.WriteLine("     5.Dyson Coralle Hair Straightner     ");
                    Console.WriteLine("     6.Philips Advanced KeraShine Straightner      ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    HairstraightnerCart(opt3, qnty);
                    break;


                case "2":
                    //Hair Dryer
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Ikonic Professional Superstar Hair Dryer      ");
                    Console.WriteLine("     2.Agaro Salon Style Hair Dryer   ");
                    Console.WriteLine("     3.Philips Hair Dryer    ");
                    Console.WriteLine("     4.VEGA Blooming Hair Dryer");
                    Console.WriteLine("     5.Dyson Supersonic Hair Dryer    ");
                    Console.WriteLine("     6.BaByliss Hair Dryer    ");
                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    HairdryerCart(opt3, qnty);
                    break;

                case "3":
                    //Face Epilator continue yaha se
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Mamaearth Rice Hair Oil      ");
                    Console.WriteLine("     2.Moroccanoil Treatment Oil   ");
                    Console.WriteLine("     3.Forest Essential Oil    ");
                    Console.WriteLine("     4.Indulekha Bringha Hair Oil     ");
                    Console.WriteLine("     5.Max Care Virgin Coconut Oil   ");
                    Console.WriteLine("     6.Wella Professional Luminous Oil    ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    FaceepilatorCart(opt3, qnty);
                    break;

                case "4":
                    //Shavers
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Livion Serum     ");
                    Console.WriteLine("     2.Streax Professional Serum   ");
                    Console.WriteLine("     3. Matrix Opti Care Professional Serum   ");
                    Console.WriteLine("     4.LOreal Paris Total Repair 5 Serum    ");
                    Console.WriteLine("     5.Tresemme Keratin Smooth Hair Serum   ");
                    Console.WriteLine("     6.Matrix Biolage Serum   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    ShaversCart(opt3, qnty);
                    break;

                case "5":
                    //Trimmers
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Livion Serum     ");
                    Console.WriteLine("     2.Streax Professional Serum   ");
                    Console.WriteLine("     3. Matrix Opti Care Professional Serum   ");
                    Console.WriteLine("     4.LOreal Paris Total Repair 5 Serum    ");
                    Console.WriteLine("     5.Tresemme Keratin Smooth Hair Serum   ");
                    Console.WriteLine("     6.Matrix Biolage Serum   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    TrimmersCart(opt3, qnty); 
                    break;

                case "6":
                    //Hair Curler
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Biotique Herb Hair Color     ");
                    Console.WriteLine("     2.Streax Coffee Collection   ");
                    Console.WriteLine("     3.Revlon Colorsilk Hair Color   ");
                    Console.WriteLine("     4.Godrej Nupur Henna    ");
                    Console.WriteLine("     5.Joves Herbal Henna   ");
                    Console.WriteLine("     6.LOreal Paris Casting Creme Gloss");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    HaircurlerCart(opt3, qnty);
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;




            }
        }

        public void HairstraightnerCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(hairstraightner1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(hairstraightner2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(hairstraightner3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(hairstraightner4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(hairstraightner5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(hairstraightner6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyAppliances(opt3);

                }
                else
                {
                    foreach (KeyValuePair<string, string> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                    }

                    Orders order = new Orders()
                    {
                        Productname = mykey,
                        Quantity = myvalue

                    };
                    myorder = JsonConvert.SerializeObject(order);

                    if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                    else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }


                    Orders cart = JsonConvert.DeserializeObject<Orders>(myorder);

                    cartitems = cart.Productname;
                    cartquantity = cart.Quantity;
                    Console.WriteLine(cartitems);
                    Console.WriteLine(cartquantity);


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
                        Console.WriteLine($"                {cartitems}                    {cartquantity}         ");
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
                            MyAppliances(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyAppliances(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyAppliances(opt3);
            }

        }

        public void HairdryerCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(hairdryer1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(hairdryer2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(hairdryer3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(hairdryer4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(hairdryer5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(hairdryer6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyAppliances(opt3);

                }
                else
                {
                    foreach (KeyValuePair<string, string> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                    }

                    Orders order = new Orders()
                    {
                        Productname = mykey,
                        Quantity = myvalue

                    };
                    myorder = JsonConvert.SerializeObject(order);

                    if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                    else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }

                    Orders cart = JsonConvert.DeserializeObject<Orders>(myorder);
                    cartitems = cart.Productname;
                    cartquantity = cart.Quantity;
                    Console.WriteLine(cartitems);
                    Console.WriteLine(cartquantity);


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
                        Console.WriteLine($"                {cartitems}                    {cartquantity}         ");
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
                            MyAppliances(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyAppliances(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyAppliances(opt3);
            }

        }

        public void FaceepilatorCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(faceepilator1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(faceepilator2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(faceepilator3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(faceepilator4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(faceepilator5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(faceepilator6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyAppliances(opt3);

                }
                else
                {
                    foreach (KeyValuePair<string, string> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                    }

                    Orders order = new Orders()
                    {
                        Productname = mykey,
                        Quantity = myvalue

                    };
                    myorder = JsonConvert.SerializeObject(order);

                    if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                    else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }

                    Orders cart = JsonConvert.DeserializeObject<Orders>(myorder);
                    cartitems = cart.Productname;
                    cartquantity = cart.Quantity;
                    Console.WriteLine(cartitems);
                    Console.WriteLine(cartquantity);


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
                        Console.WriteLine($"                {cartitems}                    {cartquantity}         ");
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
                            MyAppliances(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyAppliances(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyAppliances(opt3);
            }

        }


        public void ShaversCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(shavers1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(shavers2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(shavers3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(shavers4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(shavers5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(shavers6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyAppliances(opt3);

                }
                else
                {
                    foreach (KeyValuePair<string, string> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                    }

                    Orders order = new Orders()
                    {
                        Productname = mykey,
                        Quantity = myvalue

                    };
                    myorder = JsonConvert.SerializeObject(order);

                    if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                    else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }

                    Orders cart = JsonConvert.DeserializeObject<Orders>(myorder);
                    cartitems = cart.Productname;
                    cartquantity = cart.Quantity;
                    Console.WriteLine(cartitems);
                    Console.WriteLine(cartquantity);


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
                        Console.WriteLine($"                {cartitems}                    {cartquantity}         ");
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
                            MyAppliances(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyAppliances(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyAppliances(opt3);
            }

        }


        public void TrimmersCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(trimmers1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(trimmers2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(trimmers3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(trimmers4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(trimmers5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(trimmers6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyAppliances(opt3);

                }
                else
                {
                    foreach (KeyValuePair<string, string> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                    }

                    Orders order = new Orders()
                    {
                        Productname = mykey,
                        Quantity = myvalue

                    };
                    myorder = JsonConvert.SerializeObject(order);

                    if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                    else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }

                    Orders cart = JsonConvert.DeserializeObject<Orders>(myorder);
                    cartitems = cart.Productname;
                    cartquantity = cart.Quantity;
                    Console.WriteLine(cartitems);
                    Console.WriteLine(cartquantity);


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
                        Console.WriteLine($"                {cartitems}                    {cartquantity}         ");
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
                            MyAppliances(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyAppliances(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyAppliances(opt3);
            }

        }


        public void HaircurlerCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(haircurler1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(haircurler2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(haircurler3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(haircurler4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(haircurler5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(haircurler6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyAppliances(opt3);

                }
                else
                {
                    foreach (KeyValuePair<string, string> product in items)
                    {
                        mykey = product.Key;
                        myvalue = product.Value;

                    }

                    Orders order = new Orders()
                    {
                        Productname = mykey,
                        Quantity = myvalue

                    };
                    myorder = JsonConvert.SerializeObject(order);

                    if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                    else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }

                    Orders cart = JsonConvert.DeserializeObject<Orders>(myorder);
                    cartitems = cart.Productname;
                    cartquantity = cart.Quantity;
                    Console.WriteLine(cartitems);
                    Console.WriteLine(cartquantity);


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
                        Console.WriteLine($"                {cartitems}                    {cartquantity}         ");
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
                            MyAppliances(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyAppliances(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyAppliances(opt3);
            }

        }*/



    }

}
