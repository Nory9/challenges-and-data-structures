using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Remove_Middle_Value
{
    internal class Class1
    {
        public static int[] RemoveMiddleValue(int[] arr)
        {
            int ind = arr.Length / 2;
            int[] newArr = new int[arr.Length - 1];
            for (int i = 0, j = 0; i < arr.Length; i++)
            {
                if (i != ind)
                    newArr[j++] = arr[i];
            }
            return newArr;

        }
    }
}
