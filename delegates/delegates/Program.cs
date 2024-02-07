using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{

    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    internal class practice
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHi(string name)
        {
            return "Hi " + name;
        }
        public static void Main()
        {
            practice p = new practice();
            AddDelegate ap = new AddDelegate(p.AddNums);
            ap.Invoke(150, 20);

            string str = practice.SayHi("Ajay");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
