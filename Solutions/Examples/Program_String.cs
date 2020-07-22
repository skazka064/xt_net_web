using System;
using System.Globalization;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = "Hello";

            var temp = " World!";

            var strResult = string.IsInterned(str1 + temp);

            var str2 = "Hello World!";

            Console.WriteLine(object.ReferenceEquals(strResult, str2));
        }
    }

    class CharExamples
    {
        public static void DoSurrogatePairExample()
        {
            var normalSymbol = char.ConvertFromUtf32(0x0041);

            Console.WriteLine("Symbol: {0}, Length: {1}", normalSymbol, normalSymbol.Length);

            var strangeSymbol = char.ConvertFromUtf32(0x14476);

            Console.WriteLine("Symbol: {0}, Length: {1}", strangeSymbol, strangeSymbol.Length);
        }

        public static void DoTurkeyTestExample()
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");

            var symbol = 'i';
            char upperSymbol = char.ToUpper(symbol);

            Console.WriteLine("Symbol: {0}, Code: {1}", upperSymbol, (int)upperSymbol);
            Console.WriteLine("Symbol: {0}, Code: {1}", 'I', (int)'I');
        }

        public static void ShowCharInfo(char c)
        {
            Console.WriteLine("Symbol: {0}:\nCode: {1}, IsLetter: {2}, " +
                "IsNumber: {3}, IsDigid: {4}, IsSymbol: {5}", 
                c, 
                (int)c, 
                char.IsLetter(c), 
                char.IsNumber(c), 
                char.IsDigit(c), 
                char.IsSymbol(c)
            );
        }
    }
}
