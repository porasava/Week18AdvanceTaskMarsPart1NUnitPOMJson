using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium.Support.UI;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Assertions;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.Account.Profile
{
    public class _001PageOverview
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _001PageOverview(IWebDriver _driver)
        {
            driver1 = _driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }

        private IWebElement Availability;
        private IWebElement availabiltyType;
        private IWebElement Houredit;
        private IWebElement AvailabilityHourType;
        private IWebElement EarnTarget;
        private IWebElement availabiltyTargetDropdown;


        public void renderEditAvailabilityComponents()
        {
            try
            {
                Availability = driver1.FindElement(By.XPath("//div[@class='four wide column']//div[2]//div[1]//span[1]//i[1]"));
                availabiltyType = driver1.FindElement(By.XPath("//select[@name='availabiltyType']"));
    }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderEditHourComponents()
        {
            try
            {
                Houredit = driver1.FindElement(By.XPath("//div[@class='extra content']//div[3]//div[1]//span[1]//i[1]"));
                AvailabilityHourType = driver1.FindElement(By.XPath("//select[@name='availabiltyHour']"));
                EarnTarget = driver1.FindElement(By.XPath("(//div[@class='right floated content']//i[@class='right floated outline small write icon'])[3]"));
                availabiltyTargetDropdown = driver1.FindElement(By.XPath("//select[@name='availabiltyTarget']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderEditTargetComponents()
        {
            try
            {
                EarnTarget = driver1.FindElement(By.XPath("(//div[@class='right floated content']//i[@class='right floated outline small write icon'])[3]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void renderEditTargeDropdowntComponents()
        {
            try
            {
                
                availabiltyTargetDropdown = driver1.FindElement(By.XPath("//select[@name='availabiltyTarget']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
       
        public void EditAvailability(string availabiltyTypeInput)
        {
            Wait.WaitToBeClickable(driver1,By.XPath("//div[@class='four wide column']//div[2]//div[1]//span[1]//i[1]"), 8);
            renderEditAvailabilityComponents();
            Availability.Click();
            renderEditAvailabilityComponents();
            availabiltyType.SendKeys(availabiltyTypeInput);
        }

        public void AvailabilityShouldChangeSuccessfully(string availabilityTypeInput)
        {
            // Assuming you have a method or a way to get the locator for the element you want to assert on
            By locator = By.XPath($"//span[normalize-space()='{availabilityTypeInput}']");

            // Use the assertion method from the AssertionsPage
            pageAssertions.AssertElementTextContains(availabilityTypeInput, locator);
        }
        public void EditHours(string AvailabilityHourTypeInput)
        {
            renderEditHourComponents();
            Houredit.Click();
            Wait.WaitForElementPresent(driver1, By.XPath("//select[@name='availabiltyHour']"), 8);
            renderEditHourComponents();
            AvailabilityHourType.Click();
            AvailabilityHourType.SendKeys(AvailabilityHourTypeInput);
        }

        public void HoursshouldChangeSuccessfully(string AvailabilityHourTypeInput)
        {
            // Assuming you have a method or a way to get the locator for the element you want to assert on
            By locator = By.XPath($"(//div[@class='item']//div[@class='right floated content']/span)[2]");

            // Use the assertion method from the AssertionsPage
            pageAssertions.AssertElementTextContains(AvailabilityHourTypeInput, locator);
        }

        public void EditEarnTarget(string availabiltyTargetInput)
        {   renderEditTargetComponents();
            Wait.WaitToBeClickable(driver1, By.XPath("(//div[@class='right floated content']//i[@class='right floated outline small write icon'])[3]"), 8);
            EarnTarget.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//select[@name='availabiltyTarget']"), 8);
            renderEditTargeDropdowntComponents();  
            availabiltyTargetDropdown.Click();
            availabiltyTargetDropdown.SendKeys(availabiltyTargetInput);
        }



        public void EarnTarGetshouldChangeSuccessfully(string availabiltyTargetInput)
        {
            // Assuming you have a method or a way to get the locator for the element you want to assert on
            By locator =By.XPath("//select[@name='availabiltyTarget']"); 
            pageAssertions.AssertElementTextContainsIWeb(availabiltyTargetInput, locator);
        }
    }
}
