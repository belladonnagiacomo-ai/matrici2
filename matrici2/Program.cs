namespace matrici2
{
    internal class Program
    {
        static void verifica(int[,] m, int n, int num)
        {
            bool ver = false;
            int l = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    l = m[i, j];
                    if (l < num || l > n)
                    {
                        ver = true;
                    }
                }
            }
            if (ver == true)
            {
                Console.WriteLine("Non tutti i numeri della matrice sono nell'intervallo dato");
            }
            else
            {
                Console.WriteLine("Tutti i numeri all'interno della matrice ci sono nell'intervalo dato");
            }

        }
        static void diagonale(int[,] m)
        {
            bool v = false;
            int sommap = 0, sommas = 0, j = m.GetLength(0) - 1;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                sommap = sommap + m[i, i];
                sommas = sommas + m[i, j];
                j--;
            }
            if (sommap == sommas)
            {
                v = true;
                Console.WriteLine("Le 2 somme sono uguali");
            }
        }
        static void palindroma(int[,] m)
        {
            int somma1, somma2;
            int l = m.GetLength(0) - 1;
            for(int i = 0; i < m.GetLength(0); i++)
            {
                somma1 = 0;
                somma2 = 0;
               for(int j = 0;  j < m.GetLength(1); j++)
               {
                    somma1 = somma1 + m[i, j];
                    somma2 = somma2 + m[l, j];
               }
                l--;
                if(somma1 == somma2)
                {
                    Console.WriteLine("La somma della " + i + " riga e della " + l + " righa sono uguali");
                }
                else
                {
                    Console.WriteLine("La somma della " + i + " riga e della " + l + " righa non sono uguali");
                }

            }
        }
        static void Main(string[] args)
        {
            int[,] m = { { 5, 3, 5}, { 7, 5, 2}, { 5, 12, 5} };
            Console.WriteLine("dammi l'inizio del range");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("dammi la fine del range");
            int n = Convert.ToInt32(Console.ReadLine());
            verifica(m, n, num);
            diagonale(m);
            palindroma(m);

        }
    }
}
