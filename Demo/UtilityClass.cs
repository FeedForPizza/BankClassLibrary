using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    static class UtilityClass
    {
        public static string ReadTextInput(string aMessage)
        {
            string returnValue;
            Console.WriteLine(aMessage);
            returnValue = Console.ReadLine();
            return returnValue;
        }
        public static void ReadTextInput(string aMessage, ref string aReturnValue)
        {
            aReturnValue = ReadTextInput(aMessage);
        }
        public static int ReadNumberInput(string aMessage)
        {
            int returnValue;
            Console.WriteLine(aMessage);
            returnValue = Convert.ToInt32(Console.ReadLine());
            return returnValue;
        }
        public static void ReadNumberText(string aMessage, ref int aReturnValue)
        {
            aReturnValue = ReadNumberInput(aMessage);
        }
        public static void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
