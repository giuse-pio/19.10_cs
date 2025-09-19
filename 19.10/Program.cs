namespace _19._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> numbers = new List<float>();
            Random rand = new Random();
            for (int i = 0; i < 101; i++)
            {
                numbers.Add(rand.Next(0, 11));
            }
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
            float media = 0;
            media = numbers.Average();
            Console.WriteLine(media);
            int count = 0;
            foreach (int n in numbers)
            {
                if (n > media)
                {
                    count++;
                }
            }
            Console.WriteLine($"i numeri sopra la media sono {count}");
        }
    }
}
