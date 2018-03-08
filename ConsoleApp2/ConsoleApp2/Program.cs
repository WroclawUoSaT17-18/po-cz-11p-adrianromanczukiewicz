using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podac 3 oceny z danych przedmiotów, nastepnie zatwierdzic kazda klawiszem enter");
            Console.WriteLine("Polski:");
            float p = float.Parse(Console.ReadLine());
            Console.WriteLine("Matematyka:");
            float o = float.Parse(Console.ReadLine());
            Console.WriteLine("Wychowanie do życia w rodzinie:");
            float i = float.Parse(Console.ReadLine());
            uczen xxx = new uczen(p, o, i);
            Console.WriteLine(xxx.wartoscsrednia());
            Console.ReadKey();
        }
    }
    class uczen
    {
        public float a;
        public float s;
        public float d;

        public uczen(float stopien1, float stopien2, float stopien3)
        {
            a = stopien1;
            s = stopien2;
            d = stopien3;
        }
        public float wartoscsrednia()
        {
            Console.WriteLine("średni ocen:");
            return ((a + s + d) / 3);
        }
    }
}