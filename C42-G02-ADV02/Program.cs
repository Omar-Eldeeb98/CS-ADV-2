using System.Collections;
using System.Collections.Generic;

namespace C42_G02_ADV02
{
    internal class Program
    {
        #region Part 02


        #region 1
        public static void reverseArrayList(ArrayList arrayList)
        {
            int start = 0;
            int end = arrayList.Count - 1;
            while (start < end)
            {
                object temp = arrayList[start];
                arrayList[start] = arrayList[end];
                arrayList[end] = temp;

                start++;
                end--;

            }

        }

        #endregion


        #region 2
        public static List<int> findEvenNumbers(List<int> list)
        {
            List<int> evens = new List<int>();

            foreach (int n in list)
            {
                if (n % 2 == 0)
                {
                    evens.Add(n);
                }
            }
            return evens;

        }

        #endregion



        #endregion

        static void Main(string[] args)
        {
            #region  Part 02


            #region 1

            //ArrayList arrayList = new ArrayList() { 10,20,30,40,50};
            //Program.reverseArrayList(arrayList);
            //foreach (int item in arrayList)
            //{
            //    Console.Write(item + " ");  // 50 40 30 20 10 
            //}


            #endregion

            #region 2 

            //List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers = Program.findEvenNumbers(nums);
            //foreach (int item in evenNumbers)
            //{
            //    Console.Write(item + " ");  // 2 4 6 8 10
            //}




            #endregion

            #region 3

            //var numbers = new FixedSizeList<int>(4);
          
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);

            //---------------------------------------------------------------------------------------------------

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write(" " + numbers.Get(i)); // 1 2 3 4
            //}
            //Console.WriteLine("\n");

            //---------------------------------------------------------------------------------------------

            //// add item 
            //try
            //{
               
            //    numbers.Add(100);
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);   // List is full.
            //}

            //------------------------------------------------------------------------------------------------

            //// get element by index
            //try
            //{
                
            //    Console.WriteLine(numbers.Get(5));
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message); // Index is out of range
            //}

            //-----------------------------------------------------------------------------------------------------------
            #endregion


            #endregion
        }
    }
}
