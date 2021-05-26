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
            float FirstFloatValue = 9.6f;
            float SecondFloatValue = 4.8f;
            float ThirdFloatValue = 2.3f;
            int maximum = FindMaxumum(FirstValue, SecondValue, ThirdValue);
            float maximum1 = FindMaxumum1(FirstFloatValue, SecondFloatValue, ThirdFloatValue);
            Console.WriteLine(maximum);
            Console.WriteLine(maximum1);
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

        static float FindMaxumum1(float FirstFloatValue, float SecondFloatValue, float ThirdFloatValue)
        {
            if (FirstFloatValue.CompareTo(SecondFloatValue) > 0 && FirstFloatValue.CompareTo(ThirdFloatValue) > 0)
                return FirstFloatValue;
            else if (SecondFloatValue.CompareTo(FirstFloatValue) > 0 && SecondFloatValue.CompareTo(ThirdFloatValue) > 0)
                return SecondFloatValue;
            else if (ThirdFloatValue.CompareTo(FirstFloatValue) > 0 && ThirdFloatValue.CompareTo(SecondFloatValue) > 0)
                return ThirdFloatValue;
            else throw new Exception("Values are same");
        }

    }
}