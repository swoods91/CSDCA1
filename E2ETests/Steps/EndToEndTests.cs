using System;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using NUnit.Framework.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestContext = NUnit.Framework.TestContext;

namespace E2ETests.Features
{

    [TestClass]
    class EndToEndTests
    {
        private TestContext testContextInstance;

        // test harness uses this property to initliase test context
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        //private object driver;


        [Test]
        public void Test1Display()
        {


            using (IWebDriver driver = new PhantomJSDriver())
            {
                // navigate to URI
                driver.Navigate().GoToUrl("https://sw-bloodpressureapp-qa-staging.azurewebsites.net/");

                IWebElement systolicValue = driver.FindElement(By.CssSelector("input[id='BP_Systolic']"));

                IWebElement DiastolicValue = driver.FindElement(By.CssSelector("input[id='BP_Diastolic']"));

                IWebElement SubmitButton = driver.FindElement(By.CssSelector("input[value='Submit']"));

                NUnit.Framework.Assert.That(systolicValue.Displayed);
                NUnit.Framework.Assert.That(DiastolicValue.Displayed);
                NUnit.Framework.Assert.That(SubmitButton.Displayed);
            }
        }

        [Test]
        public void Test2Ideal()
        {


            using (IWebDriver driver = new PhantomJSDriver())
            {
                // navigate to URI
                driver.Navigate().GoToUrl("https://sw-bloodpressureapp-qa-staging.azurewebsites.net/");

                IWebElement systolicValue = driver.FindElement(By.CssSelector("input[id='BP_Systolic']"));

                IWebElement DiastolicValue = driver.FindElement(By.CssSelector("input[id='BP_Diastolic']"));

                IWebElement SubmitButton = driver.FindElement(By.CssSelector("input[value='Submit']"));

                systolicValue.SendKeys("100");

                DiastolicValue.SendKeys("70");

                SubmitButton.Click();

                String BpCategory = driver.FindElement(By.CssSelector("#form1 > div:nth-child(4)")).Text;

                NUnit.Framework.Assert.AreEqual(BpCategory, "Ideal Blood Pressure");

            }
        }

            [Test]
            public void Test3Low()
            {

                using (IWebDriver driver = new PhantomJSDriver())
                {
                    // navigate to URI
                    driver.Navigate().GoToUrl("https://sw-bloodpressureapp-qa-staging.azurewebsites.net/");

                    IWebElement systolicValue = driver.FindElement(By.CssSelector("input[id='BP_Systolic']"));

                    IWebElement DiastolicValue = driver.FindElement(By.CssSelector("input[id='BP_Diastolic']"));

                    IWebElement SubmitButton = driver.FindElement(By.CssSelector("input[value='Submit']"));

                    systolicValue.Clear();

                    DiastolicValue.Clear();

                    systolicValue.SendKeys("89");

                    DiastolicValue.SendKeys("59");

                    SubmitButton.Click();

                    String BpCategory = driver.FindElement(By.CssSelector("#form1 > div:nth-child(4)")).Text;

                    NUnit.Framework.Assert.AreEqual(BpCategory, "Low Blood Pressure");

                }
            }

        [Test]
        public void Test4Prehigh()
        {

            using (IWebDriver driver = new PhantomJSDriver())
            {
                // navigate to URI
                driver.Navigate().GoToUrl("https://sw-bloodpressureapp-qa-staging.azurewebsites.net/");

                IWebElement systolicValue = driver.FindElement(By.CssSelector("input[id='BP_Systolic']"));

                IWebElement DiastolicValue = driver.FindElement(By.CssSelector("input[id='BP_Diastolic']"));

                IWebElement SubmitButton = driver.FindElement(By.CssSelector("input[value='Submit']"));

                systolicValue.Clear();

                DiastolicValue.Clear();

                systolicValue.SendKeys("130");

                DiastolicValue.SendKeys("70");

                SubmitButton.Click();

                String BpCategory = driver.FindElement(By.CssSelector("#form1 > div:nth-child(4)")).Text;

                NUnit.Framework.Assert.AreEqual(BpCategory, "Pre-High Blood Pressure");

            }
        }

        [Test]
        public void Test5high()
        {

            using (IWebDriver driver = new PhantomJSDriver())
            {
                // navigate to URI
                driver.Navigate().GoToUrl("https://sw-bloodpressureapp-qa-staging.azurewebsites.net/");

                IWebElement systolicValue = driver.FindElement(By.CssSelector("input[id='BP_Systolic']"));

                IWebElement DiastolicValue = driver.FindElement(By.CssSelector("input[id='BP_Diastolic']"));

                IWebElement SubmitButton = driver.FindElement(By.CssSelector("input[value='Submit']"));

                systolicValue.Clear();

                DiastolicValue.Clear();

                systolicValue.SendKeys("130");

                DiastolicValue.SendKeys("90");

                SubmitButton.Click();

                String BpCategory = driver.FindElement(By.CssSelector("#form1 > div:nth-child(4)")).Text;

                NUnit.Framework.Assert.AreEqual(BpCategory, "High Blood Pressure");

            }
        }

       [Test]
       public void Test6InvalidValues()
       {

         using (IWebDriver driver = new PhantomJSDriver())
         {
              // navigate to URI
              driver.Navigate().GoToUrl("https://sw-bloodpressureapp-qa-staging.azurewebsites.net/");

              IWebElement systolicValue = driver.FindElement(By.CssSelector("input[id='BP_Systolic']"));

              IWebElement DiastolicValue = driver.FindElement(By.CssSelector("input[id='BP_Diastolic']"));

              IWebElement SubmitButton = driver.FindElement(By.CssSelector("input[value='Submit']"));

              systolicValue.Clear();

              DiastolicValue.Clear();

              systolicValue.SendKeys("200");

              DiastolicValue.SendKeys("0");

              SubmitButton.Click();

              IWebElement systolicValueInvalid = driver.FindElement(By.CssSelector("span[id='BP_Systolic-error']"));

              IWebElement DiastolicValueInvalid = driver.FindElement(By.CssSelector("span[id='BP_Diastolic-error']"));

              NUnit.Framework.Assert.That(systolicValueInvalid.Displayed);

              NUnit.Framework.Assert.That(DiastolicValueInvalid.Displayed);

              systolicValue.Clear();

              DiastolicValue.Clear();

              systolicValue.SendKeys("70");

              DiastolicValue.SendKeys("90");

              SubmitButton.Click();

              IWebElement DiastolicSystolicInvalid = driver.FindElement(By.CssSelector("#form1 > div.text-danger.validation-summary-errors"));

              NUnit.Framework.Assert.That(DiastolicSystolicInvalid.Displayed);

            }
            }
    }
}
