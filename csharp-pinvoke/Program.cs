using System;
using System.Runtime.InteropServices;

namespace csharp_pinvoke
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SampleWrapper.ReturnHello());
        }
    }
}
