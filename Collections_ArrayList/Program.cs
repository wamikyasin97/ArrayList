using System;
using System.Collections;

namespace Collections_ArrayList
{
    class Program
    {
        static void display(ArrayList arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 100, 200, 300 };

            var myArrList1 = new ArrayList();
            myArrList1.Add(1);
            myArrList1.Add("wamik");
            myArrList1.Add(true);
            myArrList1.Add(82.5);


            var myArrList2 = new ArrayList()
            {
                1, "wamik", true, 82.5
            };

            myArrList2.AddRange(arr);
            myArrList2.AddRange(myArrList1);

            Console.WriteLine("--------------------------------------------------First iteration--------------------------------------------------");
            display(myArrList2);

            myArrList1.Insert(1, 2);
            myArrList2.InsertRange(7, myArrList1);

            Console.WriteLine("--------------------------------------------------Second iteration--------------------------------------------------");
            display(myArrList2);

            myArrList2.Remove("wamik");
            myArrList2.RemoveRange(0, 4);

            Console.WriteLine("--------------------------------------------------Third iteration--------------------------------------------------");
            display(myArrList2);

            Console.WriteLine(myArrList2.Contains("wamik"));

            myArrList2.Reverse();
            Console.WriteLine("--------------------------------------------------Fourth iteration--------------------------------------------------");
            display(myArrList2);




        }
    }
}
