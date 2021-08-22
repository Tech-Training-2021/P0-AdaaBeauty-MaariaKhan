using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BeautyStore
{
    class StoreAdaa
    {
        public void MyStore()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;


            Skincareitem skincareitem = new Skincareitem();
            skincareitem.StoreSkincareitem();
            Haircareitems haircareitems = new Haircareitems();
            //haircareitems.StoreHaircareitems();
            Makeupitems makeupitems = new Makeupitems();
            //makeupitems.StoreMakeupitems();
            Fragranceitems fragranceitems = new Fragranceitems();
            fragranceitems.StoreFragranceitems();
            Appliancesitems appliancesitems = new Appliancesitems();
            //appliancesitems.StoreApplianceitems();

            SearchSkinCare searchskin = new SearchSkinCare();
            SearchMakeup searchmakeup = new SearchMakeup();
            SearchHairCare searchhair = new SearchHairCare();
            SearchAppliances searchappliances = new SearchAppliances();

            FilterSkincare filterskin = new FilterSkincare();

            string opt1 = "";
            string opt2 = "";
            string opt3 = "";
            string opt4="";
            string opt5 = "";

            Console.WriteLine("***************WELCOME TO ADAA BEAUTY CORNER********************");
            Console.WriteLine("");
            Console.WriteLine("          Skincare , Haircare and Wellness is different for everyone.If you're tring to find your customised regime");
            Console.WriteLine("              or simply have questions related to beauty and wellness....ADAA is the solution!!!!");
            Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________   __________________   ___________________");
            Console.WriteLine();
            Console.WriteLine("      1.MAKEUP               2.SKIN CARE              3.HAIR CARE               4.FRAGRANCES           5.APPLIANCES       6.SEARCH ITEMS         7.FILTERS       ");
            Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________   __________________   ___________________");
            Console.WriteLine();
            Console.WriteLine("Select the category by entering the appropriate option number:");
            opt1 = Console.ReadLine();
            MyMenus(opt1);
            void MyMenus(string opt1)
            {
                switch (opt1)
                {
                    case "1":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.FACES      ");
                        Console.WriteLine("     2.EYES       ");
                        Console.WriteLine("     3.LIPS       ");
                        Console.WriteLine("     4.NAILS      ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt2 = Console.ReadLine();
                        MyMakeup(opt2);
                        break;
                    case "2":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.TONER      ");
                        Console.WriteLine("     2.CLEANSER   ");
                        Console.WriteLine("     3.MOISTURIZER    ");
                        Console.WriteLine("     4.MASK      ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt2 = Console.ReadLine();
                        skincareitem.MySkin(opt2);

                        break;
                    case "3":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.SHAMPOO      ");
                        Console.WriteLine("     2.CONDITIONER   ");
                        Console.WriteLine("     3.HAIR OIL    ");
                        Console.WriteLine("     4.HAIR SERUM      ");
                        Console.WriteLine("     5.HAIR COLOUR    ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt2 = Console.ReadLine();
                        //haircareitems.MyHair(opt2);
                        break;
                    case "4":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.WOMEN     ");
                        Console.WriteLine("     2.MEN   ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt2 = Console.ReadLine();
                        MyCustomerGender(opt2);
                        break;
                    case "5":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.HAIR STRAIGHTNER       ");
                        Console.WriteLine("     2.HAIR DRYER   ");
                        Console.WriteLine("     3.FACE EPILATOR    ");
                        Console.WriteLine("     4.SHAVERS    ");
                        Console.WriteLine("     5.TRIMMERS    ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt2 = Console.ReadLine();
                        //appliancesitems.MyAppliances(opt2);
                        break;
                    case "6":
                        searchskin.SkincareList();
                        Console.WriteLine("__________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("Hey! In which category do you wanna perform a search in?");
                        Console.WriteLine();
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        Console.WriteLine("____________________________________________________________________");
                        Console.WriteLine("                         1.MAKEUP           ");
                        Console.WriteLine("                         2.SKINCARE           ");
                        Console.WriteLine("                         3.HAIRCARE           ");
                        Console.WriteLine("                         4.FRAGRANCES           ");
                        Console.WriteLine("                         5.APPLIANCES          ");
                        opt4=Console.ReadLine();
                        switch (opt4)
                        {
                            case"1":
                                Console.WriteLine("code to be added");
                                break;
                            case "2":
                                searchskin.SearchMySkin();
                                break;
                            case "3":
                                Console.WriteLine("code to be added");
                                break;
                            case "4":
                                Console.WriteLine("code to be added");
                                break;
                            case "5":
                                Console.WriteLine("code to be added");
                                break;
                        }
                        break;
                    case "7":
                        Console.WriteLine("__________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("Hey! In which category do you wish to aplly filters?");
                        Console.WriteLine();
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        Console.WriteLine("____________________________________________________________________");
                        Console.WriteLine("                         1.MAKEUP           ");
                        Console.WriteLine("                         2.SKINCARE           ");
                        Console.WriteLine("                         3.HAIRCARE           ");
                        Console.WriteLine("                         4.FRAGRANCES           ");
                        Console.WriteLine("                         5.APPLIANCES          ");
                        opt5 = Console.ReadLine();
                        switch (opt5)
                        {
                            case "1":
                                Console.WriteLine("code to be added");
                                break;
                            case "2":
                                filterskin.FilterMySkin();
                                break;
                            case "3":
                                Console.WriteLine("code to be added");
                                break;
                            case "4":
                                Console.WriteLine("code to be added");
                                break;
                            case "5":
                                Console.WriteLine("code to be added");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Sorry you entered the wrong option! ");
                        break;

                }
            }


            void MyMakeup(string opt2)
            {
                switch (opt2)
                {
                    case "1":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.FOUNDATION      ");
                        Console.WriteLine("     2.CONCEALER       ");
                        Console.WriteLine("     3.HIGHLIGHTER       ");
                        Console.WriteLine("     4.COMPACT      ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        //makeupitems.MyFace(opt3);

                        break;
                    case "2":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.KAJAL      ");
                        Console.WriteLine("     2.EYE-LINER   ");
                        Console.WriteLine("     3.EYE-SHADOW PALETTE    ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        //makeupitems.MyEyes(opt3);
                        break;
                    case "3":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.LIPGLOSS      ");
                        Console.WriteLine("     2.CREAME-LIPSTICK   ");
                        Console.WriteLine("     3.MATTE LIPSTICK    ");

                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        //makeupitems.MyLips(opt3);
                        break;
                    case "4":
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.SUBTLE-NAILPOLISH     ");
                        Console.WriteLine("     2.MATTE-NAILPOLISH   ");
                        Console.WriteLine("     3.GLITTER-NAILPOLISH   ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        //makeupitems.MyNails(opt3);
                        break;
                    default:
                        Console.WriteLine("Sorry you entered the wrong option! ");
                        break;

                }

            }


            void MyCustomerGender(string opt2)
            {
                switch (opt2)
                {
                    case "1":
                        //Women
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.Perfume      ");
                        Console.WriteLine("     2.Body Mists       ");
                        Console.WriteLine("     3.Deodrants       ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        fragranceitems.MyWomenFragrance(opt3);
                        break;
                    case "2":
                        //Men
                        Console.WriteLine("_________________ ");
                        Console.WriteLine();
                        Console.WriteLine("     1.Perfume      ");
                        Console.WriteLine("     2.Body Mists       ");
                        Console.WriteLine("     3.Deodrants       ");
                        Console.WriteLine("     4.Collagens and after shaves       ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt3 = Console.ReadLine();
                        fragranceitems.MyMenFragrance(opt3);
                        break;
                    default:
                        Console.WriteLine("Sorry you entered the wrong option! ");
                        break;

                }
            }
        }
    }
}
