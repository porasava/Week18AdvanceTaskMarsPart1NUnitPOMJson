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

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.HomePage.SearchSkill
{
    public class _005PageSearchSkill
    {
        private readonly IWebDriver driver1;

        public _005PageSearchSkill(IWebDriver _driver)
        {
            driver1 = _driver;
        }


        private IWebElement GoToHomePage;
        private IWebElement searchSkillButton;

        public void renderSearchSkillComponents()
        {
            try
            {
                GoToHomePage = driver1.FindElement(By.XPath("//a[normalize-space()='Mars Logo']"));

    }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSearchSkillButtonComponents()
        {
            try
            {
                searchSkillButton = driver1.FindElement(By.XPath("//div[@class='four wide column']//div//h3"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        //ClickOnLink
        public void ClickOnLink(string skill)
        {
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(15));

            if (!string.IsNullOrEmpty(skill))
            {
                Wait.WaitToBeClickable(driver1, By.XPath("//a[normalize-space()='Mars Logo']"), 15);
                renderSearchSkillComponents();
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
            renderSearchSkillButtonComponents();
            searchSkillButton.SendKeys(title);
            searchSkillButton.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
        }

    }
}
