using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes
{
    public class BasicTypes
    {
        [Fact]
        public void SomeNumericDataTypes()
        {
            int age;

            age = 52;

            Assert.Equal(52, age);
            // a tiny change again
            long bigNumber;

            float x = 3.14F;
            double y = 3.14;

            decimal pay = 3.53M;

        }

        [Fact]
        public void SomeStrings()
        {
            string name;
            name = "Roger";

            Assert.Equal("Roger", name);
           

        }
        [Fact]
        public void SingleCharacters()
        {
            char mi = 'M';

            string movie = "Dune";
            char firstLetter = movie[0];
            Assert.Equal('D', firstLetter);

        }
        [Fact]
        public void UsingBooleans()
        {
            int x = 0;

            if(x < 1)
            {

            }

            Boolean isOldEnough;
            isOldEnough = true;
            isOldEnough = false;
            int age = 22;
            isOldEnough = age >= 21;
            Assert.True(isOldEnough);

        }
    }
}
