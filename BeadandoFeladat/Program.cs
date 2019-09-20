using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoFeladat
{
    class Program
    {
        static void Harmadik()
        {
            
            Console.WriteLine("Adja meg, hány számot kérjünk be!");
            int N= Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            Console.WriteLine("Írjon be {0} számot!",N);
            int bekert;

            for (int i = 0; i < A.Length; i++)
            {
                bekert = Convert.ToInt32(Console.ReadLine());
                A[i] = bekert;
            }
            Console.WriteLine();
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            int max = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (max<A[i])
                {
                    max = A[i];
                }
            }
            int min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (min > A[i])
                {
                    min = A[i];
                }
            }
            Console.WriteLine("A legnagyobb szám: {0}, a legkisebb: {1}",max,min);


        }
        static void Main(string[] args)
        {
            Harmadik();


            Console.ReadLine();
        }
    }
}
