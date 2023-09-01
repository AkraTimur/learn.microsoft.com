namespace OrderStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

            var orders = orderStream.Split(',');

            foreach (var order in orders)
            {
                var res = order.Length != 4 ? $"{order}  - Error" : $"{order}";

                Console.WriteLine($"{res}");
            }
        }
    }
}