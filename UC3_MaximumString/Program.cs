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
            string FirstPlace = "America";
            string SecondPlace = "Australia";
            string ThirdPlace = "India";
            int maximum = FindMaxumum(FirstValue, SecondValue, ThirdValue);
            float maximum1 = FindMaxumum1(FirstFloatValue, SecondFloatValue, ThirdFloatValue);
            string maximum2 = FindMaximum2(FirstPlace, SecondPlace, ThirdPlace);
            Console.WriteLine(maximum);
            Console.WriteLine(maximum1);
            Console.WriteLine(maximum2);
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
        static string FindMaximum2(string FirstPlace, string SecondPlace, string ThirdPlace)
        {
            if (FirstPlace.CompareTo(SecondPlace) > 0 && FirstPlace.CompareTo(ThirdPlace) > 0)
                return FirstPlace;
            else if (SecondPlace.CompareTo(FirstPlace) > 0 && SecondPlace.CompareTo(ThirdPlace) > 0)
                return SecondPlace;
            else if (ThirdPlace.CompareTo(FirstPlace) > 0 && ThirdPlace.CompareTo(SecondPlace) > 0)
                return ThirdPlace;
            else throw new Exception("Values are same");
        }

    }
}