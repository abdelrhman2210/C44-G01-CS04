using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace Session04_Assignment
{
    internal class Program
    {
        #region Q2
        //class Person
        //{
        //    public string Name;
        //}

        class RefExample
        {
            //static void ModifyByValue(Person p)
            //{
            //    p = new Person();
            //    p.Name = "Essam";
            //}

            //static void ModifyByReference(ref Person p)
            //{
            //    p = new Person();
            //    p.Name = "Ismail";
            //} 
            #endregion
            static void Main(string[] args)
            {
                #region Assignment 04

                #region 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example. 
                // Passing by value means that a copy of the variable is passed to the method.
                // Changes made to the parameter inside the method do not affect the original variable.

                // Passing by reference means that a reference to the original variable is passed to the method.
                // Changes made to the parameter inside the method will affect the original variable.

                //static void PassByValue(int number)
                //{
                //    number += 5;
                //}
                //static void PassByReference(ref int number)
                //{
                //    number += 5;
                //} 

                //int value = 10;
                //PassByValue(value);
                //Console.WriteLine($"After PassByValue: {value}"); 
                //PassByReference(ref value);
                //Console.WriteLine($"After PassByReference: {value}");
                #endregion

                #region 2- Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
                // Passing by value for reference types means that a copy of the reference (not the object itself) is passed to the method.
                // Changes made to the object through the parameter will affect the original object, but reassigning the parameter will not affect the original reference.

                // Passing by reference for reference types means that a reference to the original object is passed to the method.
                // Changes made to the object through the parameter will affect the original object, and reassigning the parameter will also affect the original reference.

                //Person p = new Person();
                //p.Name = "Abdelrhman";

                //ModifyByValue(p);
                //Console.WriteLine($"After ModifyByValue: {p.Name}");
                //ModifyByReference(ref p);
                //Console.WriteLine($"After ModifyByReference: {p.Name}");
                #endregion

                #region 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers.
                //static void Calculate(int a, int b, int c, int d)
                //{
                //    int sum = a + b , difference = c - d;
                //    Console.WriteLine($"Sum = {sum}");
                //    Console.WriteLine($"Difference = {difference}");
                //}
                //Console.WriteLine("Enter four numbers:");
                //int num1 = int.Parse(Console.ReadLine());
                //int num2 = int.Parse(Console.ReadLine());
                //int num3 = int.Parse(Console.ReadLine());
                //int num4 = int.Parse(Console.ReadLine());
                //Calculate(num1, num2, num3, num4);
                #endregion

                #region 4- Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
                //static int SumOfDigits(int number)
                //{
                //    int sum = 0;
                //    while (number > 0)
                //    {
                //        sum += number % 10;
                //        number /= 10;
                //    }
                //    return sum;
                //}
                //Console.WriteLine("Enter a number:");
                //int inputNumber = int.Parse(Console.ReadLine());
                //int result = SumOfDigits(inputNumber);
                //Console.WriteLine($"The sum of the digits is: {result}");
                #endregion

                #region 5- Create a function named "IsPrime", which receives an integer number and returns true if it is prime, or false if it is not. 
                //static bool IsPrime(int number)
                //{
                //    if (number <= 1) return false;
                //    for (int i = 2; i <= Math.Sqrt(number); i++)
                //    {
                //        if (number % i == 0) return false;
                //    }
                //    return true;
                //}
                //Console.WriteLine("Enter a number to check if it's prime:");
                //int primeCheckNumber = int.Parse(Console.ReadLine());
                //bool isPrime = IsPrime(primeCheckNumber);
                //Console.WriteLine($"{primeCheckNumber} is {(isPrime ? "a prime number" : "not a prime number")}");
                #endregion

                #region 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters.
                //static void MinMaxArray(int[] array, out int min, out int max)
                //{
                //    if (array == null || array.Length == 0)
                //    {
                //        min = 0;
                //        max = 0;
                //        return;
                //    }
                //    min = array[0];
                //    max = array[0];
                //    foreach (int num in array)
                //    {
                //        if (num < min) min = num;
                //        if (num > max) max = num;
                //    }
                //}
                //Console.WriteLine("Enter the number of elements in the array:");
                //int n = int.Parse(Console.ReadLine());
                //int[] numbers = new int[n];
                //Console.WriteLine("Enter the elements of the array:");
                //for (int i = 0; i < n; i++)
                //{
                //    numbers[i] = int.Parse(Console.ReadLine());
                //}
                //int minValue, maxValue;
                //MinMaxArray(numbers, out minValue, out maxValue);
                //Console.WriteLine($"Minimum value: {minValue}");
                //Console.WriteLine($"Maximum value: {maxValue}");
                #endregion

                #region 7- Create function to calculate the factorial of the number specified parameter.               
                //static void Factorial(int number, out long result)
                //{
                //    if (number < 0) throw new ArgumentException("Number must be non-negative.");
                //    result = 1;
                //    for (int i = 2; i <= number; i++)
                //    {
                //        result *= i;
                //    }
                //}
                //Console.WriteLine("Enter a number to calculate its factorial:");
                //int factorialNumber = int.Parse(Console.ReadLine());
                //long factorialResult;
                //Factorial(factorialNumber, out factorialResult);
                //Console.WriteLine($"The factorial of {factorialNumber} is: {factorialResult}");
                #endregion

                #region 8- Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter.
                //static string ChangeChar(string input, int position, char newChar)
                //{
                //    if (position < 0 || position >= input.Length)
                //        throw new ArgumentOutOfRangeException("Position is out of range.");
                //    char[] chars = input.ToCharArray(); 
                //    chars[position] = newChar; 
                //    return new string(chars); 
                //}
                //string result = ChangeChar("abdeelrhman", 3, ' ');
                //Console.WriteLine(result);
                #endregion

                #region 9- Write a program that prints an identity matrix using for loop. 
                //Console.WriteLine("Enter the size of the identity matrix (n):");
                //int n = int.Parse(Console.ReadLine());
                //for (int i = 0; i < n; i++)
                //{
                //    for (int j = 0; j < n; j++)
                //    {
                //        if (i == j)
                //            Console.Write("1 ");
                //        else
                //            Console.Write("0 ");
                //    }
                //    Console.WriteLine();
                //}                
                #endregion

                #region 10- Write a program in C# Sharp to find the sum of all elements of the array.
                //static int SumOfArray(int[] array)
                //{
                //    int sum = 0;
                //    foreach (int element in array)
                //    {
                //        sum += element;
                //    }
                //    return sum;
                //}
                //Console.WriteLine("Enter the number of elements in the array:");
                //int n = int.Parse(Console.ReadLine());
                //int[] numbers = new int[n];
                //Console.WriteLine("Enter the elements of the array:");
                //for (int i = 0; i < n; i++)
                //{
                //    numbers[i] = int.Parse(Console.ReadLine());
                //}
                //int totalSum = SumOfArray(numbers);
                //Console.WriteLine($"The sum of all elements is: {totalSum}");
                #endregion

                #region 11- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
                //static int[] MergeSortedArrays(int[] arr1, int[] arr2)
                //{
                //    int[] merged = new int[arr1.Length + arr2.Length];
                //    int i = 0, j = 0, k = 0;
                //    while (i < arr1.Length && j < arr2.Length)
                //    {
                //        if (arr1[i] <= arr2[j])
                //        {
                //            merged[k++] = arr1[i++];
                //        }
                //        else
                //        {
                //            merged[k++] = arr2[j++];
                //        }
                //    }
                //    while (i < arr1.Length)
                //    {
                //        merged[k++] = arr1[i++];
                //    }
                //    while (j < arr2.Length)
                //    {
                //        merged[k++] = arr2[j++];
                //    }
                //    return merged;
                //}
                //Console.WriteLine("Enter the size of arrays:");
                //int size = int.Parse(Console.ReadLine());
                //int[] array1 = new int[size];
                //int[] array2 = new int[size];
                //Console.WriteLine("Enter elements for first array:");
                //for (int i = 0; i < size; i++)
                //{
                //    array1[i] = int.Parse(Console.ReadLine());
                //}
                //Console.WriteLine("Enter elements for second array:");
                //for (int i = 0; i < size; i++)
                //{
                //    array2[i] = int.Parse(Console.ReadLine());
                //}

                //Array.Sort(array1);
                //Array.Sort(array2);
                //int[] mergedArray = MergeSortedArrays(array1, array2);
                //Console.WriteLine("Merged array:");
                //foreach (int num in mergedArray)
                //{
                //    Console.Write(num + " ");
                //}
                //Console.WriteLine();
                #endregion

                #region 12- Write a program in C# Sharp to find maximum and minimum element in an array
                //static void FindMinMax(int[] array, out int min, out int max)
                //{
                //    if (array == null || array.Length == 0)
                //    {
                //        min = 0;
                //        max = 0;
                //        return;
                //    }
                //    min = array[0];
                //    max = array[0];
                //    foreach (int num in array)
                //    {
                //        if (num < min) min = num;
                //        if (num > max) max = num;
                //    }
                //}
                //Console.WriteLine("Enter the number of elements in the array:");
                //int n = int.Parse(Console.ReadLine());
                //int[] numbers = new int[n];
                //Console.WriteLine("Enter the elements of the array:");
                //for (int i = 0; i < n; i++)
                //{
                //    numbers[i] = int.Parse(Console.ReadLine());
                //}
                //int minValue, maxValue;
                //FindMinMax(numbers, out minValue, out maxValue);
                //Console.WriteLine($"Minimum element: {minValue}");
                //Console.WriteLine($"Maximum element: {maxValue}");
                #endregion

                #region 13- Write a program in C# Sharp to find the second largest element in an array.
                //static int FindSecondLargest(int[] array)
                //{
                //    if (array == null || array.Length < 2)
                //        throw new ArgumentException("Array must have at least 2 elements.");
                //    int largest = int.MinValue;
                //    int secondLargest = int.MinValue;
                //    foreach (int num in array)
                //    {
                //        if (num > largest)
                //        {
                //            secondLargest = largest;
                //            largest = num;
                //        }
                //        else if (num > secondLargest && num != largest)
                //        {
                //            secondLargest = num;
                //        }
                //    }
                //    return secondLargest;
                //}
                //Console.WriteLine("Enter the number of elements in the array:");
                //int n = int.Parse(Console.ReadLine());
                //int[] numbers = new int[n];
                //Console.WriteLine("Enter the elements of the array:");
                //for (int i = 0; i < n; i++)
                //{
                //    numbers[i] = int.Parse(Console.ReadLine());
                //}
                //int secondLargest = FindSecondLargest(numbers);
                //Console.WriteLine($"Second largest element: {secondLargest}");
                #endregion

                #region 14- Find the longest distance between two equal cells in an array
                //static int LongestDistance(int[] array)
                //{
                //    int maxDistance = 0;
                //    for (int i = 0; i < array.Length; i++)
                //    {
                //        for (int j = i + 1; j < array.Length; j++)
                //        {
                //            if (array[i] == array[j])
                //            {
                //                int distance = j - i - 1; // Number of cells between them
                //                if (distance > maxDistance)
                //                {
                //                    maxDistance = distance;
                //                }
                //            }
                //        }
                //    }
                //    return maxDistance;
                //}
                //Console.WriteLine("Enter the number of elements in the array:");
                //int n = int.Parse(Console.ReadLine());
                //int[] numbers = new int[n];
                //Console.WriteLine("Enter the elements of the array:");
                //for (int i = 0; i < n; i++)
                //{
                //    numbers[i] = int.Parse(Console.ReadLine());
                //}
                //int longestDistance = LongestDistance(numbers);
                //Console.WriteLine($"Longest distance between equal cells: {longestDistance}");
                #endregion

                #region 15- Reverse the order of words in a string
                //static string ReverseWords(string input)
                //{
                //    string[] words = input.Split(' ');
                //    Array.Reverse(words);
                //    return string.Join(" ", words);
                //}
                //Console.WriteLine("Enter a sentence:");
                //string sentence = Console.ReadLine();
                //string reversed = ReverseWords(sentence);
                //Console.WriteLine($"Reversed: {reversed}");
                #endregion

                #region 16- Create two multidimensional arrays and copy elements
                //Console.WriteLine("Enter the number of rows:");
                //int rows = int.Parse(Console.ReadLine());
                //Console.WriteLine("Enter the number of columns:");
                //int cols = int.Parse(Console.ReadLine());
                //int[,] firstArray = new int[rows, cols];
                //int[,] secondArray = new int[rows, cols];
                //Console.WriteLine("Enter elements for the first array:");
                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < cols; j++)
                //    {
                //        firstArray[i, j] = int.Parse(Console.ReadLine());
                //    }
                //}
                
                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < cols; j++)
                //    {
                //        secondArray[i, j] = firstArray[i, j];
                //    }
                //}
                //Console.WriteLine("Second array (copied):");
                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < cols; j++)
                //    {
                //        Console.Write(secondArray[i, j] + " ");
                //    }
                //    Console.WriteLine();
                //}
                #endregion

                #region 17- Print one dimensional array in reverse order
                //static void PrintArrayReverse(int[] array)
                //{
                //    for (int i = array.Length - 1; i >= 0; i--)
                //    {
                //        Console.Write(array[i] + " ");
                //    }
                //    Console.WriteLine();
                //}
                //Console.WriteLine("Enter the number of elements in the array:");
                //int n = int.Parse(Console.ReadLine());
                //int[] numbers = new int[n];
                //Console.WriteLine("Enter the elements of the array:");
                //for (int i = 0; i < n; i++)
                //{
                //    numbers[i] = int.Parse(Console.ReadLine());
                //}
                //Console.WriteLine("Array in reverse order:");
                //PrintArrayReverse(numbers);
                #endregion

                #endregion
            }
        }
    }
}
