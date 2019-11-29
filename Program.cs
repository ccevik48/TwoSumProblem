using System;
using System.Collections.Generic;

namespace TwoSum
{
    class Program
    {
        public static int[] TwoSumNaive(int[] a, int magicSum)
        {
            int[] sumIndeces = new int[2];
            for(int i = 0; i < a.Length - 1; i++)
            {
                for(int j = 1; j < a.Length; j++)
                {
                    if(a[i] + a[j] == magicSum)
                    {
                        sumIndeces[0] = i;
                        sumIndeces[1] = j;
                        //break;
                    }
                }
            }
            return sumIndeces;
        }
        public static int[] TwoSumHash(int[] a, int magicSum)
        {
            HashSet<int> ts = new HashSet<int>(a.Length);
            int[] sumIndeces = new int[2];
            ts.Add(a[0]);
            for(int i = 1; i < a.Length ; i++)
            {
                if(ts.Contains(magicSum - a[i]))
                {
                    sumIndeces[0] = Array.IndexOf(a, magicSum - a[i]);
                    sumIndeces[1] = i;
                    break;
                }
                else
                {
                    ts.Add(a[i]);
                }
            }
            return sumIndeces;
        }
        static void Main(string[] args)
        {
            int[] test = {34, 55, 3, 12, 13, 23, 8, 4, 9, 10};
            Console.WriteLine(string.Join(",", TwoSumNaive(test, 7) ));
            Console.WriteLine(string.Join(",", TwoSumHash(test, 7) ));
        }
    }
}
