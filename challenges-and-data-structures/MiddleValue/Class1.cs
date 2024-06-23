using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.MiddleValue
{
    internal class Class1
    {
        public static int[] middleValue(int[] arr, int val)
        {
            int n = arr.Length + 1, ind = (arr.Length / 2);
            int[] newArr = new int[n];
            for (int i = 0, j = 0; i < n; i++, j++)
            {
                if (i == ind)
                {
                    newArr[i] = val;
                    j--;
                }
                else
                {
                    newArr[i] = arr[j];
                }
            }
            return newArr;

        }
    }
}
