using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09TryOut03
{
    class Program
    {
        class MyClass
        {
            public int val;
        }
        struct myStruct
        {
            public int val;
        }
        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            MyClass objectB = objectA;
            objectA.val = 10;
            objectB.val = 20;
            myStruct structA = new myStruct();
            myStruct structB = structA;
            structA.val = 30;
            structB.val = 40;
            Console.WriteLine("ObjectA.val = {0}",objectA.val);
            Console.WriteLine("ObjectB.val = {0}", objectB.val);
            Console.WriteLine("structA.val = {0}", structA.val);
            Console.WriteLine("structB.val = {0}", structB.val);
        }
    }
}
