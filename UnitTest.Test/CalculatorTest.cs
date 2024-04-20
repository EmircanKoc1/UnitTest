using UnitTest.APP;

namespace UnitTest.Test
{
    public class CalculatorTest
    {
        Calculator calculator { get; set; }
        public CalculatorTest()
        {
            //calculator = new();

        }

        [Fact]
        public void AddTest()
        {

            //Arrange 
            //int a = 1;
            //int b = 20;
            //var calculator = new Calculator();


            //Action

            //var total = calculator.add(a, b);

            //Assert


            //Assert.Equal<int>(21, total);
            //Assert.NotEqual();

            //Assert.Contains("Fatih", "Fatih Çakıroğlu");
            //Assert.DoesNotContain();

            //var names = new List<string>() { "fatih", "emre", "hasan" };
            //Assert.Contains(names, x => x == "ömer");

            //Assert.True(5 > 2);
            //Assert.False(5 > 2);

            //var regex = "^dog^";
            //Assert.Matches(regex,"emir dog");
            //Assert.DoesNotMatch(regex,"emir do");


            //Assert.StartsWith("Bir", "Bir masal");
            //Assert.EndsWith("Bir", "Bir Masal");

            //Assert.Empty(new List<string>());
            //Assert.NotEmpty(new List<string>() { "x" });

            //Assert.InRange(10,0,100);
            //Assert.NotInRange(10,33,100);

            //Assert.Single(new List<string> { "x"});

            //Assert.IsType<string>("x");
            //Assert.IsNotType<string>("y");  

            //Assert.IsAssignableFrom<IEnumerable<string>>(new List<string>());
            //Assert.IsAssignableFrom<object>(2);

            //string value = null;
            //Assert.NotNull(value);
            //Assert.Null(value);

            //Assert.Equal("emir", "emir");
            //Assert.NotEqual("emir", "alşdma");



        }

        [Theory]
        [InlineData(2, 5, 7)]
        [InlineData(20, 2, 22)]
        public void Test2(int a, int b, int expectedTotal)
        {

            var actualData = calculator.add(a, b);

            Assert.Equal(expectedTotal, actualData);
        }

        [Theory]
        [InlineData(2, 5, 7)]
        [InlineData(10, 2, 12)]
        public void Add_SimpleValues_ReturnTotalValue(int a, int b, int expectedTotal)
        {
            var actualTotal = calculator.add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        }

        [Theory]
        [InlineData(0, 5, 0)]
        [InlineData(10, 0, 0)]
        public void Add_ZeroValues_ReturnZero(int a, int b, int expectedTotal)
        {
            var actualTotal = calculator.add(a, b);

            Assert.Equal(expectedTotal, actualTotal);
        }


    }
}
