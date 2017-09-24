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
    }
}
