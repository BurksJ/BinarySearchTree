using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Console.WriteLine("Please enter a number to search(1-15): ");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Value found at index: " + BinarySearch(numbers, searchNumber));
            Console.ReadKey();
        }

        public static int BinarySearch(int[] numbers, int searchValue)
        {
            int midIndex;
            int leftIndex = 0;
            int rightIndex = numbers.Length - 1;

            while (leftIndex <= rightIndex)
            {
                midIndex = leftIndex + ((rightIndex - leftIndex) / 2);

                if (numbers[midIndex] == searchValue)
                {
                    return midIndex;
                }
                else
                {
                    if (numbers[midIndex] > searchValue)
                    {
                        rightIndex = midIndex - 1;
                    }
                    else
                    {
                        leftIndex = midIndex + 1;
                    }
                }
            }

            return -1;
        }
    }
}

