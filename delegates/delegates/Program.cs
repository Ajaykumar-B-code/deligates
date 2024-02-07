using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate void Rectangledelegate(int a ,int b);
    internal class practice
    {
        public void getArea(int a, int b)
        {
            Console.WriteLine($"area: {a + b}");
        }
        public void perimeter(int l, int b)
        {
            Console.WriteLine($"rectangle: {2*(l+b)}");
        }
        public static void Main()
        {
            practice p = new practice();
            Rectangledelegate rect =p.getArea;
            rect += p.perimeter;
            rect(45, 25);
            Console.ReadLine();
        }
    }
}
