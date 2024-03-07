using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLegeplads.ConsoleInputHelper
{
    public static class ConsoleInputHelper
    {

        public static int GetInt(String prompt, int default_value)
        {
            try
            {
                Console.WriteLine(prompt);
                String input = Console.ReadLine();

                if (input == null || input.Trim().Length == 0)
                {
                    return default_value;
                }

                return Int32.Parse(input);
            }
            catch (Exception ex)
            {
                ConsoleInputException consoleInputException = new ConsoleInputException("Input error!", ex);
                throw consoleInputException;
            }
        }

        public static double GetDouble(String prompt, double default_value)
        {
            try
            {
                Console.WriteLine(prompt);

                String input = Console.ReadLine();

                if (input == null || input.Trim().Length == 0)
                {
                    return default_value;
                }

                return Double.Parse(input);
            }
            catch (Exception ex)
            {
                ConsoleInputException consoleInputException = new ConsoleInputException("Input error!", ex);
                throw consoleInputException;
            }
        }


        public static bool GetBool(String prompt, bool default_value)
        {
            try
            {
                Console.WriteLine(prompt);

                String input = Console.ReadLine();

                if (input == null || input.Trim().Length == 0)
                {
                    return default_value;
                }

                return Boolean.Parse(input);
            }
            catch (Exception ex)
            {
                ConsoleInputException consoleInputException = new ConsoleInputException("Input error!", ex);
                throw consoleInputException;
            }
        }


        public static DateTime GetDateTime(String prompt, DateTime default_value)
        {
            try
            {
                Console.WriteLine(prompt);

                String input = Console.ReadLine();

                if (input == null || input.Trim().Length == 0)
                {
                    return default_value;
                }

                return DateTime.Parse(input);
            }
            catch (Exception ex)
            {
                ConsoleInputException consoleInputException = new ConsoleInputException("Input error!", ex);
                throw consoleInputException;
            }
        }
    }
}
