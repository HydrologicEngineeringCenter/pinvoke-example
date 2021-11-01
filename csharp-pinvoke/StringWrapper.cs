using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace csharp_pinvoke
{
    class StringWrapper
    {
        [DllImport(@"..\..\..\..\cpp-pinvoke\x64\Debug\cpp-pinvoke")]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string getHelloString(); 


    }
}
