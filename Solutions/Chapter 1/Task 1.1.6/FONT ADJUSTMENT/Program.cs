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
            Underline = 3
        }
        static void Main(string[] args)
        {




            //Переменная в которую пишем значения шрифтов
            Fonts font = 0;


            while (true)
            {
                //Считываем значение с клавиатуры
                String input = Console.ReadLine();
                int a = Int32.Parse(input);

                Console.WriteLine("Параметры надписи: " + input);
                Console.WriteLine();
                Console.WriteLine("Введите: ");
                Console.WriteLine();
                Console.WriteLine("1: bold");
                Console.WriteLine();
                Console.WriteLine("2: italic");
                Console.WriteLine();
                Console.WriteLine("3: underline");
                Console.WriteLine();


                //Производим проверку

                switch (a)
                {
                    case 1:
                        font = Fonts.Bold;
                        break;

                    case 2:
                        font = Fonts.Italic;
                        break;

                    case 3:
                        font = Fonts.Underline;
                        break;

                    default:
                        font = Fonts.None;
                        break;
                }

                Console.Write(font);
                Console.WriteLine();

            }










        }
    }
}
