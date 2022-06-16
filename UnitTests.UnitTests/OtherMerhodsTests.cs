using NUnit.Framework;
using Unit_Tests;

namespace UnitTests.UnitTests
{
    [TestFixture]
    class OtherMerhodsTests
    {
        public void OutputEqualsInput_WhenCalled_ShouldReturnGoodType()
        {
            OtherMethods methods = new OtherMethods();

            int[] arr = { 1, 2, 3 };

            var resultStr = methods.OutputEqualsInput("Some string");
            var resultInt = methods.OutputEqualsInput(123);
            var resultArr = methods.OutputEqualsInput(arr);

            Assert.True(resultStr.GetType() == typeof(string));
            Assert.True(resultInt.GetType() == typeof(int));
            Assert.True(resultArr.GetType() == typeof(int[]));

        }

    }
}
