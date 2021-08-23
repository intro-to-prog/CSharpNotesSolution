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
        }

        [Fact]
        public void SomeStrings()
        {
            string name;
            name = "Roger";

            Assert.Equal("Roger", name);
        }
    }
}
