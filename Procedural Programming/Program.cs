using System;
using System.Collections.Generic;
using System.Linq;

namespace Procedural_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Summarizing Text
            Console.WriteLine("Enter Long Text: ");
            string text = Console.ReadLine();
            const int maxLength = 35;
            Console.WriteLine(GetSummary(maxLength, text));


            //Working With StringBuilder
            Console.WriteLine("Enter String: ");
            string str = Console.ReadLine();
            Console.WriteLine("Reversed String: " + ReverseString(str));


            //Get Smallest Numbers
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var smallests = GetSmallests(numbers, 3);
            foreach (var item in smallests)
                Console.WriteLine(item);


            //Finding Union And Intersection
            int[] num1 = { 1, 2, 3, 4, 3, 55, 23, 2 };
            int[] num2 = { 55, 23, 45, 50, 80 };
            Console.WriteLine("Union of Numbers.......");
            PrintUnion(num1, num2);
            Console.WriteLine("Intersecton of Numbers.....");
            PrintIntersection(num1, num2);


            //Finding the index of the number that is double the any other number in array
            Console.WriteLine("Indexes Begins");
            int[] arrayNum = { 3,6,1};
            var indexOfNumbers = GetIndexOfNumbers(arrayNum);
            foreach (var item in indexOfNumbers)
                Console.WriteLine(item);

            indexOfNumbers = GetIndexOfNumbers(1, 2, 5, 4, 9, 10);
            foreach (var item in indexOfNumbers)
                Console.WriteLine(item);
        }

        private static string GetSummary(int maxLength, string text)
        {
            var summarySentence = string.Empty;

            if (text.Length < maxLength)
                summarySentence = text;
            else
            {
                int totalCharacters = 0;
                var wordList = new List<string>();
                var words = text.Split(' ');
                foreach (var eachword in words)
                {
                    wordList.Add(eachword);
                    totalCharacters += eachword.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }
                summarySentence = String.Join(" ", wordList) + "...";
                //This is going to be a...
            }
            return summarySentence;
        }


        private static string ReverseString(string str)
        {
            var array = new char[str.Length];
            for (var i = str.Length; i > 0; i--)
                array[str.Length - i] = str[i - 1];

            var reversedString = new String(array);
            //string reversedString = null;
            //foreach (var ch in array)
            //{
            //    reversedString += ch;
            //}

            return reversedString;
        }

        private static List<int> GetSmallests(List<int> numbers, int count)
        {
            var smallests = new List<int>();
            while (smallests.Count < count)
            {
                var min = GetSmallestOne(numbers);
                smallests.Add(min);
                numbers.Remove(min);
            }

            return smallests;
        }

        private static int GetSmallestOne(List<int> numbers)
        {
            //numbers.Sort();
            //return numbers[0];

            var temp = numbers[0];
            foreach (var item in numbers)
            {
                temp = item < temp ? item : temp;
            }
            return temp;
        }

        private static void PrintIntersection(int[] num1, int[] num2)
        {
            int[] intersect = num1.Intersect(num2).ToArray();
            Array.Sort(intersect);
            Array.ForEach(intersect, n => Console.WriteLine(n));
        }

        private static void PrintUnion(int[] num1, int[] num2)
        {
            int[] union = num1.Union(num2).ToArray();
            Array.Sort(union);
            Array.ForEach(union, n => Console.WriteLine(n));
        }

        private static IEnumerable<int> GetIndexOfNumbers(params int[] arrayNum)
        {
            int length = arrayNum.Length;
            //List<int> indexOfNum = new List<int>();
            for (var i = 0; i < length; i++)
            {
                for (var j = i + 1; j < length; j++)
                {
                    if ((2 * arrayNum[i]) == arrayNum[j])
                    {
                        yield return j;
                        //indexOfNum.Add(j);
                    }
                }
            }

            //return indexOfNum; make return type to List<int>
        }
    }
}
