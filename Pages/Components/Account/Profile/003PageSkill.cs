using NUnit.Framework;
using OpenQA.Selenium;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.Account.Profile
{
    public class _003PageSkill
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _003PageSkill(IWebDriver _driver)
        {
            driver1 = _driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }
      
        private IWebElement skillTab;
        private IWebElement AccountButton;
        private IWebElement GoToProfileDropdown;
        private IWebElement addNewSkill;
        private IWebElement SkillText;
        private IWebElement skillLeveltext;
        private IWebElement addSkillbutton;
        private IWebElement editNewSkill;
        private IWebElement SkillEditText;
        private IWebElement updateSkillbutton;
        private IWebElement skillPopUp;
        private IWebElement removeSkillIcon ;


        public void renderSkillComponents()
        {
            try
            {
                skillTab = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
                AccountButton = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
                GoToProfileDropdown = driver1.FindElement(By.XPath("//a[normalize-space()='Go to Profile']"));
                addNewSkill = driver1.FindElement(By.XPath("//div[@class='ui teal button']"));
                SkillText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
                skillLeveltext = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
                addSkillbutton = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
                editNewSkill = driver1.FindElement(By.XPath("//div[@id='account-profile-section']//table//td[3]/span[1]/i\r\n"));
                SkillEditText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
                updateSkillbutton = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
                skillPopUp = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                removeSkillIcon = driver1.FindElement(By.XPath("//i[@class='remove icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSkillPopUpComponents()
        {
            try
            {
                skillPopUp = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSkillRemoveIconComponents()
        {
            try
            {
                removeSkillIcon = driver1.FindElement(By.XPath("//i[@class='remove icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSkillEditComponents()
        {
            try
            {
                editNewSkill = driver1.FindElement(By.XPath("//div[@id='account-profile-section']//table//td[3]/span[1]/i\r\n"));
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSkillEditTextComponents()
        {
            try
            {
                SkillEditText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
                updateSkillbutton = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
 

        public void NavigateToAccountProfileSkill()
        {
            Wait.WaitForElementPresent(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"), 8);
            renderSkillComponents();
            AccountButton.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//a[normalize-space()='Go to Profile']"), 8);
            GoToProfileDropdown.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"), 5);
            renderSkillComponents();
            skillTab.Click();
        }
        //AddANewSkill
        public void AddANewSkill(string skillName, string skillLevel)
        {
            Wait.WaitToBeClickable(driver1, By.XPath("//div[@class='ui teal button']"), 5);
            renderSkillComponents();
            addNewSkill.Click();
            Thread.Sleep(1000);
            renderSkillComponents();
            SkillText.SendKeys(skillName);
            skillLeveltext.Click();
            skillLeveltext.SendKeys(skillLevel);
            addSkillbutton.Click();
        }


        public void EditASkill(string skill)
        {
            Wait.WaitToBeClickable(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"), 5);
            renderSkillComponents();
            skillTab.Click();
            Thread.Sleep(1000);
            renderSkillEditComponents();
            editNewSkill.Click();
            renderSkillEditTextComponents();
            SkillEditText.Clear();
            SkillEditText.SendKeys(skill);
            updateSkillbutton.Click();
        }

        //SkillShouldEditSuccessfully
        public void SkillShouldEditSuccessfully()
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, By.XPath("//div[@class='ns-box-inner']"), 5);
            Wait.ElementIsVisible(driver1, By.XPath("//div[@class='ns-box-inner']"), 5);
            renderSkillPopUpComponents();
            By locator = By.XPath("//div[@class='ns-box-inner']");
            // The static part of the message you expect
            string expectedStaticPart = "has been updated to your skills";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }

        //DeleteASkill
        public void DeleteASkill(string skillDelete)
        {
            Thread.Sleep(1000);
            renderSkillComponents();
            string skillToRemove = skillDelete; // Replace with the Skill name based on user input
            // Find the table row that contains the specified Skill
            IWebElement rowContainingSkill = driver1.FindElement(By.XPath($"//table/tbody/tr[td[contains(text(), '{skillToRemove}')]]"));
            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingSkill.FindElement(By.XPath(".//i[@class='remove icon']"));
            // Click the "Remove" icon
            removeIcon.Click();
        }

        //SkillShouldBeRemoveSuccessfully
        public void SkillShouldBeRemoveSuccessfully()
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, By.XPath("//div[@class='ns-box-inner']"), 8);
            renderSkillPopUpComponents();
            By locator = By.XPath("//div[@class='ns-box-inner']");
            // The static part of the message you expect
            string expectedStaticPart = "has been deleted";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }

        //ShowNewSkill
        public void ShowNewSkill()
        {
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, By.XPath("//div[@class='ns-box-inner']"), 5);
            renderSkillPopUpComponents();
            By locator = By.XPath("//div[@class='ns-box-inner']");
            // The static part of the message you expect
            string expectedStaticPart = "has been added to your skills";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }

        //ErrorPleaseEnterSkillAndExperienceLevel
        public void ErrorPleaseEnterSkillAndExperienceLevel()
        {
            Wait.ElementIsVisible(driver1, By.XPath("//div[@class='ns-box-inner']"), 5);
            renderSkillPopUpComponents();
            By locator = By.XPath("//div[@class='ns-box-inner']");
            // The static part of the message you expect
            string expectedStaticPart = "Please enter skill and experience level";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }

        //This skill is already exist in your skill list.
        public void ErrorThisskillIsAlreadyExistInYourSkillList()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, By.XPath("//div[@class='ns-box-inner']"), 5);
            renderSkillPopUpComponents();
            By locator = By.XPath("//div[@class='ns-box-inner']");
            // The static part of the message you expect
            string expectedStaticPart = "This skill is already exist in your skill list";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }

        //checkExistingSkill
        public void checkExistingSkill()
        {
            Thread.Sleep(1000);
            // Loop until no more data is present
            while (IsDataPresent())
            {
                DeleteData();
            }
        }

        public bool IsDataPresent()
        {
            try
            {
                Thread.Sleep(1000);
                driver1.FindElement(By.XPath("//i[@class='remove icon'][1]"));
                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void DeleteData()
        {
            renderSkillRemoveIconComponents();
            removeSkillIcon.Click();
        }
    }
}
