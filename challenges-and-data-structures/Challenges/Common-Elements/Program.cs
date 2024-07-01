using System.Xml.Linq;

namespace challenges_and_data_structures
{
    public class Program
    {
        
    
        public static void Main(string[] args)
        {
            int[] a1 = { 79, 8, 15 };
            int[] a2 = { 23, 79, 8 };
            int[] arra = CommonElements(a1, a2);
            foreach (int i in arra)
            {
                Console.WriteLine(i);
            }

        }

        public static int[] CommonElements(int[] a1, int[] a2)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < a1.Length; i++)
            {
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a1[i] == a2[j])
                        list.Add(a2[j]);
                }
            }
            int[] arr = list.ToArray();
            return arr;
        }

    }
}