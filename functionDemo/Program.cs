using System;

namespace functionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = null;
            if (StudentFactory.Create("Qing Ping",24,out stu))
            {
                Console.WriteLine($"Student : {stu.Name},Age : {stu.Age}");
            }

            int result = Clac(1, 2, 3, 4, 5);
            Console.WriteLine(result);
        }

        static int Clac(params int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }
            return sum;
        }
    }

    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class StudentFactory
    {
        public static bool Create(string stuName, int stuAge,out Student result)
        {
            result = null;
            if (string.IsNullOrEmpty(stuName))
                return false;
            if (stuAge < 20 || stuAge > 80)
                return false;
            result = new Student() {Name = stuName, Age = stuAge};
            return true;
        }
    }
}