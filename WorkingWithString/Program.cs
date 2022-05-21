using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'w', 'o', 'r', 'd' };
            string word = new string(chars); //word
            string newString = new string('c', 10); //cccccccccc

            string dtString = DateTime.Now.ToString("D"); //Friday, 23 April 2021
            string shortDt = DateTime.Now.ToString("d/MM/yyyy"); //23/04/2021

            string sentence = "This is a string created by assignment.";
            int firstSpacePosition = sentence.IndexOf(" ") + 1; //5
            string phrase = sentence.Substring(firstSpacePosition, 11); //is a string

            string result = String.Format("At {0:t} on {0:D}", DateTime.Now);
            //At 2:46 PM on Friday, 23 April 2021

            string myString = "One Two Three *Four Five";

            string[] subStrings = myString.Split(' ');
            Array.ForEach(subStrings, name => Console.WriteLine($"{name}"));
            //One Two Three Four Five

            myString.Trim();
            string lower = myString.ToLower();
            string upper = myString.ToUpper();

            bool string1 = myString.Contains("Two"); //True
            myString.StartsWith("One"); //True
            myString.EndsWith("One"); //True

            string str2 = "Happy", str3 = "Man", str4 = " ";
            string concat = String.Concat(str2, " ", str3); //Happy Man
            concat.Equals("Happy Man"); //True //If concat is null throws exceptions

            bool isOk = myString.EndsWith("Five"); //True

            String.IsNullOrEmpty(str4); //False
            String.IsNullOrWhiteSpace(str4); //True

            string authorInfo = "Mahesh Chand is 33 years old.";
            int startPosition = authorInfo.IndexOf("is") + 1;
            string age = authorInfo.Substring(startPosition + 2, 2);
            Console.WriteLine("Age: " + age.ToString());

            string nameString = "Mahesh Chand";
            for (int counter = 0; counter <= nameString.Length - 1; counter++)
                Console.WriteLine(nameString[2]);            string n = nameString.Replace(" ", "-");            Console.WriteLine(n);            string name1 = "Mahesh Chand";
            string name2 = "Mojesh Chand";
            int comp = name1.CompareTo(name2); //-1
            Console.WriteLine(comp);
            if (comp > 0)
            {
                Console.WriteLine(name1 + " comes after " + name2);
            }
            else if (comp < 0)
            {
                Console.WriteLine(name1 + " comes before " + name2);
            }
            else
            {
                Console.WriteLine(name1 + " and " + name2 + " are same.");
            }            String authorName = "Mahesh Chand Beniwal";

            Console.WriteLine("Index of first 'a': " + authorName.IndexOf('a'));
            Console.WriteLine("Index of 'a' after 5th char: " + authorName.IndexOf('a', 5));
            Console.WriteLine("Index of 'a' after 10th char till next 5: " + authorName.IndexOf('a', 10, 5));
            Console.WriteLine("Last index of 'a': " + authorName.LastIndexOf('a'));
            Console.WriteLine("Last index of 'a': " + authorName.LastIndexOf('a', 5));
            Console.WriteLine("Last index of 'a': " + authorName.LastIndexOf('a', 10, 5));

            string removedName = authorName.Remove(6, 6);
            Console.WriteLine(removedName);

            string[] stringSeperators = new string[] { " " };
            string[] results = authorName.Split(stringSeperators, StringSplitOptions.None);
            Array.ForEach(results, strname => Console.WriteLine(strname));

            string sentenc = "Mahesh Chand is an author and founder of C# Corner";
            Console.WriteLine("Original String: {0}", sentenc);
            Console.WriteLine("Substring starting at 20: {0}", sentenc.Substring(20));
            Console.WriteLine("Substring starting at 20, next 10 chars: {0}", sentenc.Substring(20, 10));

            string fullName = " Hari Tandan ";
            Console.WriteLine($"Trimmed Name: '{fullName.Trim()}'"); //'Hari Tandan'

            if (String.IsNullOrEmpty(""))
                Console.WriteLine("Empty"); //Executes
            if (String.IsNullOrEmpty(" "))
                Console.WriteLine("Empty"); //Does not executes because it is a white space character so, not empty

            //Summarizing Text
            var text = "This is going to be a very very very very very very very long sentence.";
            const int maxLength = 30;
            Console.WriteLine(GetSummary(maxLength, text));

            //Working With StringBuilder
            WorkingWithString();
        }

        private static string GetSummary(int maxLength, string text)
        {
            var summarySentence = string.Empty;

            if (text.Length < maxLength)
                summarySentence=text;
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

        private static void WorkingWithString()
        {
            var builder= new StringBuilder();
            builder.Append('-', 20);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('_', '+');
            builder.Remove(0, 10);

            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);
        }
    }
}
