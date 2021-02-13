using System;

namespace typeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型:结构 。内置的数值类型是结构，它们具有可访问的字段和方法
            byte b = byte.MaxValue;
            // [bool,sbyte,byte,short,ushort,int,uint,long,ulong,char,float,double,decimal] 
            Console.WriteLine(b);
            MyClass mc = new MyClass();
            MyClass mc2 = mc;

            // Declare and initialize an array of integers.
            int[] nums = { 1, 2, 3, 4, 5 };

            // Access an instance property of System.Array.
            int len = nums.Length;

            B bbb = new B();
            A a = bbb;

            Console.WriteLine($"a is B ? {a is B}"); 
            Console.WriteLine($"a is A ? {a is A}");
            Console.WriteLine($"a is C ? {a is C}");

            //Convert 示例代码
            long lval = 19293;
            var i = Convert.ToInt32(lval);
            double d = 10.091;
            var dc = Convert.ToDecimal(d);
            var dt = Convert.ToDateTime("2019-03-30");

        }
    }
    class MyClass
    {
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
    }
    class A
    {
    }
    class B : A
    {
    }
    class C : A
    {
    }
}

