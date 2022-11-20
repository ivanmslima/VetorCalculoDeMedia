using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {

            int N;
            double[] A;

            Console.Write(" Digite a quantidade de números para calcular a soma e media ");


            N = int.Parse(Console.ReadLine());
            A = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i=0; i<N; i++)
            {
                A[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }
            for (int i=0; i<N; i++)
            {
                Console.WriteLine(A[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            double soma = 0.0;
            for (int i=0; i<N; i++)
            {
                soma = soma + A[i];
            }

            double media = soma / N;

            Console.WriteLine("Soma = " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();




        }
    }
}