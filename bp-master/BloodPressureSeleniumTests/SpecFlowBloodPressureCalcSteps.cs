using BPCalculator;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BloodPressureSeleniumTests
{
    [Binding]
    public class SpecFlowFeature1Steps
    {

        private BloodPressure BloodPressureTest;

        [Given(@"the Systolic number is ""(.*)""")]
        public void GivenTheSystolicNumberIs(int Systolic)
        {
            BloodPressureTest.Systolic = Systolic;
        }
        
        [Given(@"the Diastolic number is ""(.*)""")]
        public void GivenTheDiastolicNumberIs(int Diastolic)
        {
            BloodPressureTest.Diastolic = Diastolic;
        }
        
        [When(@"the Calcualte Blood Pressure button is clicked")]
        public void WhenTheCalcualteBloodPressureButtonIsClicked()
        {
            
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string BPCategory)
        {
            Assert.AreEqual(BloodPressureTest.BPCategory, BPCategory);
        }
    }
}
