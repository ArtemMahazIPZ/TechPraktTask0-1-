using System;

class Program
{
    static void Main()
    {
      
        Console.Write("Перше число: ");
        if (double.TryParse(Console.ReadLine(), out double number1))
        {
          
            Console.Write("Друге число: ");
            if (double.TryParse(Console.ReadLine(), out double number2))
            {
               
                double sum = number1 + number2;

                
                Console.WriteLine($"Сума чисел {number1} та  {number2} : {sum}");
            }
            else
            {
                Console.WriteLine("Некоректне друге число.");
            }
        }
        else
        {
            Console.WriteLine("Некоректне перше число.");
        }

        Console.ReadLine();
    }
}
