using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYNAMIC_ARRAY
{
    class Program
    {
        delegate void Message(); // 1. ��������� �������

        static void Main(string[] args)
        {
            Message mes; // 2. ������� ���������� ��������
            if (DateTime.Now.Hour < 12)
            {
                mes = GoodMorning; // 3. ����������� ���� ���������� ����� ������
            }
            else
            {
                mes = GoodEvening;
            }
            mes(); // 4. �������� �����
            Console.ReadKey();
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
    }
}
