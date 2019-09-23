using System;
using System.Linq;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a = 1, b = 22;
            Console.WriteLine("\n");
            printSelfDividingNumbers(a, b);

            int n2 = 5;
            Console.WriteLine("\n");
            printSeries(n2);

            int n3 = 5;
            Console.WriteLine("\n");
            printTriangle(n3);

            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);
            Console.WriteLine("\n");

            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
            int[] r5 = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine(r5);

            //solvePuzzle();

        }
        public static void printSelfDividingNumbers(int x, int y)
        {
            //x and y are arguments passed in printSelfDividingNumbers function




            for (int i = x; i <= y; i++)
            {
                // i argument is passed in solve function
                if (solve(i))
                {
                    Console.WriteLine(i);
                }
            }



        }
        static bool solve(int x)
        // anything is 'solve' is an integer
        {
            int[] arr = new int[10];// array intialised of 10 integers

            int num, i, j;// three variables initialised
            num = x;
            i = 0;
            while (num != 0)
            {
                arr[i] = (num % 10);//first array a[0], remainder is saved in arr[i]
                num /= 10;
                i++;

            }
            for (j = 0; j < i; j++)// if a number has 0 or remainder is not equal to zero it won't return

            {
                if ((arr[j] == 0) || (x % arr[j]) != 0)
                {
                    return false;

                }
            }
            return true;
            /*Corner Case - there's nothing specific in this. This program can be run for any integer.
             * We just have to specific the first number and last number. In this case we have taken 1 and 22 respectively.
             * 
             * Learning - being my first programming language learnt the use of % function, while loop, how to create functions,for loop basic things(initalize, test expression,increment) */


        }



        public static void printSeries(int n)
        {
            try
            {
                int i, j, k; //initializing variables in form of integers
                for (i = 0, j = 1; i < n; j++) //will check the condition and go to the next nested loop
                {
                    for (k = 1; (i < n) && (k <= j); k++)//if all conditions are satisfied it will print j or else it will go back to the main loop

                    {
                        Console.Write(j);
                        i++; //if variable j is passed, it will increment i and the loop will run again until i<n


                    }

                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
            /* Corner Case - this is the general program can be used to print n series we just need to specify how many number(count) we need in our output.
              But that is only feasible until 999999999 after that the next number will be 10 so it will print 10 ten times so this is the limit.
              Learning - Learnt the concept of nested for loop and when to break the function. Like in this case we have to print it till count of five numbers only.*/


        }

        public static void printTriangle(int n)
        {
            try
            {
                int i, j;//initializing two variables i and j 

                for (i = 1; i <= n; i++)
                {
                    for (j = 0; j <= (2 * n - i); j++)// we want to print odd number of stars so 2n-1 or 2n+1 is what that defines odd number.
                    {
                        if (j >= i)
                        {
                            Console.Write("*");// this will print * if valid

                        }
                        else
                        {
                            Console.Write(" ");// this will give space starting from left side if the statement is not satisfying and will print stars after spaces and stars will be two less than the above row(Ist row - 9* IInd row - 7* after one space, will be symmetrical

                        }
                    }
                    Console.WriteLine("");// this will change the row.
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
            /*Corner Case- This is the general case for showing inverted star triangle in odd number, also odd number is one that will satisfy the triangle shape as in last row there will be only one star
             Learning - got to know the concept of rows and column uses in programming and how to implement that */



        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            int count; // three variable initialized
            int len1, len2;
            len1 = J.Length; // .Length is the function defined in c# to count number of characters.
            len2 = S.Length;
            count = 0;
            for (int i = 0; i < len1; i++)
            {
                for (int j = 0; j < len2; j++)
                {
                    if (J[i] == S[j]) //if any character in J is same as S it will add +1 to the count 
                    {
                        count++;

                    }
                }
            }
            /* Corner Case- this will valid to compare two strings values. If it is common it will count it and add, otherwise it will neglect
             * Learning - Learnt how to compare two values of the dataset in two different array */

            return count;




        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {


            var intersect = a.Intersect(b); // Intersect function is defined in c#, this will take out common things in two arrays.

            foreach (int common in intersect) // foreach will provide function for each array element,for loop will execute and each value is extracted
            {
                Console.WriteLine(common);
            }
            /* I am able to extract common sub array element, while i am not able to execute largest common subarray.
             * 
             * Learning-Learned how to use intersect and foreach function. 
             * Corner Case - This will extract common arrays from two different arrays provided as input.*/

            return null;
        }

        public static void solvePuzzle()
        {


        }



    }
}
