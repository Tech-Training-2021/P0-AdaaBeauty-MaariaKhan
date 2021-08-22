using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore
{
    class FilterSkincare:SearchSkinCare
    {
        string opt1 = "";
        string opt2 = "";
        StoreAdaa mystoreadaa = new StoreAdaa();
        public void FilterMySkin()
        {
            SkincareList();
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
