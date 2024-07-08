using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;
using MongoDB.Driver;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.HomePage.SearchSkill.ResultPage
{
    public class _005PageSearchSkillFilter
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _005PageSearchSkillFilter(IWebDriver _driver)
        {
            driver1 = _driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }


        private IWebElement SkillResult;
        private IWebElement OtherSubCat;
        private IWebElement SearchSkill;

        public void renderSearchSkillSubCatComponents()
        {
            try
            {   
                OtherSubCat = driver1.FindElement(By.XPath("//div[@class='four wide column']//a[9]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSearchSkillComponents()
        {
            try
            {
                SearchSkill = driver1.FindElement(By.XPath("//input[@placeholder='Search skills']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderSearchSkillResultComponents()
        {
            try
            {
                SkillResult = driver1.FindElement(By.XPath("(//p[@class='row-padded'])[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        //SearchSkillFilter
        public void SearchSkillFilter(string buttonName, string SkillSearch)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Wait.WaitToBeClickable(driver1, By.XPath("//div[@class='four wide column']//a[9]"), 15);
            renderSearchSkillSubCatComponents();
            OtherSubCat.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//input[@placeholder='Search skills']"), 15);
            renderSearchSkillComponents();
            SearchSkill.SendKeys(SkillSearch);
            SearchSkill.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            IWebElement buttonNameFilter = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[text()='{buttonName}']")));
            buttonNameFilter.Click();
        }

        //SearchSkillFilterResult
        public void SearchSkillFilterResultOnline()
        {
            Wait.ElementIsVisible(driver1, By.XPath("(//p[@class='row-padded'])[1]"), 15);
            renderSearchSkillResultComponents();
            By locator = By.XPath("(//p[@class='row-padded'])[1]");
            // The static part of the message you expect
            string expected = "Video and Anime Tananya Happy";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expected, locator);
            Thread.Sleep(1000);

        }

        //SearchSkillFilterResultOnsite
        public void SearchSkillFilterResultOnsite()
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, By.XPath("(//p[@class='row-padded'])[1]"), 15);
            renderSearchSkillResultComponents();
            By locator = By.XPath("(//p[@class='row-padded'])[1]");
            // The static part of the message you expect
            string expected = "Video and Anime Tananya Happy Onsite";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expected, locator);
            Thread.Sleep(1000);

        }

        //SearchSkillFilterResultAll
        public void SearchSkillFilterResultAll()
        {
            Wait.ElementIsVisible(driver1, By.XPath("(//p[@class='row-padded'])[1]"), 15);
            renderSearchSkillResultComponents();
            By locator = By.XPath("(//p[@class='row-padded'])[1]");
            // The static part of the message you expect
            string expected = "Video and Anime Tananya Happy";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expected, locator);
            Thread.Sleep(1000);

        }
    }
}
