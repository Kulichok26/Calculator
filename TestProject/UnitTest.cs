using Calculator;
using System.Diagnostics.CodeAnalysis;

namespace TestProject
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            string a = "3";
            string b = "4";
            string expected = "7";
            string actual = Calculate.main(a, b, "+").ToString();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test2()
        {
            string a = "3";
            string b = "4";
            string expected = "-1";
            string actual = Calculate.main(a, b, "-").ToString();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test3()
        {
            string a = "3";
            string b = "4";
            string expected = "12";
            string actual = Calculate.main(a, b, "*").ToString();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test4()
        {
            string a = "4";
            string b = "4";
            string expected = "1";
            string actual = Calculate.main(a, b, "/").ToString();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Test5()
        {
            string a = "5";
            string b = "4";
            string expected = "1";
            string actual = Calculate.main(a, b, "r").ToString();
            Assert.Equal(expected, actual);
        }

    }
}