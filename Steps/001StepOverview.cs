using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.Account.Profile;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Steps
{
    public class _001StepOverall
    {

        private readonly IWebDriver driver1;
        private readonly _001PageOverview pageOverviewObj;

        public _001StepOverall(IWebDriver _driver)
        {
            driver1 = _driver;
            pageOverviewObj = new _001PageOverview(driver1);
        }

        public void StepEditAvailability(string availabiltyTypeInput)
        {
            pageOverviewObj.EditAvailability(availabiltyTypeInput);
        }
        public void StepAvailabilityshouldChangeSuccessfully(string availabiltyTypeInput)
        {
            pageOverviewObj.AvailabilityshouldChangeSuccessfully(availabiltyTypeInput);
        }
        public void StepEditHours(string AvailabilityHourTypeInput)
        {
            pageOverviewObj.EditHours(AvailabilityHourTypeInput);
         }
        public void StepHoursshouldChangeSuccessfully(string AvailabilityHourTypeInput)
        {
            pageOverviewObj.HoursshouldChangeSuccessfully(AvailabilityHourTypeInput);
         }
        public void StepEditEarnTarget(string availabiltyTargetInput)
        {
            pageOverviewObj.EditEarnTarget(availabiltyTargetInput);
          }
        public void StepEarnTarGetshouldChangeSuccessfully(string availabiltyTargetInput)
        {
            pageOverviewObj.EarnTarGetshouldChangeSuccessfully(availabiltyTargetInput);
          }
    }
}
