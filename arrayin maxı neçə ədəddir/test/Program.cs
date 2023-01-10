namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int counter=1;
            int max = 0;
            int digit;
            for (int i = 0; i < 100; i++)
            {
                digit = a % 10;
                a = (a - digit) / 10;
                if (max<digit)
                {
                    max = digit;
                }
                else if (max==digit)
                {
                    counter++;
                    
                }
            }
            Console.WriteLine(max);

            Console.WriteLine(counter);


         
        }
    }
}