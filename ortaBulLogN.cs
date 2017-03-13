using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtaBulLogN
{
    public class Program
    {
        static int ortaBul(int[] dizi)
        {
            int orta = dizi.Length / 2;
            int sumLeftMax = 0;
            int sumLeft = 0;
            for (int i = orta - 1; i > -1; i--)
            {
                sumLeft += dizi[i];
                if (sumLeft > sumLeftMax)
                {
                    sumLeftMax = sumLeft;
                }
            }
            int sumRightMax = 0;
            int sumRight = 0;
            for (int i = orta; i < dizi.Length; i++)
            {
                sumRight += dizi[i];
                if (sumRight > sumRightMax)
                {
                    sumRightMax = sumRight;
                }
            }
            return sumLeftMax + sumRightMax;
        }
        static int find_max_triple(int a, int b, int c)
        {
            if (a > b)
            {
                if (b > c)
                {
                    return a;
                }
                else if (a > c)
                {
                    return a;
                }
                else
                {
                    return c;
                }
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        static int arraySum(int[] dizi)
        {
            int sum = 0;
            foreach (int i in dizi)
                sum += i;
            return sum;
        }
        static int[] copyOfRange(int[] src, int start, int end)
        {
            int len = end - start;
            int[] dest = new int[len];
            Array.Copy(src, start, dest, 0, len);
            return dest;
        }
        static int sumLeft = 0, sumRight = 0, sumMidle = 0;
        static int maxSubSum(int[] dizi )
        {

            if (dizi.Length < 2)
            {
                return arraySum(dizi);
            }
            else
            {
                int middle = (dizi.Length) / 2;

                sumLeft = maxSubSum(copyOfRange(dizi,0,middle));
                sumRight = maxSubSum(copyOfRange(dizi, middle, dizi.Length));
                sumMidle = ortaBul(dizi);
            }
            return find_max_triple(sumLeft, sumRight, sumMidle);
        }
        static void Main(string[] args)
        {
            int[] dizi = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                Random rastgele = new Random();
                int n = rastgele.Next(5, 10000);
                dizi[i] = n;
            }

            Stopwatch watch = new Stopwatch();
            watch.Start();
            int result = maxSubSum(dizi);




            watch.Stop();
            Console.WriteLine("Sonuç: {0}", result);
            Console.WriteLine("Süre: {0}", watch.Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }
    }
}
