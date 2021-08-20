using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore
{
    class Fragrance
    {
        public string opt3 = "";
        public int qnty = 0;
        public string opt4 = "";
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


            }

        }
        class Women
        {
            public string Perfume { get; set; }
            public string Bodymists { get; set; }
            public string Deodrants { get; set; }


        }
        class Men
        {
            public string Perfume { get; set; }
            public string Bodymists { get; set; }
            public string Deodrants { get; set; }
            public string Cologne { get; set; }


        }
        

    }
}
