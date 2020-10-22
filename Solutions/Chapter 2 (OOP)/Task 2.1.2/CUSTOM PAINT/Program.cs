using System;
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
          
            // ********************Создаем List для размещения созданных фигур
            List<Line> myLine = new List<Line>();
            List<Square> mySquare = new List<Square>();
            List<Rectangle> myRectangle = new List<Rectangle>();
            List<Triangle> myTriangle = new List<Triangle>();
            List<Circle> myCircle = new List<Circle>();
            List<Ring> myRing = new List<Ring>();
            
            //******************** Создаем меню
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
                        //************** Вывести фигуры

                        if (myLine.Count > 0)
                        {                            
                         foreach (Line l in myLine)
                            {
                                Console.WriteLine("Фигура Линия");
                                Console.WriteLine($" X1 = {l.X1}");
                                Console.WriteLine($" Y1 = {l.Y1}");
                                Console.WriteLine($" X2 = {l.X2}");
                                Console.WriteLine($" Y2 = {l.Y2}");
                                Console.WriteLine($"Длина Линии = {l.GetLengh()}");
                             }
                        }
                        if (mySquare.Count > 0)
                        {
                            foreach(Square sq in mySquare)
                            {
                                Console.WriteLine("Фигура Квадрат");
                                Console.WriteLine($" X1 = {sq.X1}");
                                Console.WriteLine($" Y1 = {sq.Y1}");
                                Console.WriteLine($" X2 = {sq.X2}");
                                Console.WriteLine($" Y2 = {sq.Y2}");
                                Console.WriteLine($" X3 = {sq.X3}");
                                Console.WriteLine($" Y3 = {sq.Y3}");
                                Console.WriteLine($" X4 = {sq.X4}");
                                Console.WriteLine($" Y4 = {sq.Y4}");
                                Console.WriteLine($" Площадь = {sq.GetArea() }");

                            }
                        }
                        if (myRectangle.Count > 0)
                        {
                            foreach (Rectangle rc in myRectangle)
                            {
                                Console.WriteLine("Фигура Прямоугольник");
                                Console.WriteLine($" X1 = {rc.X1}");
                                Console.WriteLine($" Y1 = {rc.Y1}");
                                Console.WriteLine($" X2 = {rc.X2}");
                                Console.WriteLine($" Y2 = {rc.Y2}");
                                Console.WriteLine($" X3 = {rc.X3}");
                                Console.WriteLine($" Y3 = {rc.Y3}");
                                Console.WriteLine($" X4 = {rc.X4}");
                                Console.WriteLine($" Y4 = {rc.Y4}");
                                Console.WriteLine($" Площадь = {rc.GetArea()}");

                            }
                        }
                        if (myTriangle.Count > 0)
                        {
                            foreach (Triangle tri in myTriangle)
                            {
                                Console.WriteLine("Фигура Треугольник");
                                Console.WriteLine($" X1 = {tri.X1}");
                                Console.WriteLine($" Y1 = {tri.Y1}");
                                Console.WriteLine($" X2 = {tri.X2}");
                                Console.WriteLine($" Y2 = {tri.Y2}");
                                Console.WriteLine($" X3 = {tri.X3}");
                                Console.WriteLine($" Y3 = {tri.Y3}");
                                Console.WriteLine($" Длина А = {tri.GetLenghA()}");
                                Console.WriteLine($" Длина В = {tri.GetLenghB()}");
                                Console.WriteLine($" Длина С = {tri.GetLenghC()}");
                                Console.WriteLine($" Полупериметр = {tri.halfPerimetr()}");
                               Console.WriteLine($" Площадь = {tri.GetArea()}");
                            }
                        }

                        if (myCircle.Count > 0)
                        {
                            foreach (Circle cir in myCircle)
                            {
                                Console.WriteLine("Фигура Круг");
                                Console.WriteLine($" X = {cir.X1}");
                                Console.WriteLine($" Y = {cir.Y1}");
                                Console.WriteLine($" Радиус = {cir.outerRadius}");
                                Console.WriteLine($" Площадь = {cir.GetArea()}");
                                Console.WriteLine($" Длина окружности  = {cir.GetСircumscribedСircle()}");
                            }
                        }

                        if (myRing.Count > 0)
                        {
                            foreach (Ring rin in myRing)
                            {
                                Console.WriteLine("Фигура Кольцо");
                                Console.WriteLine($" X = {rin.X1}");
                                Console.WriteLine($" Y = {rin.Y1}");
                                Console.WriteLine($" OuterRadius = {rin.outerRadius}");
                                Console.WriteLine($" InnerRadius = {rin.innerRadius}");
                                Console.WriteLine($" Площадь =  {rin.GetArea()}");
                            }
                        }



                        break;

                    case 3:

                        //****************Очищаем Холст
                        myLine.Clear();
                        mySquare.Clear();
                        myRectangle.Clear();
                        myTriangle.Clear();
                        myCircle.Clear();
                        myRing.Clear();
                        break;

                    //***************** Выход
                    case 4:

                        i = 1;

                        break; 
                }
            }
        }

    }
   
    // *********************************Родительский абстрактный класс "простая Фигура"
    abstract class SimpleFigure
    {
        private int _x1;
        public int X1
        {
            get { return _x1; }
            set { _x1 = value; }
        }

        private int _y1;
        public int Y1
        {
            get { return _y1; }
            set { _y1 = value; }
        }

        private int _x2;
        public int X2
        {
            get { return _x2; }
            set { _x2 = value; }
        }

        private int _y2;
        public int Y2
        {
            get { return _y2; }
            set { _y2 = value; }
        }

        private int _x3;
        public int X3
        {
            get { return _x3; }
            set { _x3 = value; }
        }

        private int _y3;
        public int Y3
        {
            get { return _y3; }
            set { _y3 = value; }
        }

        private int _x4;
        public int X4
        {
            get { return _x4; }
            set { _x4 = value; }
        }

        private int _y4;
        public int Y4
        {
            get { return _y4; }
            set { _y4 = value; }
        }
       
        private int _inner_radius;
        public int innerRadius
        {
            get { return _inner_radius; }
            set
            {
                if (value <= 0) throw new ArgumentException("Радиус должен быть позитивным");
                _inner_radius = value;
            }
        }
        private int _outer_radius;
        public int outerRadius
        {
            get { return _outer_radius; }
            set 
            {
                if (value <= 0) throw new ArgumentException("Радиус должен быть позитивным");
                _outer_radius = value; 
            }
        }



    }
    

    // **********************************Дочерний класс Круг, унаследованнный от "Просто круглого предмета"
    class Circle : SimpleFigure
    {
        public Circle(int x, int y, int outR)
        {
            X1 = x;
            Y1 = y;
            outerRadius = outR;
        }
        public double GetArea() => Math.PI * outerRadius * outerRadius;
        public double GetСircumscribedСircle() => 2 * Math.PI * outerRadius;

    }

    // **********************************Дочерний класс Кольцо, унаследованный от "Просто круглого предмета"
    class Ring : SimpleFigure
    {
       
        public Ring(int x, int y, int outR, int innerR)
        {
            X1 = x;
            Y1 = y;
            outerRadius = outR;
            innerRadius = innerR;
            if(innerRadius>= outerRadius) throw new ArgumentException("Внутренний радиус не должен быть больше или равен внешнему радиусу!");

        }
        
        public double GetArea() => Math.PI * (outerRadius * outerRadius - innerRadius * innerRadius);

        public double GetTotalLenght() => (2 * Math.PI * outerRadius) + (2 * Math.PI * innerRadius);
    } 

    //******************************* Класс Линия, предназначенный для рисования Линии с Методом Подсчет длины отрезка
    class Line : SimpleFigure
    { 
        
        public Line(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public double GetLengh() 
        {
            return Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        }
           

    }

   
    
     /************************************Дочерний класс Квадрат, унаследованный от SimpleRectangle, предназначенный для отображения Квадрата, 
    включающий Методы для Рассчета Длины Отрезка и Расчета Площади*/
    class Square : SimpleFigure
    {
        public Square(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;
        }
        
        public double GetLengh()
        {
            return Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        }

        public double GetArea()
        {
            return GetLengh() * GetLengh();
        }
    }
   
    /********************************Дочерний  класс Прямоугольник, унаследованный от SimpleRectangle, предназначен для отображения фигуры Прямоугольник 
    и включающий Методы для рассчета Длины отрезка и Площади*/
    class Rectangle : SimpleFigure
    {
        public Rectangle(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
            X4 = x4;
            Y4 = y4;

        }
       
        public double GetLenghA()
        {
            return Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        }

        public double GetLenghB()
        {
            return Math.Sqrt(Math.Pow((X4 - X3), 2) + Math.Pow((Y4 - Y3), 2));
        }


        public double GetArea() => GetLenghA() * GetLenghB();
    }
    
    
    /************************************Класс Треугольник , предназначен для отображения треугольника
    и включает в себя методы по рассчету Длинн отрезков, Полупериметра и Площади треугольника*/
    class Triangle : SimpleFigure
    {           
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;

        }

        public double GetLenghA()
        {
            return Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
        }

        public double GetLenghB()
        {
            return Math.Sqrt(Math.Pow((X2 - X3), 2) + Math.Pow((Y2 - Y3), 2));
        }

        public double GetLenghC()
        {
            return Math.Sqrt(Math.Pow((X3 - X1), 2) + Math.Pow((Y3 - Y1), 2));
        }

        public double halfPerimetr()
        {
          return  (GetLenghA() + GetLenghB() + GetLenghC()) / 2;
        }           
                    
        public double GetArea()
        {

            return Math.Sqrt(halfPerimetr() * (halfPerimetr() - GetLenghA()) * (halfPerimetr() - GetLenghB()) * (halfPerimetr() - GetLenghC()));

        }
            

    }

}