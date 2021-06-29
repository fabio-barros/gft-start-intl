using System;

namespace Questão_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToBeGuessed, userGuess;

            Random randonNumber = new Random();

            //Número gerado para ser advinhado
            numberToBeGuessed = randonNumber.Next(100);

            bool correct = false;
            while (!correct)
            {

                Console.WriteLine("Tente advinhar o número entra 1 e 100 ->  ");
                userGuess = Convert.ToInt32(Console.ReadLine());

                if (userGuess > numberToBeGuessed)
                {
                    Console.WriteLine($"Número muito alto! Tente novamente: ");
                }

                else if (userGuess < numberToBeGuessed)
                {
                    Console.WriteLine($"Número muito baixo! Tente novamente: ");
                }

                else
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    correct = true;
                }
            }
        }
    }
}
