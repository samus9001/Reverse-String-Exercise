namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asks the user a prompt
            Console.WriteLine("Hello, please type a word and I will type it backwards!");

            //user inputs response to prompt
            string userInput = Console.ReadLine();

            //for loop runs through the user input  by looking at the length of the given string and prints the output of each letter backwards on one line
            string reverseWord = "";
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                //method created to store the reverse word then output the contents of the method to the user
                reverseWord += userInput[i];
                Console.Write(userInput[i]);
            }
            //if statement checks if the user input string matches the reverse word method string and outputs this to the user if true
            if (userInput.Equals(reverseWord, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nThis word is a palindrome!");
            }
        }
    }
}