using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes
{
    public class ValueTypesAndReferenceTypes
    {

        [Fact]
        public void TellingTheDifference()
        {
            var age = 52; // anything that is defined by a "struct" is a value type
            var name = "Ray"; // anything that is defined by a "class" is a reference type.

        }

        [Fact]
        public void MemoryAndValueTypes()
        {
            int x = 10;
            int y = x;

            x = 20;

            Assert.Equal(10, y);
        }
        [Fact]
        public void ReferenceTypesAndMemory()
        {
            Dog x = new Dog();
            x.Name = "Rover";

            Dog y = x;

            x.Name = "Fido";

            Assert.Equal("Fido", y.Name); // A "Side Effect"

            foreach (var z in Enumerable.Range(1, 100000))
            {
                var temp = new Dog();
                temp.Name = "Dog" + z.ToString();
            }
        }

        [Fact]
        public void StringsAndMemoryAndStuff()
        {
            Assert.True(false);
        }
    }

    public class Dog
    {
        public string Name;
    }
}
