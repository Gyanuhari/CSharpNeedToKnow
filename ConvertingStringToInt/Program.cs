using System;
using System.Globalization;

namespace ConvertingStringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //For Int.Parse()
                short int1 = Int16.Parse("100"); // returns 100
                short int2 = Int16.Parse("-100", NumberStyles.AllowLeadingSign); // returns -100
                int int3 = Int32.Parse("$10000", NumberStyles.AllowCurrencySymbol); //returns 10000
                long int4 = Int64.Parse(" 2147483649 ", NumberStyles.AllowLeadingWhite
                    | NumberStyles.AllowTrailingWhite, CultureInfo.InvariantCulture); // returns 2147483649

                //int.Parse(null);//thows FormatException
                //int.Parse("");//thows FormatException
                //int.Parse("100.00"); // throws FormatException
                //int.Parse("100a"); //throws formatexception
                //int.Parse(2147483649);//throws overflow exception use Int64.Parse()


                //For Convert
                short c1=Convert.ToInt16("100"); // returns short
                short c2=Convert.ToInt16(null);//returns 0

                int c3=Convert.ToInt32("233300",CultureInfo.InvariantCulture);// returns 233300
                int c4=Convert.ToInt32("1234", 16); // returns 4660 - Hexadecimal of 1234

                long c5=Convert.ToInt64("1003232131321321");//returns long

                //The following throw exceptions
                //Convert.ToInt16("");            //throws FormatException
                //Convert.ToInt32("30,000");      //throws FormatException
                //Convert.ToInt16("(100)");       //throws FormatException
                //Convert.ToInt16("100a");        //throws FormatException
                //Convert.ToInt16(2147483649);    //throws OverflowException


                //For TryParse()
                //Syntax
                //bool isParsable1 = Int32.TryParse(string s, out int result);
                //bool isParsable2 = Int32.TryParse(string s, NumberStyles style, out int result);
                //bool isParsable3 = Int32.TryParse(string s, NumberStyle style, IFormatProvider provider, out int result);

                string numStr = " 10000";
                long number;
                bool isParsable = Int64.TryParse(numStr, NumberStyles.AllowLeadingWhite,
                    CultureInfo.InvariantCulture, out number);

                if(isParsable)
                    Console.WriteLine("Parsed Number is: {0}", number);
                else                                //Results: Parsed Number is: 123456
                    Console.WriteLine("Cannot Parse");
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

                Console.WriteLine("Finally Block.");
            }
        }
    }
}
