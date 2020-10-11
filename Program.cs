using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cla=new Class1();
            Console.WriteLine("请输入第一个数");
          
            cla._x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数");
            cla._y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入要进行的运算:+,-,*,/");
         
            cla._A = Console.ReadLine();
            if (cla._A == "+")
                cla.jia();
                

            else if (cla._A == "-")
                cla.jian();

            else if (cla._A == "*")
                cla.cheng();

            else if (cla._A == "/")
                cla.chu();

            else
                Console.WriteLine("您的输入有误");
           
           if( Class1.Equals(cla._x,cla._y))
               Console.WriteLine("两个数相等");
           else
               Console.WriteLine("两个数不相等");
//if(cla._are==false)
//    Console.WriteLine("两个数不相等");
//else
//    Console.WriteLine("两个数相等");

        }
    }
}
