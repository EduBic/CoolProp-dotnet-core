using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Test1
{
    class Program
    {
	// Mono works with "libCoolProp", "libCoolProp.so", "CoolProp"
	// .Net Core doesn't work with all
        [DllImport("CoolProp")]
        private static extern double PropsSI(string Output, string Name1, double Prop1, string Name2, double Prop2, string Ref);

        static void Main(string[] args)
        {
            double propsRes = PropsSI("H", "T", 300.0, "Q", 0.0, "R410A");
            Console.WriteLine("Result " + propsRes);
        }
    }
}
