using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.HomePage.SearchSkill;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.HomePage.SearchSkill.ResultPage;
using static Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Components.SignIn.Login;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Steps
{
    public class _005StepSearchSkill
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly _005PageSearchSkill pageSearchSkillObj;
        private readonly _005PageSearchSkillFilter pageSearchSkillFilterObj;
        private readonly _005PageSearchSkillSubCategories pageSearchSkillSubCategoriesObj;
        private readonly _005PageSearchSkillResult pageSearchSkillSubCategoriesResultObj;
        public _005StepSearchSkill(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            pageSearchSkillObj = new _005PageSearchSkill(driver1);
            pageSearchSkillFilterObj = new _005PageSearchSkillFilter(driver1);
            pageSearchSkillSubCategoriesObj = new _005PageSearchSkillSubCategories(driver1);
            pageSearchSkillSubCategoriesResultObj = new _005PageSearchSkillResult(driver1);


        }

        public void StepSearchASkill(string title)
        {
            pageSearchSkillObj.SearchforAskill(title);

        }

        public void StepDisplaySkillOnTheResultPage()
        {
            pageSearchSkillSubCategoriesResultObj.DisplaySkillOnTheResultPage();
        }

        //ClickOnLink
        public void StepClickOnLink(string skill)
        {
            pageSearchSkillObj.ClickOnLink(skill);
        }

        //ClickOnVideoSubcategory
        public void StepClickOnVideoSubcategory()
        {
            pageSearchSkillSubCategoriesObj.ClickOnVideoSubcategory();
        }

        //StepSubVideoSubcategoryShouldBeBold
        public void StepSubVideoSubcategoryShouldBeBold()
        {
            pageSearchSkillSubCategoriesObj.SubVideoSubcategoryShouldBeBold();
        }

        //SearchSkillFilter
        public void StepSearchSkillFilter(string buttonName,string SkillSearch)
        {
            pageSearchSkillFilterObj.SearchSkillFilter(buttonName, SkillSearch);
        }
        //SearchSkillFilterResult
        public void StepSearchSkillFilterResultOnline()
        {
            pageSearchSkillFilterObj.SearchSkillFilterResultOnline();
        }

        //SearchSkillFilterResultOnsite
        public void StepSearchSkillFilterResultOnsite()
        {
            pageSearchSkillFilterObj.SearchSkillFilterResultOnsite();
        }
        //SearchSkillFilterResultAll
        public void StepSearchSkillFilterResultAll ()
        {
            pageSearchSkillFilterObj.SearchSkillFilterResultAll();
        }
    }
}
