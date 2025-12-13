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
    }
}