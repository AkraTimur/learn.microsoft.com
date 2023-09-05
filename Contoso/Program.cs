using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Contoso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] corporate =
             {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            string[,] external =
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "@hayworth.com";
            string corporateDomain = "@contoso.com";


            for (int i = 0; i < corporate.GetLength(0); i++)
            {
                var str = new StringBuilder();
                var element = "";

                for (int j = 0; j < corporate.GetLength(1); j++)
                {
                    //Console.WriteLine("Element({0},{1})={2}", i, j, corporate[i, j]);

                    element = corporate[i, j].ToLower();
                    str.Append(element);
                }

                var text = str.ToString();

                int startIndex = text.IndexOf(element);

                string result = text.Remove(2, startIndex - 2);

                Console.WriteLine($"{result}{corporateDomain}");

                str.Clear();
            }

            for (int i = 0; i < external.GetLength(0); i++)
            {
                var str = new StringBuilder();
                var element = "";

                for (int j = 0; j < external.GetLength(1); j++)
                {
                    //Console.WriteLine("Element({0},{1})={2}", i, j, corporate[i, j]);

                    element = external[i, j].ToLower();
                    str.Append(element);
                }

                var text = str.ToString();

                int startIndex = text.IndexOf(element);

                string result = text.Remove(2, startIndex - 2);

                Console.WriteLine($"{result}{externalDomain}");

                str.Clear();
            }
        }
    }
}