using System;
using Xunit;

namespace CSharpNotes
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test1()
        {
            // Given (Arrange)
            int a = 10;
            int b = 20;
            int answer;
            // When (Act)
            answer = a + b;
            // Then (Assert)
            Assert.Equal(30, answer);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(10,5, 15)]
        [InlineData(3,3,6)]
        public void CanAddTwoIntegers(int a, int b, int expected)
        {

            var answer = a + b;
            Assert.Equal(expected, answer);
        }
    }
}
