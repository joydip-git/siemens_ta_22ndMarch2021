using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.UserInteraface
{
    class Program
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

        static int Add(int first, int second)
        {
            return (first + second);
        }

        static int Subtract(int first, int second)
        {
            return (first - second);
        }

        static int Multiply(int first, int second)
        {
            return (first * second);
        }

        static int Divide(int first, int second)
        {
            return (first / second);
        }

        static string Calculate(int calculationChoice, int first, int second)
        {
            string result = null;
            switch (calculationChoice)
            {
                case 1:
                    int addResult = Add(first, second);
                    result = "Addition of " + first + " and " + second + " is " + addResult;
                    break;

                case 2:
                    int subtractionResult = Subtract(first, second);
                    result = "Subtraction of " + first + " and " + second + " is " + subtractionResult;
                    break;

                case 3:
                    int multiplicationResult = Multiply(first, second);
                    result = "Multiplication of " + first + " and " + second + " is " + multiplicationResult;
                    break;

                case 4:
                    int divisionResult = Divide(first, second);
                    result = "Division Result of " + first + " and " + second + " is " + divisionResult;
                    break;

                default:
                    result = "Choose proper option";
                    break;
            }
            return result;
        }

        static char ConvertToLowerCase(char charInput)
        {
            if (char.IsUpper(charInput))
            {
                charInput = char.ToLower(charInput);
            }
            return charInput;
        }

        static char Decide()
        {
            Console.Write("\nContinue?[y/Y/n/N]: ");
            char choice = char.Parse(Console.ReadLine());
            return ConvertToLowerCase(choice);
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

                string calculationResult = Calculate(choice, firstNumber, secondNumber);
                Console.WriteLine(calculationResult);
                toContinue = Decide();
            } while (toContinue != 'n' && toContinue == 'y');
            //100 lines
        }
    }
}
