using Newtonsoft.Json.Linq;

namespace StackOverflowRepro
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void TestMethod1(JObject payload, bool expected)
        {
            Assert.AreEqual(expected, payload.HasValues);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            return new[]
            {
                new object[] { JObject.FromObject(new { }), false }
            };
        }
    }
}