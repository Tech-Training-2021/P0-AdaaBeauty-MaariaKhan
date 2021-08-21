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
        Orders cart;
        HistoryCart placedorder;
        HistoryCart history;

        

       
        public string opt3 = "";
        public string opt4 = "";
        public string opt5 = "";
        public int qnty = 0;
        public int counter = 0;
        string mykey = "";
        int myvalue = 0;
        double price;

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
        string tone1 = "";
        string tone2="";
        string tone3="";
        string tone4="";
        string tone5="";
        string tone6="";

        string cleanse1="";
        string cleanse2="";
        string cleanse3="";
        string cleanse4="";
        string cleanse5="";
        string cleanse6="";

        string moisturize1 = "";
        string moisturize2 = "";
        string moisturize3 = "";
        string moisturize4 = "";
        string moisturize5 = "";
        string moisturize6 = "";

        string mas1 = "";
        string mas2 = "";
        string mas3 = "";
        string mas4 = "";
        string mas5 = "";
        string mas6 = "";

        //prices
        double toner1price = 0;
        double toner2price = 0;
        double toner3price = 0;
        double toner4price = 0;
        double toner5price = 0;
        double toner6price = 0;

        double cleanser1price = 0;
        double cleanser2price = 0;
        double cleanser3price = 0;
        double cleanser4price = 0;
        double cleanser5price = 0;
        double cleanser6price = 0;

        double moisturizer1price = 0;
        double moisturizer2price = 0;
        double moisturizer3price = 0;
        double moisturizer4price = 0;
        double moisturizer5price = 0;
        double moisturizer6price = 0;

        double mask1price = 0;
        double mask2price = 0;
        double mask3price = 0;
        double mask4price = 0;
        double mask5price = 0;
        double mask6price = 0;


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
            TonerDetails toner1 = new TonerDetails()
            {
                Tonername = "Forest Essentials",
                Tonerprice = 750
            };
            TonerDetails toner2 = new TonerDetails()
            {
                Tonername = "Tea Tree",
                Tonerprice = 450
            };
            TonerDetails toner3 = new TonerDetails()
            {
                Tonername = "Mamaearth Vitamin C",
                Tonerprice = 1500
            };
            TonerDetails toner4 = new TonerDetails()
            {
                Tonername = "PIXI Glow Tonic",
                Tonerprice = 2000
            };
            TonerDetails toner5 = new TonerDetails()
            {
                Tonername = "Lakme Absolute Pore Fix Toner",
                Tonerprice = 850
            };
            TonerDetails toner6 = new TonerDetails()
            {
                Tonername = "Biotique Bio Cucumber",
                Tonerprice = 350
            };
            //Cleanser json
            CleanserDetails cleanser1 = new CleanserDetails()
            {
                Cleansername= "Micellar",
                Cleanserprice=200

            };
            CleanserDetails cleanser2 = new CleanserDetails()
            {
                Cleansername = "Moms Co.Natural",
                Cleanserprice = 550

            };
            CleanserDetails cleanser3 = new CleanserDetails()
            {
                Cleansername = "Neutrogena",
                Cleanserprice = 700

            };
            CleanserDetails cleanser4 = new CleanserDetails()
            {
                Cleansername = "Cetaphil",
                Cleanserprice = 1200

            };
            CleanserDetails cleanser5  = new CleanserDetails()
            {
                Cleansername = "Plum Green tree",
                Cleanserprice = 650

            };
            CleanserDetails cleanser6 = new CleanserDetails()
            {
                Cleansername = "Garnier Skin Naturals",
                Cleanserprice = 800

            };

            MoisturizerDetails moisturizer1 = new MoisturizerDetails()
            {
                Moisturizername= "Simple Kind",
                Moisturizerprice = 1500

            };
            MoisturizerDetails moisturizer2 = new MoisturizerDetails()
            {
                Moisturizername = "Revitalift",
                Moisturizerprice = 2500

            };
            MoisturizerDetails moisturizer3 = new MoisturizerDetails()
            {
                Moisturizername = "Estee Lauder",
                Moisturizerprice = 700

            };
            MoisturizerDetails moisturizer4 = new MoisturizerDetails()
            {
                Moisturizername = "Minimalist",
                Moisturizerprice = 550

            };
            MoisturizerDetails moisturizer5 = new MoisturizerDetails()
            {
                Moisturizername = "Klairs Freshly Juiced",
                Moisturizerprice = 830

            };
            MoisturizerDetails moisturizer6 = new MoisturizerDetails()
            {
                Moisturizername = "Clinique Moisture Surge",
                Moisturizerprice = 1200

            };

            MaskDetails mask1 = new MaskDetails()
            {
                Maskname= "Snail Sheet Mask",
                Maskprice= 150

            };
            MaskDetails mask2 = new MaskDetails()
            {
                Maskname = "TonyMolly Mask",
                Maskprice = 750

            };
            MaskDetails mask3 = new MaskDetails()
            {
                Maskname = "Innisfree Volcanic Pore Clay",
                Maskprice = 1300

            };
            MaskDetails mask4 = new MaskDetails()
            {
                Maskname = "The Face Shop Real Nature Red Ginseng Face Mask",
                Maskprice = 600

            };
            MaskDetails mask5 = new MaskDetails()
            {
                Maskname = "Prolixr Detoxifying Sea Algae Mask",
                Maskprice = 1500

            };
            MaskDetails mask6 = new MaskDetails()
            {
                Maskname = "MCaffeine Deep Pore Cleansing Regime",
                Maskprice = 370

            };

            //toner file objects serializing 
            string mytoner1 = JsonConvert.SerializeObject(toner1);
            File.WriteAllText(@"tonerdetails.json", mytoner1);
            string mytoner2 = JsonConvert.SerializeObject(toner2);
            File.AppendAllText(@"tonerdetails.json", mytoner2);
            string mytoner3 = JsonConvert.SerializeObject(toner3);
            File.AppendAllText(@"tonerdetails.json", mytoner3);
            string mytoner4 = JsonConvert.SerializeObject(toner4);
            File.AppendAllText(@"tonerdetails.json", mytoner4);
            string mytoner5 = JsonConvert.SerializeObject(toner5);
            File.AppendAllText(@"tonerdetails.json", mytoner5);
            string mytoner6 = JsonConvert.SerializeObject(toner6);
            File.AppendAllText(@"tonerdetails.json", mytoner6);

            string mycleanser1 = JsonConvert.SerializeObject(cleanser1);
            File.WriteAllText(@"cleanserdetails.json", mycleanser1);
            string mycleanser2 = JsonConvert.SerializeObject(cleanser2);
            File.AppendAllText(@"cleanserdetails.json", mycleanser2);
            string mycleanser3 = JsonConvert.SerializeObject(cleanser3);
            File.AppendAllText(@"cleanserdetails.json", mycleanser3);
            string mycleanser4 = JsonConvert.SerializeObject(cleanser4);
            File.AppendAllText(@"cleanserdetails.json", mycleanser4);
            string mycleanser5 = JsonConvert.SerializeObject(cleanser5);
            File.AppendAllText(@"cleanserdetails.json", mycleanser5);
            string mycleanser6 = JsonConvert.SerializeObject(cleanser6);
            File.AppendAllText(@"cleanserdetails.json", mycleanser6);

            string mymoisturizer1 = JsonConvert.SerializeObject(moisturizer1);
            File.WriteAllText(@"moisturizerdetails.json", mymoisturizer1);
            string mymoisturizer2 = JsonConvert.SerializeObject(moisturizer2);
            File.AppendAllText(@"moisturizerdetails.json", mymoisturizer2);
            string mymoisturizer3 = JsonConvert.SerializeObject(moisturizer3);
            File.AppendAllText(@"moisturizer.json", mymoisturizer3);
            string mymoisturizer4 = JsonConvert.SerializeObject(moisturizer4);
            File.AppendAllText(@"moisturizerdetails.json", mymoisturizer4);
            string mymoisturizer5 = JsonConvert.SerializeObject(moisturizer5);
            File.AppendAllText(@"moisturizerdetails.json", mymoisturizer5);
            string mymoisturizer6 = JsonConvert.SerializeObject(moisturizer6);
            File.AppendAllText(@"moisturizerdetails.json", mymoisturizer6);

            string mymask1 = JsonConvert.SerializeObject(mask1);
            File.WriteAllText(@"maskdetails.json", mymask1);
            string mymask2 = JsonConvert.SerializeObject(mask2);
            File.AppendAllText(@"maskdetails.json", mymask2);
            string mymask3 = JsonConvert.SerializeObject(mask3);
            File.AppendAllText(@"maskdetails.json", mymask3);
            string mymask4 = JsonConvert.SerializeObject(mask4);
            File.AppendAllText(@"maskdetails.json", mymask4);
            string mymask5 = JsonConvert.SerializeObject(mask5);
            File.AppendAllText(@"maskdetails.json", mymask5);
            string mymask6 = JsonConvert.SerializeObject(mask6);
            File.AppendAllText(@"maskdetails.json", mymask6);







            //desrializing toner file objects
            t1 = JsonConvert.DeserializeObject<TonerDetails>(mytoner1);
            t2 = JsonConvert.DeserializeObject<TonerDetails>(mytoner2);
            t3 = JsonConvert.DeserializeObject<TonerDetails>(mytoner3);
            t4 = JsonConvert.DeserializeObject<TonerDetails>(mytoner4);
            t5 = JsonConvert.DeserializeObject<TonerDetails>(mytoner5);
            t6 = JsonConvert.DeserializeObject<TonerDetails>(mytoner6);

            c1 = JsonConvert.DeserializeObject<CleanserDetails>(mycleanser1);
            c2 = JsonConvert.DeserializeObject<CleanserDetails>(mycleanser2);
            c3 = JsonConvert.DeserializeObject<CleanserDetails>(mycleanser3);
            c4 = JsonConvert.DeserializeObject<CleanserDetails>(mycleanser4);
            c5 = JsonConvert.DeserializeObject<CleanserDetails>(mycleanser5);
            c6 = JsonConvert.DeserializeObject<CleanserDetails>(mycleanser6);

            mo1 = JsonConvert.DeserializeObject<MoisturizerDetails>(mymoisturizer1);
            mo2 = JsonConvert.DeserializeObject<MoisturizerDetails>(mymoisturizer2);
            mo3 = JsonConvert.DeserializeObject<MoisturizerDetails>(mymoisturizer3);
            mo4 = JsonConvert.DeserializeObject<MoisturizerDetails>(mymoisturizer4);
            mo5 = JsonConvert.DeserializeObject<MoisturizerDetails>(mymoisturizer5);
            mo6 = JsonConvert.DeserializeObject<MoisturizerDetails>(mymoisturizer6);

            ma1 = JsonConvert.DeserializeObject<MaskDetails>(mymask1);
            ma2 = JsonConvert.DeserializeObject<MaskDetails>(mymask2);
            ma3 = JsonConvert.DeserializeObject<MaskDetails>(mymask3);
            ma4 = JsonConvert.DeserializeObject<MaskDetails>(mymask4);
            ma5 = JsonConvert.DeserializeObject<MaskDetails>(mymask5);
            ma6 = JsonConvert.DeserializeObject<MaskDetails>(mymask6);


            //accessing toners

            tone1 = t1.Tonername;
            toner1price = t1.Tonerprice;
            tone2 = t2.Tonername;
            toner2price = t2.Tonerprice;
            tone3 = t3.Tonername;
            toner3price = t3.Tonerprice;
            tone4 = t4.Tonername;
            toner4price = t1.Tonerprice;
            tone5 = t5.Tonername;
            toner5price = t1.Tonerprice;
            tone6 = t6.Tonername;
            toner6price = t1.Tonerprice;

            //accessing cleansers
            cleanse1 = c1.Cleansername;
            cleanser1price = c1.Cleanserprice;
            cleanse2 = c2.Cleansername;
            cleanser2price = c2.Cleanserprice;
            cleanse3 = c3.Cleansername;
            cleanser3price = c3.Cleanserprice;
            cleanse4 = c4.Cleansername;
            cleanser4price = c4.Cleanserprice;
            cleanse5 = c5.Cleansername;
            cleanser5price = c5.Cleanserprice;
            cleanse6 = c6.Cleansername;
            cleanser6price = c6.Cleanserprice;

            //accessing moisturizers
            moisturize1 = mo1.Moisturizername;
            moisturizer1price = mo1.Moisturizerprice;
            moisturize2 = mo2.Moisturizername;
            moisturizer2price = mo2.Moisturizerprice;
            moisturize3 = mo3.Moisturizername;
            moisturizer3price = mo3.Moisturizerprice;
            moisturize4 = mo4.Moisturizername;
            moisturizer4price = mo4.Moisturizerprice;
            moisturize5 = mo5.Moisturizername;
            moisturizer5price = mo5.Moisturizerprice;
            moisturize6 = mo6.Moisturizername;
            moisturizer6price = mo6.Moisturizerprice;

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
                    qnty = int.Parse(Console.ReadLine());
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
                    qnty = int.Parse(Console.ReadLine());
                    //CleanserCart(opt3, qnty);
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
                    qnty = int.Parse(Console.ReadLine());
                    //MoisturizerCart(opt3, qnty);
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
                    qnty = int.Parse(Console.ReadLine());
                    //MaskCart(opt3, qnty);
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;

            }
        }
        public void TonerCart(string opt3,int qnty)
        {
                Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
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
                            

                        }
                        myorder = JsonConvert.SerializeObject(order);
                        if (counter == 1) { File.WriteAllText(@"order.json", myorder); }
                        else if (counter > 1) { File.AppendAllText(@"order.json", myorder); }
                        cart = JsonConvert.DeserializeObject<Orders>(myorder);

                        //cartitems = cart.Productname;
                        //cartquantity = cart.Quantity;
                        itemnamecart.Add(cart.Productname);
                        itemquantitycart.Add(cart.Quantity);
                        itempricecart.Add(cart.Price);

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
                            
                            Console.WriteLine("_______________________________________________________________________________");
                            Console.WriteLine("If you want to remove item from cart press r:");
                            Console.WriteLine("If you want to place order press p:");
                            Console.WriteLine("If you want to continue shopping press c:");
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
                                         MySkin(opt3);
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
                                    MySkin(opt3);

                                }

                            }
                            else if(ch3=='c')
                            {
                                MySkin(opt3);


                            }
                            else
                            {
                                Console.WriteLine("Incorrect character!");

                            }

                        }
                        else if (ch2 == 'c')
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
                    adaa.LogoutAdaa();
                }

        }

        /*public void CleanserCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            ch1 = Convert.ToChar(Console.ReadLine());

            if (ch1 == 'y')
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
                    case "4" :
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
                    ch2 = Convert.ToChar(Console.ReadLine());
                    if (ch2 == 'y')
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
                        ch3 = Convert.ToChar(Console.ReadLine());
                        if (ch3 == 'p')
                        {
                            Console.WriteLine("Congratulations ur order has been placed!");
                            mystore.MyStore();

                        }
                        else if (ch3 == 'r')
                        {
                            cartitems = "";
                            cartquantity = "";


                        }
                        else if (ch3 == 'c')
                        {
                            MySkin(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (ch2 == 'c')
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
                adaa.LogoutAdaa();
            }

        }

        public void MoisturizerCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            ch1 = Convert.ToChar(Console.ReadLine());

            if (ch1 == 'y')
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
                    ch2 = Convert.ToChar(Console.ReadLine());
                    if (ch2 == 'y')
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
                        ch3 = Convert.ToChar(Console.ReadLine());
                        if (ch3 == 'p')
                        {
                            Console.WriteLine("Congratulations ur order has been placed!");
                            mystore.MyStore();

                        }
                        else if (ch3 == 'r')
                        {
                            cartitems = "";
                            cartquantity = "";


                        }
                        else if (ch3 == 'c')
                        {
                            MySkin(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (ch2 == 'c')
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
                adaa.LogoutAdaa();
            }

        }


        public void MaskCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            ch1 = Convert.ToChar(Console.ReadLine());

            if (ch1 == 'y')
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
                    ch2 = Convert.ToChar(Console.ReadLine());
                    if (ch2 == 'y')
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
                        ch3 = Convert.ToChar(Console.ReadLine());
                        if (ch3 == 'p')
                        {
                            Console.WriteLine("Congratulations ur order has been placed!");
                            mystore.MyStore();

                        }
                        else if (ch3 == 'r')
                        {
                            cartitems = "";
                            cartquantity = "";


                        }
                        else if (ch3 == 'c')
                        {
                            MySkin(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (ch2 == 'c')
                    {
                        MySkin(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else if(ch1=='e')
            {
                adaa.LogoutAdaa();
                
            }

        }*/
    }

}

