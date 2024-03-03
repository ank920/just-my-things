using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ankit Verma");
            Console.WriteLine("MCA-I A, Roll No: 14");

           
            List<object> myList = new List<object>();

           
            myList.Add(4);
            myList.Add(2.55);
            myList.Add("apple");
            myList.Add(true);

            
            if (myList.Contains(4))
            {
                myList.Remove(4);
            }

            
            Console.WriteLine("\nModified List:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("\nDoes the list contain 'apple'? " + myList.Contains("apple"));

            Console.ReadKey(); 
        }
    }
}
