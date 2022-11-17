namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Beugro1();
        }

        private static void Beugro1()
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
        }
    }
}