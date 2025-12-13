using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static public class Calculate
    {
        static public double main(string a_value, string b_value, string func)
        {
            int a = Convert.ToInt16(a_value);
            int b = Convert.ToInt16(b_value);

            switch (func)
            {
                case "+": return Plus(a, b);
                case "-": return Minus(a, b);
                case "*": return Multi(a, b);
                case "/": return Div(a, b);
                case "r": return Rest(a, b);
                case "sin": return Sinus(a);
                case "cos": return Cosinus(a);
                case "square": return Square(a);
                case "ceil": return Ceil(a);
                case "floor": return Floor(a);

            }
            return 4;
        }

        static public double Plus(int a, int b)
        {
            return a + b;
        }
        static public double Minus(int a, int b)
        {
            return a - b;
        }
        static public double Multi(int a, int b)
        {
            return a * b;
        }
        static public double Div(int a, int b)
        {
            if (b != 0)
            {
                return Math.Round((float)a / (float)b, 2);
            }
            return 0;
        }
        static public double Rest(int a, int b)
        {
            return a % b;
        }
        static public double Sinus(int a)
        {
            return Math.Round(Math.Sin((float)a), 2);
        }
        static public double Cosinus(int a)
        {
            return Math.Round(Math.Cos((float)a), 2);
        }
        static public double Ceil(int a)
        {
            return Math.Ceiling((float)a);
        }
        static public double Floor(int a)
        {
            return Math.Floor((float)a);
        }
        static public double Square(int a)
        {
            return Math.Round(Math.Sqrt(a), 2);
        }
    }
}
