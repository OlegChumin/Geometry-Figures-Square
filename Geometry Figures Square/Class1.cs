using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateGeometryFigureSquare
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчета площадей геометрических фигур");
            selectGeometryfigure();
            Console.WriteLine("Спасибо за использование программы.");

        }


        static void selectGeometryfigure()
        {
            Console.WriteLine("Привет, выбери номер геометрической фигуры: \n" +
               "1 - треугольник\n" +
               "2 - круг\n" +
               "3 - квадрат\n" +
               "4 - трапеция\n" +
               "5 - правильный многоугольник\n" +
               "6 - эллипс\n");

            int geometryFigure;
            geometryFigure = Convert.ToInt32(Console.ReadLine());


            switch (geometryFigure)
            {
                case 1:
                    {
                        Console.WriteLine("1 - выбран расчет площади треугольника");
                        Console.WriteLine($"Площадь заданного треугольника =  {calculateTriangleSquare()}");
                    }
           ;
                    break;
                case 2:
                    {
                        Console.WriteLine("2 - выбран расчет площади круга");
                        Console.WriteLine($"Площадь заданного круга = {calculateCircleSquare()}");
                    }
           ;
                    break;
                case 3:
                    {
                        Console.WriteLine("3 - выбран расчет площади квадрата");
                        Console.WriteLine($"Площадь заданного квадрата =  {calculateSquareSquare()}");
                    }
           ;
                    break;
                case 4:
                    {
                        Console.WriteLine("4 - выбран расчет площади трапеции");
                        Console.WriteLine($"Площадь заданной трапеции = {calculateTrapezoidSquare()}");
                    }
           ;
                    break;
                case 5:
                    {
                        Console.WriteLine("5 - выбран расчет площади правильного многоугольника");
                        Console.WriteLine($"Площадь заданного правильного многоугольника = {calculateRegularPolygon()}");
                    }
           ;
                    break;
                case 6:
                    {
                        Console.WriteLine("6 - выбран расчет площади эллипса");
                        Console.WriteLine($"Площадь заданного эллипса = {calculateEllipse()}");
                    }
           ;
                    break;
                default:
                    Console.WriteLine("нет такой фигуры в базе программы");
                    break;
            }

        }

        // метод, вычисляющий площадь треугольника

        static long calculateTriangleSquare()
        {
            Console.WriteLine("Введите высоту треугольника");
            long height;
            height = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите длину стороны треугольника");
            long side = Convert.ToInt64(Console.ReadLine());
            return (long)(0.5 * height * side);
        }

        // метод, вычисляющий площадь круга
        static double calculateCircleSquare()
        {
            Console.WriteLine("Введите длину радиуса окружности");
            double radius;
            radius = Convert.ToDouble((Console.ReadLine())); ; // readln().toDouble <- Kotlin
            // Java -> scanner.nextDouble() (hasNextDouble())
            return Math.PI * Math.Pow(radius, 2);
        }

        //метод, вычисляющий площадь квадрата
        static long calculateSquareSquare()
        {
            Console.WriteLine("Введи длину стороны квадрата");
            long side;
            side = Convert.ToInt64(Console.ReadLine());
            return (long)Math.Pow(side, 2);
        }

        //метод, вычисляющий площадь трапеции
        static long calculateTrapezoidSquare()
        {
            Console.WriteLine("Введи длину первой параллельной стороны трапеции:");
            long side;
            side = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введи длину второй параллельной стороны трапеции:");
            long secondSide;
            secondSide = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введи длину высоты трапеции:");
            long height;
            height = Convert.ToInt64(Console.ReadLine());
            return (long)(0.5 * (side + secondSide) * height);
        }

        //метод, вычисляющий площадь правильного многоугольника
        static long calculateRegularPolygon()
        {
            //S = n/4 × a 2 × ctg (pi/n)
            Console.WriteLine("Введи количество сторон правильного многоугольника:");
            long sidesNumber;
            sidesNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введи длину стороны правильного многоугольника:");
            long side;
            side = Convert.ToInt64(Console.ReadLine());
            return (long)(sidesNumber / 4 * Math.Pow(side, 2) * 1 / Math.Tan(Math.PI / sidesNumber));
        }

        //метод, вычисляющий площадь эллипса
        static long calculateEllipse()
        {
            Console.WriteLine("Введи длину первой полуоси эллипса");
            long semiAxisA;
            semiAxisA = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введи длину второй полуоси эллипса");
            long semiAxisB;
            semiAxisB = Convert.ToInt64(Console.ReadLine());
            return (long)(Math.PI * semiAxisA * semiAxisB);
        }



    }
}
