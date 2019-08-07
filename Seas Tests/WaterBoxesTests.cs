using System;
using Seas;
using Xunit;

namespace Seas_Tests
{
    public class WaterBoxesTests
    {
        [Fact]
        public void WaterBoxIs4Decimals()
        {
            var seas = new WaterBoxes();
            var waterbox = seas.WaterBox(new decimal(1.0), new decimal(1.0), new decimal(1.0));
            var round = getDecimalCount(waterbox);
            Assert.Equal(4, round);
        }
        [Fact]
        public void ConvertToCentimetersTest()
        {
            var seas = new WaterBoxes();
            decimal cm = seas.ConvertToCentimeters(new decimal(1.0));
            Assert.Equal(new decimal(2.54), cm);
        }

        [Fact]
        public void CalcLitersTest()
        {
            var seas = new WaterBoxes();
            decimal cm = seas.CalcLiters(new decimal(1.0), new decimal(1.0), new decimal(1.0));
            Assert.Equal(new decimal(0.0164), Math.Round(cm, 4));
        }

        [Fact]
        public void WaterBoxTest()
        {
            var seas = new WaterBoxes();
            decimal WaterBox = seas.WaterBox(new decimal(1.0), new decimal(1.0), new decimal(1.0));
            Assert.Equal(new decimal(983.6129), WaterBox);
        }

        private static int getDecimalCount(decimal val)
        {

            int i = 0;
            while (Math.Round(val, i) != val)
                i++;
            return i;
        }

    }
}
