using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper
    {
        #region Non Generic Swap
        //public static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //}
        //public static void Swap(ref Point x, ref Point y)
        //{
        //    Point temp = x;
        //    x = y;
        //    y = temp;
        //} 
        #endregion

        #region Generic Swap
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region Non Generic Linear Search
        //public static int LinearSearch(int[] arr, int value)
        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i] == value)
        //                return i;
        //        }
        //    }
        //    return -1;
        //} 
        #endregion

        #region Generic Linear Search
        public static int LinearSearch<T>(T[] arr, T value)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(value))
                        return i;
                }
            }
            return -1;
        }
        #endregion

        #region Non Generic BubbleSort
        //public static void BubbleSort(int[] arr)
        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (arr[j] > arr[j + 1])
        //                {
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //} 
        #endregion

        #region Generic BubbleSort
        public static void BubbleSort<T>(T[] arr) where T : IComparable
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        } 
        #endregion

        public static void PrintArray<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
