using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range<T>
        where T : IComparable<T>
    {
        public T Max { get; set; }
        public T Min { get; set; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
            {
                Console.WriteLine("Invalid Range");
                return;
            }
            Max = max;
            Min = min;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) > 0 && value.CompareTo(Max) < 0;
        }

        public int Length()
        {
            dynamic min = Min;
            dynamic max = Max;
            if (min != null && max != null)
            {
                return (int)max - (int)min;
            }
            else
                Console.WriteLine("Invalid");
            return 0;
        }
        
    }
}
