 using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace BeautyStore
{
    public class Makeupitems
    {
        /*Adaa adaa = new Adaa();

        StoreAdaa mystore = new StoreAdaa();
        string orderfile = "";

        public string opt3 = "";
        public string qnty = "";
        public string opt4 = "";
        public int counter = 0;
        string mykey = "";
        string myvalue = "";

        string foundation1 = "";
        string foundation2 = "";
        string foundation3 = "";
        string foundation4 = "";
        string foundation5 = "";
        string foundation6 = "";

        string concealer1 = "";
        string concealer2 = "";
        string concealer3 = "";
        string concealer4 = "";
        string concealer5 = "";
        string concealer6 = "";

        string highlighter1 = "";
        string highlighter2 = "";
        string highlighter3 = "";
        string highlighter4 = "";
        string highlighter5 = "";
        string highlighter6 = "";

        string compact1 = "";
        string compact2 = "";
        string compact3 = "";
        string compact4 = "";
        string compact5 = "";
        string compact6 = "";

        string kajal1 = "";
        string kajal2 = "";
        string kajal3 = "";
        string kajal4 = "";
        string kajal5 = "";
        string kajal6 = "";

        string liner1 = "";
        string liner2 = "";
        string liner3 = "";
        string liner4 = "";
        string liner5 = "";
        string liner6 = "";

        string eyeshadow1 = "";
        string eyeshadow2 = "";
        string eyeshadow3 = "";
        string eyeshadow4 = "";
        string eyeshadow5 = "";
        string eyeshadow6 = "";

        string lipgloss1 = "";
        string lipgloss2 = "";
        string lipgloss3 = "";
        string lipgloss4 = "";
        string lipgloss5 = "";
        string lipgloss6 = "";

        string creamylipstick1 = "";
        string creamylipstick2 = "";
        string creamylipstick3 = "";
        string creamylipstick4 = "";
        string creamylipstick5 = "";
        string creamylipstick6 = "";

        string mattelipstick1 = "";
        string mattelipstick2 = "";
        string mattelipstick3 = "";
        string mattelipstick4 = "";
        string mattelipstick5 = "";
        string mattelipstick6 = "";

        string subtlenail1 = "";
        string subtlenail2 = "";
        string subtlenail3 = "";
        string subtlenail4 = "";
        string subtlenail5 = "";
        string subtlenail6 = "";

        string mattenail1 = "";
        string mattenail2 = "";
        string mattenail3 = "";
        string mattenail4 = "";
        string mattenail5 = "";
        string mattenail6 = "";

        string glitternail1 = "";
        string glitternail2 = "";
        string glitternail3 = "";
        string glitternail4 = "";
        string glitternail5 = "";
        string glitternail6 = "";


        string myorder = "";
        string cartitems = "";
        string cartquantity = "";

        Dictionary<string, string> items = new Dictionary<string, string>();

        char c1;
        char c2;
        char c3;

        public void StoreMakeupitems()
        {
            Makeup makeup1 = new Makeup()
            {
                Foundation = "LOreal Paris Infallible",
                Concealer = "Maybelline New York Fit me Concealer",
                Highlighter = "BECCA Ignite Liquified Light Hightlighter",
                Compact = "Maybelline New York Fit Me Oil Control",
                Kajal = "Lakme Eyeconic Kajal",
                Liner = "LOreal Paris Super Liner",
                Eyeshadow = "Makeup Revolution Eyeshadow Palette",
                Lipgloss = "SUGAR Time To Shine Lip Gloss",
                Creamylipstick = "MyGlamm LIT Creamy Matte Lipstick",
                Mattelipstick = "Kay Beauty Long Stay Matte Lipstick",
                Subtlenail = "Pear Nova Nail Polish",
                Mattenail = "Littmuss Matte Chrome Nail Polish",
                Glitternail = "Lakme Color Crush Nail Art",

            };
            Makeup makeup2 = new Makeup()
            {
                Foundation = "Kay Beauty Hydrating Foundation",
                Concealer = "L.A. Girl",
                Highlighter = "Huda Beauty 3D Highlighter",
                Compact = "Kay Beauty Matte Compact",
                Kajal = "Swiss Beauty Deep Black Kajal",
                Liner = "Kay Beauty Quick Dry Liquid Eyeliner",
                Eyeshadow = "SUGAR Blend The Rules Eyeshadow Palette",
                Lipgloss = "Lime Crime Wet Cherry Lip Gloss",
                Creamylipstick = "Kiko Milano Gossamer Emotion Creamy Lipstick",
                Mattelipstick = "Elle 18 Color Pops Matte Lipstick",
                Subtlenail = "Olive and June Nail Polish",
                Mattenail = "MyGlamm LIT Matte Nail Enamel",
                Glitternail = "Bella Voste Glitter Nail Paint",



            };
            //yaha se change kro!!!
            Makeup makeup3 = new Makeup()
            {
                Foundation = "LOreal Paris Infallible",
                Concealer = "Maybelline New York Fit me Concealer",
                Highlighter = "BECCA Ignite Liquified Light Hightlighter",
                Compact = "Maybelline New York Fit Me Oil Control",
                Kajal = "Lakme Eyeconic Kajal",
                Liner = "LOreal Paris Super Liner",
                Eyeshadow = "Makeup Revolution Eyeshadow Palette",
                Lipgloss = "SUGAR Time To Shine Lip Gloss",
                Creamylipstick = "MyGlamm LIT Creamy Matte Lipstick",
                Mattelipstick = "Kay Beauty Long Stay Matte Lipstick",
                Subtlenail = "Pear Nova Nail Polish",
                Mattenail = "Littmuss Matte Chrome Nail Polish",
                Glitternail = "Lakme Color Crush Nail Art",


            };
            Makeup makeup4 = new Makeup()
            {
                Foundation = "LOreal Paris Infallible",
                Concealer = "Maybelline New York Fit me Concealer",
                Highlighter = "BECCA Ignite Liquified Light Hightlighter",
                Compact = "Maybelline New York Fit Me Oil Control",
                Kajal = "Lakme Eyeconic Kajal",
                Liner = "LOreal Paris Super Liner",
                Eyeshadow = "Makeup Revolution Eyeshadow Palette",
                Lipgloss = "SUGAR Time To Shine Lip Gloss",
                Creamylipstick = "MyGlamm LIT Creamy Matte Lipstick",
                Mattelipstick = "Kay Beauty Long Stay Matte Lipstick",
                Subtlenail = "Pear Nova Nail Polish",
                Mattenail = "Littmuss Matte Chrome Nail Polish",
                Glitternail = "Lakme Color Crush Nail Art",


            };
            Makeup makeup5 = new Makeup()
            {
                Foundation = "LOreal Paris Infallible",
                Concealer = "Maybelline New York Fit me Concealer",
                Highlighter = "BECCA Ignite Liquified Light Hightlighter",
                Compact = "Maybelline New York Fit Me Oil Control",
                Kajal = "Lakme Eyeconic Kajal",
                Liner = "LOreal Paris Super Liner",
                Eyeshadow = "Makeup Revolution Eyeshadow Palette",
                Lipgloss = "SUGAR Time To Shine Lip Gloss",
                Creamylipstick = "MyGlamm LIT Creamy Matte Lipstick",
                Mattelipstick = "Kay Beauty Long Stay Matte Lipstick",
                Subtlenail = "Pear Nova Nail Polish",
                Mattenail = "Littmuss Matte Chrome Nail Polish",
                Glitternail = "Lakme Color Crush Nail Art",


            };
            Makeup makeup6 = new Makeup()
            {
                Foundation = "LOreal Paris Infallible",
                Concealer = "Maybelline New York Fit me Concealer",
                Highlighter = "BECCA Ignite Liquified Light Hightlighter",
                Compact = "Maybelline New York Fit Me Oil Control",
                Kajal = "Lakme Eyeconic Kajal",
                Liner = "LOreal Paris Super Liner",
                Eyeshadow = "Makeup Revolution Eyeshadow Palette",
                Lipgloss = "SUGAR Time To Shine Lip Gloss",
                Creamylipstick = "MyGlamm LIT Creamy Matte Lipstick",
                Mattelipstick = "Kay Beauty Long Stay Matte Lipstick",
                Subtlenail = "Pear Nova Nail Polish",
                Mattenail = "Littmuss Matte Chrome Nail Polish",
                Glitternail = "Lakme Color Crush Nail Art",


            };

            //makeup file objects serializing
            string mymakeup1 = JsonConvert.SerializeObject(makeup1);
            File.WriteAllText(@"makeup.json", mymakeup1);
            string mymakeup2 = JsonConvert.SerializeObject(makeup2);
            File.AppendAllText(@"makeup.json", mymakeup2);
            string mymakeup3 = JsonConvert.SerializeObject(makeup3);
            File.AppendAllText(@"makeup.json", mymakeup3);
            string mymakeup4 = JsonConvert.SerializeObject(makeup4);
            File.AppendAllText(@"makeup.json", mymakeup4);
            string mymakeup5 = JsonConvert.SerializeObject(makeup5);
            File.AppendAllText(@"makeup.json", mymakeup5);
            string mymakeup6 = JsonConvert.SerializeObject(makeup6);
            File.AppendAllText(@"makeup.json", mymakeup6);


            //desrializing makeup file objects
            Makeup mk1 = JsonConvert.DeserializeObject<Makeup>(mymakeup1);
            Makeup mk2 = JsonConvert.DeserializeObject<Makeup>(mymakeup2);
            Makeup mk3 = JsonConvert.DeserializeObject<Makeup>(mymakeup3);
            Makeup mk4 = JsonConvert.DeserializeObject<Makeup>(mymakeup4);
            Makeup mk5 = JsonConvert.DeserializeObject<Makeup>(mymakeup5);
            Makeup mk6 = JsonConvert.DeserializeObject<Makeup>(mymakeup6);

            //accessing foundations
            foundation1 = mk1.Foundation;
            foundation2 = mk2.Foundation;
            foundation3 = mk3.Foundation;
            foundation4 = mk4.Foundation;
            foundation5 = mk5.Foundation;
            foundation6 = mk6.Foundation;


            //accessing concealers
            concealer1 = mk1.Concealer;
            concealer1 = mk2.Concealer;
            concealer1 = mk3.Concealer;
            concealer1 = mk4.Concealer;
            concealer1 = mk5.Concealer;
            concealer1 = mk6.Concealer;

            //accessing highlighters
            highlighter1 = mk1.Highlighter;
            highlighter2 = mk2.Highlighter;
            highlighter3 = mk3.Highlighter;
            highlighter4 = mk4.Highlighter;
            highlighter5 = mk5.Highlighter;
            highlighter6 = mk6.Highlighter;

            //accessing compacts
            compact1 = mk1.Compact;
            compact2 = mk2.Compact;
            compact3 = mk3.Compact;
            compact4 = mk4.Compact;
            compact5 = mk5.Compact;
            compact6 = mk6.Compact;

            //accessing kajals
            kajal1 = mk1.Kajal;
            kajal2 = mk2.Kajal;
            kajal3 = mk3.Kajal;
            kajal4 = mk4.Kajal;
            kajal5 = mk5.Kajal;
            kajal6 = mk6.Kajal;


            //accessing liners
            liner1 = mk1.Liner;
            liner2 = mk2.Liner;
            liner3 = mk3.Liner;
            liner4 = mk4.Liner;
            liner5 = mk5.Liner;
            liner6 = mk6.Liner;

            //accessing eyeshadows
            eyeshadow1 = mk1.Eyeshadow;
            eyeshadow2 = mk2.Eyeshadow;
            eyeshadow3 = mk3.Eyeshadow;
            eyeshadow4 = mk4.Eyeshadow;
            eyeshadow5 = mk5.Eyeshadow;
            eyeshadow6 = mk6.Eyeshadow;

            //accessing lipglosss
            lipgloss1 = mk1.Lipgloss;
            lipgloss2 = mk2.Lipgloss;
            lipgloss3 = mk3.Lipgloss;
            lipgloss4 = mk4.Lipgloss;
            lipgloss5 = mk5.Lipgloss;
            lipgloss6 = mk6.Lipgloss;

            //accessing Creamylipsticks
            creamylipstick1 = mk1.Creamylipstick;
            creamylipstick2 = mk2.Creamylipstick;
            creamylipstick3 = mk3.Creamylipstick;
            creamylipstick4 = mk4.Creamylipstick;
            creamylipstick5 = mk5.Creamylipstick;
            creamylipstick6 = mk6.Creamylipstick;


            //accessing Mattelipsticks
            mattelipstick1 = mk1.Mattelipstick;
            mattelipstick2 = mk2.Mattelipstick;
            mattelipstick3 = mk3.Mattelipstick;
            mattelipstick4 = mk4.Mattelipstick;
            mattelipstick5 = mk5.Mattelipstick;
            mattelipstick6 = mk6.Mattelipstick;

            //accessing subtlenails
            subtlenail1 = mk1.Subtlenail;
            subtlenail2 = mk2.Subtlenail;
            subtlenail3 = mk3.Subtlenail;
            subtlenail4 = mk4.Subtlenail;
            subtlenail5 = mk5.Subtlenail;
            subtlenail6 = mk6.Subtlenail;

            //accessing mattenails
            mattenail1 = mk1.Mattenail;
            mattenail2 = mk2.Mattenail;
            mattenail3 = mk3.Mattenail;
            mattenail4 = mk4.Mattenail;
            mattenail5 = mk5.Mattenail;
            mattenail6 = mk6.Mattenail;

            //accessing glitternails
            glitternail1 = mk1.Glitternail;
            glitternail2 = mk2.Glitternail;
            glitternail3 = mk3.Glitternail;
            glitternail4 = mk4.Glitternail;
            glitternail5 = mk5.Glitternail;
            glitternail6 = mk6.Glitternail;


        }


        public void MyFace(string opt3)
        {
            switch (opt3)
            {
                case "1":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.LOreal Paris Infallible     ");
                    Console.WriteLine("     2.Kay Beauty Hydrating Foundation   ");
                    Console.WriteLine("     3.Maybelline New York Fit me Foundation   ");
                    Console.WriteLine("     4.Huda Beauty Fauxfilter     ");
                    Console.WriteLine("     5.Charlotte Tilbury Hollywood Filter   ");
                    Console.WriteLine("     6.M.A.C Studio Fix Fuild   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    FoundationCart(opt4, qnty);
                    break;
                case "2":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Maybelline New York Fit me Concealer     ");
                    Console.WriteLine("     2.L.A. Girl   ");
                    Console.WriteLine("     3.Charlotte Tilbury Magic Away Liquid Concealer   ");
                    Console.WriteLine("     4.Smashbox Studio     ");
                    Console.WriteLine("     5.PAC Spotlight Liquid Concealer   ");
                    Console.WriteLine("     6.Swiss Beauty Liquid Concealer   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    ConcealerCart(opt4, qnty);
                    break;
                case "3":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.BECCA Ignite Liquified Light Hightlighter     ");
                    Console.WriteLine("     2.Huda Beauty 3D Highlighter   ");
                    Console.WriteLine("     3.Kay Beauty Illuminating Hightlighter   ");
                    Console.WriteLine("     4.Swiss Beauty Drop and Glow Liquid Highlighter     ");
                    Console.WriteLine("     5.M.A.C Mineralize Skinfinish  ");
                    Console.WriteLine("     6.Swiss Beauty Brick Highlighter   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    HighlighterCart(opt4, qnty);
                    break;
                case "4":
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Maybelline New York Fit Me Oil Control     ");
                    Console.WriteLine("     2.Kay Beauty Matte Compact   ");
                    Console.WriteLine("     3.Faces Canada Compact   ");
                    Console.WriteLine("     4.LOreal Paris Infalliable Pro Matte Powder     ");
                    Console.WriteLine("     5.Lakme Absolute Compact  ");
                    Console.WriteLine("     6.Bobbi Brown Sheer Finish Powder   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    CompactCart(opt4, qnty);
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;

            }

        }
        public void MyEyes(string opt3)
        {
            switch (opt3)
            {
                case "1":
                    //kajal
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Lakme Eyeconic Kajal     ");
                    Console.WriteLine("     2.Swiss Beauty Deep Black Kajal   ");
                    Console.WriteLine("     3.Maybelline New York Colossal Kajal   ");
                    Console.WriteLine("     4.Chambor Extreme Eyes Kajal     ");
                    Console.WriteLine("     5.Colorbar Intensely Rich Kajal   ");
                    Console.WriteLine("     6.SUGAR Khol Of Honour Intense Kajal   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    KajalCart(opt4, qnty);
                    return;
                case "2":
                    //liner
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.LOreal Paris Super Liner     ");
                    Console.WriteLine("     2.Kay Beauty Quick Dry Liquid Eyeliner   ");
                    Console.WriteLine("     3.Lakme 9 to 5 Black Impact Eye Liner   ");
                    Console.WriteLine("     4.M.A.C Technakhol Liner     ");
                    Console.WriteLine("     5.Colorbar Waterproof Liquid Eyeliner   ");
                    Console.WriteLine("     6.Maybelline New York Collassal Bold Liner   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    LinerCart(opt4, qnty);
                    break;
                case "3":
                    //eyeshadow
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Makeup Revolution Eyeshadow Palette     ");
                    Console.WriteLine("     2.SUGAR Blend The Rules Eyeshadow Palette   ");
                    Console.WriteLine("     3.Miss Claire Makeup Studio Eyeshadow Palette    ");
                    Console.WriteLine("     4.Huda Beauty The Nude Eyeshadow Palette     ");
                    Console.WriteLine("     5.Kay Beauty Eyeshadow Palette  ");
                    Console.WriteLine("     6.Huda Beauty Pastel Obsessions Eyeshadow Palette   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    EyeshadowCart(opt4, qnty);
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;

            }

        }

        public void MyLips(string opt3)
        {
            switch (opt3)
            {
                case "1":
                    //lipgloss
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.SUGAR Time To Shine Lip Gloss     ");
                    Console.WriteLine("     2.Lime Crime Wet Cherry Lip Gloss   ");
                    Console.WriteLine("     3.Miss Claire Pearly Gloss   ");
                    Console.WriteLine("     4.Bobbi Brown Crushed Oil Infused Gloss     ");
                    Console.WriteLine("     5.Lakme Absolute Plump And Shine Lip Gloss   ");
                    Console.WriteLine("     6.Rimmel London Oh My Gloss!   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    LipglossCart(opt4, qnty);
                    break;
                case "2":
                    //creamylipstick
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.MyGlamm LIT Creamy Matte Lipstick     ");
                    Console.WriteLine("     2.Kiko Milano Gossamer Emotion Creamy Lipstick   ");
                    Console.WriteLine("     3.SERY Say Cheez!   ");
                    Console.WriteLine("     4.Maybelline New York Color Sensational Creamy Lipstick     ");
                    Console.WriteLine("     5.SUGAR X Wonder Woman Creamy Lipstick   ");
                    Console.WriteLine("     6.Stars Cosmetics Lush Creamy Lipstick   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    CreamylipstickCart(opt4, qnty);
                    break;
                case "3":
                    //mattelipstick
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Kay Beauty Long Stay Matte Lipstick     ");
                    Console.WriteLine("     2.Elle 18 Color Pops Matte Lipstick   ");
                    Console.WriteLine("     3.Huda Beauty Power Bullet Matte Lipstick    ");
                    Console.WriteLine("     4.Swiss Beauty Pure Matte Lipstick     ");
                    Console.WriteLine("     5.Insight Cosmetics Matte Lipsticks  ");
                    Console.WriteLine("     6.Masaba Pure Matte Lipstick   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    MattelipstickCart(opt4, qnty);
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;


            }

        }

        public void MyNails(string opt3)
        {
            switch (opt3)
            {
                case "1":
                    //SUBTLENAILPOLISH
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Pear Nova Nail Polish     ");
                    Console.WriteLine("     2.Olive and June Nail Polish   ");
                    Console.WriteLine("     3.Paint Box Nail Lacquer   ");
                    Console.WriteLine("     4.Cote Toxin Free Nail Polish     ");
                    Console.WriteLine("     5.Sally Hansen Miracle Gel   ");
                    Console.WriteLine("     6.Essie Sheer Enamel Nail Polish   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    SubtlenailCart(opt4, qnty);
                    break;
                case "2":
                    //mattenailpolish
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Littmuss Matte Chrome Nail Polish     ");
                    Console.WriteLine("     2.MyGlamm LIT Matte Nail Enamel   ");
                    Console.WriteLine("     3.Bella Voste Matte Nail Paint   ");
                    Console.WriteLine("     4.Eylina Matte Nail Polish    ");
                    Console.WriteLine("     5.Iba Perfect Matte Top Coat   ");
                    Console.WriteLine("     6.Revlon Summer Matte-Ness Nail Enamel   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    MattenailCart(opt4, qnty); 
                    break;
                case "3":
                    //glitternailpolish
                    Console.WriteLine("_________________ ");
                    Console.WriteLine();
                    Console.WriteLine("     1.Lakme Color Crush Nail Art     ");
                    Console.WriteLine("     2.Bella Voste Glitter Nail Paint   ");
                    Console.WriteLine("     3.Colorbar Nail Lacquer    ");
                    Console.WriteLine("     4.Swiss Beauty Glitter Nail Polish     ");
                    Console.WriteLine("     5.Manish Malhotra Beauty By MyGlamm Nail Lacquer  ");
                    Console.WriteLine("     6.Miss Claire Ultimate Glitter Nail Polish   ");

                    Console.WriteLine("_________________     ______________________     _____________________     ___________________    __________________");
                    Console.WriteLine("Select the item you want to buy:");
                    opt4 = Console.ReadLine();
                    Console.WriteLine("Select the quantity:");
                    qnty = Console.ReadLine();
                    GlitternailCart(opt4, qnty); 
                    break;
                default:
                    Console.WriteLine("Sorry you entered the wrong option! ");
                    break;


            }

        }
        public void FoundationCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(foundation1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(foundation2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(foundation3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(foundation4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(foundation5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(foundation6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyFace(opt3);

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
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"            {orderfile}");
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
                            MyFace(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyFace(opt3);

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

        public void ConcealerCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(concealer1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(concealer2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(concealer3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(concealer4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(concealer5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(concealer6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyFace(opt3);

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
                            MyFace(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyFace(opt3);

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

        public void HighlighterCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(highlighter1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(highlighter2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(highlighter3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(highlighter4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(highlighter5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(highlighter6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyFace(opt3);

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
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"             {orderfile}");
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
                            MyFace(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyFace(opt3);

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


        public void CompactCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(compact1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(compact2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(compact3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(compact4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(compact5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(compact6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyFace(opt3);

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
                            MyFace(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyFace(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyFace(opt3);
            }
        }


        public void KajalCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(kajal1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(kajal2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(kajal3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(kajal4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(kajal5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(kajal6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyEyes(opt3);

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
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"            {orderfile}");
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
                            MyEyes(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyEyes(opt3);

                    }
                    else
                    {
                        Console.WriteLine("Incorrect character!");

                    }

                }


            }
            else
            {
                MyEyes(opt3);
            }

        }

        public void LinerCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(liner1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(liner2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(liner3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(liner4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(liner5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(liner6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyEyes(opt3);

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
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"             {orderfile}");
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
                            MyEyes(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyEyes(opt3);

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

        public void EyeshadowCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(eyeshadow1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(eyeshadow2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(eyeshadow3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(eyeshadow4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(eyeshadow5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(eyeshadow6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyEyes(opt3);

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
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
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
                            MyEyes(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyEyes(opt3);

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


        public void LipglossCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(lipgloss1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(lipgloss2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(lipgloss3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(lipgloss4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(lipgloss5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(lipgloss6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyLips(opt3);

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
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"              {orderfile}");
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
                            MyLips(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyLips(opt3);

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

        public void CreamylipstickCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(creamylipstick1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(creamylipstick2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(creamylipstick3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(creamylipstick4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(creamylipstick5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(creamylipstick6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyLips(opt3);

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
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"              {orderfile}");
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
                            MyLips(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyLips(opt3);

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

        public void MattelipstickCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(mattelipstick1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(mattelipstick2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(mattelipstick3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(mattelipstick4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(mattelipstick5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(mattelipstick6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyLips(opt3);

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
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"              {orderfile}");
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
                            MyLips(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyLips(opt3);

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

        public void SubtlenailCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(subtlenail1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(subtlenail2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(subtlenail3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(subtlenail4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(subtlenail5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(subtlenail6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyNails(opt3);

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
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
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
                            MyNails(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyNails(opt3);

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


        public void MattenailCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(mattenail1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(mattenail2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(mattenail3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(mattenail4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(mattenail5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(mattenail6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyNails(opt3);

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
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"              {orderfile}");
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
                            MyNails(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyNails(opt3);

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

        public void GlitternailCart(string opt4, string qnty)
        {
            Console.WriteLine("Press 'y' to add product in cart or press any character to go exit:");
            c1 = Convert.ToChar(Console.ReadLine());

            if (c1 == 'y')
            {
                switch (opt4)
                {
                    case "1":
                        items.Add(glitternail1, qnty);
                        counter++;
                        break;
                    case "2":
                        items.Add(glitternail2, qnty);
                        counter++;
                        break;
                    case "3":
                        items.Add(glitternail3, qnty);
                        counter++;
                        break;
                    case "4":
                        items.Add(glitternail4, qnty);
                        counter++;
                        break;
                    case "5":
                        items.Add(glitternail5, qnty);
                        counter++;
                        break;
                    case "6":
                        items.Add(glitternail6, qnty);
                        counter++;
                        break;
                }

                if (qnty == "")
                {
                    //if quantity not set means asked quantity is greater than available
                    Console.WriteLine($"We have only  foundations available ....Please buy within or equal to the available stock! ");
                    MyNails(opt3);

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
                    c2 = Convert.ToChar(Console.ReadLine());
                    if (c2 == 'y')
                    {
                        Console.WriteLine("**************CART ITEMS******************");
                        Console.WriteLine("_______________________________________________________________________________");
                        Console.WriteLine();
                        Console.WriteLine("                   Item Name                   Item quantity                   ");
                        Console.WriteLine($"               {orderfile}");
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
                            MyNails(opt3);


                        }
                        else
                        {
                            Console.WriteLine("Incorrect character!");

                        }

                    }
                    else if (c2 == 'c')
                    {
                        MyNails(opt3);

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

        }*/

    }
}

    

