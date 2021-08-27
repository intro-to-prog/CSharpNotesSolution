using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNotes.DelegatesAndStuff
{
    public delegate bool FilterFunction(int x);
    public class NumberFilter
    {
        public List<int> FilterOutEvens(List<int> numbers)
        {
            // "Method Group"
            // return Filter(numbers, IsEven);
            // Anonymous Delegates (2.0)
            //return Filter(numbers, delegate (int x)
            //{
            //    return x % 2 != 0;
            //});
            return Filter(numbers, x => x % 2 != 0);
        }


        public List<int> FilterOutOdds(List<int> numbers)
        {
            // "Method Group"
            // return Filter(numbers, IsEven);
            //return Filter(numbers, delegate (int z)
            //{
            //    return z % 2 == 0;
            //});
            return Filter(numbers, x => x % 2 == 0);
        }

        private  List<int> Filter(List<int> numbers, Func<int, bool> op)
        {
            var result = new List<int>();
            foreach (var num in numbers)
            {
                if (op(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }


        //private bool IsOdd(int num)
        //{
        //    return num % 2 != 0;
        //}

        //private bool IsEven(int num)
        //{
        //    return num % 2 == 0;
        //}
    }
}
