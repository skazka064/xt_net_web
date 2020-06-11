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
            /*Act act = Act.Добавить_фигуру;
            Array enumData = Enum.GetValues(act.GetType());
            Console.WriteLine("Выберите действие");
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine($"{enumData.GetValue(i):D}.{enumData.GetValue(i)}");
            }*/


            Console.WriteLine("Выберите действие");
            Console.WriteLine("1. Добавить фигуру");
            Console.WriteLine("2. Вывести фигуры");
            Console.WriteLine("3. Очистить холст");
            Console.WriteLine("4. Выход");

            var str = Console.ReadLine();
            var actType = (byte)Enum.Parse(typeof(Act),  str);
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
                            int x1 = Int32.Parse(Console.ReadLine()) ;
                            Console.WriteLine("Введите координаты y1");
                            int y1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Введите координаты x2");
                            int x2 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Введите координаты y2");
                            int y2 = Int32.Parse(Console.ReadLine());
                            Line l = new Line(x1,y1,x2,y2);
                             Console.WriteLine(l.GetLengh());
                            Console.WriteLine("Фигура Линия создана");
                            
                           
                            break;
                    }
                    
                    
                    break;

                    
            }


            /*Console.WriteLine("***********Func with Enum ***********");
            Act act = Act.Добавить_фигуру;
            Console.WriteLine($"Вы выбрали имя переменной перечисления: {act.ToString()} ");
            
            Console.WriteLine($"Значение переменной перечисления: {(byte)act}") ;
            Console.WriteLine($"Тип данных : {Enum.GetUnderlyingType(act.GetType())}");
            Console.WriteLine($"Информация о: {act.GetType().Name}");
            Array enumData = Enum.GetValues(act.GetType());
            Console.WriteLine($"Это перечисление имеет {enumData.Length} члена");
            for(int i=0; i<enumData.Length; i++)
            {
                Console.WriteLine($"Имя: {enumData.GetValue(i)} Значение: {enumData.GetValue(i):D}"); 
            }*/
            /*Circle circle = new Circle();
            circle.x = 1;
            circle.y = 1;
            circle.radius = 11;
            Console.WriteLine(circle.GetArea());*/

            /*int x = 5;
            object obj = x;
            Type t = obj.GetType();
            if (obj.Equals(x))
            {
                Console.WriteLine("eq");
            }
            Console.ReadLine();*/

        }
    }
   
    class MenuAct
    {


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
        public double GetArea() => Math.PI * radius * radius;
        public double GetСircumscribedСircle() => 2 * Math.PI * radius;

    }

    // Дочерний класс Кольцо, унаследованный от Просто круглого предмета
    class Ring : RoundShape
    {
        public int innerRadius;
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

