using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExp02
{
    class Program
    {
        static void Main(string[] args)
        {
            Brid b1 = new Brid();
            Brid b2 = new Sparrow();
            Sparrow s1 = new Sparrow();

            List<Brid> listBrid1 = new List<Brid>();
            //List<Brid> listBrid2 = new List<Sparrow>();  //  他们没有继承关系。根本无关

            // 协变 out  修饰返回值 
            // 左边是父类，右边是父类或者子类
            //  泛型T 只能做返回值 。 返回的肯定父类
            //ICustomerListOut<Brid> iBrid1 = new CustomerListOut<Brid>();
            //ICustomerListOut<Brid> iBrid2 = new CustomerListOut<Sparrow>();  // out  修饰返回值 


            // 逆变 in  修饰参数
            // 左边是子类，右边是父类或者子类
            // 泛型T 只能做参数
            ICustomerListIn<Sparrow> iList1 = new CustomerListIn();

            ICustomerListIn<Brid> brid = new CustomerListIn();
            ICustomerListIn<Sparrow> iList2 = brid;
        }
    }
    public class Brid
    {
        public int Id { get; set; }
    }
    public class Sparrow : Brid {
        public string  Name { get; set; }
    }

}
