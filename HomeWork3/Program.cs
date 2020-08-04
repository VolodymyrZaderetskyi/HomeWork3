using System;

namespace HomeWork3
{
    class Program
    {
        /*  Богдан Ігнатович
         *  1.  а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
                б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
                в) Добавить диалог с использованием switch демонстрирующий работу класса.
            
            2.  С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
                Требуется подсчитать сумму всех нечётных положительных чисел. 
                Сами числа и сумму вывести на экран, используя tryParse. 

            3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
                Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
                Написать программу, демонстрирующую все разработанные элементы класса.   
             */

        struct Complex
        {
            public double a;
            public double b;

            public Complex(double _a,double _b)
            {
                a = _a;
                b = _b;
            }

            public string Print()
            {
                if (b == 0) return $"{a}";
                if (b == 1) return $"{a} + i";
                if (b == -1) return $"{a} - i";
                return (b>0)?$"{a} + {b}i":$"{a} - {-b}i";
            }

            public static Complex Sub(Complex x, Complex y)
            {
                Complex temp = new Complex();
                temp.a = x.a - y.a;
                temp.b = x.b - y.b;
                return temp;
            }

            public static Complex Mul(Complex x, Complex y)
            {
                Complex temp = new Complex();
                temp.a = (x.a * y.a) - (x.b * y.b);
                temp.b = (x.a * y.b) - (x.b * y.a);
                return temp;
            }
        }

        class ComplexClass
        {
            public double a;
            public double b;

            public ComplexClass()
            {
                a = 0;
                b = 0;
            }
            public ComplexClass(double _a, double _b)
            {
                a = _a;
                b = _b;
            }

            public string Print()
            {
                if (b == 0) return $"{a}";
                if (b == 1) return $"{a} + i";
                if (b == -1) return $"{a} - i";
                return (b > 0) ? $"{a} + {b}i" : $"{a} - {-b}i";
            }

            public static ComplexClass Sub(ComplexClass x, ComplexClass y)
            {
                ComplexClass temp = new ComplexClass();
                temp.a = x.a - y.a;
                temp.b = x.b - y.b;
                return temp;
            }

            public static ComplexClass Mul(ComplexClass x, ComplexClass y)
            {
                ComplexClass temp = new ComplexClass();
                temp.a = (x.a * y.a) - (x.b * y.b);
                temp.b = (x.a * y.b) - (x.b * y.a);
                return temp;
            }
        }

        class Fraction
        {
            public int a;
            public int b;

            public Fraction()
            {

            }

            public Fraction(int _a, int _b)
            {
                a = _a;
                b = _b;
            }
            public string Print()
            {
                if (b == 0) return "infinity";
                if (b == 1 || b == -1) return $"{a * b}";
                if (a == 0) return "0";
                return $"{a}/{b}";
            }

            public static Fraction Sum(Fraction x, Fraction y)
            {
                Fraction temp = new Fraction();
                temp.b = x.b * y.b;
                temp.a = (x.a * y.b) + (y.a * x.b);
                if (temp.a == 0 || temp.b == 0) return temp;
                if (temp.a % temp.b == 0 || temp.b % temp.a == 0) {
                    if (temp.a > temp.b) {
                        temp.a /= temp.b;
                        temp.b = 1;
                    } else {
                        temp.b /= temp.a;
                        temp.a = 1;
                    }
                }else {
                    while (temp.a % 2 == 0 && temp.b % 2 == 0)
                    {
                        temp.a /= 2;
                        temp.b /= 2;
                    }
                    while (temp.a % 3 == 0 && temp.b % 3 == 0)
                    {
                        temp.a /= 3;
                        temp.b /= 3;
                    }
                    while (temp.a % 5 == 0 && temp.b % 5 == 0)
                    {
                        temp.a /= 5;
                        temp.b /= 5;
                    }
                    while (temp.a % 7 == 0 && temp.b % 7 == 0)
                    {
                        temp.a /= 7;
                        temp.b /= 7;
                    }
                    while (temp.a % 11 == 0 && temp.b % 11 == 0)
                    {
                        temp.a /= 11;
                        temp.b /= 11;
                    }
                }
                return temp;
            }

            public static Fraction Sub(Fraction x, Fraction y)
            {
                Fraction temp = new Fraction();
                temp.b = x.b * y.b;
                temp.a = (x.a * y.b) - (y.a * x.b);
                if (temp.a == 0 || temp.b == 0) return temp;
                if (temp.a % temp.b == 0 || temp.b % temp.a == 0)
                {
                    if (temp.a > temp.b)
                    {
                        temp.a /= temp.b;
                        temp.b = 1;
                    }
                    else
                    {
                        temp.b /= temp.a;
                        temp.a = 1;
                    }
                }
                else
                {
                    while (temp.a % 2 == 0 && temp.b % 2 == 0)
                    {
                        temp.a /= 2;
                        temp.b /= 2;
                    }
                    while (temp.a % 3 == 0 && temp.b % 3 == 0)
                    {
                        temp.a /= 3;
                        temp.b /= 3;
                    }
                    while (temp.a % 5 == 0 && temp.b % 5 == 0)
                    {
                        temp.a /= 5;
                        temp.b /= 5;
                    }
                    while (temp.a % 7 == 0 && temp.b % 7 == 0)
                    {
                        temp.a /= 7;
                        temp.b /= 7;
                    }
                    while (temp.a % 11 == 0 && temp.b % 11 == 0)
                    {
                        temp.a /= 11;
                        temp.b /= 11;
                    }
                }
                return temp;
            }

            public static Fraction Mul(Fraction x, Fraction y)
            {
                Fraction temp = new Fraction();
                temp.b = x.b * y.b;
                temp.a = x.a * y.a;
                if (temp.a == 0 || temp.b == 0) return temp;
                if (temp.a % temp.b == 0 || temp.b % temp.a == 0)
                {
                    if (temp.a > temp.b)
                    {
                        temp.a /= temp.b;
                        temp.b = 1;
                    }
                    else
                    {
                        temp.b /= temp.a;
                        temp.a = 1;
                    }
                }
                else
                {
                    while (temp.a % 2 == 0 && temp.b % 2 == 0)
                    {
                        temp.a /= 2;
                        temp.b /= 2;
                    }
                    while (temp.a % 3 == 0 && temp.b % 3 == 0)
                    {
                        temp.a /= 3;
                        temp.b /= 3;
                    }
                    while (temp.a % 5 == 0 && temp.b % 5 == 0)
                    {
                        temp.a /= 5;
                        temp.b /= 5;
                    }
                    while (temp.a % 7 == 0 && temp.b % 7 == 0)
                    {
                        temp.a /= 7;
                        temp.b /= 7;
                    }
                    while (temp.a % 11 == 0 && temp.b % 11 == 0)
                    {
                        temp.a /= 11;
                        temp.b /= 11;
                    }
                }
                return temp;
            }

            public static Fraction Div(Fraction x, Fraction y)
            {
                Fraction temp = new Fraction();
                temp.b = x.b * y.a;
                temp.a = x.a * y.b;
                if (temp.a == 0 || temp.b == 0) return temp;
                if (temp.a % temp.b == 0 || temp.b % temp.a == 0)
                {
                    if (temp.a > temp.b)
                    {
                        temp.a /= temp.b;
                        temp.b = 1;
                    }
                    else
                    {
                        temp.b /= temp.a;
                        temp.a = 1;
                    }
                }
                else
                {
                    while (temp.a % 2 == 0 && temp.b % 2 == 0)
                    {
                        temp.a /= 2;
                        temp.b /= 2;
                    }
                    while (temp.a % 3 == 0 && temp.b % 3 == 0)
                    {
                        temp.a /= 3;
                        temp.b /= 3;
                    }
                    while (temp.a % 5 == 0 && temp.b % 5 == 0)
                    {
                        temp.a /= 5;
                        temp.b /= 5;
                    }
                    while (temp.a % 7 == 0 && temp.b % 7 == 0)
                    {
                        temp.a /= 7;
                        temp.b /= 7;
                    }
                    while (temp.a % 11 == 0 && temp.b % 11 == 0)
                    {
                        temp.a /= 11;
                        temp.b /= 11;
                    }
                }
                return temp;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Struct:");

            Complex x1 = new Complex(4,5);
            Console.WriteLine(x1.Print());

            Complex x2 = new Complex(2,-5);
            Console.WriteLine(x2.Print());

            Console.WriteLine();
            Console.WriteLine("Class:");

            ComplexClass y1 = new ComplexClass(3, 1);
            Console.WriteLine(y1.Print());

            ComplexClass y2 = new ComplexClass(8, -9);
            Console.WriteLine(y2.Print());

            Console.WriteLine();
            Console.WriteLine("Enter sub if you want to substruct this numbers, mul to multiply:");
            string command = Console.ReadLine();
            switch (command)
            {
                case "sub":  Console.WriteLine("Substruct:");
                             Console.WriteLine("Struct:");
                             Complex res1 = Complex.Sub(x1, x2);
                             Console.WriteLine(res1.Print());
                             Console.WriteLine("Class:");
                             ComplexClass result1 = ComplexClass.Sub(y1, y2);
                             Console.WriteLine(result1.Print());
                             break;

                case "mul":  Console.WriteLine("Multiply:");
                             Console.WriteLine("Struct:");
                             ComplexClass result = ComplexClass.Mul(y1, y2);
                             Console.WriteLine(result.Print());
                             Console.WriteLine("Class:");
                             ComplexClass result2 = ComplexClass.Mul(y1, y2);
                             Console.WriteLine(result2.Print());
                             break;
                default: Console.WriteLine("Incorrect command");
                    break;
            }

            Console.WriteLine("Enter numbers or 0 to exit:");
            int number = 1;
            bool success = false;
            int res = 0;
            while (number != 0)
            {
                success = int.TryParse(Console.ReadLine(),out number);
                if (success)
                {
                    res += number;
                }
                else
                {
                    number = 1;
                }
            }
            Console.WriteLine("Result:" + res.ToString());

            Console.WriteLine();
            Console.WriteLine("Fraction:");

            Fraction f1 = new Fraction(1, 2);
            Console.WriteLine(f1.Print());
            Fraction f2 = new Fraction(2, 4);
            Console.WriteLine(f2.Print());
            Console.WriteLine("Sum:");
            Fraction resultf1 = Fraction.Sum(f1, f2);
            Console.WriteLine(resultf1.Print());
            Console.WriteLine("Sub:");
            Fraction resultf2 = Fraction.Sub(f1, f2);
            Console.WriteLine(resultf2.Print());
            Console.WriteLine("Mul:");
            Fraction resultf3 = Fraction.Mul(f1, f2);
            Console.WriteLine(resultf3.Print());
            Console.WriteLine("Div:");
            Fraction resultf4 = Fraction.Div(f1, f2);
            Console.WriteLine(resultf4.Print());
        }
    }
}
