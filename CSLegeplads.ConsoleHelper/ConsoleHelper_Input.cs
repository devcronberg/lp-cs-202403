using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSLegeplads.ConsoleHelper
{    
    public static class ConsoleInputHelper
    {
        public static int GetInt(string optionalArgument, int optionalValue, bool promptUser = false)
        {
            return UserInput<int>(OperationType.Integer, optionalArgument, optionalValue.ToString(), promptUser);                   
        }
        public static int GetInt(int optionalValue)
        {
            return GetInt("Input number", optionalValue, false);
        }
        public static int GetInt(string optionalArgument)
        {
            return GetInt(optionalArgument, 0, true);
        }
        public static int GetInt()
        {
            return GetInt("Input number", 0, true);
        }


        public static double GetDouble(string optionalArgument, double optionalValue, bool promptUser = false)
        {            
            return UserInput<double>(OperationType.Double, optionalArgument, optionalValue.ToString(), promptUser);             
        }
        public static double GetDouble(double optionalValue)
        {
            return GetDouble("Input number", optionalValue, false);
        }
        public static double GetDouble(string optionalArgument)
        {
            return GetDouble(optionalArgument, 0, true);
        }
        public static double GetDouble()
        {
            return GetDouble("Input number", 0, true);
        }


        public static bool GetBool(string optionalArgument, bool optionalValue, bool promptUser = false)
        {
            return UserInput<bool>(OperationType.Boolean, optionalArgument, optionalValue.ToString(), promptUser);            
        }
        public static bool GetBool(bool optionalValue)
        {
            return GetBool("Input true or false", optionalValue, false);
        }
        public static bool GetBool(string optionalArgument)
        {
            return GetBool(optionalArgument,false, true);
        }
        public static bool GetBool()
        {
            return GetBool("Input true or false", false, true);
        }


        public static DateTime GetDateTime(string optionalArgument, DateTime optionalValue, bool promptUser = false)
        {            
            return UserInput<DateTime>(OperationType.Date, optionalArgument, optionalValue.ToString(), promptUser);
        }
        public static DateTime GetDateTime(DateTime optionalValue)
        {
            return GetDateTime("Input DateTime", optionalValue, false);
        }
        public static DateTime GetDateTime(string optionalArgument)
        {
            return GetDateTime(optionalArgument, default, true);
        }
        public static DateTime GetDateTime()
        {
            return GetDateTime("Input DateTime", DateTime.MinValue, true);
        }
       
        private static T UserInput<T>(OperationType operation, string optionalArgument, string optionalValue, bool promptUser )
        {          
            Console.WriteLine($"Please {optionalArgument} {operation}:");

            string userInput;

            if (!promptUser) { userInput = optionalValue; }
            else { userInput = Console.ReadLine(); }

            if(string.IsNullOrEmpty(userInput))
            {
                return default;
            }

            try
            {
                switch (operation)
                {
                    case OperationType.Integer:
                        int i = Convert.ToInt32(userInput);
                        return (T)(object)i;

                    case OperationType.Double:
                        if (userInput.Contains(".")) { userInput = userInput.Replace('.', ','); }
                        double d = Convert.ToDouble(userInput);
                        return (T)(object)d;

                    case OperationType.Boolean:
                        if (userInput == "1") { userInput = "True"; }
                        if (userInput == "0") { userInput = "False"; }
                        bool b = Convert.ToBoolean(userInput);
                        return (T)(object)b;

                    case OperationType.Date:
                        DateTime dt = Convert.ToDateTime(userInput);
                        return (T)(object)dt;
                    default:
                        throw new ConsoleInputException("Invalid operation type");
                }
            }            
            catch(Exception ex)
            {
                throw new ConsoleInputException("Program ran into a problem: ", ex);
            }            
        }

        enum OperationType
        {
            Integer,
            Double,
            Boolean,
            Date,
        }
    }
    public class ConsoleInputException : Exception 
    { 
        public ConsoleInputException() 
        { 

        }
        public ConsoleInputException(string msg) : base(msg)
        {

        }
        public ConsoleInputException(string msg, Exception inner): base(msg, inner)
        {

        }
    }
}
