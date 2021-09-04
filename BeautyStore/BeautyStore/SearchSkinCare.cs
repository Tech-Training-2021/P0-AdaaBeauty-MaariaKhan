using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore
{
    class SearchSkinCare:Skincareitem
    {
        List<string> allskincarename = new List<string>();
        List<double> allskincareprice = new List<double>();
        public string myproduct = "";
        public string myitemname = "";
        public string opt1 = "";
        public string opt2 = "";
        public int qnt = 0;
        Adaa adaa = new Adaa();
        public  void SkincareList()
        {
            StoreSkincareitem();
            allskincarename.Add(tone1);
            allskincarename.Add(tone2);
            allskincarename.Add(tone3);
            allskincarename.Add(tone4);
            allskincarename.Add(tone5);
            allskincarename.Add(tone6);
            allskincarename.Add(cleanse1);
            allskincarename.Add(cleanse2);
            allskincarename.Add(cleanse3);
            allskincarename.Add(cleanse4);
            allskincarename.Add(cleanse5);
            allskincarename.Add(cleanse6);
            allskincarename.Add(moisturize1);
            allskincarename.Add(moisturize2);
            allskincarename.Add(moisturize3);
            allskincarename.Add(moisturize4);
            allskincarename.Add(moisturize5);
            allskincarename.Add(moisturize6);
            allskincarename.Add(mas1);
            allskincarename.Add(mas2);
            allskincarename.Add(mas3);
            allskincarename.Add(mas4);
            allskincarename.Add(mas5);
            allskincarename.Add(mas6);

            //adding price
            allskincareprice.Add(toner1price);
            allskincareprice.Add(toner2price);
            allskincareprice.Add(toner3price);
            allskincareprice.Add(toner4price);
            allskincareprice.Add(toner5price);
            allskincareprice.Add(toner6price);
            allskincareprice.Add(cleanser1price);
            allskincareprice.Add(cleanser2price);
            allskincareprice.Add(cleanser3price);
            allskincareprice.Add(cleanser4price);
            allskincareprice.Add(cleanser5price);
            allskincareprice.Add(cleanser6price);
            allskincareprice.Add(moisturizer1price);
            allskincareprice.Add(moisturizer2price);
            allskincareprice.Add(moisturizer3price);
            allskincareprice.Add(moisturizer4price);
            allskincareprice.Add(moisturizer5price);
            allskincareprice.Add(moisturizer6price);
            allskincareprice.Add(mask1price);
            allskincareprice.Add(mask2price);
            allskincareprice.Add(mask3price);
            allskincareprice.Add(mask4price);
            allskincareprice.Add(mask5price);
            allskincareprice.Add(mask6price);

        }
        
        public void SearchMySkin()
        {
            Console.WriteLine("Search by typing in the product name!");
            myproduct = Console.ReadLine().ToLower();
            
            for(int i = 0; i < allskincarename.Count; i++)
            {
                myitemname = allskincarename[i].ToLower();
                if (String.Equals(myproduct,myitemname))
                {
                    Console.WriteLine("        Hey! Your searched item is caught!!!        ");
                    Console.WriteLine("_______________________________________________________________________________________________________");
                    Console.WriteLine("                                                        ");
                    Console.WriteLine($"         {allskincarename[i]}                                     {allskincareprice[i]}     ");
                    Console.WriteLine("                                                        ");
                    Console.WriteLine("______________________________________________________________________________________________________");
                    Console.WriteLine("Select the appropriate option to perform further operation:");
                    Console.WriteLine("              1.Add the above product in cart");
                    Console.WriteLine("              2.Search new item");
                    Console.WriteLine("              3.Go to main menu");
                    opt1 = Console.ReadLine();
                    switch (opt1)
                    {
                        case "1":
                            Console.WriteLine("Please enter the quantity:");
                            qnt = int.Parse(Console.ReadLine());
                            if (i < 6)
                            {
                                switch (i)
                                {
                                    case 0:
                                        TonerCart("1", qnt);
                                        break;
                                    case 1:
                                        TonerCart("2", qnt);
                                        break;
                                    case 2:
                                        TonerCart("3", qnt);
                                        break;
                                    case 3:
                                        TonerCart("4", qnt);
                                        break;
                                    case 4:
                                        TonerCart("5", qnt);
                                        break;
                                    case 5:
                                        TonerCart("6", qnt);
                                        break;
                                }
                            }
                            else if((i > 5) && (i < 12))
                            {
                                switch (i)
                                {
                                    case 6:
                                        CleanserCart("1", qnt);
                                        break;
                                    case 7:
                                        CleanserCart("2", qnt);
                                        break;
                                    case 8:
                                        CleanserCart("3", qnt);
                                        break;
                                    case 9:
                                        CleanserCart("4", qnt);
                                        break;
                                    case 10:
                                        CleanserCart("5", qnt);
                                        break;
                                    case 11:
                                        CleanserCart("6", qnt);
                                        break;
                                }
                            }
                            else if ((i > 11) && (i < 18))
                            {
                                switch (i)
                                {
                                    case 12:
                                        MoisturizerCart("1", qnt);
                                        break;
                                    case 13:
                                        MoisturizerCart("2", qnt);
                                        break;
                                    case 14:
                                        MoisturizerCart("3", qnt);
                                        break;
                                    case 15:
                                        MoisturizerCart("4", qnt);
                                        break;
                                    case 16:
                                        MoisturizerCart("5", qnt);
                                        break;
                                    case 17:
                                        MoisturizerCart("6", qnt);
                                        break;
                                }
                            }
                            else if ((i > 17) && (i < 24))
                            {
                                switch (i)
                                {
                                    case 18:
                                        MaskCart("1", qnt);
                                        break;
                                    case 19:
                                        MaskCart("2", qnt);
                                        break;
                                    case 20:
                                        MaskCart("3", qnt);
                                        break;
                                    case 21:
                                        MaskCart("4", qnt);
                                        break;
                                    case 22:
                                        MaskCart("5", qnt);
                                        break;
                                    case 23:
                                        MaskCart("6", qnt);
                                        break;
                                }
                            }
                            break;
                        case "2":
                            SearchMySkin();
                            break;

                        case "3":
                            adaa.LogoutAdaa();
                            break;

                    }

                }
            }

        }
    }
}
