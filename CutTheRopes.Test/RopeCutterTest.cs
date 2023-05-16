using CutTheRopes.BL;

namespace CutTheRopes.Test
{
    public class RopeCutterTest
    {
        [Fact]
        public void CutTheRopes_LowValue()
        {
            //arrange
            IRopeCutter cutter = new RopeCutter();

            var ropes = new int[] { 3, 3, 2, 9, 7 };

            var expected = new int[] { 5, 4, 2, 1 };

            //act
            int[] actual = cutter.CutTheRopes(ropes);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CutTheRopes_HighValue()
        {
            //arrange
            IRopeCutter cutter = new RopeCutter();

            var ropes = new int[] { 13035, 6618, 13056, 20912, 1119, 13035, 6618, 6618, 8482, 13056 };

            var expected = new int[] { 10, 9, 6, 5, 3, 1 };

            //act
            int[] actual = cutter.CutTheRopes(ropes);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CutTheRopes_SubtractByOne()
        {
            //arrange
            IRopeCutter cutter = new RopeCutter();

            var ropes = new int[] { 1, 2, 3, 4, 3, 3, 2, 1 };

            var expected = new int[] { 8, 6, 4, 1 };

            //act
            int[] actual = cutter.CutTheRopes(ropes);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}