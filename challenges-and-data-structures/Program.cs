using System.Xml.Linq;

namespace ContactManager
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int j = 19;
            int[] aa = middleValue(arr, j);
            for (int i = 0; i < aa.Length; i++)
            {
                Console.WriteLine(aa[i]);
            }
            // Console.WriteLine ("Try programiz.pro");
        }

        public static int[] middleValue(int[] arr, int val)
        {
            int n = arr.Length + 1, ind = (arr.Length / 2) ;
            int[] newArr = new int[n];
            for (int i = 0,j =0; i < n; i++,j++){
                if (i == ind)
                {
                    newArr[i] = val;
                    j--;
                }
                else {
                    newArr[i]= arr[j];
                }
            }
            return newArr;

        }
    }
}