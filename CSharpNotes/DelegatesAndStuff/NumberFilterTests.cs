using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CSharpNotes.DelegatesAndStuff
{
    public class NumberFilterTests
    {

        [Fact]
        public void CanFilterOutEvens()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var filter = new NumberFilter();

            List<int> odds = filter.FilterOutEvens(numbers);

            Assert.Equal(1, odds[0]);
            Assert.Equal(3, odds[1]);
            Assert.Equal(5, odds[2]);
        }

        [Fact]
        public void CanFilterOutOdds()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var filter = new NumberFilter();

            List<int> evens = filter.FilterOutOdds(numbers);

            Assert.Equal(2, evens[0]);
            Assert.Equal(4, evens[1]);
            Assert.Equal(6, evens[2]);
        }
    }
}
