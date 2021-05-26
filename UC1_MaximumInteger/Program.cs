using System;

namespace FindMaximumGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstValue = 12;
            int SecondValue = 16;
            int ThirdValue = 14;
            int maximum = FindMaxumum(FirstValue, SecondValue, ThirdValue);
            Console.WriteLine(maximum);
            Console.ReadKey();

        }
        static int FindMaxumum(int FirstValue, int SecondValue, int ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
                return FirstValue;
            else if (SecondValue.CompareTo(FirstValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
                return SecondValue;
            else if (ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0)
                return ThirdValue;
            else throw new Exception("Values are same");
        }


    }
}