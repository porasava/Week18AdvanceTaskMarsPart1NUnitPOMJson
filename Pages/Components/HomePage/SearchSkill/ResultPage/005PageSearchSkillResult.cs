using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.HomePage.SearchSkill.ResultPage
{
    public class _005PageSearchSkillResult
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _005PageSearchSkillResult(IWebDriver _driver)
        {
            driver1 = _driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }

        private IWebElement SkillCheck ;

        public void renderDisplaySkillComponents()
        {
            try
            {
                 SkillCheck = driver1.FindElement(By.XPath("//div[@class='four wide column']//div//h3"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void DisplaySkillOnTheResultPage()
        {
            Wait.WaitToExist(driver1, By.XPath("//div[@class='four wide column']//div//h3"), 15);
            renderDisplaySkillComponents();
            // SkillCheck = driver1.FindElement(By.XPath("//div[@class='four wide column']//div//h3"));
            By locator = By.XPath("//div[@class='four wide column']//div//h3");
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Refine Results";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator); ;
            Thread.Sleep(1000);

        }


    }
}
