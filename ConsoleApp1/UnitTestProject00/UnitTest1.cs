using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
namespace UnitTestProject00
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ConsoleApp2.Program calc = new ConsoleApp2.Program();
           int i= ConsoleApp2.Program .alg(2,'*',3);
            if (i == 6)
            {
                int j=ConsoleApp2.Program.alg1(6, '+', 3);
                if(j!=9)
                {
                    Console.WriteLine("´íÎó");
                }

            }
            else
            {
                Console.WriteLine("´íÎó");
            }


        }
    }
}
