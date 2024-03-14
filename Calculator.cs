using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Calculator
    {
        //метод сложения
        public static double Addition(double x,double y)
        {
            return x + y;
        }
        //метод вычитания
        public static double Subtraction(double x, double y)
        {
            return x - y;
        }

        //метод деления
        public static double Division(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                throw new DivideByZeroException("Деление на ноль невозможно!");// тип исключения 
            }
        }

        //метод умножения
       
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
       
    }
}
