using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        public static int Add(int a, int b)
        {
            return a+ b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool isTrue)
        {
            var sum = a + b;
            if (isTrue)
            {
                if (sum > 1 || sum <= 0)
                {
                    //figure out how to do negatives
                    return $"{a} + {b} = {sum} dollars";
                }
                else
                {
                    return $"{a} + {b} = {sum} dollar";
                }
               
            }
            else
            {
                return $"{a + b}";
            }
        }


        
        static void Main(string[] args)
        {
            var a = -13;
            var b = 5;
            var c = 23.45m;
            var d = 76.3456m;
            var isTrue = true;
            var methodOne = Add(a, b);
            var methodTwo = Add(c, d);
            var methodThree = Add(a, b, isTrue);
            Console.WriteLine(methodOne);
            Console.WriteLine(methodTwo);
            Console.WriteLine(methodThree);
        }
    }
}
 