using System;
using Xunit;
using playground;

namespace PlaygroudTest
{
    public class UniquePath1Test
    {
        private readonly UniquePath1 _uniquePath1;
        public UniquePath1Test()
        {
            _uniquePath1 = new UniquePath1();
        }

        [Fact]
        public void input1()
        {
            var result = _uniquePath1.GetUniquePath(3, 7);
            Assert.Equal(28,result);
        }
        [Fact]
        public void input2()
        {
            var result = _uniquePath1.GetUniquePath(3, 2);
            Assert.Equal(3, result);
        }
        [Fact]
        public void input3()
        {
            var result = _uniquePath1.GetUniquePath(7, 3);
            Assert.Equal(28, result);
        }
        [Fact]
        public void input4()
        {
            var result = _uniquePath1.GetUniquePath(3, 3);
            Assert.Equal(6, result);
        }
        [Fact]
        public void input5()
        {
            var result = _uniquePath1.GetUniquePath(23, 12);
            Assert.Equal(193536720, result);
        }
    }
}
