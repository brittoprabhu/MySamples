using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass<int> intObj = new TestClass<int>();
            intObj.Add(1);
            intObj.Add(2);

            for  (int i=0; i<2; i++)
            {
                Console.WriteLine(intObj[i]);

            }

            TestClass<string> strobj = new TestClass<string>();
            strobj.Add("Arul");
            strobj.Add("Britto");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(strobj[i]);

            }


            Console.ReadKey();
        }
    }
}
