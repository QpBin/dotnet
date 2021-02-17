using System;
using System.Collections.Generic;

namespace ReflectDemo
{
    class Program
    {
        public static int StaticSum(int a, int b)   {
            return a + b;
        }

        public int InstanceSum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Qing q = new Qing();
            Ping p = new Ping();
            //获取类型
            Type t = p.GetType();
            //获取字段
            foreach (var v in t.GetFields())
            {
                Console.WriteLine(v.Name);
            }
            //获取属性
            foreach (var v in t.GetProperties())
            {
                Console.WriteLine(v.Name);
            }
            //实例化
            var qInstance = (Qing)Activator.CreateInstance(q.GetType());
            qInstance.Id = 5;

            var qInstance1 = q.GetType().GetConstructor(new[] {typeof(int)});
            var obj = (Qing)qInstance1.Invoke(new object[]{5});
            Console.WriteLine(obj.Id);
            
            Type closed = typeof(List<int>);
            Type unBound = typeof(List<>);

            //转换
            var newClosed = unBound.MakeGenericType(typeof(int));
            var newUnBound = closed.GetGenericTypeDefinition();

            Console.WriteLine($"List<int> 类型{closed}");
            Console.WriteLine($"List<> 类型{unBound}");
            Console.WriteLine($"List<> MakeGenericType执行后 类型{newClosed}");
            Console.WriteLine($"List<int> GetGenericTypeDefinition执行后 类型{newUnBound}");
            
            //静态方法的委托
            Delegate staticD = Delegate.CreateDelegate(typeof(delegateOperate), typeof(Program),"StaticSum");
            //实例方法的委托
            Delegate instanceD = Delegate.CreateDelegate(typeof(delegateOperate), new Program(), "InstanceSum");
        
            Console.WriteLine($"staticD：{staticD.DynamicInvoke(1,2)}");
            Console.WriteLine($"instanceD：{instanceD.DynamicInvoke(10,20)}");

        }
        //创建一个委托
        delegate int delegateOperate(int a, int b);
    }

    class Qing 
    {
        public Qing()
        {
            
        }
        public Qing(int id)
        {
            this.Id = id;
        }
        public int Id { get; set; }
        private string NickName;
    }

    class Ping : Qing , IRead
    {
        public string Name { get; set; }
        public void Read()
        {
            Console.WriteLine("Ping is reading");
        }
        public class Yixue
        {
            public int Age { get; set; }
        }
    }

    public interface IRead
    {
        void Read();
    }
        
}
