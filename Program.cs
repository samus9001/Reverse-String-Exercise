namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, please type a word and I will type it backwards!");
            string UserInput = Console.ReadLine();

            for (int i = UserInput.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(UserInput[i]);
            }
        }
    }
}