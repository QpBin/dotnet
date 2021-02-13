using System;
using System.IO;
using System.Text;

namespace Day01_string
{
    class Program
    {
        static void Main(string[] args)
        {
            //字面值
            string str01 = "Hello";
            //构造器
            string str02 = new string("World");
            char[] chars = { 'c', 's', 'h', 'a', 'r', 'p' };
            string str03 = new string(chars);
            //空字符串
            string str = string.Empty;
            bool result = str == "" || str == string.Empty || str.Length == 0;

            //字符串拼接 +
            string strA = "Qing";
            strA = strA + " Ping";
            Console.WriteLine(strA);

            //StringBuilder 拼接
            StringBuilder strB = new StringBuilder("Qing");
            strB.Append(" Ping");
            Console.WriteLine(strB);

            //string.Format
            string formatStr = string.Format("{0} {1}", "Qing", "Ping");
            Console.WriteLine(formatStr);

            //$  -> vs2015支持 c#6.0语法
            string newStr = $"{str01},{str02}";
            Console.WriteLine(newStr);

            StreamReader sr = new StreamReader(@"/home/xiaobin/xbRepos/dotfiles/README.md");
        }
    }
}

