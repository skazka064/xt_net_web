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
        static void Main(string[] args)
        {

            
           
       
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
        public double GetLengh() => Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

    }
    // Класс Квадрат, предназначенный для отображения Квадрата, включающий Методы для Рассчета Длины Отрезка и Расчета Площади
    class Square
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public int x3;
        public int y3;
        public int x4;
        public int y4;
        public double GetLengh()
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public double GetArea()
        {
            return GetLengh() * GetLengh();
        }
    }
   
    // класс Прямоугольник, предназначен для отображения фигуры Прямоугольник и включающий Методы для рассцета Длины отрезка и Площади
    class Rectangle
    {
        public int x1;
        public int y1;
        public int x2;
        public int y2;
        public int x3;
        public int y3;
        public int x4;
        public int y4;
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
    
    
   // Класс Треугольник , предназначен для отображения треугольника и включает в себя методы по рассчету Длинн отрезков, Полупериметра и Площади треугольника
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

