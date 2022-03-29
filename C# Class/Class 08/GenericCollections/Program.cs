using Entities;
using System;
using System.Collections.Generic;

namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ageDictionary = new Dictionary<string, int>()
            {
                { "Stanko", 20 },
                { "Miki", 30 },
                { "Zoran", 20 },
                { "Petko", 10 }
            };
            ageDictionary.Add("Blazho", 50);
            ageDictionary.Add("asdf", 20);
            Console.WriteLine(ageDictionary["Blazho"]);

            if (ageDictionary.ContainsKey("asdf"))
            {
                int age = ageDictionary["asdf"];
            }

            ageDictionary.Remove("Blazho");

            ageDictionary["Petko"] = 30;

            int[] intArray = new int[1];
            List<int> intList = new List<int>();
            intList.Add(4);
            intList.AddRange(new List<int>() { 4, 5, 6 });
            intList.IndexOf(4);
            intList.Insert(0, 5);

            Console.WriteLine(intList[0]);
            List<string> stringList = new List<string>();

            Queue<DateTime> dateTimeQueue = new Queue<DateTime>();

            dateTimeQueue.Enqueue(DateTime.Now);
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-1));
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-2));
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-3));

            Console.WriteLine(dateTimeQueue.Dequeue());
            Console.WriteLine(dateTimeQueue.Dequeue());

            bool isSuccessfull = dateTimeQueue.TryDequeue(out DateTime result);
            DateTime copyDate = dateTimeQueue.Peek();

            Stack<double> doubleStack = new Stack<double>();
            doubleStack.Push(3.4);
            doubleStack.Push(1.2);
            doubleStack.Pop();

           
        }
    }
}
