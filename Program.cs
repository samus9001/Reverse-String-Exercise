using System.Diagnostics.Metrics;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asks the user a prompt
            Console.WriteLine("Hello, please type a word and I will type it backwards!\n");

            while (true)
            {
                string reverseWord = "";
                //user inputs response to prompt
                string userInput = Console.ReadLine();

                //runs through the user input by looking at the length of the given string
                for (int i = userInput.Length - 1; i >= 0; i--)
                {
                    //method created to store the reverse word
                    reverseWord += userInput[i];
                    //prints the output of each letter in reverse order on one line
                    Console.Write(userInput[i]);
                }

                Console.WriteLine("\n");

                //checks if the user input string matches the reverse word method string and outputs this to the user if true
                if (userInput.Equals(reverseWord, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("This word is a palindrome!\n");
                }
            }
        }
    }
}