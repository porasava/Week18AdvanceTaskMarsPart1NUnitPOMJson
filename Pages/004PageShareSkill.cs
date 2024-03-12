using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages
{
    public class _004PageShareSkill
    {
        private readonly IWebDriver driver1;

        public _004PageShareSkill(IWebDriver _driver)
        {
            driver1 = _driver;
        }


        By titleActivateCheck1 => By.XPath("//div[@class='twelve wide column']//div//div[@class='ui basic red prompt label transition visible']");
        private IWebElement titleActivateCheck => driver1.FindElement(titleActivateCheck1);
        By DescriptionActivateCheck1 => By.XPath("//div[@class='tooltip-target ui grid']//div[@class='row']//div[@class='ui twelve wide column']//div//div[@class='ui basic red prompt label transition visible']");
        private IWebElement DescriptionActivateCheck => driver1.FindElement(DescriptionActivateCheck1);
        By CategoryactivateCheck1 => By.XPath("//div[normalize-space()='Category is required']");
        private IWebElement CategoryactivateCheck => driver1.FindElement(CategoryactivateCheck1);
        By TagsActivateCheck1 =>  By.XPath("//div[contains(text(),'Tags are required')]");
        private IWebElement TagsActivateCheck => driver1.FindElement(TagsActivateCheck1);
        By SkillsActivateCheck1 => By.XPath("//div[contains(text(),'Tag is required')]");
        private IWebElement SkillsActivateCheck => driver1.FindElement(SkillsActivateCheck1);
        By shareSkillButton1 => By.XPath("//a[normalize-space()='Share Skill']");
        private IWebElement shareSkillButton => driver1.FindElement(shareSkillButton1);
        By shareSkillTitle1 => By.XPath("//input[@placeholder='Write a title to describe the service you provide.']");
        private IWebElement shareSkillTitle => driver1.FindElement(shareSkillTitle1);
        By descriptionText1 => By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']");
        private IWebElement descriptionText => driver1.FindElement(descriptionText1);
        By categoryDropdown1 => By.XPath("//select[@name='categoryId']");
        private IWebElement categoryDropdown => driver1.FindElement(categoryDropdown1);
        By tagsText1 => By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]");
        private IWebElement tagsText => driver1.FindElement(tagsText1);
        By skillExchangeText1 => By.XPath("//div[contains(@class,'twelve wide column')]//div[contains(@class,'')]//div[contains(@class,'form-wrapper')]//input[contains(@placeholder,'Add new tag')]");
        private IWebElement skillExchangeText => driver1.FindElement(skillExchangeText1);
        By shareSkillSave1 => By.XPath("//input[@value='Save']");
        private IWebElement shareSkillSave => driver1.FindElement(shareSkillSave1);
        By EditSkillButton1 => By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[2]/i[1]");
        private IWebElement EditSkillButton => driver1.FindElement(EditSkillButton1);
        By subCategoryDropdown1 => By.XPath("//select[@name='subcategoryId']");
        private IWebElement subCategoryDropdown => driver1.FindElement(subCategoryDropdown1);
        By manageListingButton1 => By.XPath("//a[normalize-space()='Manage Listings']");
        private IWebElement manageListingButton => driver1.FindElement(manageListingButton1);
        By seeButton1 => By.XPath("//i[@class='eye icon']");
        private IWebElement seeButton => driver1.FindElement(seeButton1);
        By skillTitle1 => By.XPath("//span[@class='skill-title']");
        private IWebElement skillTitle => driver1.FindElement(seeButton1);
        By categoryText1 => By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]");
        private IWebElement categoryText => driver1.FindElement(categoryText1);
        By subCategoryText1 => By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[2]");
        private IWebElement subCategoryText => driver1.FindElement(subCategoryText1);
        By locationText1 => By.XPath("//div[@class='ui container']//div[3]//div[1]//div[3]//div[1]//div[2]");
        private IWebElement locationText => driver1.FindElement(locationText1);
        By deleteButton1 => By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[3]");
        private IWebElement deleteButton => driver1.FindElement(deleteButton1);

        By yesButton1 => By.XPath("//button[@class='ui icon positive right labeled button']");
        private IWebElement yesButton => driver1.FindElement(yesButton1);
        By deleteCheck1 => By.XPath("//div[@class='ns-box-inner']");
        private IWebElement deleteCheck => driver1.FindElement(deleteCheck1);
        By titleListing1 => By.XPath("//tbody/tr[1]/td[3]");
        private IWebElement titleListing => driver1.FindElement(titleListing1);
        private IWebElement Screenrefresh => driver1.FindElement(By.XPath("//div[@id='service-listing-section']"));




        //ErrorTitleIsRequired
        public void ErrorTitleIsRequired()
        {
            Wait.ElementIsVisible(driver1, titleActivateCheck1, 8);
            string actualactivateCheck = titleActivateCheck.Text.Trim();
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Title is required";
            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }

        //ErrorDescriptionIsRequired
        public void ErrorDescriptionIsRequired()
        {
            Wait.ElementIsVisible(driver1, DescriptionActivateCheck1, 5);
            string actualactivateCheck = DescriptionActivateCheck.Text.Trim();
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Description is required";

            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }

        //ErrorCategoryIsRequired
        public void ErrorCategoryIsRequired()
        {
            Wait.ElementIsVisible(driver1,CategoryactivateCheck1, 5);
            string actualactivateCheck = CategoryactivateCheck.Text.Trim();
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Category is required";
            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }

        //ErrorTagsAreRequired
        public void ErrorTagsAreRequired()
        {

            Wait.ElementIsVisible(driver1, TagsActivateCheck1, 5);
            string actualactivateCheck = TagsActivateCheck.Text.Trim();
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Tags are required";
            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);

        }

        //ErrorSkill_ExchangeAreRequired
        public void ErrorSkillExchangeAreRequired()
        {
            Wait.ElementIsVisible(driver1, SkillsActivateCheck1, 5);
            string actualactivateCheck = SkillsActivateCheck.Text.Trim();
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Tag is required";
            // Assert that the actual message contains the expected static part
            Assert.That(actualactivateCheck.Contains(expectedactivateCheckStaticPart),
                $"The actual text '{actualactivateCheck}' does not contain the expected text '{expectedactivateCheckStaticPart}'.");
            Thread.Sleep(1000);
        }


        //CreateAListing
        public void CreateAListing( string title, string description, string category, string subCategory, string tags, string skillExchange)
        {
            Wait.ElementIsVisible(driver1, shareSkillButton1, 5);
            shareSkillButton.Click();
            Screenrefresh.Click();
            driver1.Navigate().Refresh();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, shareSkillTitle1, 5);
            shareSkillTitle.SendKeys(title);
            Wait.WaitToBeClickable(driver1, descriptionText1, 5);
            descriptionText.Clear();
            descriptionText.SendKeys(description);
            Wait.WaitToBeClickable(driver1, categoryDropdown1, 5);
            categoryDropdown.SendKeys(category);
            Thread.Sleep(1000);
            if (string.IsNullOrEmpty(subCategory))
            {
                Thread.Sleep(1000);
                Wait.WaitToBeClickable(driver1, tagsText1, 5);
                tagsText.SendKeys(tags);
                tagsText.SendKeys(Keys.Enter);
            }
            else
            {
                Thread.Sleep(1000); 
                Wait.WaitToBeClickable(driver1, subCategoryDropdown1, 5);
                subCategoryDropdown.Click();
                subCategoryDropdown.SendKeys(subCategory);
                Wait.WaitToBeClickable(driver1, tagsText1, 5);
                tagsText.SendKeys(tags);
                tagsText.SendKeys(Keys.Enter);
            }
            skillExchangeText.Click();
            Wait.WaitToBeClickable(driver1, skillExchangeText1, 5);
            skillExchangeText.SendKeys(skillExchange);
            skillExchangeText.SendKeys(Keys.Enter);
            shareSkillSave.Click();
        }


        public void EditAListing(string title, string description, string category, string subCategory, string tags, string skillExchange)
        {
            EditSkillButton.Click();
            Thread.Sleep(1000);
            shareSkillTitle.Clear();
            shareSkillTitle.SendKeys(title);
            descriptionText.Clear();
            descriptionText.SendKeys(description);
            categoryDropdown.SendKeys(category);
            subCategoryDropdown.Click();
            subCategoryDropdown.SendKeys(subCategory);
            tagsText.SendKeys(tags);
            tagsText.SendKeys(Keys.Enter);
            skillExchangeText.Click();
            skillExchangeText.SendKeys(skillExchange);
            skillExchangeText.SendKeys(Keys.Enter);
            shareSkillSave.Click();
        }

        //NavigateToManageListingPage
        public void NavigateToManageListingPage()
        {
            Thread.Sleep(1000);
            manageListingButton.Click();
            Thread.Sleep(1000);
        }

        //ListingUpdateOnTheListingDetailPage
        public void ListingUpdateOnTheListingDetailPage(string title, string description)
        {
            seeButton.Click();
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, skillTitle1, 5);
            string actualText = skillTitle.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = title;
            // Assert that the actual message contains the expected static part
            Assert.That(actualText.Contains(expectedStaticPart),
                $"The actual text '{actualText}' does not contain the expected text '{expectedStaticPart}'.");
            Wait.ElementIsVisible(driver1, descriptionText1, 5);
            string actualdescriptionText = descriptionText.Text.Trim();
            // The static part of the message you expect
            string expectedDescriptionTextStaticPart = description;
            // Assert that the actual message contains the expected static part
            Assert.That(actualText.Contains(expectedDescriptionTextStaticPart),
                $"The actual text '{actualdescriptionText}' does not contain the expected text '{expectedDescriptionTextStaticPart}'.");

        }

        //ClickOnSeeListing
        public void ClickOnSeeListing()
        {
            seeButton.Click();
            Thread.Sleep(1000);
        }

        //ShowTheListingOnTheListingDetailPage
        public void ShowTheListingOnTheListingDetailPage(string title, string description, string Category, string SubCategory, string SkillExchange, string LocationType)
        {
            Thread.Sleep(1000);
            string skillTitleactualText = skillTitle.Text.Trim();
            // The static part of the message you expect
            Assert.That(skillTitleactualText.Contains(title), $"Title of element does not match expected.");

            string descriptionactualText = descriptionText.Text.Trim();
            // The static part of the message you expect
            Assert.That(descriptionactualText.Contains(description), $"Description of element does not match expected.");

            string categoryactualText = categoryText.Text.Trim();
            // The static part of the message you expect
            Assert.That(categoryactualText.Contains(Category), $"category of element does not match expected.");

            string subCategoryactualText = subCategoryText.Text.Trim();
            // The static part of the message you expect
            Assert.That(subCategoryactualText.Contains(SubCategory), $"subCategory of element does not match expected.");

            string skillExchangeactualText = skillExchangeText.Text.Trim();
            // The static part of the message you expect
            Assert.That(skillExchangeactualText.Contains(SkillExchange), $"skillExchange of element does not match expected.");

            string locationactualText = locationText.Text.Trim();
            // The static part of the message you expect
            Assert.That(locationactualText.Contains(LocationType), $"location of element does not match expected.");
        }

        //DeleteListing
        public void DeleteListing()
        {
            Wait.ElementIsVisible(driver1, deleteButton1, 5);
            deleteButton.Click();
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, yesButton1, 5);
            yesButton.Click();
        }




        //ListingShouldBeDeleteSuccessfully
        public void ListingShouldBeDeleteSuccessfully()
        {

            Wait.ElementIsVisible(driver1, deleteCheck1, 5);
            string actualdeleteCheck = deleteCheck.Text.Trim();
            // The static part of the message you expect
            string expecteddeleteCheckStaticPart = "has been deleted";
            // Assert that the actual message contains the expected static part
            Assert.That(actualdeleteCheck.Contains(expecteddeleteCheckStaticPart),
                $"The actual text '{actualdeleteCheck}' does not contain the expected text '{expecteddeleteCheckStaticPart}'.");

        }

        //SkillShouldBeshareSuccessfully
        public void SkillShouldBeshareSuccessfully(string TitleListing)
        {

            Wait.ElementIsVisible(driver1, titleListing1, 5);
            string actualdeleteCheck = titleListing.Text.Trim();
            // The static part of the message you expect
            string expecteddeleteCheckStaticPart = TitleListing;
            // Assert that the actual message contains the expected static part
            Assert.That(actualdeleteCheck.Contains(expecteddeleteCheckStaticPart),
                $"The actual text '{actualdeleteCheck}' does not contain the expected text '{expecteddeleteCheckStaticPart}'.");

        }

    }
}
  
