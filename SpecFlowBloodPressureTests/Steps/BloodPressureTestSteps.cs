using System;
using TechTalk.SpecFlow;
using BPCalculator;
using NUnit.Framework;

namespace SpecFlowBloodPressureTests.Features
{
    [Binding]
    public class BloodPressureTestSteps
    {
        private BloodPressure _BloodPressure;

        [Given(@"the Systolic number is ""(.*)""")]
        public void GivenTheSystolicNumberIs(int systolicTest)
        {
            _BloodPressure = new BloodPressure(); 
           _BloodPressure.Systolic = systolicTest;
        }
        
        [Given(@"the Diastolic number is ""(.*)""")]
        public void GivenTheDiastolicNumberIs(int diastolicTest)
        {
            _BloodPressure.Diastolic = diastolicTest;
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string bpCategory)
        {
            Assert.AreEqual(_BloodPressure.BPCategory.ToString(), bpCategory);
        }
    }
}
