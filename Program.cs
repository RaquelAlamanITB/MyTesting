using System;
namespace Refactoring
{
    class FirstRefactoringExercise
    {
        static void Main(string[] args)
        {
            int quantity, input, errors = 0, answer = 1, result;
            Console.WriteLine("Indica quants valors vols introduir:");
            quantity = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[quantity];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (errors < 3)
                {
                    do
                    {
                        Console.WriteLine("introdueix un valor entre el 5 i el 150 (inclosos). Tens 3 intents com a màxim");
                        input = Convert.ToInt32(Console.ReadLine());
                        errors++;
                    } while (input < 5 || input > 150);                                  
                    
                        numbers[i] = input;
                    
                }
            }
            if (errors == 3)
            {
                Console.WriteLine("Has superat el total d'intents.");
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    answer *= numbers[i];
                }
                Console.WriteLine(answer);
            }
        }
    }
}