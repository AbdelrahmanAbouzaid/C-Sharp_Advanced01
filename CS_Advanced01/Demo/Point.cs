using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        public int CompareTo(Point? other)
        {
            if (other is not null)
            {
                if (X == other.X) return Y.CompareTo(other.Y);
                return X.CompareTo(other.X);
            }
            return 1;
        }

        //public int CompareTo(object? obj)
        //{
        //    if (obj is not null)
        //    {
        //        Point point = (Point)obj;

        //        if (X == point.X) return Y.CompareTo(point.Y);
        //        return X.CompareTo(point.X);
        //    }
        //    return 1;
        //}

        //public int CompareTo(object? obj)
        //{
        //    //1. is Conditional Operator
        //    if (obj is not null)
        //    {
        //       if (obj is Point point)
        //        {
        //            //Point point = (Point)obj;

        //            if (X == point.X) return Y.CompareTo(point.Y);
        //            return X.CompareTo(point.X);
        //        }
        //    }
        //    return 1;
        //}

        //public int CompareTo(object? obj)
        //{
        //    //1. as Casting Operator
        //    Point point = obj as Point;

        //    if (obj is not null)
        //    {
        //        if (X == point.X) return Y.CompareTo(point.Y);
        //        return X.CompareTo(point.X);
        //    }
        //    return 1;
        //}
    }
}
