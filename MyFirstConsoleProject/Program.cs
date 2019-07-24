using System;

namespace MyFirstConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int answer = Arithmetic.Add(3, 7);
            Console.WriteLine("3 + 7 = " + answer);
            answer = Arithmetic.Sub(10, 6);
            Console.WriteLine("10 - 6 = " + answer);
            answer = Arithmetic.Mult(5, 7);
            Console.WriteLine("5 * 7 = " + answer);
            answer = Arithmetic.Div(7, 2);
            Console.WriteLine("7 / 2 = " + answer);
            answer = Arithmetic.Mod(2345, 317);
            Console.WriteLine("5 % 2 = " + answer);
            // 
            //bool TorF = Arithmetic.IsEvenlyDivisible(655, 112);
            //Console.WriteLine($"655 is evenly evenly divisible by 112: {TorF}");          // RETURNS FALSE
            bool TorF = Arithmetic.IsEvenlyDivisible(655, 5);                              
            Console.WriteLine($"655 is evenly evenly divisible by 5: {TorF}");               // RETURNS TRUE


        }
    }
    class Arithmetic
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Mult(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)                                 // accessible to any class in the universe
        //internal static int Div(int a, int b)                             // accessible to all classes within project
        {
            return a / b;
        }

        // all the # between and  is easily divisible by ---> use modulus

        public static int Mod(int a, int b)                        
        //internal static int Mod(int a, int b)                       
        {
            int ans = a % b;
            Console.WriteLine($"{a} mod {b} = {ans}");      // interpolation -- using $ in front of " allows you to use {}, 
            return ans;                                     // telling it to use the value of variable within brackets
        }
        public static bool IsEvenlyDivisible(int a, int b)          // returns boolean; either is even (returns 0) or is not even 
        {
            return Mod(a, b) == 0;                        // For even, 0 returned.  0 === 0   TRUE   
        }                                                  // FOR ODD, a different value is returned.  
    }
}
