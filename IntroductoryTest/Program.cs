using System.Text;

class Program
{
    private static void Main()
    {
        var sb = new StringBuilder();

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                sb.Append("Fizz");
            }

            if (i % 5 == 0)
            {
                sb.Append("Buzz");
            }

            Console.WriteLine(sb.Length > 0 ? sb.ToString() : i);

            sb.Clear();
        }
    }
}
