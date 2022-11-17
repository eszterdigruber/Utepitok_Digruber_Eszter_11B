namespace HelloWorld
{
    class Program
    {
        static int[] DolgozokTMB = new int[18];
        static double[] UtHosszTMB = new double[18];
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //Beugro1();
            Utepitok();
        }

        private static void Utepitok()
        {
            Feladat1();
            Feladat_02();
            Feladat3();
            Feladat4();
            Feladat6();
            Feladat7();
            Feladat8();
        }

        private static void Feladat8()
        {
            Console.WriteLine("\nFeladat 8:");
            int CsereDolgozo;
            double CsereUtHossz;
            for (int i = 0; i < UtHosszTMB.Length; i++)
            {
                for (int j = 0; j <UtHosszTMB.Length -1; j++)
                {
                    if (UtHosszTMB[j] < UtHosszTMB[j + 1])
                    {
                        CsereUtHossz = UtHosszTMB[j];
                        CsereDolgozo = DolgozokTMB[j];
                        UtHosszTMB[j] = UtHosszTMB[j + 1];
                        DolgozokTMB[j] = DolgozokTMB[j + 1];
                        UtHosszTMB[j + 1] = CsereUtHossz;
                        DolgozokTMB[j + 1] = CsereDolgozo;
                    }
                }
            }
            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine($"{i + 1}. nap -> dolgozók szánma: {DolgozokTMB[i]} -> {UtHosszTMB[i]:0.00}");
            }
        }

        private static void Feladat7()
        {
            Console.WriteLine("\nFeladat 7:");
            bool Vane = false;
            Console.Write("Kérem adjon meg 8-12 között egy számot: ");
            int KeresSzam = int.Parse(Console.ReadLine());
            for (int i = 0; i < DolgozokTMB.Length; i++)
            {
                if (KeresSzam == DolgozokTMB[i])
                { 
                    Vane = true; 
                    break; 
                }
            }
            if (Vane == true) 
            { Console.WriteLine("Igen volt ilyen nap"); }
            else 
            { Console.WriteLine("Nem volt ilyen nap"); }
        }

        private static void Feladat6()
        {
            Console.WriteLine("\nFeladat 6:");
            int db65 = 0;
            for (int i = 0; i < UtHosszTMB.Length; i++)
            {
                if (65 < UtHosszTMB[i])
                { db65++; }
            }
            Console.WriteLine($"Ennyi alkalommal volt 65 méter feletti: {db65}");
        }

        private static void Feladat4()
        {
            Console.WriteLine("\nFeladat 4:");
            double MaxHossz = double.MinValue;
            int MaxHely = 0;
            int DolgozokSzama = 0;
            for (int i = 0; i < UtHosszTMB.Length; i++)
            {
                if (MaxHossz < UtHosszTMB[i])
                {
                    MaxHossz = UtHosszTMB[i];
                    DolgozokSzama = DolgozokTMB[i];
                }
            }
            Console.WriteLine($"Max út hossz: {MaxHossz}, dolgozók száma: {DolgozokSzama}");
        }

        private static void Feladat3()
        {
            Console.WriteLine("\nFeladat 3:");
            int OsszDolgozo = 0;
            for (int i = 0; i < 18; i++)
            {
                OsszDolgozo += DolgozokTMB[i];
            }
            double AtlagDolgozok = (double)OsszDolgozo / DolgozokTMB.Length;
            Console.WriteLine($"Dolgozók számának átlaga: {AtlagDolgozok:0.00}");
        }

        private static void Feladat_02()
        {
            Console.WriteLine("Feladat 2:");
            for (int i = 0; i < 18; i++)
            {
                Console.WriteLine($"{i + 1}. nap -> dolgozók szánma: {DolgozokTMB[i]} -> {UtHosszTMB[i]:0.00}");
            }
        }

        private static void Feladat1()
        {
            //Console.WriteLine("Feladat 1:");
            for (int i = 0; i < 18; i++)
            {
                DolgozokTMB[i] = rnd.Next(8, 13);
                UtHosszTMB[i] = rnd.Next(5055, 7555) / 100.00;
            }
        }

        /*private static void Beugro1()
        {
            int[] FeltoltTMB = { 23, 52, 62, 42, 73, 45, 32, 25, 36, 58, 39, 42, 12, 40 };
            int CsereSzam;
            for (int i = 0; i < FeltoltTMB.Length; i++)
            {
                for (int j = 0; j < FeltoltTMB.Length-1; j++)
                {
                    if (FeltoltTMB[j] > FeltoltTMB[j + 1]) // Növekvő: FeltoltTMB[j] > FeltoltTMB[j + 1] Csökkenő: FeltoltTMB[j] < FeltoltTMB[j + 1]
                    {
                        CsereSzam = FeltoltTMB[j];
                        FeltoltTMB[j] = FeltoltTMB[j + 1];
                        FeltoltTMB[j + 1] = CsereSzam;
                    }
                }
            }
            for (int i = 0; i < FeltoltTMB.Length; i++)
            { Console.Write($"{FeltoltTMB[i]}, ");  }
        }*/
    }
}