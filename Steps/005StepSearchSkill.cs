using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Steps
{
    public class _005StepSearchSkill
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly _005PageSearchSkill pageSearchSkillObj;

        public _005StepSearchSkill(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            pageSearchSkillObj = new _005PageSearchSkill(driver1);
        }

        public void StepSearchASkill(string title)
        {
            pageSearchSkillObj.SearchforAskill(title);

        }

        public void StepDisplaySkillOnTheResultPage()
        {
            pageSearchSkillObj.DisplaySkillOnTheResultPage();
        }

        //ClickOnLink
        public void StepClickOnLink(string skill)
        {
            pageSearchSkillObj.ClickOnLink(skill);
        }

        //ClickOnVideoSubcategory
        public void StepClickOnVideoSubcategory()
        {
            pageSearchSkillObj.ClickOnVideoSubcategory();
        }

        //StepSubVideoSubcategoryShouldBeBold
        public void StepSubVideoSubcategoryShouldBeBold()
        {
            pageSearchSkillObj.SubVideoSubcategoryShouldBeBold();
        }

        //SearchSkillFilter
        public void StepSearchSkillFilter(string buttonName,string SkillSearch)
        {
            pageSearchSkillObj.SearchSkillFilter(buttonName, SkillSearch);
        }
        //SearchSkillFilterResult
        public void StepSearchSkillFilterResultOnline()
        {
            pageSearchSkillObj.SearchSkillFilterResultOnline();
        }

        //SearchSkillFilterResultOnsite
        public void StepSearchSkillFilterResultOnsite()
        {
            pageSearchSkillObj.SearchSkillFilterResultOnsite();
        }
        //SearchSkillFilterResultAll
        public void StepSearchSkillFilterResultAll ()
        {
            pageSearchSkillObj.SearchSkillFilterResultAll();
        }
    }
}
