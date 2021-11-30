using HeartRateCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TargetHeartRateUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Testing In Range Target Heart Rate
        public void TestMethod1()
        {
            HeartRate hr = new HeartRate { ageValue = 30, PercentRate = 50 };
            Assert.AreEqual(hr.TargetHeartRate, 95);
        }

        [TestMethod]
        //Testing Lower Range Age Target Heart Rate
        public void TestMethod2()
        {
            HeartRate hr = new HeartRate { ageValue = 1, PercentRate = 50 };
            Assert.AreEqual(hr.TargetHeartRate, 110);
        }

        [TestMethod]
        //Testing Lower Range Percent Target Heart Rate
        public void TestMethod3()
        {
            HeartRate hr = new HeartRate { ageValue = 30, PercentRate = 0 };
            Assert.AreEqual(hr.TargetHeartRate, 0);
        }

        [TestMethod]
        //Testing Upper Range Age Target Heart Rate
        public void TestMethod4()
        {
            HeartRate hr = new HeartRate { ageValue = 132, PercentRate = 50 };
            Assert.AreEqual(hr.TargetHeartRate, 44);
        }

        [TestMethod]
        //Testing Upper Range Percent Target Heart Rate
        public void TestMethod5()
        {
            HeartRate hr = new HeartRate { ageValue = 30, PercentRate = 100 };
            Assert.AreEqual(hr.TargetHeartRate, 190);
        }

        [TestMethod]
        //Testing Lower Range Age Exceeded Target Heart Rate
        public void TestMethod6()
        {
            HeartRate hr = new HeartRate { ageValue = 0, PercentRate = 50 };
            Assert.AreEqual(hr.TargetHeartRate, 0);
        }

        [TestMethod]
        //Testing Upper Range Age Exceeded Target Heart Rate
        public void TestMethod7()
        {
            HeartRate hr = new HeartRate { ageValue = 133, PercentRate = 50 };
            Assert.AreEqual(hr.TargetHeartRate, 0);
        }

        [TestMethod]
        //Testing Lower Range Percent Exceeded Target Heart Rate
        public void TestMethod8()
        {
            HeartRate hr = new HeartRate { ageValue = 30, PercentRate = -1 };
            Assert.AreEqual(hr.TargetHeartRate, 0);
        }

        [TestMethod]
        //Testing Upper Range Percent Exceeded Target Heart Rate
        public void TestMethod9()
        {
            HeartRate hr = new HeartRate { ageValue = 30, PercentRate = 101 };
            Assert.AreEqual(hr.TargetHeartRate, 0);
        }
    }
}
