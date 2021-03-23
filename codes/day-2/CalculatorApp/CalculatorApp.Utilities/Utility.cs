namespace CalculatorApp.Utilities
{
    public class Utility
    {
        public static char ConvertToLowerCase(char charInput)
        {
            if (char.IsUpper(charInput))
            {
                charInput = char.ToLower(charInput);
            }
            return charInput;
        }

        public static char ConvertToUpperCase(char charInput)
        {
            if (char.IsLower(charInput))
            {
                charInput = char.ToUpper(charInput);
            }
            return charInput;
        }
    }
}
