﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CUSTOM_PAINT
{
    class Program
    {
        enum Act : byte
        {
            None,
            Добавить_фигуру,
            Вывести_фигуры,
            Очистить_холст,
            Выход   
        }
        enum TypeFigure : byte
        {
            None,
            Линия,
            Квадрат,
            Прямоугольник,
            Треугольник,
            Круг,
            Кольцо
        }
       
        static void Main(string[] args)
        {
          
            // Создаем List для размещения созданных фигур
            List<Line> myLine = new List<Line>();
            List<Square> mySquare = new List<Square>();
            List<Rectangle> myRectangle = new List<Rectangle>();
            List<Triangle> myTriangle = new List<Triangle>();
            List<Circle> myCircle = new List<Circle>();
            List<Ring> myRing = new List<Ring>();
            int i = 0;
            while (i==0)
            {
                

                Console.WriteLine("Выберите действие");
                Console.WriteLine("1. Добавить фигуру");
                Console.WriteLine("2. Вывести фигуры");
                Console.WriteLine("3. Очистить холст");
                Console.WriteLine("4. Выход");

                var str = Console.ReadLine();
                var actType = (byte)Enum.Parse(typeof(Act), str);
                switch (actType)
                {
                    case 1:
                        Console.WriteLine("Выберите тип фигуры");
                        Console.WriteLine("1. Линия");
                        Console.WriteLine("2. Квадрат");
                        Console.WriteLine("3. Прямоугольник");
                        Console.WriteLine("4. Треугольник");
                        Console.WriteLine("5. Круг");
                        Console.WriteLine("6. Кольцо");
                        Console.WriteLine("7. Выход");
                        var str1 = Console.ReadLine();
                        var figureType = (byte)Enum.Parse(typeof(TypeFigure), str1);

                        Console.WriteLine(figureType);
                        switch (figureType)
                        {
                            case 1:

                                Console.WriteLine("Введите параметры фигуры Линия");
                                Console.WriteLine("Введите координаты x1");
                                int xLine1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y1");
                                int yLine1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты x2");
                                int xLine2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y2");
                                int yLine2 = Int32.Parse(Console.ReadLine());
                                Line line = new Line(xLine1, yLine1, xLine2, yLine2);
                                                             
                                Console.WriteLine("Фигура Линия создана!");
                                myLine.Add(line);

                                break;

                            case 2:

                                Console.WriteLine("Введите параметры фигуры Квадрат");
                                Console.WriteLine("Введите координаты x1");
                                int xSquare1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y1");
                                int ySquare1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты x2");
                                int xSquare2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y2");
                                int ySquare2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты x3");
                                int xSquare3 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y3");
                                int ySquare3 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты x4");
                                int xSquare4 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y4");
                                int ySquare4 = Int32.Parse(Console.ReadLine());
                                Square square = new Square(xSquare1, ySquare1, xSquare2, ySquare2, xSquare3, ySquare3, xSquare4, ySquare4);
                                Console.WriteLine("Фигура Квадрат создана!");
                                mySquare.Add(square);

                                break;

                            case 3:

                                Console.WriteLine("Введите параметры фигуры Прямоугольник");
                                Console.WriteLine("Введите координаты x1");
                                int xRectangle1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y1");
                                int yRectangle1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты x2");
                                int xRectangle2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y2");
                                int yRectangle2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты x3");
                                int xRectangle3 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y3");
                                int yRectangle3 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты x4");
                                int xRectangle4 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y4");
                                int yRectangle4 = Int32.Parse(Console.ReadLine());
                                Rectangle rectangle = new Rectangle(xRectangle1, yRectangle1, xRectangle2, yRectangle2, xRectangle3, yRectangle3, xRectangle4, yRectangle4);
                                myRectangle.Add(rectangle);
                                Console.WriteLine("Фигура Прямоугольник создана!");

                                break;

                            case 4:
                                Console.WriteLine("Введите параметры фигуры Треугольник");
                                Console.WriteLine("Введите координаты x1");
                                int xTriangle1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y1");
                                int yTriangle1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты x2");
                                int xTriangle2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y2");
                                int yTriangle2 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты x3");
                                int xTriangle3 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты y3");
                                int yTriangle3 = Int32.Parse(Console.ReadLine());
                               
                                Triangle triangle = new Triangle(xTriangle1, yTriangle1, xTriangle2, yTriangle2, xTriangle3, yTriangle3);
                                myTriangle.Add(triangle);
                                Console.WriteLine("Фигура Треугольник создана!");
                                break;

                            case 5:
                                Console.WriteLine("Введите параметры фигуры Круг");
                                Console.WriteLine("Введите координаты центра x1");
                                int xCircle1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты центра y1");
                                int yCircle1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите радиус окружности");
                                int rCircle = Int32.Parse(Console.ReadLine());

                                Circle circle = new Circle(xCircle1, yCircle1, rCircle);
                                myCircle.Add(circle);
                                Console.WriteLine("Фигура Круг создана!");
                                break;

                            case 6:

                                Console.WriteLine("Введите параметры фигуры Кольцо");
                                Console.WriteLine("Введите координаты центра x1");
                                int xRing1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите координаты центра y1");
                                int yRing1 = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите радиус внешней окружности");
                                int rRadius = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Введите радиус внутренней окружности");
                                int rInnerRadius = Int32.Parse(Console.ReadLine());

                                Ring ring = new Ring(xRing1, yRing1, rRadius, rInnerRadius);
                                myRing.Add(ring);
                                Console.WriteLine("Фигура Кольцо создана!");
                                break;


                        }

                        break;


                    case 2:
                        // Вывести фигуры

                        if (myLine.Count > 0)
                        {                            
                         foreach (Line l in myLine)
                            {
                                Console.WriteLine("Фигура Линия");
                                Console.WriteLine($" X1 = {l.x1}");
                                Console.WriteLine($" Y1 = {l.y1}");
                                Console.WriteLine($" X2 = {l.x2}");
                                Console.WriteLine($" Y2 = {l.y2}");
                             }
                        }
                        if (mySquare.Count > 0)
                        {
                            foreach(Square sq in mySquare)
                            {
                                Console.WriteLine("Фигура Квадрат");
                                Console.WriteLine($" X1 = {sq.x1}");
                                Console.WriteLine($" Y1 = {sq.y1}");
                                Console.WriteLine($" X2 = {sq.x2}");
                                Console.WriteLine($" Y2 = {sq.y2}");
                                Console.WriteLine($" X3 = {sq.x3}");
                                Console.WriteLine($" Y3 = {sq.y3}");
                                Console.WriteLine($" X4 = {sq.x4}");
                                Console.WriteLine($" Y4 = {sq.y4}");

                            }
                        }
                        if (myRectangle.Count > 0)
                        {
                            foreach (Rectangle rc in myRectangle)
                            {
                                Console.WriteLine("Фигура Прямоугольник");
                                Console.WriteLine($" X1 = {rc.x1}");
                                Console.WriteLine($" Y1 = {rc.y1}");
                                Console.WriteLine($" X2 = {rc.x2}");
                                Console.WriteLine($" Y2 = {rc.y2}");
                                Console.WriteLine($" X3 = {rc.x3}");
                                Console.WriteLine($" Y3 = {rc.y3}");
                                Console.WriteLine($" X4 = {rc.x4}");
                                Console.WriteLine($" Y4 = {rc.y4}");

                            }
                        }
                        if (myTriangle.Count > 0)
                        {
                            foreach (Triangle tri in myTriangle)
                            {
                                Console.WriteLine("Фигура Треугольник");
                                Console.WriteLine($" X1 = {tri.x1}");
                                Console.WriteLine($" Y1 = {tri.y1}");
                                Console.WriteLine($" X2 = {tri.x2}");
                                Console.WriteLine($" Y2 = {tri.y2}");
                                Console.WriteLine($" X3 = {tri.x3}");
                                Console.WriteLine($" Y3 = {tri.y3}");
                            }
                        }

                        if (myCircle.Count > 0)
                        {
                            foreach (Circle cir in myCircle)
                            {
                                Console.WriteLine("Фигура Круг");
                                Console.WriteLine($" X = {cir.x}");
                                Console.WriteLine($" Y = {cir.y}");
                                Console.WriteLine($" Radius = {cir.radius}");
                            }
                        }

                        if (myRing.Count > 0)
                        {
                            foreach (Ring rin in myRing)
                            {
                                Console.WriteLine("Фигура Кольцо");
                                Console.WriteLine($" X = {rin.x}");
                                Console.WriteLine($" Y = {rin.y}");
                                Console.WriteLine($" OuterRadius = {rin.radius}");
                                Console.WriteLine($" InnerRadius = {rin.innerRadius}");
                            }
                        }



                        break;

                    case 3:

                        //Очищаем Холст
                        myLine.Clear();
                        mySquare.Clear();
                        myRectangle.Clear();
                        myTriangle.Clear();
                        myCircle.Clear();
                        myRing.Clear();
                        break;

                    // Выход
                    case 4:

                        i = 1;

                        break; 


                }

              

            }
        }

    }
   
    // Родительский класс Просто круглый предмет, предназначенный для Круга и Кольца
    class RoundShape
    {
        public int x;
        public int y;
        public int radius;
    }

    // Дочерний класс Круг, унаследованнный от Просто круглого предмета
    class Circle : RoundShape
    {
        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public double GetArea() => Math.PI * radius * radius;
        public double GetСircumscribedСircle() => 2 * Math.PI * radius;

    }

    // Дочерний класс Кольцо, унаследованный от Просто круглого предмета
    class Ring : RoundShape
    {
        public int innerRadius;
        public Ring(int x, int y, int radius, int innerRadius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
            this.innerRadius = innerRadius;
                
        }
        
        public double GetArea() => Math.PI * (radius * radius - innerRadius * innerRadius);

        public double GetTotalLenght() => (2 * Math.PI * radius) + (2 * Math.PI * innerRadius);
    } 

    // Клас Линия, предназначенный для рисования Линии с Методом Подсчет длины отрезка
    class Line
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public Line(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double GetLengh() 
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }
           

    }
    
    // Родительский класс для прямоугольных фигур
    class SimpleRectangle
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public int x3;
        public int y3;
        public int x4;
        public int y4;

    }
    
     /*Дочерний класс Квадрат, унаследованный от SimpleRectangle, предназначенный для отображения Квадрата, 
    включающий Методы для Рассчета Длины Отрезка и Расчета Площади*/
    class Square : SimpleRectangle
    {
        public Square(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;
        }
        
        public double GetLengh()
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public double GetArea()
        {
            return GetLengh() * GetLengh();
        }
    }
   
    /*Дочерний  класс Прямоугольник, унаследованный от SimpleRectangle, предназначен для отображения фигуры Прямоугольник 
    и включающий Методы для рассчета Длины отрезка и Площади*/
    class Rectangle : SimpleRectangle
    {
        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;

        }
       
        public double GetLenghA()
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public double GetLenghB()
        {
            return Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
        }


        public double GetArea() => GetLenghA() * GetLenghB();
    }
    
    
    /*Класс Треугольник , предназначен для отображения треугольника
    и включает в себя методы по рассчету Длинн отрезков, Полупериметра и Площади треугольника*/
    class Triangle
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public int x3;
        public int y3;
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;

        }

        public double GetLenghA()
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public double GetLenghB()
        {
            return Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
        }

        public double GetLenghC()
        {
            return Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
        }

        public double halfPerimetr()
        {
          return  (GetLenghA() + GetLenghB() + GetLenghC()) / 2;
        }           
                    
        public double GetArea() => Math.Sqrt(halfPerimetr() * (halfPerimetr() - GetLenghA()) * (halfPerimetr() - GetLenghB()) * (halfPerimetr() - GetLenghC()));

    }

}