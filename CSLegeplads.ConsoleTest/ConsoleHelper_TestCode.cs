using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CSLegeplads.ConsoleHelper
{
    public static class ConsoleHelper_Input_Test
    {
        public static void RunTest()
        {
            int i = ConsoleInputHelper.GetInt();
            Console.WriteLine(i);
            i = ConsoleInputHelper.GetInt("Input Number", 100);
            Console.WriteLine(i);

            double d = ConsoleInputHelper.GetDouble();
            Console.WriteLine(d);
            d = ConsoleInputHelper.GetDouble("Input Number");
            Console.WriteLine(d);

            bool b = ConsoleInputHelper.GetBool();
            Console.WriteLine(b);
            b = ConsoleInputHelper.GetBool("Input Right or Wrong", true);
            Console.WriteLine(b);

            DateTime dt = ConsoleInputHelper.GetDateTime();
            Console.WriteLine(dt);
            dt = ConsoleInputHelper.GetDateTime(DateTime.Now);
            Console.WriteLine(dt);

        }
        
    }
}
