using System.Xml.Linq;

namespace challenges_and_data_structures
{
    public class ReverseWords
    {


        public static void Main(string[] args)
        {
            string string1 = "csharp is programming language";
            Console.WriteLine(Reverse_Words(string1));
        }

        public static string Reverse_Words(string word)
        {
            string[] word_array = word.Split(' ');
            string reversedWord = "";
            for (int i = word_array.Length - 1; i >= 0; i--)
            {
                {
                    if (i == 0)
                    {
                        reversedWord += word_array[i];
                    }
                    else
                    {
                        word_array[i] += " ";
                        reversedWord += word_array[i];
                    }
                }
                
            }
            return reversedWord;
        }
    }
}