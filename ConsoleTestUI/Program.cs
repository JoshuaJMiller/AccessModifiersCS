using ZAccessDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Access access = new Access();
            access.SSN = "123-12-1234";
            string SSN = access.SSN;
            Console.WriteLine(SSN);
        }
    }
}
