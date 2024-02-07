using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    public delegate string GreetingsDelegate(string name);
    internal class practice
    {
       
        public static void Main()
        {
            GreetingsDelegate obj = delegate (string name)
            {
                return "hi " + name + " good morninig";
            };
            string str = obj("Ajay");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
