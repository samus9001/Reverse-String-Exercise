namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, please type a word and I will type it backwards!");
            string UserInput = Console.ReadLine();

            char[] arr = UserInput.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine(new String(arr));
        }
    }
}