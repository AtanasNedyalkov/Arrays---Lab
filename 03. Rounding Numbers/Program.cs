using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] numbersAsArray =
                Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            
            for (int i = 0; i < numbersAsArray.Length; i++)
            {
                Console.WriteLine($"{numbersAsArray[i]} => {(int)Math.Round(numbersAsArray[i], MidpointRounding.AwayFromZero)}");
            }
            //double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //int[] numbers = new int[nums.Length];


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine($"{nums[i]} => {(int)Math.Round(nums[i], MidpointRounding.AwayFromZero)}");
            //}

        }
    }
}
