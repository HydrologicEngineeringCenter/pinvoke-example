using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_pinvoke
{
    
    public class AddWrapper
    {
        [DllImport(@"C:\Projects\pinvoke-example\cpp-pinvoke\x64\Debug\cpp-pinvoke")]
        public static extern int add(int a, int b);
    }
}
