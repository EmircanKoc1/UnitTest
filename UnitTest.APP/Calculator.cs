namespace UnitTest.APP
{
    public class Calculator
    {
        private ICalculatorService _calculatorService;

        public Calculator(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public int add(int a, int b)
        {
            return _calculatorService.add(a, b);
        }

        public int multip(int a, int b)
            => _calculatorService.multip(a, b);


    }
}
