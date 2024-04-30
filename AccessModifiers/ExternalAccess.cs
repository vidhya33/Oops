using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessDemoNS;

namespace AccessModifiers
{
    class ExternalAccess : AccessDemo
    {
        AccessDemo demo =  new AccessDemo();
        protected void assignValue()
        {
            /*demo.a = 333;
            Console.WriteLine(demo.a);*/
        }
    }
}
