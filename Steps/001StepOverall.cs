using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Steps
{
    public class _001StepOverall
    {

        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly _001PageOverall pageOverallObj;

        public _001StepOverall(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            pageOverallObj = new _001PageOverall(driver1);
        }

        public void StepEditAvailability(string availabiltyTypeInput)
        {
            pageOverallObj.EditAvailability(availabiltyTypeInput);
        }
        public void StepAvailabilityshouldChangeSuccessfully(string availabiltyTypeInput)
        {
            pageOverallObj.AvailabilityshouldChangeSuccessfully(availabiltyTypeInput);
        }
        public void StepEditHours(string AvailabilityHourTypeInput)
        {
            pageOverallObj.EditHours(AvailabilityHourTypeInput);
         }
        public void StepHoursshouldChangeSuccessfully(string AvailabilityHourTypeInput)
        {
            pageOverallObj.HoursshouldChangeSuccessfully(AvailabilityHourTypeInput);
         }
        public void StepEditEarnTarget(string availabiltyTargetInput)
        {
            pageOverallObj.EditEarnTarget(availabiltyTargetInput);
          }
        public void StepEarnTarGetshouldChangeSuccessfully(string availabiltyTargetInput)
        {
            pageOverallObj.EarnTarGetshouldChangeSuccessfully(availabiltyTargetInput);
          }
    }
}
