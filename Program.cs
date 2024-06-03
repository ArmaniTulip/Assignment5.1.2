using System.Reflection.Metadata;

namespace Assignment5._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers for the total sum");

            int userNums = Convert.ToInt32(Console.ReadLine());

            int sum =SumofDigits(userNums);

            Console.WriteLine(sum.ToString());

            

        }

        static int SumofDigits(int number)
        {
            int sum = 0;
            while (number != 0) 
            {
                sum += number % 10;

                number /= 10;
            }
            return sum;
        }
    }
}
