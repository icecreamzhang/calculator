using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Basic
    {
        public string _A;
        public int _x;
        public int _y;
        public int _reslt;
        public bool _are;
        public string A1
        #region 属性
        {
            get { return _A; }
            set { _A = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Reslt
        {
            get { return _reslt; }
            set { _reslt = value; }
        }
        public bool Are
        {
            get { return _are; }
            set { _are = value; }
        }

        #endregion
        public virtual void jia()
        { }
        public virtual void jian()
        { }
        public virtual void cheng()
        { }

        public virtual void chu()
        { }
    }
}
