using System;
using System.Collections.Generic;

namespace listDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>(); // 初始化一个空的列表
            List<string> strList = new List<string>{"Q", "P"}; //初始化一个包含两个元素的列表
            List<string> list = new List<string>(100); // 初始化空列表，指定容量为100
            string[] strArr = new[] {"a", "b", "c"};
            List<string> listArr = new List<string>(strArr); // 使用一个List/Array 初始化一个列表

            int listCount = listArr.Count;  //3
            string str = strList[1];  //P
            
            intList.Add(8888);
            strList.AddRange(strArr);
        }
    }
    
}
