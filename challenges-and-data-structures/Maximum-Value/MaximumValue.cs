using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Maximum_Value
{
    internal class MaximumValue
    {
        public int Maximumvalue(int[] arr) {
            int maxi = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > maxi)
                    maxi = arr[i];
            }
            return maxi;
        }
    }
}
