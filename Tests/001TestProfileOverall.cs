using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Models;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Tests
{
    public class _001ProfileOverall:Hooks
    {
        private List<ModelLogin> _ModelLogin;
        private List<_001ModelOverall> _ModelOverall;
        private List<_002ModelLanguage> _ModelLanguage;

        [SetUp]
        public new void Initialize()
        {
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);
            string jsonFilePathOverall = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "001TestDataProfileOverall.json");
            _ModelOverall = JsonReader.ReadOverallData(jsonFilePathOverall);
            string jsonFilePathLanguage = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "002TestDataLanguage.json");
            _ModelLanguage = JsonReader.ReadLanguageData(jsonFilePathLanguage);

        }


        [Test, Category("Overall")]
        // TS_101_TC_002 Valify that availability can edit
        public void TS_101_TC_002EditavailabilityOnProfilePage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelOverall.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _001ModelOverall OverallModel = _ModelOverall.FirstOrDefault(edu => edu.TestCaseId == "TS_101_TC_002");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepNavigateToAccountProfile();
                StepOverallObj.StepEditAvailability(OverallModel.availabiltyTypeInput);
                StepOverallObj.StepAvailabilityshouldChangeSuccessfully(OverallModel.availabiltyTypeInput);
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Overall")]
        // TS_101_TC_003 Valify that Hours can edit
        public void TS_101_TC_002EditHoursOnProfilePage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelOverall.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _001ModelOverall OverallModel = _ModelOverall.FirstOrDefault(edu => edu.TestCaseId == "TS_101_TC_003");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepNavigateToAccountProfile();
                StepOverallObj.StepEditHours(OverallModel.AvailabilityHourTypeInput);
                StepOverallObj.StepHoursshouldChangeSuccessfully(OverallModel.AvailabilityHourTypeInput);
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Overall")]
        // TS_101_TC_004 Valify that earn target can edit
        public void TS_101_TC_004EditEarnTargetOnProfilePage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelOverall.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _001ModelOverall OverallModel = _ModelOverall.FirstOrDefault(edu => edu.TestCaseId == "TS_101_TC_004");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepNavigateToAccountProfile();
                StepOverallObj.StepEditEarnTarget(OverallModel.availabiltyTargetInput);
                StepOverallObj.StepEarnTarGetshouldChangeSuccessfully(OverallModel.availabiltyTargetInput);
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

    }
}
