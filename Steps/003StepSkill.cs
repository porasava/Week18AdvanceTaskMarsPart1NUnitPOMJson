using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Steps
{
    public class _003StepSkill
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly _003PageSkill pageSkillObj;

        public _003StepSkill(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            pageSkillObj = new _003PageSkill(driver1);
        }


        public void StepNavigateToAccountProfileSkill()
        {
            pageSkillObj.NavigateToAccountProfileSkill();
        }

        public void StepAddANewSkill(string skillName, string skillLevel)
        {
            pageSkillObj.AddANewSkill(skillName, skillLevel);
        }

        public void StepShowANewSkill()
        {
            pageSkillObj.ShowNewSkill();
        }

        public void StepDeleteASkill(string skillDelete)
        {
            pageSkillObj.DeleteASkill(skillDelete);
        }

        public void StepSkillShouldBeRemoveSuccessfully()
        {
            pageSkillObj.SkillShouldBeRemoveSuccessfully();
        }

        public void StepErrorPleaseEnterSkillAndExperienceLevel()
        {
            pageSkillObj.ErrorPleaseEnterSkillAndExperienceLevel();
        }

        public void StepErrorThisskillIsAlreadyExistInYourSkillList()
        {
            pageSkillObj.ErrorThisskillIsAlreadyExistInYourSkillList();
        }
        public void StepEditASkill(string skill)
        {
            pageSkillObj.EditASkill(skill);
        }

        public void StepTheSkillShouldEditSuccessfully()
        {
            pageSkillObj.SkillShouldEditSuccessfully();
        }

        public void StepSkillShouldDeleteSuccessfully()
        {
            pageSkillObj.SkillShouldBeRemoveSuccessfully();
        }
        public void StepCheckExistingSkill()
        {
            pageSkillObj.checkExistingSkill();
        }
    }
}
