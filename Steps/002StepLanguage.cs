using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Steps
{
    public class _002StepLanguage
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly _002PageLanguage pageLanguageObj;

        public _002StepLanguage(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            pageLanguageObj = new _002PageLanguage(driver1);
        }

        public void StepNavigateToAccountProfile()
        {
            pageLanguageObj.NavigateToAccountProfile();
        }


        public void StepAddNewLanguage(string language, string languageLevel)
        {
            pageLanguageObj.addNewLanguage(language, languageLevel);
        }


        public void StepClickOnAddLanguage()
        {
            pageLanguageObj.clickAddLanguage();
        }

        public void StepLanguageShouldBeAddSuccessfully(string language, string languageLevel)
        {
            pageLanguageObj.languageShouldBeAddSuccessfully(language, languageLevel);
        }


        public void StepClickOnCancel()
        {
            pageLanguageObj.clickCancelLanguage();
        }


        public void StepAddLanguageButtonShouldBeGone()
        {
            pageLanguageObj.checkAddLanguageButtonDisappear();

        }


        public void StepEditALanguage(string language)
        {
            pageLanguageObj.EditALanguage(language);
        }


        public void StepEditALastLanguage(string language)
        {
            pageLanguageObj.EditALatsLanguage(language);
        }



        public void StepLanguageShouldBeEditedSuccessfully(string languageEdit)
        {
            pageLanguageObj.LanguageShouldBeEdited(languageEdit);
        }


        public void StepErrorThisLanguageIsAlreadyExistInYourLanguageList()
        {
            pageLanguageObj.ErrorThisLanguageIsAlreadyExistInYourLanguageList();
        }


        public void StepRemoveLanguage()
        {
            pageLanguageObj.RemoveLanguage();
        }

        public void StepDeleteALanguage(string languageDelete)
        {
            pageLanguageObj.DeleteALanguage(languageDelete);
        }

        public void StepLanguageShouldBeRemoveSuccessful()
        {
            pageLanguageObj.LanguageShouldBeRemoveSuccessful();
        }

        public void StepErrorPleaseEnterLanguageAndLevel()
        {
            pageLanguageObj.ErrorPleaseenterlanguageandlevel();
        }

        public void StepThisLanguageIsAlreadyAddedToYourLanguageList_()
        {
            pageLanguageObj.ErrorThisLanguageIsAlreadyAddedToYourLanguageList();
        }

        public void StepCheckExistingLanguage()
        {
            pageLanguageObj.CheckExistingLanguage();
        }
    }
}
