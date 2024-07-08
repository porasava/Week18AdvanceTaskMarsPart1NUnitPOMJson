using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.Account.ShareSkill;
using static Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Components.SignIn.Login;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Steps
{
    public class _004StepShareSkill
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly _004PageShareSkill pageShareSkillObj;

        public _004StepShareSkill(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            pageShareSkillObj = new _004PageShareSkill(driver1);
        }

        public void StepCreateAListing(string title, string description, string category, string subCategory, string tags, string skillExchange)
        {
            pageShareSkillObj.CreateAListing(title, description, category, subCategory, tags, skillExchange);
        }

        public void StepErrorTitleIsRequired()
        {
            pageShareSkillObj.ErrorTitleIsRequired();
        }

        public void StepErrorDescriptionIsRequired()
        {
            pageShareSkillObj.ErrorDescriptionIsRequired();
        }

        public void StepErrorCategoryIsRequired()
        {
            pageShareSkillObj.ErrorCategoryIsRequired();
        }

        public void StepErrorTagsAreRequired()
        {
            pageShareSkillObj.ErrorTagsAreRequired();
        }

        public void StepErrorSkill_ExchangeAreRequired()
        {
            pageShareSkillObj.ErrorSkillExchangeAreRequired();
        }


        public void StepNavigateToManageListingPage()
        {
            pageShareSkillObj.NavigateToManageListingPage();

        }

        public void StepEditListing(string title, string description, string category, string subCategory, string tags, string skillExchange)
        {
            pageShareSkillObj.EditAListing(title, description, category, subCategory, tags, skillExchange);
        }


        public void StepListingUpdateOnTheListingDetailPage(string title, string description)
        {
            pageShareSkillObj.ListingUpdateOnTheListingDetailPage(title, description);
        }

        public void StepClickOnSeeListing()
        {
            pageShareSkillObj.ClickOnSeeListing();
        }


        public void StepShowTheListingOnTheListingDetailPage(string title, string description, string Category, string SubCategory, string SkillExchange, string LocationType)
        {
            pageShareSkillObj.ShowTheListingOnTheListingDetailPage(title, description, Category, SubCategory, SkillExchange, LocationType);
        }

        public void StepDeleteListing()
        {
            pageShareSkillObj.DeleteListing();
        }

        public void StepListingShouldBeDeleteSuccessfully()
        {
            pageShareSkillObj.ListingShouldBeDeleteSuccessfully();
        }
        
        public void StepSkillShouldBeshareSuccessfully(string TitleListing)
        {
            pageShareSkillObj.SkillShouldBeshareSuccessfully(TitleListing);
        }
    }
}
