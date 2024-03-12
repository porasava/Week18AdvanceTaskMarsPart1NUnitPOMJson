using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;
using static System.Collections.Specialized.BitVector32;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages
{
    public class _005PageSearchSkill
    {
        private readonly IWebDriver driver1;

        public _005PageSearchSkill(IWebDriver _driver)
        {
            driver1 = _driver;
        }


        By SkillCheck1 => By.XPath("//div[@class='four wide column']//div//h3");
        private IWebElement SkillCheck => driver1.FindElement(SkillCheck1);
        By GoToHomePage1 => By.XPath("//a[normalize-space()='Mars Logo']");
        private IWebElement GoToHomePage => driver1.FindElement(GoToHomePage1);
        By searchSkillButton1 => By.XPath("//div[@class='four wide column']//div//h3");
        private IWebElement searchSkillButton => driver1.FindElement(searchSkillButton1);
        By subCategoryPromotionalVideo1 => By.XPath("//div[@class='ui container']//div[@class='row-padded']//a[6]");
        private IWebElement subCategoryPromotionalVideo => driver1.FindElement(subCategoryPromotionalVideo1);
        By SkillResult1 => By.XPath("(//p[@class='row-padded'])[1]");
        private IWebElement SkillResult => driver1.FindElement(SkillResult1);
        By SearchUser1 => By.XPath("//input[@placeholder='Search user']");
        private IWebElement SearchUser => driver1.FindElement(SearchUser1);
        By SearchUserDropdown1 => By.XPath("//body/div/div/div[@id='service-search-section']/div[@class='ui container']/div[@class='row-padded']/section[@class='search-results']/div[@class='ui grid']/div[@class='four wide column']/div[@class='ui grid']/div[@class='left floated thirteen wide column']/div[@class='ui active visible search']/div[@class='results transition visible']/div[1]");
        private IWebElement SearchUserDropdown => driver1.FindElement(SearchUserDropdown1);
        By OtherSubCat1 => By.XPath("//div[@class='four wide column']//a[9]");
        private IWebElement OtherSubCat => driver1.FindElement(OtherSubCat1);
        By SearchSkill1 => By.XPath("//input[@placeholder='Search skills']");
        private IWebElement SearchSkill => driver1.FindElement(SearchSkill1);
        

        public void DisplaySkillOnTheResultPage()
        {
            Wait.ElementIsVisible(driver1, SkillCheck1, 15);
            string actualactivateCheck = SkillCheck.Text.Trim();
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Refine Results";
            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }

        //ClickOnLink
        public void ClickOnLink(string skill)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(15));

            if (!string.IsNullOrEmpty(skill))
            {
                Wait.WaitToBeClickable(driver1,GoToHomePage1, 15);
                GoToHomePage.Click();
                Thread.Sleep(1000);                                                                    
                IWebElement SkillElement = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//a[@href='/Home/Search?cat={skill}']//h3")));
                SkillElement.Click();
                Thread.Sleep(1000);

            }
        }

            //SearchforAskill
            public void SearchforAskill(string title)
            {
                Thread.Sleep(1000);
                searchSkillButton.SendKeys(title);
                searchSkillButton.SendKeys(Keys.Enter);
                Thread.Sleep(1000);
            }

        //Promotional Videos
        public void ClickOnVideoSubcategory()
        {
            //Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, subCategoryPromotionalVideo1, 15);
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

        //SearchSkillFilter
        public void SearchSkillFilter(string buttonName,string SkillSearch)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(8));
            Wait.WaitToBeClickable(driver1, OtherSubCat1, 15);
            OtherSubCat.Click();
            Wait.WaitToBeClickable(driver1, SearchSkill1, 15);
            SearchSkill.SendKeys(SkillSearch);
            SearchSkill.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            IWebElement buttonNameFilter = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[text()='{buttonName}']")));
            buttonNameFilter.Click();
        }

        //SearchSkillFilterResult
        public void SearchSkillFilterResultOnline()
        {
            Wait.ElementIsVisible(driver1, SkillResult1, 15);
            string actual = SkillResult.Text.Trim();
            // The static part of the message you expect
            string expected = "Video and Anime Tananya Happy";
            // Assert that the actual message contains the expected static part
            Assert.That(actual.Contains(expected),
                $"The actual text '{actual}' does not contain the expected text '{expected}'.");
            Thread.Sleep(1000);

        }

        //SearchSkillFilterResultOnsite
        public void SearchSkillFilterResultOnsite()
        {
            Wait.ElementIsVisible(driver1, SkillResult1, 15);
            string actual = SkillResult.Text.Trim();
            // The static part of the message you expect
            string expected = "Video and Anime Tananya Happy Onsite";
            // Assert that the actual message contains the expected static part
            Assert.That(actual.Contains(expected),
                $"The actual text '{actual}' does not contain the expected text '{expected}'.");
            Thread.Sleep(1000);

        }

        //SearchSkillFilterResultAll
        public void SearchSkillFilterResultAll()
        {
            Wait.ElementIsVisible(driver1, SkillResult1, 15);
            string actual = SkillResult.Text.Trim();
            // The static part of the message you expect
            string expected = "Video and Anime Tananya Happy";
            // Assert that the actual message contains the expected static part
            Assert.That(actual.Contains(expected),
                $"The actual text '{actual}' does not contain the expected text '{expected}'.");
            Thread.Sleep(1000);

        }
    }
}

