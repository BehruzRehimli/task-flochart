namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int counter = 0;
            for (int i = 0; i < 100; i++)
            {
                if (a == 1)
                {
                    Console.WriteLine(counter);
                    break;
                }
                counter++; 
                if (a/2==1)
                {
                    Console.WriteLine(counter);
                    break;
                }
                else if (a%2==1||a==0)
                {
                    Console.WriteLine("2nin quvveti deyil!");
                    break;
                }
                else
                {
                    
                    a = a / 2;

                }
            }
  
        }
    }
}