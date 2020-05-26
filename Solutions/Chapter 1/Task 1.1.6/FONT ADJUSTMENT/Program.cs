using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FONT_ADJUSTMENT
{
    class Program
    {


        //Объявление
        [Flags]
        enum Fonts : byte
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Параметры надписи: None");
            Console.WriteLine();
            Console.WriteLine("Введите: ");
            Console.WriteLine();
            Console.WriteLine("1: bold");
            Console.WriteLine();
            Console.WriteLine("2: italic");
            Console.WriteLine();
            Console.WriteLine("4: underline");
            Console.WriteLine();



            //Переменная в которую пишем значения шрифтов
            Fonts a = 0;



            while (true)
            {
                //Считываем значение с клавиатуры
                int input = Int32.Parse(Console.ReadLine());



                Console.WriteLine();
                Console.WriteLine("Введите: ");
                Console.WriteLine();
                Console.WriteLine("1: bold");
                Console.WriteLine();
                Console.WriteLine("2: italic");
                Console.WriteLine();
                Console.WriteLine("4: underline");
                Console.WriteLine();


                //Производим проверку

                switch (input)
                {
                    case 1:

                        if (a.HasFlag(Fonts.Italic))
                        {
                            a = Fonts.Bold | Fonts.Italic;
                        }
                        else if (a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.Bold | Fonts.Underline;
                        }
                        else if (a.HasFlag(Fonts.Bold))
                        {
                            a = Fonts.None;
                        }
                        else if (a.HasFlag(Fonts.Bold) & a.HasFlag(Fonts.Italic) & a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.Italic | Fonts.Underline;
                        }
                        else if (a.HasFlag(Fonts.Bold) & a.HasFlag(Fonts.Italic))
                        {
                            a = Fonts.Italic;
                        }
                        else if (a.HasFlag(Fonts.Bold) & a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.Underline;
                        }
                        else if (a.HasFlag(Fonts.Italic) & a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.Underline | Fonts.Italic | Fonts.Bold;
                        }


                        else a = Fonts.Bold;
                        break;

                    case 2:

                        if (a.HasFlag(Fonts.Italic))
                        {
                            a = Fonts.None;
                        }
                        else if (a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.Italic | Fonts.Underline;
                        }
                        else if (a.HasFlag(Fonts.Bold))
                        {
                            a = Fonts.Bold | Fonts.Italic;
                        }
                        else if (a.HasFlag(Fonts.Bold) & a.HasFlag(Fonts.Italic) & a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.Bold | Fonts.Underline;
                        }
                        else if (a.HasFlag(Fonts.Bold) & a.HasFlag(Fonts.Italic))
                        {
                            a = Fonts.Bold;
                        }
                        else if (a.HasFlag(Fonts.Bold) & a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.Underline | Fonts.Bold | Fonts.Italic;
                        }
                        else if (a.HasFlag(Fonts.Italic) & a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.Underline;
                        }


                        else a = Fonts.Italic;

                        break;

                    case 4:
                        if (a.HasFlag(Fonts.Italic))
                        {
                            a = Fonts.Italic | Fonts.Underline;
                        }
                        else if (a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.None;
                        }
                        else if (a.HasFlag(Fonts.Bold))
                        {
                            a = Fonts.Bold | Fonts.Underline;
                        }
                        else if (a.HasFlag(Fonts.Bold) & a.HasFlag(Fonts.Italic) & a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.Bold | Fonts.Italic;
                        }
                        else if (a.HasFlag(Fonts.Bold) & a.HasFlag(Fonts.Italic))
                        {
                            a = Fonts.Bold | Fonts.Italic | Fonts.Underline;
                        }
                        else if (a.HasFlag(Fonts.Bold) & a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.Bold;
                        }
                        else if (a.HasFlag(Fonts.Italic) & a.HasFlag(Fonts.Underline))
                        {
                            a = Fonts.Italic;
                        }


                        else a = Fonts.Underline;
                        break;

                    default:
                        a = Fonts.None;
                        break;
                }

                Console.Write("Параметры надписи: ");
                Console.Write(a);
                Console.WriteLine();

            }










        }
    }
}