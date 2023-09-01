namespace Panagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog";

            var arrOfStr = pangram.Split(' ').ToArray();

            for (int i = 0; i < arrOfStr.Length; i++)
            {
                var localArr = arrOfStr[i].ToCharArray();

                Array.Reverse(localArr);

                arrOfStr[i] = string.Join("", localArr);
            }

            var res = "ehT kciuq nworb xof spmuj revo eht yzal god";

            Console.WriteLine($"Should be like this: {res}");

            var myRes = string.Join(" ", arrOfStr);
            Console.WriteLine(myRes);

            Console.WriteLine();

            Console.WriteLine(res == myRes ? "DONE" : "TRY AGAIN");
        }
    }
}