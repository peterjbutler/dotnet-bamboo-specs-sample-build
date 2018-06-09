namespace DotnetBambooSpecs.SampleProject
{
    public static class Calculator
    {
        public static int Increment(int number)
        {
            return ++number;
        }

        public static int Decrement(int number)
        {
            return --number;
        }

        public static int Multiply(int multiplicand, int multiplier)
        {
            return multiplicand * multiplier;
        }
    }
}
