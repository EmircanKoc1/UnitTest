namespace UnitTest.APP
{
    public class CalculatorService : ICalculatorService
    {
        public int add(int a, int b)
        {
            if (a is 0 || b is 0)
                return 0;

            return a + b;
        }
        public int multip(int a, int b)
        {
            if (a is 0)
                throw new Exception("a=0 olamaz");


            return a * b;
        }

    }
}
