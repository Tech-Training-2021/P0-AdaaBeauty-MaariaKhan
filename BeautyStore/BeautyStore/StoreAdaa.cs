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
            Console.WriteLine("_________________     ______________________     _____________________     ___________________   __________________   ___________________");
            Console.WriteLine();
            Console.WriteLine("      1.MAKEUP               2.SKIN CARE              3.HAIR CARE             4.APPLIANCES         5.SEARCH ITEMS          6.FILTERS       ");
            Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________   ___________________");
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
                        Console.WriteLine("     1.FOUNDATION      ");
                        Console.WriteLine("     2.KAJAL       ");
                        Console.WriteLine("     3.LIPSTICK       ");
                        Console.WriteLine("     4.NAILPOLISH      ");
                        Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                        Console.WriteLine("Select the category by entering the appropriate option number:");
                        opt2 = Console.ReadLine();
                        //makeupitem.Mymakeup(opt2);
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
                    case "5":
                        
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
                                searchskin.SkincareList();
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
                    case "6":
                        Console.WriteLine("__________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("Hey! In which category do you wish to apply filters?");
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
        }
    }
}
