using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace csharp_pinvoke
{
    public class ArraysWrapper
    {
        [DllImport(@"..\..\..\..\cpp-pinvoke\x64\Debug\cpp-pinvoke")]
        public static extern int fillArrayWithVals(int[] arr, int length);
    }
}
