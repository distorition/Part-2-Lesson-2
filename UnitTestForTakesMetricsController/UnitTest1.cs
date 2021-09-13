using Part_2_Lesson_2.Controllers;
using System;
using Xunit;

namespace UnitTestForTakesMetricsController
{
    public class UnitTest1
    {
        private ControolerToTakeMetrics controoler;
        public UnitTest1 ()
        {
            controoler = new ControolerToTakeMetrics();
        }

        [Fact]
        public void GetMetrics()
        {

            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            var Cpu = controoler.GetMetricsFromCpu(fromTime, toTime);
            var hdd = controoler.GetMetricsFromHdd(fromTime, toTime);
            var net = controoler.GetMetricsFromNetwork(fromTime, toTime);
            var Dot = controoler.GetMetricsFromDotNet(fromTime, toTime);
            _ = Assert.IsAssignableFrom<IAsyncResult>(Dot);
            _ = Assert.IsAssignableFrom<IAsyncResult>(Cpu);
            _ = Assert.IsAssignableFrom<IAsyncResult>(hdd);
            _ = Assert.IsAssignableFrom<IAsyncResult>(net);
        }
    }
}
