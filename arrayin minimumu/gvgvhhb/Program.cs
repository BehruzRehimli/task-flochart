using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq.Expressions;

namespace gvgvhhb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            int[] input = { 2, 4, 8, 9, 1, 6, 11 };
            int MIN = input[0];
            
            for (int i = 0; i < input.Length; i++)
            {
                if (MIN > input[i])
                {
                    MIN = input[i];
                }
            }
            Console.WriteLine(MIN);


        }
    }
}