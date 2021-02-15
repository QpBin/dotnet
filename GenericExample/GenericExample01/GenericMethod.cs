using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample01
{
    public class GenericMethod
    {
        public static void Show<T>(T tParam) where T : Person, IRun, ISay, new()
        {
            Console.WriteLine($"This is Generic Show, param ={tParam},type ={tParam.GetType()}");
        }
        public static void Zap<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = default(T);
                Console.WriteLine(array[i]);
            }
        }

    }
    public interface ICustomerListIn<in T>
    {
        void Show(T t);
    }

    public class CustomerListIn<T> : ICustomerListIn<T>
    {
        public void Show(T t)
        {
        }
    }
    public class Animal
    {
        public int Id { get; set; }
    }
    public class Cat : Animal
    {
        public string Name { get; set; }
    }

    public class Person
    {
        public int Age { get; set; }
    }
    public interface IRun
    {
        void Run();
    }
    public interface ISay
    {
        void Say();
    }

}
