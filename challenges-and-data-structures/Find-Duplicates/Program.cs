using System.Xml.Linq;

namespace ContactManager
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int[] arr = {16, 8, 31, 17, 15, 23, 17, 8};
            List<int> arr1=Find_Duplicates(arr);
            for (int i = 0; i < arr1.Count; i++) { 
            Console.WriteLine(arr1[i]);
            }
        }

        public static List<int> Find_Duplicates(int[] arr)
        {
            int mm = 0;
            List<int> list = new List<int>();
           // int[] newArr = new int[arr.Length/2];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > mm)
                    mm = arr[i];
            }
            int[] freq = new int[mm + 1];
            int c = 0, maxi = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                freq[arr[i]]++;
            }
            for (int i = 0; i < freq.Length; i++) {
              //  Console.WriteLine((freq[i]));
                if (freq[i]>1)
                  list.Add(i);
                //    new/Arr[i] = i;
            }
            
            return list;

        }
    }
}