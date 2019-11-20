using System;


namespace ComputerAssistedInstruction
{
    class ComputerAssistedInstruction
    {
        
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();

            int firstNumber = randomNumbers.Next(10);
            int secondNumber = randomNumbers.Next(10);

            Console.WriteLine($"{firstNumber}  {secondNumber}");

            int answer = 0;
            int product = firstNumber * secondNumber;
            bool isCorrect = false;
            problemGeneration(firstNumber, secondNumber, answer);
     
        }

        static void problemGeneration(int num1, int num2, int answer)
        {
            Console.WriteLine($"How much is {num1} times {num2}");
        }

        static void checkAnswer(int answer, int product, bool isCorrect)
        {
            
        }
    }
}
