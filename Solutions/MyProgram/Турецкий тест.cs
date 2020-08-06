using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            var normalSymbol = char.ConvertFromUtf32(0x14476) ;
            
            Console.WriteLine("Symbol: {0}, Length: {1}",normalSymbol,normalSymbol.Length);
            Console.WriteLine((int)'\n');
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("\a");
            ShowCharInfo('I');
            DoTurkeyTestExample();
        }
        public static void ShowCharInfo(char c)
        {
            Console.WriteLine("Symbol: {0}\n Code: {1}, IsLetter: {2}, IsNumber: {3}, IsDigit: {4}, IsSymbol: {5}",
                c,
                (int)c,
                char.IsLetter(c),
                char.IsNumber(c),
                char.IsDigit(c),
                char.IsSymbol(c));
        }
        public static void DoTurkeyTestExample()
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("tr-TR");
            var symbol = 'i';
            char upperSymbol = char.ToUpper(symbol);
            Console.WriteLine("Symbol: {0}, Code: {1}", upperSymbol, (int)upperSymbol);
            Console.WriteLine("Symbol: {0}, Code: {1}",'I', (int)'I');
            Console.WriteLine(upperSymbol=='I');

        }
    }
}