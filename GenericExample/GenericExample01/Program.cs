using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample01
{
    // 泛型 -->  泛型方法, 泛型类, 泛型接口, 泛型委托, 泛型集合
    class Program
    {
        static void Main(string[] args)
        {
            int iValue = 222;
            string sValue = "ABC";
            DateTime dtValue = DateTime.Now;
            CommonMethod.ShowInt(iValue);
            CommonMethod.ShowString(sValue);
            CommonMethod.ShowDataTime(dtValue);

            Console.WriteLine("--------Obiect会装箱拆箱，有性能损耗--------");
            Console.WriteLine("--------Obiect有类型安全问题--------");
            CommonMethod.ShowObject(iValue);
            CommonMethod.ShowObject(dtValue);

            Console.WriteLine("--------Generic方法 --------");
            // 调用时，一般要指定类型参数，类型参数与参数类型要吻合
            //GenericMethod.Show<int>(iValue);
            //GenericMethod.Show<string>(sValue);
            //GenericMethod.Show<DateTime>(dtValue);

            // 编译器 --> 遇到泛型生成占位符
            // CLR  --> 调用时，类型确定了 JIT 生成确定类型的代码
            // 等同于原生代码

            // 泛型的默认值
            GenericMethod.Zap(new int[] { 1, 2 });


            //协变与逆变

            // 直接声明Animal类
            Animal animal = new Animal();
            // 直接声明Cat类
            Cat cat = new Cat();
            // 声明子类对象指向父类
            Animal animal2 = new Cat();
            // 声明Animal类的集合
            List<Animal> listAnimal = new List<Animal>();
            // 声明Cat类的集合
            List<Cat> listCat = new List<Cat>();

            //List<Animal> animal3 = new List<Car>();
            IEnumerable<Animal> List1 = new List<Animal>();
            IEnumerable<Animal> List2 = new List<Cat>();
        }
    }
}
