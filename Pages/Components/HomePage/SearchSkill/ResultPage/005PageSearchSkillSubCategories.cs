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

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.HomePage.SearchSkill.ResultPage
{
    public class _005PageSearchSkillSubCategories
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _005PageSearchSkillSubCategories(IWebDriver _driver)
        {
            driver1 = _driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }

        private IWebElement subCategoryPromotionalVideo;

        public void renderDisplaySkillComponents()
        {
            try
            {
                //searchSkillButton1 = By.XPath("//div[@class='four wide column']//div//h3");
                subCategoryPromotionalVideo = driver1.FindElement(By.XPath("//div[@class='ui container']//div[@class='row-padded']//a[6]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        //Promotional Videos
        public void ClickOnVideoSubcategory()
        {
            //Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//div[@class='ui container']//div[@class='row-padded']//a[6]"), 15);
            renderDisplaySkillComponents();
            subCategoryPromotionalVideo.Click();
            Thread.Sleep(1000);

        }

        //SubVideoSubcategoryShouldBeBold
        public void SubVideoSubcategoryShouldBeBold()
        {
            // Example: If the "active" class is on a parent of the element you initially clicked
            IWebElement parentElementAfterClick = driver1.FindElement(By.XPath("//a[contains(@class,'active item subcategory')]"));
            string parentClassAttribute = parentElementAfterClick.GetAttribute("class");
            Assert.That(parentClassAttribute, Does.Contain("active"), "The element did not become active after clicking.");


        }  
    }
}
