using System.Collections;

namespace CS_ADV_2
{
    internal class Program
    {
        /*
        //public static int sumArrayList(ArrayList arrayList)
        //{
        //    int sum = 0;
        //    if(arrayList is not null)
        //    {
        //        for (int i = 0; i < arrayList.Count ; i++) 
        //        {
        //            sum = sum + ((int)arrayList[i]); // cast from object to int , unboxing , unsafe 
        //        }
        //        return sum;
        //    }
        //    return 0;
        //}

        */


        /*
        //public static int sumList(List<int> list)
        //{
        //    int sum = 0;
        //    if(list is not null)
        //    {
        //        for (int i = 0; i < list.Count;  i++)
        //        {
        //            sum += list[i];
        //        }

        //        return sum;
        //    }

        //    return 0;
        //}
        */


        static void Main(string[] args)
        {
            // Collections : Data Structure تنقسم الي  (Lists or HashTable)

            // 1- Non Generic Collections ---> C# v1.0 , (arrayList, Stored Array, Stack, Queue, HashTable)

            // 2- Generic Collections ---> C# c2.0 , (List, LinkedList, stack, Queue, Dictionary) 

            //---------------------------------------------------------------------

            #region Non Generic Collections "Lists" - [ArrayList]

            //ArrayList arrayList = new ArrayList();
            // arrayList --> size = 0

            //------------------------------------------------------------------

            //Console.WriteLine($"count:  {arrayList.Count}");  // count : 0
            //// count --> actual numbers of elements in array List.
            //Console.WriteLine($"capacity:  {arrayList.Capacity}"); // capacity: 0
            //// capacity: numbers of elements that can Carry.
            //Console.WriteLine("\n");

            //------------------------------------------------------------------

            //arrayList.Add(1);
            //Console.WriteLine($"count:  {arrayList.Count}");         // count:  1
            //Console.WriteLine($"capacity:  {arrayList.Capacity}");   // capacity:  4
            //Console.WriteLine("\n");

            //------------------------------------------------------------------

            //arrayList.AddRange(new int[] { 3,4,5});
            //Console.WriteLine($"count:  {arrayList.Count}");        // count:  4
            //Console.WriteLine($"capacity:  {arrayList.Capacity}");  // capacity:  4
            //Console.WriteLine("\n");

            //-------------------------------------------------------------------

            //arrayList.Add(77);
            //Console.WriteLine($"count:  {arrayList.Count}");         // count:  5
            //Console.WriteLine($"capacity:  {arrayList.Capacity}");   // capacity: 8
            //Console.WriteLine("\n");

            //-------------------------------------------------------------------

            //ArrayList arrayList = new ArrayList(5)
            //{ // {object initializer} 
            //    10,20,30,70
            //};

            //Console.WriteLine($"count:  {arrayList.Count}");         // count:  4
            //Console.WriteLine($"capacity: {arrayList.Capacity}");   // capacity: 5
            //Console.WriteLine("\n");


            //---------------------------------------------------------------

            //arrayList.TrimToSize(); // deallocate unused bytes.

            //Console.WriteLine("after trim");                      // after trim
            //Console.WriteLine($"count:  {arrayList.Count}");      // count:  4    
            //Console.WriteLine($"capacity: {arrayList.Capacity}"); // capacity: 4
            //Console.WriteLine("\n");

            // -------------------------------------------------------------------

            //arrayList.Add("Omar");
            //* arrayList بقت غير متجانسة و دي من ضمن العيوب 


            //foreach (int i in arrayList)
            //{
            //    Console.Write( " " + i); //  10 20 30 70
            //}
            //Console.WriteLine("\n");

            //---------------------------------------------------------------

            //int sumResult =   Program.sumArrayList(arrayList);
            //Console.WriteLine($"Sum = {sumResult}"); //  Sum = 130
            //Console.WriteLine("\n");


            //------------------------------------------------------------

            #endregion


            #region Generic Collections "Lists" - [List]

            // List --> new version from ArrayList with generics

            //List<int> numbers = new List<int>();

            //Console.WriteLine($"count: {numbers.Count}");      // count: 0
            //Console.WriteLine($"capacity: {numbers.Capacity}");// capacity: 0
            //Console.WriteLine("\n");

            //------------------------------------------------------------------

            //numbers.Add(50);
            //Console.WriteLine($"count: {numbers.Count}");      // count: 1
            //Console.WriteLine($"capacity: {numbers.Capacity}");// capacity: 4
            //Console.WriteLine("\n");

            //-----------------------------------------------------------------------

            //numbers.AddRange(new int[] { 70, 80, 30 });
            //Console.WriteLine($"count: {numbers.Count}");       // count: 4
            //Console.WriteLine($"capacity: {numbers.Capacity}"); // capacity: 4
            //Console.WriteLine("\n");

            //----------------------------------------------------------------

            //numbers.Add(100);
            //Console.WriteLine("\n");
            //Console.WriteLine($"count: {numbers.Count}");       // count: 5
            //Console.WriteLine($"capacity: {numbers.Capacity}"); // capacity: 8

            // ---------------------------------------------------------------

            //numbers.TrimExcess(); // --> deallocate unused bytes.

            //Console.WriteLine("after trim:");
            //Console.WriteLine($"count: {numbers.Count}");       // count: 5
            //Console.WriteLine($"capacity: {numbers.Capacity}"); // capacity: 5
            //Console.WriteLine("\n");

            //----------------------------------------------------------------


            //List<int> numbers2 = new List<int>(5);
            //Console.WriteLine($"count: {numbers2.Count}");       // count: 0
            //Console.WriteLine($"capacity: {numbers2.Capacity}"); // capacity: 5
            //Console.WriteLine("\n");


            //------------------------------------------------------------------









            #endregion


            #region List Methods

            //List<int> Numbers = new List<int>(4) { 1,2,3,4};

            //Console.WriteLine($"count: {Numbers.Count}");  // count: 4
            //Console.WriteLine($"capacity: {Numbers.Capacity}"); // capacity: 4
            //Console.WriteLine("\n");

            //------------------------------------------------------------------------

            //Numbers.Add(7); // add new single element 
            //Numbers.AddRange(new int[] { 10, 20 });  // add array of elements

            //foreach (int item in Numbers)
            //{
            //    Console.Write(" " + item);  //  1 2 3 4 7 10 20
            //}
            //Console.WriteLine("\n");

            //------------------------------------------------------------------------

            //Numbers.Insert(5, 100); // insert new element in specific index

            //Numbers.InsertRange(3, new int[] { 33, 22 }); // insert range of elements in specific index

            //Console.WriteLine($"count: {Numbers.Count}");  // count:  10
            //Console.WriteLine($"capacity: {Numbers.Capacity}"); // capacity: 16 
            //Console.WriteLine("\n");

            //--------------------------------------------------------------

            //foreach (int item in Numbers)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine("\n");

            //--------------------------------------------------------------

            //Console.WriteLine(Numbers.BinarySearch(3)); // 2

            //Console.WriteLine(Numbers.BinarySearch(100)); // 7

            //------------------------------------------------------------------------

            /*   Numbers.Clear();*/ // remove all elements from list

            /*  Console.WriteLine(Numbers.Contains(3));*/ // true

            //------------------------------------------------------------------

            //int[] array = new int[10];

            /* Numbers.CopyTo(array);*/  // 1 2 3 4 
            /* Numbers.CopyTo(array, 3); */// array  , starting index 
                                           // Numbers.CopyTo(1,array , 3 , 2 );

            //------------------------------------------------------------------






            #endregion


            #region Generics Collections "Lists" - [Linked List]

            // LinkedList  --> consist of list of (Nodes).
            // node ---> consist of (data and link or pointer refer to the next node )

            //LinkedList<int> linkedList = new LinkedList<int>();
            ///*  Console.WriteLine(linkedList.Count);*/ // 0

            //linkedList.AddFirst(100);
            ///*   Console.WriteLine(linkedList.Count);*/ // 1

            //linkedList.AddLast(200); // add at the (end) of LinkedList


            //LinkedListNode<int> node = linkedList.Find(100);
            //linkedList.AddAfter(node, 50);

            //linkedList.AddBefore(node, 30);


            //foreach (int item in linkedList)
            //{
            //    Console.Write(item + " ");  // 30 100 50 200
            //}
            //Console.WriteLine("\n");



            // 

            #endregion


            #region Generic Collections "Lists" - [stack]

            //Stack<int> stack = new Stack<int>();    // FI - LO (first in - last out)


            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);

            //foreach (int item in stack)
            //{
            //    Console.WriteLine(item);  // 3
            //                             // 2
            //                            // 1
            //}
            //Console.WriteLine("\n");



            //Console.WriteLine(stack.Peek()); // return the (top) element in the stack without removing it from stack. 
            //Console.WriteLine("\n");


            //Console.WriteLine(stack.Pop()); // remove and return the (top) element in the stack
            //Console.WriteLine("\n");


            //bool res = stack.TryPop(out int ele);
            //Console.WriteLine(res); // True
            //Console.WriteLine(ele); // 2


            #endregion


            #region Generic Collections "Lists" - [Queue]
            
            //* FI - FO  (first in - first out)

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);


            //foreach (int item in queue)
            //{
            //    Console.Write(item + " "); // 1 2 3
            //}
            //Console.WriteLine("\n");

            //Console.WriteLine(queue.Peek()); // return first element in queue without removing it from queue.
            //Console.WriteLine("\n");


            //Console.WriteLine(queue.Dequeue()); // return and remove first element in queue.
            //Console.WriteLine("\n");


            //bool res = queue.TryDequeue(out int ele);
            //Console.WriteLine(res); // true
            //Console.WriteLine(ele); // 2 



            #endregion
        }
    }
}
