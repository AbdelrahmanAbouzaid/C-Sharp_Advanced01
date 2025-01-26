using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class Helper
    {
        public static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            if (arr?.Length > 0)
            {
                // We Can Optemize Buuble sort Algorithm by adding swapped flag
                bool swapped;
                for (int i = 0; i < arr.Length; i++)
                {
                    swapped = false;
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j].CompareTo(arr[j + 1]) > 0)
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                            swapped = true;
                        }
                    }
                    if (!swapped) break;
                }
            }
        }

        public static void ReverseArrayList(ArrayList arr)
        {
            if (arr?.Count > 0)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    for (int j = 0; j < arr.Count - i - 1; j++)
                    {
                        object obj = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = obj;
                    }
                }
            }
        }
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void PrintArray<T>(T[] arr)
        {
            foreach (T item in arr)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }

        public static void DisplayList(ICollection collection)
        {
            foreach (var item in collection)
            {

                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
    }
}
