using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.UserInteraface
{
    class Conversion
    {
        public static void Demo()
        {
            //long l = 1234567890123;
            //int a = checked((int)l); //10100101010001000100....
            //int a = unchecked((int)l); //10100101010001000100....

            //long l = 123456;
            //int a = Convert.ToInt32(l);
            //Console.WriteLine(a);

            //castong doesn't work between tyeps of two completely different nature (Rt and VT)
            string value = "100";
            //int x = (int)value;
            //int x = value as int;
            //int x = Convert.ToInt32(value);

            int x = int.Parse(value);
            Console.WriteLine(x);
        }
    }
}
