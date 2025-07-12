namespace Session04_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1D Array
            //int x = 500;
            //int[] ints = { 500, 120, 15, 90, 14 };

            //x = 400;
            //Console.WriteLine(x);

            //ints[3] = 9;
            //Console.WriteLine(ints[1]);

            //int[] numbers;
            //numbers = new int[3];

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);

            //numbers[0] = 3;
            //numbers[1] = 6;
            //numbers[2] = 9;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //Console.WriteLine($"Size of Array {numbers.Length}, Dimension of array {numbers.Rank}");

            //for (int i = 0; i < numbers.Length /* i<= 2*/; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //} 
            #endregion

            #region Array Creation Ways
            //int[] arr01 = new int[3]; // 0, 0, 0
            //int[] arr02 = new int[3] { 1, 2, 3 }; // 1, 2, 3
            //int[] arr03 = new int[] { 1, 2, 3 }; // 1, 2, 3
            //int[] arr04 = { 1, 2, 3 }; // 1, 2, 3 
            #endregion

            #region 2D Array
            //int[,] Marks = new int[3, 5]
            //{
            //    {100,90,100,90,89 },
            //    {99,88,100,70,90 },
            //    {80,75,89,78,100 }
            //};

            //for (int i = 0; i < Marks.GetLength(0); i++) /*0, 2*/
            //{
            //    Console.WriteLine($"Enter Grades of student Number {i + 1}");
            //    for (int j = 0; j < Marks.GetLength(1);)
            //    {
            //        bool isParsed;
            //        Console.Write($"Enter Grade of subject Number {j + 1}: ");
            //        isParsed = int.TryParse(Console.ReadLine(), out Marks[i, j]);
            //        if (isParsed && Marks[i,j] >= 0)
            //        {
            //            j++;
            //        }
            //    }
            //    Console.WriteLine("************************************");
            //}

            //Console.WriteLine(Marks[0, 4]);

            //Console.WriteLine($"Size of Array {Marks.Length}, Dimension of array {Marks.Rank}");
            //for (int i = 0; i < Marks.GetLength(0); i++) /*0, 2*/
            //{
            //    Console.WriteLine($"Grades of student Number {i+1}");
            //    for(int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.Write($"Grade of subject Number {j+1}: ");
            //        Console.WriteLine(Marks[i,j]);
            //    }
            //    Console.WriteLine("************************************");
            //} 
            #endregion

            #region Jagged Array
            //int[][] Marks = new int[3][];

            //Marks[0] = new int[3];
            //Marks[1] = new int[2];
            //Marks[2] = new int[1];

            //Marks[0][0] = 1;
            //Marks[0][1] = 2;
            //Marks[0][2] = 3;
            //Marks[1][0] = 4;
            //Marks[1][1] = 5;
            ////Marks[1][2] = 6; // invalid
            //Marks[2][0] = 7; 
            #endregion

            #region Array Methods
            //int[] numbers = { 9, 4, 6, 8, 7, 6, 3, 1, 2, 6, 5 };

            //Array.Sort(numbers);
            //Array.Reverse(numbers, 3, 4);
            //Array.Clear(numbers, 3, 4);
            //Console.WriteLine(Array.IndexOf(numbers, 6, 3, 2));
            //Console.WriteLine(Array.LastIndexOf(numbers, 6, 3, 4));
            //Array.Resize(ref numbers, 23);

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] Arr01 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] Arr02 = new int[4];

            //Array.Copy(Arr01, 2, Arr02, 0, 6);

            //foreach (int i in Arr01)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("**************************");
            //foreach (int i in Arr02)
            //{
            //    Console.Write($"{i} ");
            //} 
            #endregion

            #region 2D Array using 1 Loop
            //int[,] Marks = new int[3, 5]
            //{
            //    {100,90,100,90,89 },
            //    {99,88,100,70,90 },
            //    {80,75,89,78,100 }
            //};

            //for (int i = 0; i < Marks.Length; i++) /*0 .. 14*/
            //{
            //    int row = i / Marks.GetLength(1);
            //    int col = i % Marks.GetLength(1);
            //    Console.WriteLine(Marks[row,col]);
            //} 
            #endregion

            #region Value Type Parameters [by value, by ref]
            #region Value
            //int a = 9, b = 4;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap(a, b);
            //Console.WriteLine("Main Method");
            //Console.WriteLine(a);
            //Console.WriteLine(b); 
            #endregion

            #region Ref
            //int a = 9, b = 4;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Swap(ref a, ref b);
            //Console.WriteLine("Main Method");
            //Console.WriteLine(a);
            //Console.WriteLine(b); 
            #endregion
            #endregion

            #region Reference Type Parameters [by value, by ref]
            #region Example 1
            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArray(ref Numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(Numbers[0]); 
            #endregion

            //Array.Sort(numbers);

            #region Example 2
            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArray(ref Numbers);
            //Console.WriteLine(result);
            //Console.WriteLine(Numbers[0]); 
            #endregion

            //numbers = new int[Newsize];
            //Array.Resize(ref numbers); 
            #endregion

            #region Function Parameters [out]
            //int a = 16, b = 9;
            //int sumResult, subResult = 10006;
            //SumSub(a, b, out sumResult, out subResult);
            //Console.WriteLine(sumResult);
            //Console.WriteLine(subResult);

            //int.TryParse(Console.ReadLine(), out int x); 
            #endregion

            #region Function Parameters [params]
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //int result;
            ////result = Sum(4, 9,numbers);
            //result = Sum(9,7,36,8,1,3,8);
            //result = Sum(9,7,36,8,1,3,8, 9, 5, 7,6);
            //result = Sum(9,7);

            //string.Format("Equation: {0} + {1} = {2}", 10, 5, 15, 45); 
            #endregion
        }
    }
}
