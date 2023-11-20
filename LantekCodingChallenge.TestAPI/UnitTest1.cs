using LantekCodingChallenge.Services;

namespace LantekCodingChallenge.TestAPI
{
    public class Tests
    {
        private LantekAPIService _service;

        [SetUp]
        public void Setup()
        {
            _service = new();
        }

        [Test]
        public void Test_GetMachines()
        {
            try
            {
                var result = _service.GetMachinesAsync("/api/cut", new("lantekacademy", ":cPIi<kyF(=5OXc")).Result;
                if (result != null && result.Count > 0)
                {
                    Assert.IsTrue(result.Count > 0);
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}