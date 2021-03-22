using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static void main()
        {
            a a1 = new a();

           a1. show(10, 20);
        }

       
    }
    public class a
    {

        public void show(int a, int b)
        {
            Console.WriteLine("{0}{1}", a, b);
        }

    }
}
