using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class Class1
    {
        public string test()
        {
            return new dal.Class1().test();
        }

        public string HelloWorld()
        {
            return new dal.Class1().HelloWorld();
        }
        public string Add()
        {
            return new dal.Class1().Add();
        }

        public string Add2()
        {
            return new dal.Class1().Add2();
        }
    }
}
