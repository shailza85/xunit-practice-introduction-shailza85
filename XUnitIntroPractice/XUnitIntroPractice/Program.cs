using System;
using System.Linq;
using System.Collections.Generic;

namespace XUnitIntroPractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();
        }
        public static void HelloWorld()
        {
            Console.WriteLine("Hello, world!");
        }


        public static bool IsYesOrNo(string myString)
        {

            if (myString == "Yes".Trim().ToLower() || myString == "Y".Trim().ToLower() || myString == "No".Trim().ToLower() || myString == "N".Trim().ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Write a method called IsYesOrNo that will accept a string and return true if the string is “YES”, “Y”, “NO”, or “N”, in any casing, trimmed. Otherwise it will return false.

        public static bool Str_ToUpper(string upStr)
        {
            if (upStr == "yes".ToUpper() || upStr == "y".ToUpper() || upStr == "no".ToUpper())
            {
                return true;
            }
            return false;
        }

        public static bool AcceptValue(string inputValue)
        {
            string strVal = inputValue;
            if (strVal.ToLower() == inputValue)
            {
                return true;
            }
            return false;
        }

        public static bool InvalidValue(string invalidVal)
        {
            string strVal1 = invalidVal;
            if (invalidVal == "" || invalidVal.Length == 1 || invalidVal.Length > 1)
            {
                return false;
            }
            return true;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static void NullExec()
        {
            int[] values = null;
            for (int ctr = 0; ctr <= 9; ctr++)
            {
                values[ctr] = ctr * 2;
            }
            foreach (var value in values)
                Console.WriteLine(value);
        }

        //@link: https://docs.microsoft.com/en-us/dotnet/api/system.indexoutofrangeexception?view=netcore-3.1
        public static int[] PopulateArray(int items, int maxValue)
        {
            int[] values = new int[items];
            Random rnd = new Random();
            for (int ctr = 0; ctr < items; ctr++)
                values[ctr] = rnd.Next(0, maxValue + 1);
 foreach (var value in values)
                Console.Write("{0}   ", values[value]);
            return values;
           
        }
    }
}
