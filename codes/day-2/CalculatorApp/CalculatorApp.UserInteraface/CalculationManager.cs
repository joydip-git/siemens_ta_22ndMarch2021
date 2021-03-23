namespace CalculatorApp.UserInteraface
{
    class CalculationManager
    {
        public static string Calculate(int calculationChoice, int first, int second)
        {
            string result = null;
            switch (calculationChoice)
            {
                case 1:
                    int addResult = Calculation.Add(first, second);
                    result = "Addition of " + first + " and " + second + " is " + addResult;
                    break;

                case 2:
                    int subtractionResult = Calculation.Subtract(first, second);
                    result = "Subtraction of " + first + " and " + second + " is " + subtractionResult;
                    break;

                case 3:
                    int multiplicationResult = Calculation.Multiply(first, second);
                    result = "Multiplication of " + first + " and " + second + " is " + multiplicationResult;
                    break;

                case 4:
                    int divisionResult = Calculation.Divide(first, second);
                    result = "Division Result of " + first + " and " + second + " is " + divisionResult;
                    break;

                default:
                    result = "Choose proper option";
                    break;
            }
            return result;
        }        
    }
}
