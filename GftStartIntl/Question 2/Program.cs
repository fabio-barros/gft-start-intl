using System;
using System.Collections.Generic;
using System.Linq;

namespace Question_2
{
    class Program
    {
        private static List<double> _userNumbers = new List <double>();

        static void Main(string[] args)
        {
            TakeUserInput();
            PrintValues(_userNumbers);
        }


        private static void TakeUserInput()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i+1}º número: ");
                _userNumbers.Add(Convert.ToDouble(Console.ReadLine()));
            }

        }

        private static void PrintValues(List<double> userNumbers)
        {
            userNumbers.Sort();
            /**
             * Maior e menor valor a partir do índice.
             */
            //Console.WriteLine($"Maior número: {userNumbers[0]}");
            //Console.WriteLine($"Menor número: {userNumbers[userNumbers.Count -1]}");

            /**
             * Maneira mais simples utilizando LINQ
             */
            Console.WriteLine($"Maior número: {userNumbers.Max()}");
            Console.WriteLine($"Maior número: {userNumbers.Min()}");

            List<double> numbersAbove10 = NumbersAboveGivenNumber(userNumbers, 10);
            List<double> numbersAbove50 = NumbersAboveGivenNumber(userNumbers, 50);

            Console.WriteLine($"Números acima de 10: Quantidade - {numbersAbove10.Count} Números - ");
            PrintList(numbersAbove10);

            Console.WriteLine($"Números acima de 50: Quantidade - {numbersAbove10.Count} Números - ");
            PrintList(numbersAbove50);

            Console.WriteLine($"Média Artimética: {userNumbers.Average()}");
        }

        private static List<double> NumbersAboveGivenNumber(List<double> userNumbers, double parameter)
        {
            return userNumbers.FindAll(num => num > parameter);
        }

        private static void PrintList(List<double> userNumbers)
        {
            foreach (var number in userNumbers)
            {
                Console.Write($"{number}, ");
            }
            Console.Write(".");
        }
    }
}
