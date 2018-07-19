using System;
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
            bool continueFlag = true;
            var name = GetName();
            do
            {
                DetermineEvenOdd(name);
                var userContinue = ' ';
                do
                {
                    Console.Write("Would you like to Continue? Y/N");
                    userContinue = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                } while (char.ToLower(userContinue) != 'y' && char.ToLower(userContinue) != 'n');

                if (char.ToLower(userContinue) == 'n')
                {
                    continueFlag = false;
                }
            } while (continueFlag);
            
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }

        private static void DetermineEvenOdd(string name)
        {
            
            var input = GetNumber();
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
        }

        private static string GetNumber()
        {
            Console.Write("Please enter an integer between 1 and 100:");
            var input = Console.ReadLine();
            return input;
        }

        private static string GetName()
        {
            Console.Write("Please Enter your Name: ");
            var name = Console.ReadLine();
            return name;
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
