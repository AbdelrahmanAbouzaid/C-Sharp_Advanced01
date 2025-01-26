using System.Collections;
using static Assignment.Helper;

namespace Assignment
{
    internal class Program
    {
        static List<int> EvenNumbers(List<int> numbers)
        {
            List<int> newNumbers = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                    newNumbers.Add(number);
            }
            return newNumbers;
        }
        static int FindNonRepeatedCharacter(string str)
        {
            Dictionary<char, int> values = new Dictionary<char, int>();
            foreach (char item in str)
            {
                if (values.ContainsKey(item))
                    values[item]++;
                else values[item] = 1;
            }
            for (int i = 0; i < str?.Length; i++)
            {
                if (values[str[i]] == 1)
                    return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            #region Q1
            // We Can Optemize Buuble sort Algorithm by adding swapped flag
            //int[] numbers = { 5, 6, 7, 1, 2, 3, 4, -1, 8, 9, 10 };
            //PrintArray(numbers);
            //BubbleSort(numbers);
            //PrintArray(numbers); 
            #endregion

            #region Q2
            //Range<int> range1 = new Range<int>(3,10);
            //Console.WriteLine($"(6) Is In Range: {range1.IsInRange(6)}");
            //Console.WriteLine($"(1) Is In Range: {range1.IsInRange(1)}");
            //Console.WriteLine($"Length Of Range: {range1.Length()}");

            //Range<char> range2 = new Range<char>('c','g');
            //Console.WriteLine($"(a) Is In Range: {range2.IsInRange('d')}");
            //Console.WriteLine($"(x) Is In Range: {range2.IsInRange('x')}");
            //Console.WriteLine($"Length Of Range: {range2.Length()}"); 
            #endregion

            #region Q3
            //ArrayList arrayList = new ArrayList() { 1, 2, "Abdelrahman", 4, 5.5 };
            //ReverseArrayList(arrayList);
            //DisplayList(arrayList); 
            #endregion

            #region Q4
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumners = EvenNumbers(numbers);
            //DisplayList(evenNumners); 
            #endregion

            #region Q5
            //FixedSizeList<int> list = new FixedSizeList<int>(4);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //list.Display();

            //int x= list.Get(2);
            //Console.WriteLine($"index 2: {x}");

            //int y = list.Get(5);
            //Console.WriteLine($"index 5: {y}"); 
            #endregion

            #region Q6
            //Console.Write("Enter The String: ");
            //string str = Console.ReadLine().ToLower();
            //int result = FindNonRepeatedCharacter(str);
            //if (result > 0)
            //    Console.WriteLine($"Index Of Non-Repeated Character: {result}");
            //else
            //    Console.WriteLine("There is no Non-Repeated Character"); 
            #endregion

        }
    }
}
