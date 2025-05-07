﻿using System;
namespace LabPractical
{
    internal class UserArray
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] Arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");

            for (int i = 0; i < n; i++)
            {
                Arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] *= 7;
            }

            Console.WriteLine("Modified Array:");
            foreach (int item in Arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int sumOfOdd = 0;
            int index = 1; 
            foreach (int item in Arr)
            {
                if (index % 2 != 0)
                {
                    sumOfOdd += item;
                }
                index++;
            }

            Console.WriteLine("Sum of Odd Indices: " + sumOfOdd);
            Console.Beep();
        }
    }

}

