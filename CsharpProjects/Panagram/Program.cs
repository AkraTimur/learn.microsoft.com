namespace Panagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog";

            var arrOfStr = pangram.Split(' ').ToArray();

            Console.WriteLine("Hello, World!");
        }
    }
}