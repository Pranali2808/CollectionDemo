using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to C# collection");

             //doListDemo();
             //doDictionaryDemo();
              doStackDemo();

        }
        private static void doListDemo()

        {
            Console.WriteLine("\n In DoListDemo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ajay");
            list.Add("Vijay");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static void doDictionaryDemo()
        {
            Console.WriteLine("\n In DictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Amit");
            dictionary.Add(2, "Rahul");
            dictionary.Add(3, "Vijay");

            Console.WriteLine("Access value using key(key=1):" + dictionary[1]);

            Console.WriteLine("\n Iterating Dictionary:");
            foreach (var item in dictionary)
            {
                Console.WriteLine("Key = " + item.Key + " & Value = " + item.Value);
            }
            Console.ReadLine();
        }

        private static void doStackDemo()
        {
            Console.WriteLine("\n In StackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop = stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Poped element: " + pop);
            Console.ReadLine();

        }
    }
}

        
        

