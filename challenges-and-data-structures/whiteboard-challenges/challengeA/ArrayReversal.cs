using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.challengeA
{
    internal class ArrayReversal
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { 87, 2, 3, 4, 5 };
        //    int[] a1 = { 2, 8, 15, 23, 42 };
        //    ArrayReversa(arr);
        //    int[] aaa = ArrayReversa(a1);
        //    for (int i = 0; i < aaa.Length; i++)
        //    {
        //        Console.Write(aaa[i] + " ");

        //    }
        //}

        private static int[] ArrayReversa(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr1[j] = arr[i];
                j++;

            }

            return arr1;

        }
    }
}
