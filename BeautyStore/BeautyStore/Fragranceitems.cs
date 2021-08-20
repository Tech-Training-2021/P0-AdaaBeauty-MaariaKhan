using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace BeautyStore
{
    class Fragranceitems
    {
        
        public int qnty = 0;
        public string opt4 = "";

        public void StoreFragranceitems()
        {
            WomenFragrances womenfragrance1 = new WomenFragrances()
            {
                Perfume = "Mercedes-Benz Woman Eau De Toilette",
                bodymists = "The Body Shop Shea Body Mist",
                deodorants = "NIVEA Women Deodorant"
            };

            WomenFragrances womenfragrance2 = new WomenFragrances()
            {
                Perfume = "Police To Be Woman Eau De Parfu",
                bodymists = "Dark Kiss Fragrance Mis",
                deodorants = "Engage Spell Deodorant For Women"
            };

            WomenFragrances womenfragrance3 = new WomenFragrances()
            {
                Perfume = "Davidoff Cool Water Wave Woman Eau De Toilette",
                bodymists = "Body Cupid Rasberry Burst Body Mists",
                deodorants = "Playboy Wild Women Deodorant Spray"
            };

            WomenFragrances womenfragrance4 = new WomenFragrances()
            {
                Perfume = "Active Woman Blanche",
                bodymists = "DIOR J'adore Body Mists",
                deodorants = "Dove Eventone Deodorant For Women"
            };

            WomenFragrances womenfragrance5 = new WomenFragrances()
            {
                Perfume = "HUGO Woman Eau De Parfum",
                bodymists = "Salvatore Ferragamo Incanto Bloom Body Mist",
                deodorants = "Antonio Banderas Her Golden Secret Deodrant"
            };

            WomenFragrances womenfragrance6 = new WomenFragrances()
            {
                Perfume = "United Colors of Benetton Colors Rose Women",
                bodymists = "Beverly Hills Polo Club Premium Body Mis",
                deodorants = "Guess 1981 Deodorant Body Spray",
            };

            MenFragrances menfragrance1 = new MenFragrances()
            {
                Perfume = "Skinn by Titan Raw Perfume For Men EDP",
                bodymists = "The Body Shop Shea Body Mist",
                deodorants = "Brut Original Deodorant Spray For Men",
                cologneandaftershaves = "Gucci Guilty Cologne Eau De Toilette For Him"
            };

            MenFragrances menfragrance2 = new MenFragrances()
            {
                Perfume = "Villain Eau De Parfum For Men",
                bodymists = "Forest Essentials Body Mist Nargis",
                deodorants = "United Dreams Go Far Deodorant Spray",
                cologneandaftershaves = "Jo Malone London Peony & Blush Suede Cologne"
            };

            MenFragrances menfragrance3 = new MenFragrances()
            {
                Perfume = "Brut Original Deodorant Spray For Men",
                bodymists = "The Body Shop Japanese Cherry Blossom Fragrance Mist",
                deodorants = "Playboy Wild Women Deodorant Spray",
                cologneandaftershaves = "Bath & Body Works Teakwood Cologne"
            };

            MenFragrances menfragrance4 = new MenFragrances()
            {
                Perfume = "Givenchy Gentleman Eau De Parfum",
                bodymists = "Bath & Body Works Dark Kiss Fine Fragrance Mist",
                deodorants = "David Beckham Respect Deodorant",
                cologneandaftershaves = "Forest Essentials After Shave"
            };

            MenFragrances menfragrance5 = new MenFragrances()
            {
                Perfume = "Montblanc Explorer Eau De Parfum",
                bodymists = "Forest Essentials Body Mist Jasmine & Saffron",
                deodorants = "Jaguar For Men Deodorant",
                cologneandaftershaves = "NIVEA MEN Shaving"
            };

            MenFragrances menfragrance6 = new MenFragrances()
            {
                Perfume = "The Man Company Blanc Body Perfume",
                bodymists = "Royal Mirage Body Spray Sport",
                deodorants = "Engage Mate Deodrant For Men",
                cologneandaftershaves = "Biotique Bio Wild Grass Soothing After Shave Gel"
            };


            

            //women fragrances file objects serializing
            string mywomenfragrance1 = JsonConvert.SerializeObject(womenfragrance1);
            File.WriteAllText(@"womenfragrance.json", mywomenfragrance1);
            string mywomenfragrance2 = JsonConvert.SerializeObject(womenfragrance2);
            File.AppendAllText(@"womenfragrance.json", mywomenfragrance2);
            string mywomenfragrance3 = JsonConvert.SerializeObject(womenfragrance3);
            File.AppendAllText(@"womenfragrance.json", mywomenfragrance3);
            string mywomenfragrance4 = JsonConvert.SerializeObject(womenfragrance4);
            File.AppendAllText(@"womenfragrance.json", mywomenfragrance4);
            string mywomenfragrance5 = JsonConvert.SerializeObject(womenfragrance5);
            File.AppendAllText(@"womenfragrance.json", mywomenfragrance5);
            string mywomenfragrance6 = JsonConvert.SerializeObject(womenfragrance6);
            File.AppendAllText(@"womenfragrance.json", mywomenfragrance6);

            //men fragrances file objects serializing
            string mymenfragrance1 = JsonConvert.SerializeObject(menfragrance1);
            File.WriteAllText(@"menfragrance.json", mymenfragrance1);
            string mymenfragrance2 = JsonConvert.SerializeObject(menfragrance2);
            File.AppendAllText(@"menfragrance.json", mymenfragrance2);
            string mymenfragrance3 = JsonConvert.SerializeObject(menfragrance3);
            File.AppendAllText(@"menfragrance.json", mymenfragrance3);
            string mymenfragrance4 = JsonConvert.SerializeObject(menfragrance4);
            File.AppendAllText(@"menfragrance.json", mymenfragrance4);
            string mymenfragrance5 = JsonConvert.SerializeObject(menfragrance5);
            File.AppendAllText(@"menfragrance.json", mymenfragrance5);
            string mymenfragrance6 = JsonConvert.SerializeObject(menfragrance6);
            File.AppendAllText(@"menfragrance.json", mymenfragrance6);

        }

        public void MyWomenFragrance(string opt3)
        {
            switch (opt3)
            {
                case "1":
                    //Perfume
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Mercedes-Benz Woman Eau De Toilette     ");
                    Console.WriteLine("     2.Police To Be Woman Eau De Parfum   ");
                    Console.WriteLine("     3.Davidoff Cool Water Wave Woman Eau De Toilette   ");
                    Console.WriteLine("     4.Active Woman Blanche     ");
                    Console.WriteLine("     5.HUGO Woman Eau De Parfum   ");
                    Console.WriteLine("     6.United Colors of Benetton Colors Rose Women   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "2":
                    //bodymists
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.The Body Shop Shea Body Mist     ");
                    Console.WriteLine("     2.Dark Kiss Fragrance Mist   ");
                    Console.WriteLine("     3.Body Cupid Rasberry Burst Body Mist  ");
                    Console.WriteLine("     4.DIOR J'adore Body Mist     ");
                    Console.WriteLine("     5.Salvatore Ferragamo Incanto Bloom Body Mist   ");
                    Console.WriteLine("     6.Beverly Hills Polo Club Premium Body Mist   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "3":
                    //deodorants
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.NIVEA Women Deodorant     ");
                    Console.WriteLine("     2.Engage Spell Deodorant For Women   ");
                    Console.WriteLine("     3.Playboy Wild Women Deodorant Spray    ");
                    Console.WriteLine("     4.Dove Eventone Deodorant For Women     ");
                    Console.WriteLine("     5.Antonio Banderas Her Golden Secret Deodrant  ");
                    Console.WriteLine("     6.Guess 1981 Deodorant Body Spray   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;


            }

        }
        public void MyMenFragrance(string opt3)
        {
            switch (opt3)
            {
                case "1":
                    //perfumes
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Skinn by Titan Raw Perfume For Men EDP     ");
                    Console.WriteLine("     2.DIOR Sauvage Eau De Parfum   ");
                    Console.WriteLine("     3.Villain Eau De Parfum For Men   ");
                    Console.WriteLine("     4.Givenchy Gentleman Eau De Parfum     ");
                    Console.WriteLine("     5.Montblanc Explorer Eau De Parfum   ");
                    Console.WriteLine("     6.The Man Company Blanc Body Perfume   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "2":
                    //bodymists
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.The Body Shop Shea Body Mist     ");
                    Console.WriteLine("     2.Forest Essentials Body Mist Nargis   ");
                    Console.WriteLine("     3.The Body Shop Japanese Cherry Blossom Fragrance Mist  ");
                    Console.WriteLine("     4.Bath & Body Works Dark Kiss Fine Fragrance Mist     ");
                    Console.WriteLine("     5.Forest Essentials Body Mist Jasmine & Saffron   ");
                    Console.WriteLine("     6.Royal Mirage Body Spray Sport   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "3":
                    //deodorants
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Brut Original Deodorant Spray For Men    ");
                    Console.WriteLine("     2.NIVEA Men Deodorant   ");
                    Console.WriteLine("     3.United Dreams Go Far Deodorant Spray    ");
                    Console.WriteLine("     4.David Beckham Respect Deodorant    ");
                    Console.WriteLine("     5.Jaguar For Men Deodorant  ");
                    Console.WriteLine("     6.Engage Mate Deodrant For Men   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                case "4":
                    //cologne and after shaves
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Gucci Guilty Cologne Eau De Toilette For Him    ");
                    Console.WriteLine("     2.Jo Malone London Peony & Blush Suede Cologne   ");
                    Console.WriteLine("     3.Bath & Body Works Teakwood Cologne    ");
                    Console.WriteLine("     4.Forest Essentials After Shave    ");
                    Console.WriteLine("     5.NIVEA MEN Shaving   ");
                    Console.WriteLine("     6.Biotique Bio Wild Grass Soothing After Shave Gel    ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;


            }

        }
    }
}
