﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter your Name: ");
            var name = Console.ReadLine();
            Console.Write("Please enter an integer between 1 and 100:");
            var input = Console.ReadLine();
            if (int.TryParse(input, out var inputAsInteger))
            {
                if (inputAsInteger < 1 || inputAsInteger > 100)
                {
                    Console.WriteLine("The number you input was not between 1 and 100.");
                }
                if (inputAsInteger % 2 == 0)
                {
                    GenerateEvenOutput(name, inputAsInteger);
                }
                else
                {
                    GenerateOddOutput(name, inputAsInteger);
                }
            }
            else
            {
                Console.WriteLine("Please input an integer.");
            }

            Console.ReadKey();
        }

        private static void GenerateOddOutput(string name, int inputAsInteger)
        {
            //Odd Cases

            //There is no need to check input ranges, because they both output the same text.
            Console.WriteLine($"{name} - {inputAsInteger} Odd.");
        }

        private static void GenerateEvenOutput(string name, int inputAsInteger)
        {
            //Even Cases
            if (inputAsInteger >= 2 && inputAsInteger <= 25)
            {
                Console.WriteLine($"{name} - Even and less than 25.");
            }
            else if (inputAsInteger >= 26 && inputAsInteger <= 60)
            {
                Console.WriteLine($"{name} - Even");
            }
            else
            {
                Console.WriteLine($"{name} - {inputAsInteger} Even.");
            }
        }
    }
}
