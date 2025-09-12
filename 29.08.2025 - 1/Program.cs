using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _29._08._2025___1
{
    /*public class Father {
        public Father() { 
        }
        public static string FatherReturn()
        {
            return "read newspapers";
        }
    }
    public class Son : Father
    {
        public override string FatherReturn()
        {
            return "read books";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          
        }
    }*/
    public class Math
    {

        public int SumFrom1ToN(int n)
        {
            if (n < 1)
                return 0; // для від’ємних або нульових n сума = 0

            return n * (n + 1) / 2;
        }
    }


    [TestClass]
    public class CalculatorFluentTests
    {
        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            var calculator = new Math();
            var result = calculator.SumFrom1ToN(2);
            result.Should().Be(3, "");

        }
    }




}
