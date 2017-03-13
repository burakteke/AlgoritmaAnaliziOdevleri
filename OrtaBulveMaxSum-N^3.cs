using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtaBulveMaxSub__N_3
{
    class Program
    {
        static void ortaBul(int[] dizi)
        {
            List<int> dizi1 = new List<int>();
            List<int> dizi2 = new List<int>();
            if (dizi.Length % 2 == 0)
            {
                for (int i = 0; i < dizi.Length / 2; i++)
                {
                    dizi1.Add(dizi[i]);

                }
                for (int i = dizi.Length / 2; i < dizi.Length; i++)
                {
                    dizi2.Add(dizi[i]);
                }
                //            for (int i = 0; i < dizi.length/2; i++) {
                //                System.out.println(dizi1.get(i));
                //                
                //            }   
                Console.WriteLine("1. Dizi MaxSum:" + maxSubSum(dizi1));
                //            System.out.println();
                //            System.out.println("2.dizi");
                //           for (int i = 0; i < dizi.length/2; i++) {
                //                System.out.println(dizi2.get(i));
                //                
                //            } 
                Console.WriteLine("2. Dizi MaxSum:" + maxSubSum(dizi2));
            }
            else
            {
                for (int i = 0; i < dizi.Length / 2; i++)
                {
                    dizi1.Add(dizi[i]);

                }
                for (int i = dizi.Length / 2; i < dizi.Length; i++)
                {
                    dizi2.Add(dizi[i]);
                }
                //            for (int i = 0; i < dizi.length/2; i++) {
                //                System.out.println(dizi1.get(i));
                //                
                //            } 

                Console.Write("1.Dizi MaxSum:");
                Console.WriteLine(maxSubSum(dizi1));
                //            System.out.println("2.dizi");
                //           for (int i = 0; i < dizi.length/2+1; i++) {
                //                System.out.println(dizi2.get(i));
                //                
                //            }   
                Console.WriteLine("2. Dizi MaxSum:" + maxSubSum(dizi2));
            }

        }
        static int maxSubSum(List<int> dizi)
        {

            int maxSum = 0;

            int i, j, k;
            for (i = 0; i < dizi.Count(); i++)
            {

                for (j = i; j < dizi.Count(); j++)
                {
                    int thisSum = 0;
                    for (k = i; k <= j; k++)
                    {
                        thisSum += dizi[k];
                    }
                    if (thisSum > maxSum)
                    {
                        maxSum = thisSum;
                    }
                }
            }
            return maxSum;
        }
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int[] dizi = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                Random rastgele = new Random();
                int n = rastgele.Next(5, 10000);
                dizi[i] = n;
            }
            ortaBul(dizi);
            watch.Stop();
            //Console.WriteLine("Sonuç: {0}", result);
            Console.WriteLine("Süre: {0}", watch.Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }
    }
}
