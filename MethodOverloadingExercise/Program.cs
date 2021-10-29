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
            if (isTrue)
            {
                if (a + b > 1)
                {
                    return $"{a} + {b} = {a + b} dollars";
                }
                else
                {
                    return $"{a} + {b} = 1 dollar";
                }
            }
            else
            {
                return $"{a + b}";
            }
        }


        
        static void Main(string[] args)
        {
            var a = 13;
            var b = 45;
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
 