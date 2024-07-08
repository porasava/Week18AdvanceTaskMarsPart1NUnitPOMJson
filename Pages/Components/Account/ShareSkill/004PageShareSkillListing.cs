using AventStack.ExtentReports.Model;
using MongoDB.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.Account.ShareSkill
{
    public class _004PageShareSkill
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _004PageShareSkill(IWebDriver _driver)
        {
            driver1 = _driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }

        private IWebElement titleActivateCheck;
        private IWebElement DescriptionActivateCheck;
        private IWebElement CategoryactivateCheck ;
        private IWebElement TagsActivateCheck ;
        private IWebElement SkillsActivateCheck ;
        private IWebElement shareSkillButton;
        private IWebElement shareSkillTitle;
        private IWebElement descriptionText;
        private IWebElement categoryDropdown ;
        private IWebElement tagsText;
        private IWebElement skillExchangeText;
        private IWebElement shareSkillSave;
        private IWebElement EditSkillButton;
        private IWebElement subCategoryDropdown;
        private IWebElement manageListingButton ;
        private IWebElement seeButton;
        private IWebElement skillTitle ;
        private IWebElement categoryText ;
        private IWebElement subCategoryText ;
        private IWebElement locationText ;
        private IWebElement deleteButton ;
        private IWebElement yesButton ;
        private IWebElement deleteCheck ;
        private IWebElement titleListing ;
        private IWebElement Screenrefresh ;

        public void renderShareSkillComponents()
        {
            try
            {
                
        titleActivateCheck = driver1.FindElement(By.XPath("//div[@class='twelve wide column']//div//div[@class='ui basic red prompt label transition visible']"));
        DescriptionActivateCheck = driver1.FindElement(By.XPath("//div[@class='tooltip-target ui grid']//div[@class='row']//div[@class='ui twelve wide column']//div//div[@class='ui basic red prompt label transition visible']"));
        CategoryactivateCheck = driver1.FindElement(By.XPath("//div[normalize-space()='Category is required']"));
        TagsActivateCheck = driver1.FindElement(By.XPath("//div[contains(text(),'Tags are required')]"));
        SkillsActivateCheck = driver1.FindElement(By.XPath("//div[contains(text(),'Tag is required')]"));
        shareSkillButton = driver1.FindElement(By.XPath("//a[normalize-space()='Share Skill']"));
        shareSkillTitle = driver1.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));
        descriptionText = driver1.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
        categoryDropdown = driver1.FindElement(By.XPath("//select[@name='categoryId']"));
        tagsText = driver1.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
        skillExchangeText = driver1.FindElement(By.XPath("//div[contains(@class,'twelve wide column')]//div[contains(@class,'')]//div[contains(@class,'form-wrapper')]//input[contains(@placeholder,'Add new tag')]"));
        shareSkillSave = driver1.FindElement(By.XPath("//input[@value='Save']"));
        EditSkillButton = driver1.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[2]/i[1]"));
        subCategoryDropdown = driver1.FindElement(By.XPath("//select[@name='subcategoryId']"));
        manageListingButton = driver1.FindElement(By.XPath("//a[normalize-space()='Manage Listings']"));
        seeButton = driver1.FindElement(By.XPath("//i[@class='eye icon']"));
        skillTitle = driver1.FindElement(By.XPath("//span[@class='skill-title']"));
        categoryText = driver1.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]"));
        subCategoryText = driver1.FindElement(By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[2]/div/div[2]/div/div[2]"));
        locationText = driver1.FindElement(By.XPath("//div[@class='ui container']//div[3]//div[1]//div[3]//div[1]//div[2]"));
        deleteButton = driver1.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[3]"));
        yesButton = driver1.FindElement(By.XPath("//button[@class='ui icon positive right labeled button']"));
        deleteCheck = driver1.FindElement(By.XPath("//div[@class='ns-box-inner']"));
        titleListing = driver1.FindElement(By.XPath("//tbody/tr[1]/td[3]"));
        Screenrefresh = driver1.FindElement(By.XPath("//div[@id='service-listing-section']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShareSkillButtonComponents()
        {
            try
            {
                shareSkillButton = driver1.FindElement(By.XPath("//a[normalize-space()='Share Skill']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

     
        public void renderShareSkillScreenReFreshComponents()
        {
            try
            {
                Screenrefresh = driver1.FindElement(By.XPath("//div[@id='service-listing-section']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareSkillCreateListingComponents()
        {
            try
            {
                shareSkillTitle = driver1.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));
                descriptionText = driver1.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
                categoryDropdown = driver1.FindElement(By.XPath("//select[@name='categoryId']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShareSkillDescriptionComponents()
        {
            try
            {
                DescriptionActivateCheck = driver1.FindElement(By.XPath("//div[@class='tooltip-target ui grid']//div[@class='row']//div[@class='ui twelve wide column']//div//div[@class='ui basic red prompt label transition visible']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShareSkillSubCatComponents()
        {
            try
            {
                subCategoryDropdown = driver1.FindElement(By.XPath("//select[@name='subcategoryId']"));
                tagsText = driver1.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
                skillExchangeText = driver1.FindElement(By.XPath("//div[contains(@class,'twelve wide column')]//div[contains(@class,'')]//div[contains(@class,'form-wrapper')]//input[contains(@placeholder,'Add new tag')]"));
                shareSkillSave = driver1.FindElement(By.XPath("//input[@value='Save']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareSkillTagComponents()
        {
            try
            {
                tagsText = driver1.FindElement(By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShareSkillExchangeComponents()
        {
            try
            {
                skillExchangeText = driver1.FindElement(By.XPath("//div[contains(@class,'twelve wide column')]//div[contains(@class,'')]//div[contains(@class,'form-wrapper')]//input[contains(@placeholder,'Add new tag')]"));
                shareSkillSave = driver1.FindElement(By.XPath("//input[@value='Save']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShareSkillCategoryactivateComponents()
        {
            try
            {
                CategoryactivateCheck = driver1.FindElement(By.XPath("//div[normalize-space()='Category is required']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShareSkillTagsActivateComponents()
        {
            try
            {
                TagsActivateCheck = driver1.FindElement(By.XPath("//div[contains(text(),'Tags are required')]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void renderShareSkillSkillsActivatComponents()
        {
            try
            {
                SkillsActivateCheck = driver1.FindElement(By.XPath("//div[contains(text(),'Tag is required')]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

       
        public void renderShareSkillEditComponents()
        {
            try
            {
                shareSkillTitle = driver1.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));
                descriptionText = driver1.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
                categoryDropdown = driver1.FindElement(By.XPath("//select[@name='categoryId']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        public void renderShareSkillEditButtonComponents()
        {
            try
            {
                EditSkillButton = driver1.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[2]/i[1]"));
                shareSkillTitle = driver1.FindElement(By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"));
                descriptionText = driver1.FindElement(By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"));
                categoryDropdown = driver1.FindElement(By.XPath("//select[@name='categoryId']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderShareSkilltitleListingComponents()
        {
            try
            {
                titleListing = driver1.FindElement(By.XPath("//tbody/tr[1]/td[3]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShareSkilldeleteButtonComponents()
        {
            try
            {
                deleteButton = driver1.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[3]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderShareSkillYesComponents()
        {
            try
            {
                yesButton = driver1.FindElement(By.XPath("//button[@class='ui icon positive right labeled button']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        
        public void renderShareSkillmanageListingComponents()
        {
            try
            {
                manageListingButton = driver1.FindElement(By.XPath("//a[normalize-space()='Manage Listings']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        //ErrorTitleIsRequired
        public void ErrorTitleIsRequired()
        {
            Wait.ElementIsVisible(driver1, By.XPath("//div[@class='twelve wide column']//div//div[@class='ui basic red prompt label transition visible']"), 8);
            renderShareSkillComponents();
            By locator = By.XPath("//div[@class='twelve wide column']//div//div[@class='ui basic red prompt label transition visible']");
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Title is required";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator);
            Thread.Sleep(1000);

        }

        //ErrorDescriptionIsRequired
        public void ErrorDescriptionIsRequired()
        {
            Wait.WaitForElementPresent(driver1, By.XPath("//div[@class='tooltip-target ui grid']//div[@class='row']//div[@class='ui twelve wide column']//div//div[@class='ui basic red prompt label transition visible']"), 5);
            renderShareSkillDescriptionComponents();
            By locator = By.XPath("//div[@class='tooltip-target ui grid']//div[@class='row']//div[@class='ui twelve wide column']//div//div[@class='ui basic red prompt label transition visible']");
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Description is required";

            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator);
            Thread.Sleep(1000);

        }

        //ErrorCategoryIsRequired
        public void ErrorCategoryIsRequired()
        {
            Wait.ElementIsVisible(driver1, By.XPath("//div[normalize-space()='Category is required']"), 5);
            renderShareSkillCategoryactivateComponents();
            By locator = By.XPath("//div[normalize-space()='Category is required']");
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Category is required";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator);
            Thread.Sleep(1000);

        }

        //ErrorTagsAreRequired
        public void ErrorTagsAreRequired()
        {

            Wait.ElementIsVisible(driver1, By.XPath("//div[contains(text(),'Tags are required')]"), 5);
            renderShareSkillTagsActivateComponents();
            By locator = By.XPath("//div[contains(text(),'Tags are required')]");
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Tags are required";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator);
            Thread.Sleep(1000);

        }

        //ErrorSkill_ExchangeAreRequired
        public void ErrorSkillExchangeAreRequired()
        {
            Wait.ElementIsVisible(driver1, By.XPath("//div[contains(text(),'Tag is required')]"), 5);
            renderShareSkillSkillsActivatComponents();
            By locator = By.XPath("//div[contains(text(),'Tag is required')]");
            // The static part of the message you expect
            string expectedactivateCheckStaticPart = "Tag is required";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedactivateCheckStaticPart, locator); ;
            Thread.Sleep(1000);
        }


        //CreateAListing
        public void CreateAListing(string title, string description, string category, string subCategory, string tags, string skillExchange)
        {
            Wait.ElementIsVisible(driver1, By.XPath("//a[normalize-space()='Share Skill']"), 5);
            renderShareSkillButtonComponents();
            shareSkillButton.Click();
            renderShareSkillScreenReFreshComponents();
            Screenrefresh.Click();
            driver1.Navigate().Refresh();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, By.XPath("//input[@placeholder='Write a title to describe the service you provide.']"), 5);
            renderShareSkillCreateListingComponents();
            shareSkillTitle.SendKeys(title);
            Wait.WaitToBeClickable(driver1, By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"), 5);
            descriptionText.Clear();
            descriptionText.SendKeys(description);
            Wait.WaitToBeClickable(driver1, By.XPath("//select[@name='categoryId']"), 5);
            categoryDropdown.SendKeys(category);
            Thread.Sleep(1000);
            if (string.IsNullOrEmpty(subCategory))
            {
                Thread.Sleep(1000);
                Wait.WaitToBeClickable(driver1, By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"), 5);
                renderShareSkillTagComponents();
                tagsText.SendKeys(tags);
                tagsText.SendKeys(Keys.Enter);
            }
            else
            {
                Thread.Sleep(1000);
                Wait.WaitToBeClickable(driver1, By.XPath("//select[@name='subcategoryId']"), 5);
                renderShareSkillSubCatComponents();
                subCategoryDropdown.Click();
                subCategoryDropdown.SendKeys(subCategory);
                Wait.WaitToBeClickable(driver1, By.XPath("//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]"), 5);
                tagsText.SendKeys(tags);
                tagsText.SendKeys(Keys.Enter);
            }
            renderShareSkillExchangeComponents();
            skillExchangeText.Click();
            Wait.WaitToBeClickable(driver1, By.XPath("//div[contains(@class,'twelve wide column')]//div[contains(@class,'')]//div[contains(@class,'form-wrapper')]//input[contains(@placeholder,'Add new tag')]"), 5);
            skillExchangeText.SendKeys(skillExchange);
            skillExchangeText.SendKeys(Keys.Enter);
            shareSkillSave.Click();
        }


        public void EditAListing(string title, string description, string category, string subCategory, string tags, string skillExchange)
        {
            renderShareSkillEditButtonComponents();
            EditSkillButton.Click();
            Thread.Sleep(1000);
            renderShareSkillEditComponents();
            shareSkillTitle.Clear();
            shareSkillTitle.SendKeys(title);
            descriptionText.Clear();
            descriptionText.SendKeys(description);
            categoryDropdown.SendKeys(category);
            renderShareSkillSubCatComponents();
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
            renderShareSkillmanageListingComponents();
            manageListingButton.Click();
            Thread.Sleep(1000);
        }

        //ListingUpdateOnTheListingDetailPage
        public void ListingUpdateOnTheListingDetailPage(string title, string description)
        {
            renderShareSkillComponents();
            seeButton.Click();
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, By.XPath("//span[@class='skill-title']"), 5);
            string actualText = skillTitle.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = title;
            // Assert that the actual message contains the expected static part
            Assert.That(actualText.Contains(expectedStaticPart),
                $"The actual text '{actualText}' does not contain the expected text '{expectedStaticPart}'.");
            Wait.ElementIsVisible(driver1, By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']"), 5);
            By locator = By.XPath("//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']");
            // The static part of the message you expect
            string expectedDescriptionTextStaticPart = description;
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expectedDescriptionTextStaticPart, locator); ;

        }

        //ClickOnSeeListing
        public void ClickOnSeeListing()
        {
            renderShareSkillComponents();
            seeButton.Click();
            Thread.Sleep(1000);
        }

        //ShowTheListingOnTheListingDetailPage
        public void ShowTheListingOnTheListingDetailPage(string title, string description, string Category, string SubCategory, string SkillExchange, string LocationType)
        {
            Thread.Sleep(1000);
            renderShareSkillComponents();
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
            Wait.ElementIsVisible(driver1, By.XPath("//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[8]/div[1]/button[3]"), 5);
            renderShareSkilldeleteButtonComponents();
            deleteButton.Click();
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, By.XPath("//button[@class='ui icon positive right labeled button']"), 5);
            renderShareSkillYesComponents();
            yesButton.Click();
        }




        //ListingShouldBeDeleteSuccessfully
        public void ListingShouldBeDeleteSuccessfully()
        {

            Wait.ElementIsVisible(driver1, By.XPath("//div[@class='ns-box-inner']"), 5);
            renderShareSkillComponents();
            By locator = By.XPath("//div[@class='ns-box-inner']");
            // The static part of the message you expect
            string expecteddeleteCheckStaticPart = "has been deleted";
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expecteddeleteCheckStaticPart, locator);

        }

        //SkillShouldBeshareSuccessfully
        public void SkillShouldBeshareSuccessfully(string TitleListing)
        {

            Wait.ElementIsVisible(driver1,By.XPath("//tbody/tr[1]/td[3]"), 5);
            renderShareSkilltitleListingComponents();
            By locator = By.XPath("//tbody/tr[1]/td[3]");
            // The static part of the message you expect
            string expecteddeleteCheckStaticPart = TitleListing;
            // Assert that the actual message contains the expected static part
            pageAssertions.AssertElementTextContainsIWeb(expecteddeleteCheckStaticPart, locator);

        }
    }
}