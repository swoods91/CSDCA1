using BPCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BloodPressureUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Testing Low Blood Pressure
        public void TestMethod1()
        {
            BloodPressure bp = new BloodPressure { Systolic = 89, Diastolic = 59 };
            Assert.AreEqual(bp.BPCategory, BPCategory.Low);
        }

        [TestMethod]
        //Testing Ideal Blood Pressure
        public void TestMethod2()
        {
            BloodPressure bp = new BloodPressure { Systolic = 110, Diastolic = 79 };
            Assert.AreEqual(bp.BPCategory, BPCategory.Ideal);
        }

        [TestMethod]
        //Testing Ideal Blood Pressure
        public void TestMethod2a()
        {
            BloodPressure bp = new BloodPressure { Systolic = 110, Diastolic = 59 };
            Assert.AreEqual(bp.BPCategory, BPCategory.Ideal);
        }

        [TestMethod]
        //Testing Pre-High Pressure Systolic Way
        public void TestMethod3()
        {
            BloodPressure bp = new BloodPressure { Systolic = 130, Diastolic = 70 };
            Assert.AreEqual(bp.BPCategory, BPCategory.PreHigh);
        }

        [TestMethod]
        //Testing Pre-High Pressure Diastolic Way
        public void TestMethod4()
        {
            BloodPressure bp = new BloodPressure { Systolic = 120, Diastolic = 89 };
            Assert.AreEqual(bp.BPCategory, BPCategory.PreHigh);
        }

        [TestMethod]
        //Testing High Pressure Systolic Way
        public void TestMethod5()
        {
            BloodPressure bp = new BloodPressure { Systolic = 140, Diastolic = 89 };
            Assert.AreEqual(bp.BPCategory, BPCategory.High);
        }

        [TestMethod]
        //Testing High Pressure Diastolic Way
        public void TestMethod6()
        {
            BloodPressure bp = new BloodPressure { Systolic = 130, Diastolic = 90 };
            Assert.AreEqual(bp.BPCategory, BPCategory.High);
        }

    }
}
