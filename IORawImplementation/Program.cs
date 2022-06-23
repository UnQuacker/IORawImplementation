using System;
using System.Runtime.InteropServices;
using System.Text;

namespace IORawImplementation
{
    class Program
    {
        [DllImport("IORawDll.dll")]
        public static extern IntPtr Create();

        [DllImport("IORawDll.dll")]
        public static extern void TestWrite(IntPtr dll, string path, string data);

        static void Main(string[] args)
        {
            IntPtr dll = Create();
            string path = "C://Users//Alser//Desktop//test1.txt";
            string data = "Raw data test";
            TestWrite(dll, path, data);
        }
    }
}
