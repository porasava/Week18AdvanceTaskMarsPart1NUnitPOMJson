using NUnit.Framework;
using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages
{
    public class _001PageOverall
    {
        private readonly IWebDriver driver1;

        public _001PageOverall(IWebDriver _driver)
        {
            driver1 = _driver;
        }

        //(//i)[8]
        By Availability1 => By.XPath("//div[@class='four wide column']//div[2]//div[1]//span[1]//i[1]");
        private IWebElement Availability => driver1.FindElement(Availability1);
        private IWebElement availabiltyType => driver1.FindElement(By.XPath("//select[@name='availabiltyType']"));
        private IWebElement availabiltyTypeCheck => driver1.FindElement(By.XPath("//span[normalize-space()=[contains(text(),'{Availability}')]]"));
        private IWebElement Houredit => driver1.FindElement(By.XPath("//div[@class='extra content']//div[3]//div[1]//span[1]//i[1]"));
        By AvailabilityHourType1 => By.XPath("//select[@name='availabiltyHour']");
        private IWebElement AvailabilityHourType => driver1.FindElement(AvailabilityHourType1);
        By EarnTarget1 => By.XPath("(//div[@class='right floated content']//i[@class='right floated outline small write icon'])[3]");
        private IWebElement EarnTarget => driver1.FindElement(EarnTarget1);
        By availabiltyTargetDropdown1 => By.XPath("//select[@name='availabiltyTarget']");
        private IWebElement availabiltyTargetDropdown => driver1.FindElement(availabiltyTargetDropdown1);

        public void EditAvailability(string availabiltyTypeInput)
        {
            Wait.WaitToBeClickable(driver1, Availability1, 8);
            Availability.Click();
            availabiltyType.SendKeys(availabiltyTypeInput);
        }
        public void AvailabilityshouldChangeSuccessfully(string availabiltyTypeInput)
        {
            Thread.Sleep(1000);
            string AvailabilityExpect = availabiltyTypeInput; // Replace with the Skill name based on user input
            IWebElement AvailabilityShow = driver1.FindElement(By.XPath($"//span[normalize-space()='{availabiltyTypeInput}']"));
            string actualMessage = AvailabilityShow.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = AvailabilityExpect;
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");

        }
        public void EditHours(string AvailabilityHourTypeInput)
        {
            Houredit.Click();
            Wait.WaitForElementPresent(driver1, AvailabilityHourType1, 8);
            AvailabilityHourType.Click();
            AvailabilityHourType.SendKeys(AvailabilityHourTypeInput);
        }
        public void HoursshouldChangeSuccessfully(string AvailabilityHourTypeInput)
        {
            Thread.Sleep(1000);
            string AvailabilityHoursExpect = AvailabilityHourTypeInput; // Replace with the Skill name based on user input
            IWebElement AvailabilityHoursShow = driver1.FindElement(By.XPath($"(//div[@class='item']//div[@class='right floated content']/span)[2]"));


 string actualMessage = AvailabilityHoursShow.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = AvailabilityHoursExpect;
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");

        }
        public void EditEarnTarget(string availabiltyTargetInput)
        {
            Wait.WaitToBeClickable(driver1,EarnTarget1, 8);
           EarnTarget.Click();
            Wait.WaitForElementPresent(driver1,availabiltyTargetDropdown1, 8);
            availabiltyTargetDropdown.Click();
            availabiltyTargetDropdown.SendKeys(availabiltyTargetInput);
        }
        public void EarnTarGetshouldChangeSuccessfully(string availabiltyTargetInput)
        {
            Thread.Sleep(1000);
            string AvailabilityHoursExpect = availabiltyTargetInput; // Replace with the Skill name based on user input
            IWebElement AvailabilityTargetShow = availabiltyTargetDropdown;
            string actualMessage = AvailabilityTargetShow.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = AvailabilityHoursExpect;
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");

        }
    }
}
