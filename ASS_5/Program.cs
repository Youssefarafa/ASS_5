using System;

namespace ASS_5
{
    internal class Program
    {
        #region 1
        //1-passing by value:-
        //it make a new stack frame in heap and the changes does not affect in main stack frame the new stack frame delete when function process end.
        public static void SWAP(int X, int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        ///////////////////////////////////
        //2-passing by reference:-
        //it change at the main stack frame and the changes safe forever.
        public static void REF_SWAP(ref int X2, ref int Y2)
        {
            int Temp2 = X2;
            X2 = Y2;
            Y2 = Temp2;
        }
        #endregion

        #region 2
        //1-passing by value:-
        //it make a new stack frame in heap and the changes does not affect in main stack frame the new stack frame delete when function process end.
        public static int SumArray(int[] Arr)
        {
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            Arr[0] = 100;
            return Sum;
        }
        //////////////////////
        ////2-passing by reference:-
        ////it change at the main stack frame and the changes safe forever.
        public static int REF_SumArray(ref int[] Arr)
        {
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
                Sum += Arr[i];
            Arr[0] = 100;
            return Sum;
        }
        #endregion

        #region 3
        public static (double sum , double sub) SUM_AND_SUB(int num1, int num2, int num3, int num4)
        {
            int sum = 0, sub = 0;
            sum = num1 + num2;
            sub = num3 - num4;
            Console.WriteLine(sum);
            Console.WriteLine(sub);
            return (sum,sub);
        }
        #endregion

        #region 4
        public static int SUM_INDIVIDUAL_NUM(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int x = number % 10;
                sum += x;
                number /= 10;
            }
            return sum;
        }
        #endregion

        #region 5
        public static bool ISPRIME(int num2)
        {
            int count = 0;
            if (num2 > 1)
            {
                for (int i = 1; i <= num2; i++)
                {
                    int result = num2 % i == 0 ? count++ : count;
                }
            }
            else
            {
                return false;
            }
            bool check = count < 3 ? true : false;
            return check;
        }
        #endregion

        #region 6
        public static (int min, int max) minmax(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return (min, max);
        }
        #endregion

        #region 7
        public static int CalculateFactorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        #endregion

        #region 8
        public static string ChangeChar(string input, int position, char newChar)
        {
            char[] charArray = input.ToCharArray();
            charArray[position] = newChar;
            return new string(charArray);
        }
        #endregion
        static void Main(string[] args)
        {
            #region 1
            //1-passing by value:-
            Console.WriteLine("\n swap  with using passing by value => the result: \n");
            int a = 9, b = 4;
            Console.WriteLine(a); // 9
            Console.WriteLine(b); // 4
            SWAP(a, b);
            Console.WriteLine(a);  // 9
            Console.WriteLine(b);  // 4
            //2-passing by reference:-
            Console.WriteLine("\n swap with using passing by reference => the result: \n");
            int c = 9, d = 4;
            Console.WriteLine(c); // 9
            Console.WriteLine(d); // 4
            REF_SWAP(ref c, ref d);
            Console.WriteLine(c); // 4
            Console.WriteLine(d); // 9
            #endregion

            #region 2
            //1-passing by value:-
            Console.WriteLine("\n array number with using passing by value => result: \n");
            int[] Numbers = { 1, 2, 3 };
            Console.WriteLine(SumArray(Numbers));
            Console.WriteLine(Numbers[0]);
            //////////////////////////
            //2-passing by reference:-
            Console.WriteLine("\n SWAP with using passing by reference => the result: \n");
            int[] Numbers2 = { 1, 2, 3 };
            Console.WriteLine(REF_SumArray(ref Numbers2));
            Console.WriteLine(Numbers[0]);
            #endregion

            #region 3
            Console.WriteLine(SUM_AND_SUB(1, 2, 3, 4));
            #endregion

            #region 4
            int result = SUM_INDIVIDUAL_NUM(325);
            Console.WriteLine(result);
            #endregion

            #region 5
            bool resultt = ISPRIME(31);
            Console.WriteLine(resultt);
            #endregion

            #region 6
            int[] arr = { 10, 25, 13, 43, 8, 17, 6, 80 };
            (int min, int max) = minmax(arr);
            Console.WriteLine($" the min is {min}, the max is {max}");
            #endregion

            #region 7
            double factorial = CalculateFactorial(10);
            Console.WriteLine(factorial);
            #endregion

            #region 8
            string text = "Arafa";
            int index = 0;
            char h = 'Y';
            string modified = ChangeChar(text, index, h);
            Console.WriteLine($"New string is {modified}");
            #endregion
        }
    }
}