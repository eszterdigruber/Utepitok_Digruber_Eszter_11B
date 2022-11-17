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