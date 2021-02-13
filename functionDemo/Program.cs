using System;

namespace functionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

			var outterStu = new Student(){Name="P"};
			System.Console.WriteLine("调用前");
			System.Console.WriteLine($"{outterStu.GetHashCode()} - {outterStu.Name}");
			IwantEffect(ref outterStu);
			System.Console.WriteLine("调用后");
			System.Console.WriteLine($"{outterStu.GetHashCode()} - {outterStu.Name}");



            // var stu =new Student(){Name="Ping"};
            // SomeMethod(stu);
            // System.Console.WriteLine(stu.Name);
            // System.Console.WriteLine(stu.GetHashCode());

            // int y = 1;
            // IwantEffect(ref y);
            // System.Console.WriteLine(y);   //101
        }
        // static void SomeMethod(Student stu){
        // 	stu = new Student();
        // 	stu.Name = "Qing";
        // 	System.Console.WriteLine(stu.GetHashCode());
        // }
        static void IwantEffect(ref Student stu)
        {
            stu = new Student() { Name = "Q" };
            System.Console.WriteLine(stu.GetHashCode());
        }

        // static void IwantEffect(ref int x){
        // 	 x += 100;
        // }

    }
    class Student
    {
        public string Name { get; set; }
    }
}
