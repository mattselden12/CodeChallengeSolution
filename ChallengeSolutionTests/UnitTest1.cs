using System;
using Xunit;
using ChallengeSolution;

namespace ChallengeSolutionTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string expected = "{\"date\":\"08/04/2018\",\"type\":\" By Batch #\",\"orders\":[{\"date\":\"08/04/2018\",\"code\":\"ONF002793300\",\"number\":\"080427bd1\",\"buyer\":{\"name\":\"Brett Nagy\",\"street\":\"5825 221st Place S.E.\",\"zip\":\"98027\"},\"items\":[{\"sku\":\"602527788265\",\"qty\":2},{\"sku\":\"602517642850\",\"qty\":1}],\"timings\":{\"start\":3,\"stop\":3,\"gap\":0,\"offset\":2,\"pause\":0}}],\"ender\":{\"process\":1,\"paid\":2,\"created\":9}}";
            string actual = Solution.ConvertCSVtoJSON(@"..\..\..\Input.txt", @"..\..\..");

            Assert.Equal(expected, actual);
        }
    }
}
