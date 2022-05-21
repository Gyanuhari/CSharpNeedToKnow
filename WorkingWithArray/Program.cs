using System;
using System.Linq;

namespace WorkingWithArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Array Directories = Directories.GetDirectories(@"C:\myfolder");

            object[] array = new String[10];
            array[0] = 10;


            //string[] names = new string[7];
            //string[] names = new string[] { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };
            string[] names = { "Steve", "Bill", "Bill Gates", "Ravi", "Mohan", "Salman", "Boski" };

            //Find By String
            var stringToFind = "Bill";
            var result = Array.Find(names, name => name == stringToFind); //returns "Bill"
            string[] results = Array.FindAll(names, name => name==stringToFind); //returns "Bill"

            //Element that starts with B
            var resultStartWithB = Array.Find(names, name => name.StartsWith("B")); //returns "Bill"
            string[] resultsStartWithB = Array.FindAll(names, name => name.StartsWith("B")); 
            //returns "Bill" "Bill Gates" "Boski"

            foreach (var item in results)
                Console.WriteLine("Result: " + item);

            //Counting Array Items
            var totalCount = names.Count(); //returns 7
            var totalCountStartWithB = names.Count(n => n.StartsWith("B")); //returns 3


            //Combining two arrays without dublicating the values
            String[] animal1 = { "Cat", "Dog", "Cow", "Rat" };
            String[] animal2 = { "Cow", "Buffalo", "Rat", "Goat" };

            string[] all = animal1.Union(animal2).ToArray();

            //Displays distinct value of num1 first and non-repeating from num2
            Array.ForEach(all, n => Console.WriteLine(n)); //1 2 3 4 55 23 45 50 80

            //Sort to get in Ascending Order
            Array.Sort(all);
            Array.ForEach(all, n=>Console.WriteLine(n)); //1 2 3 4 23 45 50 55 80

            //First Sort and Reverse to get in Descending Order
            Array.Reverse(all);
            Array.ForEach(all, n => Console.WriteLine(n)); //80 55 50 45 23 4 3 2 1

            Console.ReadKey();

            //Finding Union And Intersection
            int[] num1 = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] num2 = { 55, 23, 45, 50, 80 };
            Console.WriteLine("Union of Numbers.......");
            PrintUnion(num1, num2);
            Console.WriteLine("Intersecton of Numbers.....");
            PrintIntersection(num1, num2);
        }

        private static void PrintIntersection(int[] num1, int[] num2)
        {
            int[] intersect = num1.Intersect(num2).ToArray();
            Array.Sort(intersect);
            Array.ForEach(intersect, n => Print(n));
        }

        private static void PrintUnion(int[] num1, int[] num2)
        {
            int[] union=num1.Union(num2).ToArray();
            Array.Sort(union);
            Array.ForEach(union, n => Print(n));
        }

        private static void Print(int n)
        {
            System.Console.WriteLine(n);
        }
    }
}
