using System.Text;

namespace Practice_task_01_Strings_and_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myStrings = ["Jovan", "Alexander", "Eye", "Madam", "Hello world!", "   My name is    Jovan.   "];

            Console.WriteLine("Original array: ");
            foreach (string str in myStrings)
            {
                Console.WriteLine(str);
            }

            string[] reversedStrings = ReverseString(myStrings);
            Console.WriteLine("\n\nArray with reversed strings: ");
            foreach (string str in reversedStrings)
            {
                Console.WriteLine(str);
            }

            int[] vowelsNumber = CountVowelsInString(myStrings);
            Console.WriteLine("\n\nNumber of vowels in each string: ");
            foreach (int count in vowelsNumber)
            {
                Console.Write(count + " ");
            }

            bool[] palindromes = IsStringPalindrome(myStrings);
            Console.WriteLine("\n\nAre strings palindromes: ");
            foreach (bool pal in palindromes)
            {
                Console.Write(pal + " ");
            }

            int[] numberOfWords = CountWords(myStrings);
            Console.WriteLine("\n\nNumber of words in each string: ");
            foreach (int count in numberOfWords)
            {
                Console.Write(count + " ");
            }

            Console.ReadLine();
        }

        public static string[] ReverseString(string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                StringBuilder ReversedString = new StringBuilder();

                for (int j = 0; j < strings[i].Length; j++)
                {
                    ReversedString.Append(strings[i][strings[i].Length - 1 - j]);
                }
                strings[i] = ReversedString.ToString();
            }
            return strings;
        }

        public static int[] CountVowelsInString(string[] strings)
        {
            int[] numberOfVowels = new int[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < strings[i].Length; j++)
                {
                    strings[i] = strings[i].ToLower();
                    if (strings[i][j] == 'a' || strings[i][j] == 'e' || strings[i][j] == 'i' || strings[i][j] == 'o' || strings[i][j] == 'u')
                    {
                        counter++;
                    }
                }
                numberOfVowels[i] = counter;
            }
            return numberOfVowels;
        }

        public static bool[] IsStringPalindrome(string[] strings)
        {
            bool[] isPalindrome = new bool[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                StringBuilder palindrome = new StringBuilder();

                strings[i] = strings[i].ToLower();

                for (int j = 0; j < strings[i].Length; j++)
                {
                    palindrome.Append(strings[i][strings[i].Length - 1 - j]);
                }

                if (palindrome.ToString() == strings[i])
                {
                    isPalindrome[i] = true;
                }
            }
            return isPalindrome;
        }

        public static int[] CountWords(string[] strings)
        {
            int[] numberOfWords = new int[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                int counter = 1;
                strings[i] = strings[i].Trim();

                for (int j = 0; j < strings[i].Length; j++)
                {
                    if (strings[i][j] == ' ')
                    {
                        if (strings[i][j + 1] == ' ')
                        {
                            continue;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
                numberOfWords[i] = counter;
            }
            return numberOfWords;
        }
    }
}
