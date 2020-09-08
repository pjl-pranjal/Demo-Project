using System;
using FirstLib;
using Xunit;

namespace FirstcoreProject
{
    public class Tester {
        
        [Fact]
        public void test1() {
            // var ob = new Class1();
            Assert.Equal(3, Class1.add(1, 2));
        }
    }
}