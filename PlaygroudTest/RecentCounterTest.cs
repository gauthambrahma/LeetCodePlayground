using System;
using playground;
using Xunit;

namespace PlaygroudTest
{
    public class RecentCounterTest
    {
        private readonly RecentCounter recentCounter;

        public RecentCounterTest()
        {
            recentCounter = new RecentCounter();
        }

        [Fact]
        public void input1()
        {
            var result = recentCounter.Ping(1);
            var result2 = recentCounter.Ping(100);
            var result3 = recentCounter.Ping(3001);
            var result4 = recentCounter.Ping(3002);
            Assert.Equal(1, result);
            Assert.Equal(2, result2);
            Assert.Equal(3, result3);
            Assert.Equal(3, result4);
        }
    }
}
