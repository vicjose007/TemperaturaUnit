using ISBNc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace unitTest
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void Validate_Farenheit()
        {
            Temperature obj = new Temperature();

            int num = 10;

            string key = "farenheit";

            bool result = obj.Fahrenheit(num, key);

            Assert.IsTrue(result);

        }
        [Fact]
        public void Validate_Celsius()
        {
            Temperature obj = new Temperature();

            int num = 10;

            string key = "celcius";

            bool result = obj.Celsius(num, key);

            Assert.IsTrue(result);

        }
        [Fact]
        public void Validate_Kelvin()
        {
            Temperature obj = new Temperature();

            int num = 10;

            string key = "kelvin";

            bool result = obj.Kelvin(num, key);

            Assert.IsTrue(result);

        }
    }
}
