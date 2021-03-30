namespace ReflectionDemo.Entities
{
    public class Calculation
    {
        private int addResult;
        private int multiResult;

        public int AddResult { get => addResult; }
        public int MultiResult { get => multiResult; }

        public void Add(int first, int second)
        {
            addResult = first + second;
        }
        public void Multiply(int first, int second)
        {
            multiResult = first * second;
        }
        public static int Subtract(int first, int second)
        {
            return (first - second);
        }
    }
}
