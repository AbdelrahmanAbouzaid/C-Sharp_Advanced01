using System.ComponentModel.Design;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Generic Ex01 : Swap
            //int A = 3, B = 4;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            //Console.WriteLine("******* After Swap *******");
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            //double j = 7, k = 5;
            //Console.WriteLine($"J: {j}");
            //Console.WriteLine($"K: {k}");
            //Console.WriteLine("******* After Swap *******");
            //Helper.Swap(ref j, ref k);
            //Console.WriteLine($"J: {j}");
            //Console.WriteLine($"K: {k}");

            //Point p01 = new Point(4,5);
            //Point p02 = new Point(6,7);
            //Console.WriteLine($"P01: {p01}");
            //Console.WriteLine($"P02: {p02}");
            //Console.WriteLine("******* After Swap *******");
            //Helper.Swap(ref p01, ref p02);
            //Console.WriteLine($"P01: {p01}");
            //Console.WriteLine($"P02: {p02}");  
            #endregion

            #region Generic Ex02 : LinearSearch
            // Linear Search 

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int result = Helper.LinearSearch(arr, 4);
            //Console.WriteLine($"Index : {result}");

            //Employee emp1 = new Employee() { Id = 1, Name = "Abdelrahman", Age = 22, Salary = 20000 };
            //Employee emp2 = new Employee() { Id = 2, Name = "Toqa", Age = 21, Salary = 16000 };
            //Employee emp3 = new Employee() { Id = 3, Name = "Khadeja", Age = 20, Salary = 18000 };
            //Employee emp4 = new Employee() { Id = 4, Name = "Omar", Age = 18, Salary = 19000 };

            //Employee[] employees ={ emp1, emp2, emp3, emp4 };
            //int index = Helper.LinearSearch(employees , emp3);
            //Console.WriteLine($"Index: {index}"); 
            #endregion

            #region Equality in Class or Struct
            // Equality in Class or Struct
            // Equals()
            // 'class' has Equals Function Wich Inherited Feom Object Class -> Compare Based on Reference 
            // 'struct' has Equals Function Wich Inherited Feom Object Class -> Compare Based on Data 
            //  Note: struct Dont have Implementation For The == Operator


            //Employee emp1 = new Employee() { Id = 1, Name = "Abdelrahman", Age = 22, Salary = 20000 };
            //Employee emp2 = new Employee() { Id = 1, Name = "Abdelrahman", Age = 22, Salary = 20000 };

            //// Employee emp2 = new Employee() { Id = 2, Name = "Toqa", Age = 21, Salary = 16000 };
            //Console.WriteLine($"emp1: {emp1.GetHashCode()}");
            //Console.WriteLine($"emp2: {emp2.GetHashCode()}");

            //if(emp1.Equals(emp2))
            //    Console.WriteLine("emp1 == emp2");
            //else
            //    Console.WriteLine("emp1 != emp2"); 
            #endregion

            #region Generic Ex03 : Bubble Sorting
            // Bubble Sorting

            //int[] numbers = { 2, 3, 9, 8, 7, 6, 5, 4, 1, 12, -1, 0 };

            //Helper.PrintArray(numbers);
            //Helper.BubbleSort(numbers);
            //Helper.PrintArray(numbers);

            //Point[] points =
            //{
            //    new Point(6,6),
            //    new Point(3,3),
            //    new Point(2,2), 
            //    new Point(4,4),
            //    new Point(1,1),
            //    new Point(5,5),
            //};

            //Helper.PrintArray(points);
            //Helper.BubbleSort(points);
            //Helper.PrintArray(points);

            #endregion



        }
    }
}
