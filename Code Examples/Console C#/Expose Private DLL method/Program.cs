using System;
using System.Reflection;
using Test_Library;

namespace Expose_Private_DLL_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exposes Private method in Class1 using reflection
            Type m = typeof(Class1);
            object t = Activator.CreateInstance(m);
            MethodInfo PrivateDLLMethodInfo = typeof(Class1).GetMethod("ReturnInt", BindingFlags.NonPublic | BindingFlags.Instance);
            object ExposedMethod = PrivateDLLMethodInfo.Invoke(t, new object[] {});
            Console.Read();
            //All this to print a single line of code

        }
    }
}
