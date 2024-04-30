using AccessModifiers;
using System;


namespace AccessDemoNS
{
    public class AccessDemo
    {
        protected int a = 150;
        protected void dis()
        {
            Console.WriteLine(a);
        }
    }

    class Demo : ExternalAccess
    {
        static void Main(string[] ss)
        {
            /*AccessDemo ob = new AccessDemo();
            ob.a = 15;0.
            ob.dis();*/
            /*ExternalAccess externalAccess = new ExternalAccess();
            externalAccess.assignValue();*/
            Demo demo = new Demo();
            demo.assignValue();

        }
    }
}