namespace CalculatorApp.UserInteraface
{
    class Utility
    {
        public static char ConvertToLowerCase(char charInput)
        {
            if (char.IsUpper(charInput))
            {
                charInput = char.ToLower(charInput);
            }
            return charInput;
        }
    }
}
