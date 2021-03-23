using System;
using CalculatorApp.Manager;
using CalculatorApp.Utilities;

namespace CalculatorApp.UserInteraface
{
    class UI
    {
        static void ShowMenu()
        {
            Console.WriteLine("----MENU----");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtratc");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
        }

        static int GetChoice()
        {
            Console.Write("\nEnter Choice: ");
            //string input =  Console.ReadLine();//1 --> "1"
            //int choice = int.Parse(input);
            //return choice;
            //Convert.ToInt32(Console.ReadLine());
            return int.Parse(Console.ReadLine());
        }

        static int GetParameter()
        {
            Console.Write("\nEnter value: ");
            return int.Parse(Console.ReadLine());
        }  

        static char Decide()
        {
            Console.Write("\nContinue?[y/Y/n/N]: ");
            char choice = char.Parse(Console.ReadLine());
            return Utility.ConvertToLowerCase(choice);
        }

        static void Main()
        {
            char toContinue = 'n';           
            do
            {
                int choice = 0;
                int firstNumber = 0;
                int secondNumber = 0;
               
                ShowMenu();
                
                choice = GetChoice();
                firstNumber = GetParameter();
                secondNumber = GetParameter();

                string calculationResult = CalculationManager.Calculate(choice, firstNumber, secondNumber);
                Console.WriteLine(calculationResult);
                toContinue = Decide();
            } while (toContinue != 'n' && toContinue == 'y');
            //100 lines
        }
    }
}
