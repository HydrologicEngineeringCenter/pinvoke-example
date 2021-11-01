using System;
using System.Runtime.InteropServices;

namespace csharp_pinvoke
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddWrapper.add(1, 2));
            Console.WriteLine(StringWrapper.getHelloString());
        }
    }
}
