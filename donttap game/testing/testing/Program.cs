namespace testing
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("  Enter city:");
                Console.Write("->");
                string x = Console.ReadLine();
                var y = new[] { "x", "X" };
                bool notSafe = false;
                for(int i = 0; i < x.Length; i++)
                {
                    if(x[i] == 'x')
                    {
                        Console.WriteLine("Not Safe");
                        notSafe = true;
                        break;
                    }
                }
                if (!notSafe)
                    Console.WriteLine("Safe");
                Console.ReadLine();
            }
        }
    }
}