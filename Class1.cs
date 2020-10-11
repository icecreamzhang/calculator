using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Calculator
{
    class Class1:Basic
    {
        
     
        public override void jia()
        {
            //base.jia();
            _reslt = _x + _y;
            Console.WriteLine("x+y=" + _reslt);
            string str1 = _x.ToString();
            string str2 = _y.ToString();
            string str = str1 + str2;
            Console.WriteLine("连接两字符串：" + str);
        }
       
        public override void jian()
        {
            //base.jian();
            _reslt = _x - _y;
            Console.WriteLine("x-y=" + _reslt);
            string  str1= _x.ToString();
            string str2 = _y.ToString();
            string newstr = str1.Replace(str2, "");
            Console.WriteLine("删除后的字符串为：" + newstr);
        }
      public override void cheng()
      {
          _reslt = _x * _y;
          Console.WriteLine("x*y=" + _reslt);
      }
      public override void chu()
      {
          _reslt = _x / _y;
          Console.WriteLine("x/y="+_reslt);
         
      }
      public bool Equals()
      {
          return _are = Equals(_x, _y);

      }
      
    }
}
