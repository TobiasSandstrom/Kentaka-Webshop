using Xunit;

namespace Kentaka_Webshop_Test
{

         public class IntegerTest
    {
        [Fact]
        public void TestAnInteger()
        {
            // ARANGE
            // Setting up test environment for account balance.
            int expected = 50;

           
            // ACT
            // performing the act to be tested
            // gathering the actual answer
            int actual = 10 * 5;


            // ASSERT
            // check that expected = actual
            Assert.Equal(expected, actual);
        }
    }
}