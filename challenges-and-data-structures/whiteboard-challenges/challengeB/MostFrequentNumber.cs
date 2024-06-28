using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.challengeB
{
    internal class MostFrequentNumber
    {
       
            //static void Main(string[] args)
            //{
            //    int[] arr = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1, 76, 76, 76, 76, 76, 76, 76, 7, 6, 76, 76, 76 };
            //    int maxii = freq(arr);
            //    Console.WriteLine(maxii);

            //}

            private static int freq(int[] arr)
            {
                int mm = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > mm)
                        mm = arr[i];
                }
                int[] arr1 = new int[mm + 1];
                int c = 0, maxi = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr1[arr[i]]++;
                }
                for (int i = 0; i <= mm; i++)
                {
                    if (arr1[i] > c)
                    {

                        c = arr1[i];
                        maxi = i;
                    }
                }

                return maxi;

            }

        }


    }
