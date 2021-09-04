using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore
{
    class FilterSkincare:Skincareitem
    {
        string opt1 = "";
        string opt2 = "";
        List<string> allskincarename = new List<string>();
        List<double> allskincareprice = new List<double>();
        StoreAdaa mystoreadaa = new StoreAdaa();

        public void FilterSkincareList()
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

        public void FilterMySkin()
        {
            FilterSkincareList();
            Console.WriteLine("What kind of filters do you wanna apply on skincare itmes");
            Console.WriteLine("                    1.Sort By Name                       ");
            Console.WriteLine("                    2.Sort By Price (High to Low)                   ");
            Console.WriteLine("                    3.Sort By Price (Low to High)                   ");
            opt1 = Console.ReadLine();
            switch (opt1)
            {
                case "1":
                    SkinNameSort();
                    break;
                case "2":
                    SkinPriceDownSort();
                    break;
                case "3":
                    SkinPriceUpSort();
                    break;

            }
        }
        public void SkinNameSort()
        {
            allskincarename.Sort();
            Console.WriteLine("************************** There You Go!!!!! *****************************");
            Console.WriteLine();
            for (int i = 0; i < allskincarename.Count; i++)
            {
                Console.WriteLine("__________________________________________________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine($"                   {allskincarename[i]}                   {allskincareprice[i]}");
                Console.WriteLine();

            }
            Console.WriteLine("Select the appropraite option:");
            Console.WriteLine("       1.Continue Applying Filters");
            Console.WriteLine("       2.Go to main menu");
            opt2 = Console.ReadLine();
            switch (opt2)
            {
                case "1":
                    FilterMySkin();
                    break;
                case "2":
                    mystoreadaa.MyStore();
                    break;
                    
            }


        }
        public void SkinPriceDownSort()
        {
            allskincareprice.Reverse();
            Console.WriteLine("************************** There You Go!!!!! *****************************");
            Console.WriteLine();
            for (int i = 0; i < allskincareprice.Count; i++)
            {
                Console.WriteLine("__________________________________________________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine($"                   {allskincarename[i]}                   {allskincareprice[i]}");
                Console.WriteLine();


            }
            Console.WriteLine("Select the appropraite option:");
            Console.WriteLine("       1.Continue Applying Filters");
            Console.WriteLine("       2.Go to main menu");
            opt2 = Console.ReadLine();
            switch (opt2)
            {
                case "1":
                    FilterMySkin();
                    break;
                case "2":
                    mystoreadaa.MyStore();
                    break;

            }

        }
        public void SkinPriceUpSort()
        {
            allskincareprice.Sort();            
            Console.WriteLine("************************** There You Go!!!!! *****************************");
            Console.WriteLine();
            for (int i = 0; i < allskincareprice.Count; i++)
            {
                Console.WriteLine("__________________________________________________________________________________________________________");
                Console.WriteLine();
                Console.WriteLine($"                   {allskincarename[i]}                   {allskincareprice[i]}");
                Console.WriteLine();

            }
            Console.WriteLine("Select the appropraite option:");
            Console.WriteLine("       1.Continue Applying Filters");
            Console.WriteLine("       2.Go to main menu");
            opt2 = Console.ReadLine();
            switch (opt2)
            {
                case "1":
                    FilterMySkin();
                    break;
                case "2":
                    mystoreadaa.MyStore();
                    break;

            }

        }
    }
}
