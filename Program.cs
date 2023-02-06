namespace newTask._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Massivin uzunlugu: ");
            int n = int.Parse(Console.ReadLine());
            double[] massBir = new double[n];

            for (int i = 0; i < massBir.Length; i++)
            {
                Console.Write($"Massivin uzunlugu]{i}: ");
                massBir[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Ikinci massiv uzunlugu:");
            int n2 = int.Parse(Console.ReadLine());
            double[] massIki = new double[n2];

            for (int i = 0; i < massIki.Length; i++)
            {
                Console.Write($"Ikinci massiv uzunlugu]{i}: ");
                massIki[i] = double.Parse(Console.ReadLine());
            }

            double massBirMax = massBir[0];
            double masaIkiMax = massIki[0];

            for (int i = 1; i < massBir.Length; i++)
            {
                if (massBirMax < massBir[i])
                {
                    massBirMax = massBir[i];
                }
            }

            for (int i = 1; i < massIki.Length; i++)
            {
                if (masaIkiMax < massIki[i])
                {
                    masaIkiMax = massIki[i];
                }
            }

            if (massBirMax > masaIkiMax)
            {
                Console.WriteLine("Birinci massivdeki en boyuk element: " + massBirMax);
            }
            else
            {
                Console.WriteLine("Ikinci massivdeki en boyuk element: " + masaIkiMax);
            }

        }
    }
}

