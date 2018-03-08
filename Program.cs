using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzienniczek
{
    class Dziennik
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj 3 oceny ,następnie zatwierdź każdą klawiszem enter");
            Console.WriteLine("matematyka:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("historia:");
            float s = float.Parse(Console.ReadLine());
            Console.WriteLine("wychowanie do życia w rodzinie");
            float d = float.Parse(Console.ReadLine());
            uczen xxx = new uczen(a, s, d);
            Console.WriteLine(xxx.wartoscsrednia());
            Console.ReadKey();
        }
    }
}
class uczen
{
    public float z;
    public float x;
    public float c;

    public uczen(float stopien1, float stopien2, float stopien3)
    {
        z = stopien1;
        x = stopien2;
        c = stopien3;
    }
    public float wartoscsrednia()
    {
        Console.WriteLine("średnia ocen:");
        return ((z + x + c) / 3);
    }
}