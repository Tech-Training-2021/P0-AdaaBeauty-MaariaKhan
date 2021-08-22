using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace BeautyStore
{
    class Haircareitems
    {
        /*public string opt3 = "";
        public string qnty = "";
        public string opt4 = "";
        public int counter = 0;

        StoreAdaa mystore = new StoreAdaa();
        Skincareitem sk = new Skincareitem();
        Dictionary<string, string> items = new Dictionary<string, string>();

        char c1;
        char c2;
        char c3;
        string mykey = "";
        string myvalue = "";
        string myorder = "";
        string cartitems = "";
        string cartquantity = "";


        string shampoo1 ="";
        string shampoo2 = "";
        string shampoo3 = "";
        string shampoo4 = "";
        string shampoo5 = "";
        string shampoo6 = "";

        string conditioner1 = "";
        string conditioner2 = "";
        string conditioner3 = "";
        string conditioner4 = "";
        string conditioner5 = "";
        string conditioner6 = "";

        //accessing all Hairoils
        string hairoil1 = "";
        string hairoil2 = "";
        string hairoil3 = "";
        string hairoil4 = "";
        string hairoil5 = "";
        string hairoil6 = "";

        //accessing all Hairserums
        string hairserum1 = "";
        string hairserum2 = "";
        string hairserum3 = "";
        string hairserum4 = "";
        string hairserum5 = "";
        string hairserum6 = "";

        //accessing all Haircolors
        string haircolor1 = "";
        string haircolor2 = "";
        string haircolor3 = "";
        string haircolor4 = "";
        string haircolor5 = "";
        string haircolor6 = "";

        //accessing all Hairmasks
        string hairmask1 = "";
        string hairmask2 = "";
        string hairmask3 = "";
        string hairmask4 = "";
        string hairmask5 = "";
        string hairmask6 = "";

        public void StoreHaircareitems()
        {
            HairCare haircare1 = new HairCare()
            {
                Shampoo = "Loreal Professional Serie Expert",
                Conditioner = "Loreal Paris Rapid Reviver",
                Hairoil = "Mamaearth Rice Hair Oil",
                Hairserum = "Livion Serum",
                Haircolor = "Biotique Herb Hair Color",
                Hairmasks = "Tresemme Deep Smoothing Mask"

            };


            HairCare haircare2 = new HairCare()
            {
                Shampoo = "Mama Earth Rice Water Shampoo",
                Conditioner = "Sebastian Professional Penetraitt",
                Hairoil = "Moroccanoil Treatment Oil",
                Hairserum = "Streax Professional Serum ",
                Haircolor = "Streax Coffee Collection",
                Hairmasks = "Mamaearth Argan Hair Mask"

            };

            HairCare haircare3 = new HairCare()
            {
                Shampoo = "Tresemme Keratin Smooth",
                Conditioner = "Matrix Opti Care ",
                Hairoil = "Forest Essential Oil",
                Hairserum = "Matrix Opti Care Professional Serum",
                Haircolor = "Revlon Colorsilk Hair Color",
                Hairmasks = "SP Luxe Oil Keratin Restore Mask"

            };

            HairCare haircare4 = new HairCare()
            {
                Shampoo = "Mamaearth Onion Shampoo",
                Conditioner = "Herbal Essences",
                Hairoil = "Indulekha Bringha Hair Oil",
                Hairserum = "LOreal Paris Total Repair 5 Serum",
                Haircolor = "Godrej Nupur Henna",
                Hairmasks = "Wella Professionals Renewing Mask "

            };

            HairCare haircare5 = new HairCare()
            {
                Shampoo = "Wella Professionals",
                Conditioner = "Loreal Paris Dream Lengths",
                Hairoil = "Max Care Virgin Coconut Oil",
                Hairserum = "Tresemme Keratin Smooth Hair Serum",
                Haircolor = "Joves Herbal Henna",
                Hairmasks = "Dove Intense Damage Repair Hair Mask"

            };

            HairCare haircare6 = new HairCare()
            {
                Shampoo = "GK Hair Balancing Shampoo",
                Conditioner = "Dove Intense Repair Conditioner",
                Hairoil = "Wella Professional Luminous Oil",
                Hairserum = "Matrix Biolage Serum",
                Haircolor = "LOreal Paris Casting Creme Gloss",
                Hairmasks = "Mamaearth Rice Water Hair Mask"

            };

            //haircare file objects serialzing
            string myhaircare1 = JsonConvert.SerializeObject(haircare1);
            File.WriteAllText(@"haircare.json", myhaircare1);
            string myhaircare2 = JsonConvert.SerializeObject(haircare2);
            File.AppendAllText(@"haircare.json", myhaircare2);
            string myhaircare3 = JsonConvert.SerializeObject(haircare3);
            File.AppendAllText(@"haircare.json", myhaircare3);
            string myhaircare4 = JsonConvert.SerializeObject(haircare4);
            File.AppendAllText(@"haircare.json", myhaircare4);
            string myhaircare5 = JsonConvert.SerializeObject(haircare5);
            File.AppendAllText(@"haircare.json", myhaircare5);
            string myhaircare6 = JsonConvert.SerializeObject(haircare6);
            File.AppendAllText(@"haircare.json", myhaircare6);

            //deserializing
            HairCare ha1 = JsonConvert.DeserializeObject<HairCare>(myhaircare1);
            HairCare ha2 = JsonConvert.DeserializeObject<HairCare>(myhaircare2);
            HairCare ha3 = JsonConvert.DeserializeObject<HairCare>(myhaircare3);
            HairCare ha4 = JsonConvert.DeserializeObject<HairCare>(myhaircare4);
            HairCare ha5 = JsonConvert.DeserializeObject<HairCare>(myhaircare5);
            HairCare ha6 = JsonConvert.DeserializeObject<HairCare>(myhaircare6);

            //accessing all shampoos
            shampoo1 = ha1.Shampoo;
            shampoo2 = ha2.Shampoo;
            shampoo3 = ha3.Shampoo;
            shampoo4 = ha4.Shampoo;
            shampoo5 = ha5.Shampoo;
            shampoo6 = ha6.Shampoo;

            //accessing all conditioners
            conditioner1 = ha1.Conditioner;
            conditioner2 = ha2.Conditioner;
            conditioner3 = ha3.Conditioner;
            conditioner4 = ha4.Conditioner;
            conditioner5 = ha5.Conditioner;
            conditioner6 = ha6.Conditioner;

            //accessing all Hairoils
            hairoil1 = ha1.Hairoil;
            hairoil2 = ha2.Hairoil;
            hairoil3 = ha3.Hairoil;
            hairoil4 = ha4.Hairoil;
            hairoil5 = ha5.Hairoil;
            hairoil6 = ha6.Hairoil;

            //accessing all Hairserums
            hairserum1 = ha1.Hairserum;
            hairserum2 = ha2.Hairserum;
            hairserum3 = ha3.Hairserum;
            hairserum4 = ha4.Hairserum;
            hairserum5 = ha5.Hairserum;
            hairserum6 = ha6.Hairserum;

            //accessing all Haircolors
            haircolor1 = ha1.Haircolor;
            haircolor2 = ha2.Haircolor;
            haircolor3 = ha3.Haircolor;
            haircolor4 = ha4.Haircolor;
            haircolor5 = ha5.Haircolor;
            haircolor6 = ha6.Haircolor;

            //accessing all Hairmasks
            hairmask1 = ha1.Hairmasks;
            hairmask2 = ha2.Hairmasks;
            hairmask3 = ha3.Hairmasks;
            hairmask4 = ha4.Hairmasks;
            hairmask5 = ha5.Hairmasks;
            hairmask6 = ha6.Hairmasks;
        }

        public void MyHair(string opt2)
        {
            switch (opt2)
            {
                case "1":
                    //SHampoo
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Loreal Professional Serie Expert      ");
                    Console.WriteLine("     2.Mama Earth Rice Water Shampoo       ");
                    Console.WriteLine("     3.Tresemme Keratin Smooth       ");
                    Console.WriteLine("     4.Mamaearth Onion Shampoo      ");
                    Console.WriteLine("     5.Wella Professionals       ");
                    Console.WriteLine("     6.GK Hair Balancing Shampoo      ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    ShampooCart(opt3, qnty);
                    break;
                case "2":
                    //Conditioner
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Loreal Paris Rapid Reviver      ");
                    Console.WriteLine("     2.Sebastian Professional Penetraitt   ");
                    Console.WriteLine("     3.Matrix Opti Care    ");
                    Console.WriteLine("     4.Herbal Essences");
                    Console.WriteLine("     5.Loreal Paris Dream Lengths    ");
                    Console.WriteLine("     6.Dove Intense Repair Conditioner    ");
                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    ConditionerCart(opt3, qnty);
                    break;
                case "3":
                    //Hair Oil
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
                    HairoilCart(opt3, qnty);
                    break;
                case "4":
                    //Hair Serum
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
                    HairserumCart(opt3, qnty);
                    break;
                
                case "5":
                    //Hair Color
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
                    HaircolorCart(opt3, qnty);
                    break;
                case "6":
                    //Hair Masks
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Tresemme Deep Smoothing Mask     ");
                    Console.WriteLine("     2.Mamaearth Argan Hair Mask   ");
                    Console.WriteLine("     3.SP Luxe Oil Keratin Restore Mask   ");
                    Console.WriteLine("     4.Wella Professionals Renewing Mask    ");
                    Console.WriteLine("     5.Dove Intense Damage Repair Hair Mask   ");
                    Console.WriteLine("     6.Mamaearth Rice Water Hair Mask");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt3 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    HairmaskCart(opt3, qnty);
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;

            }

        }


        public void ShampooCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(shampoo1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(shampoo2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(shampoo3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(shampoo4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(shampoo5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(shampoo6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyHair(opt3);

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
                            MyHair(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyHair(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyHair(opt3);
            }

        }

        public void ConditionerCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(conditioner1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(conditioner2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(conditioner3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(conditioner4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(conditioner5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(conditioner6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyHair(opt3);

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
                            MyHair(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyHair(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyHair(opt3);
            }

        }
        public void HairoilCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(hairoil1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(hairoil2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(hairoil3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(hairoil4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(hairoil5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(hairoil6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyHair(opt3);

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
                            MyHair(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyHair(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyHair(opt3);
            }

        }
        public void HairserumCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(hairserum1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(hairserum2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(hairserum3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(hairserum4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(hairserum5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(hairserum6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyHair(opt3);

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
                            MyHair(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyHair(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyHair(opt3);
            }

        }


        public void HaircolorCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(haircolor1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(haircolor2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(haircolor3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(haircolor4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(haircolor5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(haircolor6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyHair(opt3);

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
                            MyHair(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyHair(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyHair(opt3);
            }

        }
        public void HairmaskCart(string opt3, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt3)
                {
                    case "1":
                        items.Add(hairmask1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(hairmask2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(hairmask3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(hairmask4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(hairmask5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(hairmask6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyHair(opt3);

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
                            MyHair(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyHair(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyHair(opt3);
            }

        }*/


    }

}