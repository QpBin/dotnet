using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample01
{
    public class CommonMethod
    {
        public static void ShowInt(int iParam)
        {
            Console.WriteLine($"This is ShowInt, param = {iParam},type={iParam.GetType()}");
        }
        public static void ShowString(string sParam)
        {
            Console.WriteLine($"This is ShowString, param = {sParam},type={sParam.GetType()}");
        }
        public static void ShowDataTime(DateTime dtParam)
        {
            Console.WriteLine($"This is ShowDataTime, param = {dtParam},type={dtParam.GetType()}");
        }

        public static void ShowObject(Object oParam)
        {
            Console.WriteLine($"This is ShowDataTime, param = {oParam},type={oParam.GetType()}");
        }
    }
}
