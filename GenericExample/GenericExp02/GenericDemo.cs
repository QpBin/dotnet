using System;

namespace GenericExp02
{
    public class GenericDemo
    {
    }
    public interface ICustomerListIn<in T>
    {
        //T Get();

        void Show(T t);
    }

    public class CustomerListIn : ICustomerListIn<Object>

    {
        public void Show(object t)
        {
            Console.WriteLine(t.ToString());
        }
    }
}
