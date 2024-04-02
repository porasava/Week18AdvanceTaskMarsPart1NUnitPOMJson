using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.Account.Profile
{
    public class _002PageLanguage
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _002PageLanguage(IWebDriver _driver)
        {
            driver1 = _driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }

        private IWebElement AccountButton;
        private IWebElement GoToProfileDropdown;
        private IWebElement AddIcon;
        private IWebElement languageText;
        private IWebElement languageLeveldropdown;
        private IWebElement languageAdd;
        private IWebElement languagecancel;
        private IWebElement editIcon;
        private IWebElement editIconL;
        private IWebElement languageTextedit;
        private IWebElement languageUpdate;
        private IWebElement languagePopUp;
        private IWebElement deleteIcon;
        private IWebElement deleteError;
        private IWebElement Language;
        private IWebElement LanguageLevel;
        private IWebElement PopUpClose;

        public void renderLanguageComponents()
        {
            try
            {
                AccountButton = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
                GoToProfileDropdown = driver1.FindElement(By.XPath("//a[normalize-space()='Go to Profile']"));
                AddIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
                languageText = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
                languageLeveldropdown = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
                languageAdd = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
                languagecancel = driver1.FindElement(By.XPath("//input[@value='Cancel']"));
                editIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
                editIconL = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i"));
                languageTextedit = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
                languagePopUp = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
                deleteIcon = driver1.FindElement(By.XPath("//i[@class='remove icon']"));
                deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
                Language = driver1.FindElement(By.XPath("//tbody//tr//td[1]"));
                LanguageLevel = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
                PopUpClose = driver1.FindElement(By.XPath("//a[@class='ns-close']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderLanguageEditComponents()
        {
            try
            {
                editIcon = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
                editIconL = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderLanguageEditUpdateComponents()
        {
            try
            {
                languageUpdate = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderLanguageEditClearComponents()
        {
            try
            {
                
                languageTextedit = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderLanguageDeleteComponents()
        {
            try
            {
                deleteIcon = driver1.FindElement(By.XPath("//i[@class='remove icon']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderPopupDeleteComponents()
                {
            try
            {
                deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
                languagePopUp = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderPopupComponents()
        {
            try
            {
                Language = driver1.FindElement(By.XPath("//tbody//tr//td[1]"));
                PopUpClose = driver1.FindElement(By.XPath("//a[@class='ns-close']"));
                LanguageLevel = driver1.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
                deleteError = driver1.FindElement(By.XPath("/html/body/div[1]/div"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
       

        public void NavigateToAccountProfile()
        {
            
            Wait.WaitForElementPresent(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"), 8);
            renderLanguageComponents();
            AccountButton.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//a[normalize-space()='Go to Profile']"), 8);
            GoToProfileDropdown.Click();
        }

        // AddNewLanguage
        public void addNewLanguage(string language, string languageLevel)
        {   
            language = language.Replace("[SPACE]", " ");
            language = language.Replace("[NEWLINE]", "\n");
            Wait.WaitToBeClickable(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"), 8);
            Thread.Sleep(1000);
            renderLanguageComponents();
            AddIcon.Click();
            Thread.Sleep(1000);
            renderLanguageComponents();
            languageText.Clear();
            languageText.SendKeys(language);
            languageLeveldropdown.Click();
            languageLeveldropdown.SendKeys(languageLevel);
        }

        //Click Add Language
        public void clickAddLanguage()
        {
            renderLanguageComponents();
            Wait.WaitToBeClickable(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"), 8);
            languageAdd.Click();
        }

        public void clickCancelLanguage()
        {
            renderLanguageComponents();
            languagecancel.Click();
        }

        public void checkAddLanguageButtonDisappear()
        {
            bool isElementPresent;
            renderLanguageComponents();
            clickAddLanguage();
            Thread.Sleep(1000);
            Wait.WaitForElementToDisappear(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"), 8);
            try
            {
                // Try to find the element
                isElementPresent = languageAdd != null && languageAdd.Displayed;
            }
            catch (NoSuchElementException)
            {
                // If the element is not found, it's not present
                isElementPresent = false;
            }
            // Assert that the element is not present or not displayed
            Assert.That(isElementPresent, Is.False, "The 'languageAdd' button should not be visible.");

        }

        //EditALanguage
        public void EditALanguage(string languageEdit)
        {
            renderLanguageComponents();
            languageEdit = languageEdit.Replace("[SPACE]", " ");
            Wait.WaitForElementPresent(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"), 9);
            renderLanguageEditComponents();
            editIcon.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"), 9);
            renderLanguageEditClearComponents();
            languageTextedit.Clear();
            languageTextedit.SendKeys(languageEdit);
            renderLanguageEditUpdateComponents();
            languageUpdate.Click();
        }


        //EditALastLanguage
        public void EditALatsLanguage(string languageEdit)
        {
            renderLanguageComponents();
            languageEdit = languageEdit.Replace("[SPACE]", " ");
            Wait.WaitForElementPresent(driver1, By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]/i"), 9);
            editIconL.Click();
            languageTextedit.Clear();
            languageTextedit.SendKeys(languageEdit);
            languageUpdate.Click();
        }

        ////LanguageShouldBeEditSuccessfully
        //public void LanguageShouldBeEdited(string languageEdit)
        //{
        //    renderLanguageComponents();
        //    Thread.Sleep(2000);
        //    Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
        //    renderPopupDeleteComponents();
        //    string actualMessage = languagePopUp.Text.Trim();
        //    // The static part of the message you expect
        //    string expectedStaticPart = "has been updated to your languages";
        //    // Assert that the actual message contains the expected static part
        //    Assert.That(actualMessage.Contains(expectedStaticPart),
        //        $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        //}
        public void LanguageShouldBeEdited(string languageEdit)
        {
            renderLanguageComponents();
            Thread.Sleep(2000);
            Wait.ElementIsVisible(driver1, By.XPath("/html/body/div[1]/div"), 8);
            renderPopupDeleteComponents();
            // Assuming you have a method or a way to get the locator for the element you want to assert on
            By locator = By.XPath("/html/body/div[1]/div");
            string expectedStaticPart = "has been updated to your languages";
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }


        //RemoveLanguage
        public void RemoveLanguage()
        {
            
            Wait.WaitForElementPresent(driver1, By.XPath("//i[@class='remove icon']"), 8);
            renderLanguageDeleteComponents();
            deleteIcon.Click();
            Thread.Sleep(1000);
        }

        //LanguageShouldBeRemoveSuccessful
        public void LanguageShouldBeRemoveSuccessful()
        {
            
            Wait.WaitToExist(driver1, By.XPath("/html/body/div[1]/div"), 5);// first popup
            Thread.Sleep(1000);
            renderPopupComponents();
           // PopUpClose.Click();
            Thread.Sleep(1000);
            Wait.WaitToExist(driver1, By.XPath("/html/body/div[1]/div"), 5);//second pop up
            By locator = By.XPath("/html/body/div[1]/div");
            renderPopupDeleteComponents();
            // The static part of the message you expect
            string expectedStaticPart = "has been deleted from your languages";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, locator);
        }

        //DeleteALanguage
        public void DeleteALanguage(string languageDelete)
        {
            renderLanguageComponents();
            Wait.WaitForElementPresent(driver1, By.XPath("//i[@class='remove icon']"), 8);
            string languageToRemove = languageDelete; // Replace with the language name based on user input
            // Find the table row that contains the specified language
            IWebElement rowContainingLanguage = driver1.FindElement(By.XPath($"//table/tbody/tr[td[contains(text(), '{languageToRemove}')]]"));
            // Find the "Remove" icon within this row
            IWebElement removeIcon = rowContainingLanguage.FindElement(By.XPath(".//i[@class='remove icon']"));
            // Click the "Remove" icon
            removeIcon.Click();
        }

        //LanguageShouldBeAddSuccessfully
        public void languageShouldBeAddSuccessfully(string language, string languageLevel)
        {
            Wait.WaitForElementPresent(driver1, By.XPath("//tbody//tr//td[1]"), 8);
            Thread.Sleep(1000);
            renderPopupComponents();
            string actualMessage = Language.Text.Trim();
            // Set the expected message for the language element
            string expectedMessage = language.Trim();  // Replace with the actual expected text
            // Assert and print the expected and actual message
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");
            // Similar process for the second element (languageLevel)
            string actualMessage2 = LanguageLevel.Text.Trim();
            // Set the expected message for the language level element
            string expectedMessage2 = languageLevel.Trim();  // Replace with the actual expected text
            // Assert and print the expected and actual message for language level
            Assert.That(actualMessage2.Equals(expectedMessage2, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage2 + "', Actual: '" + actualMessage2 + "'");
        }

        //ErrorThisLanguageIsAlreadyExistInYourLanguageList
        public void ErrorThisLanguageIsAlreadyExistInYourLanguageList()
        {
            renderLanguageComponents();
            PopUpClose.Click();
            Wait.WaitToExist(driver1, By.XPath("/html/body/div[1]/div"), 5);
            renderPopupDeleteComponents();
            string actualMessage = deleteError.Text.Trim();
            // Assuming you expect the text to be removed and thus to be an empty string
            string expectedMessage = "This language is already exist in your language list."; // Set this to the expected text if it's not supposed to be empty
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");
        }

        //ErrorThisLanguageIsAlreadyAddedToYourLanguageList
        public void ErrorThisLanguageIsAlreadyAddedToYourLanguageList()
        {
            renderLanguageComponents();
            PopUpClose.Click();
            Wait.WaitToExist(driver1, By.XPath("/html/body/div[1]/div"), 5);
            renderPopupDeleteComponents();
            string actualMessage = deleteError.Text.Trim();
            // Assuming you expect the text to be removed and thus to be an empty string
            string expectedMessage = "This language is already added to your language list."; // Set this to the expected text if it's not supposed to be empty
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The expected text did not appear. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");
        }

        //ErrorPleaseenterlanguageandlevel
        public void ErrorPleaseenterlanguageandlevel()
        {
            renderLanguageComponents();
            Wait.WaitToExist(driver1, By.XPath("/html/body/div[1]/div"), 5);
            renderPopupDeleteComponents();
            string actualMessage = deleteError.Text.Trim();
            // Assuming you expect the text to be removed and thus to be an empty string
            string expectedMessage = "Please enter language and level"; // Set this to the expected text if it's not supposed to be empty
            Assert.That(actualMessage.Equals(expectedMessage, StringComparison.Ordinal),
                "Error: The text was not removed as expected. Expected: '" + expectedMessage + "', Actual: '" + actualMessage + "'");
        }


        //CheckExistingLanguage
        public void CheckExistingLanguage()
        {
            renderLanguageComponents();
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
                renderLanguageComponents();
                driver1.FindElement(By.XPath($"(//i[@class='remove icon'])[1]"));
                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void DeleteData()
        {
            renderLanguageComponents();
            deleteIcon.Click();

        }
    }
}
