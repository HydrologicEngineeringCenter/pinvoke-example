using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace csharp_pinvoke
{
    public class ExampleClassWrapper
    {
        private IntPtr ExampleClassObject;
        [DllImport(@"..\..\..\..\cpp-pinvoke\x64\Debug\cpp-pinvoke")]
        private static extern IntPtr createExampleClass(int num, string word, int[] nums);
        [DllImport(@"..\..\..\..\cpp-pinvoke\x64\Debug\cpp-pinvoke")]
        private static extern int getNum(IntPtr ec);
        [DllImport(@"..\..\..\..\cpp-pinvoke\x64\Debug\cpp-pinvoke")]
        [return: MarshalAs(UnmanagedType.BStr)]
        private static extern string getWord(IntPtr ec);
        [DllImport(@"..\..\..\..\cpp-pinvoke\x64\Debug\cpp-pinvoke")]
        private static extern int[] getNums(IntPtr ec);

        public int Num 
        {
            get
            {
                return getNum(ExampleClassObject);
            } 
        }
        public string Word 
        { 
            get
            {
                return getWord(ExampleClassObject);
            }
        }
        public int[] Nums 
        {
            get
            {
                return getNums(ExampleClassObject);
            }
        }


        public ExampleClassWrapper(int num, string word, int[] nums)
        {
            ExampleClassObject = createExampleClass(num, word, nums);
        }
    }
}
