using System;
using System.Collections.Generic;
// If you would like to test BigInteger uncomment below line.
// using System.Numerics;

namespace ForegoneSolution
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int testCases = int.Parse(Console.ReadLine());

            for (int i = 1; i <= testCases; i++)
            {
                string prizeToPay = Console.ReadLine();

                char[] firstSequence = new char[prizeToPay.Length];
                char[] secondSequence = new char[prizeToPay.Length];
                

                for (int index = 0; index <= prizeToPay.Length - 1; index++)
                {
                    char currentNumber = prizeToPay[index];

                    if (currentNumber == '4')
                    {
                        firstSequence[index] = '3';
                        secondSequence[index] = '1';
                    }
                    else
                    {
                        firstSequence[index] = currentNumber;
                        secondSequence[index] = '0';
                    }
                }

                // Altough solving mathematical operations on chars feels wrong we need to do it.
                string firstCheck = string.Join("", firstSequence).TrimStart('0');
                string secondCheck = string.Join("", secondSequence).TrimStart('0');
                
                Console.WriteLine($"Case #{i}: {firstCheck} {secondCheck}");
                
            }
        }
    }
}
