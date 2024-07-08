using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Models;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Tests 
{[TestFixture]
    public class _005SearchSkillTest : Hooks
{
        
        private List<ModelLogin> _ModelLogin;
        private List<_005ModelSearchSkill> _ModelSearchSkill;

        [SetUp]
        public new void Initialize()
        {
            string jsonFilePathLogin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "TestDataLogin.json");
            _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);
            string jsonFilePathSearchSkill = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestData", "005TestDataSearchSkill.json");
            _ModelSearchSkill = JsonReader.ReadSearchSkillData(jsonFilePathSearchSkill);

        }


        [Test, Category("SearchSkill")]
        // TS_501_TC_001 Verify the 'Explore Categories' link for Graphic Design on the home page
        public void TS_501_TC_001SearchGraphicDesignOnTheHomepage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_501_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("SearchSkill")]
        // TS_501_TC_002 Verify the 'Explore Categories' link for Digital Marketing on the home page
        public void TS_501_TC_002SearchDigitalMarketingOnTheHomePpage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_501_TC_002");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("SearchSkill")]
        // TS_501_TC_003 Verify the 'Explore Categories' link for Writing & Translation on the home page
        public void TS_501_TC_003SearchforWritingTranslationOnTheHomePage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_501_TC_003");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("SearchSkill")]
        // TS_501_TC_004 Verify the 'Explore Categories' link for Music Audio on the home page
        public void TS_501_TC_004SearchMusicAudioOnTheHomePage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_501_TC_004");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("SearchSkill")]
        // TS_501_TC_005 Verify the 'Explore Categories' link for Programmimg Tech on the home page
        public void TS_501_TC_005SearchProgrammimgTechOnTheHomePage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_501_TC_005");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("SearchSkill")]
        // TS_501_TC_006 Verify the 'Explore Categories' link for Business on the home page
        public void TS_501_TC_006SearchForBusinessOnTheHomePage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_501_TC_006");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("SearchSkill")]
        // TS_501_TC_007 Verify the 'Explore Categories' link for Fun & Lifestyle on the home page
        public void TS_501_TC_007SearchForFunLifestyleOnTheHomePage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_501_TC_007");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("SearchSkill")]
        // TS_501_TC_008 Verify the 'Explore Categories' link for Video and animation on the home page
        public void TS_501_TC_008SearchForVideoAndAnimationOnTheHomePage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_501_TC_008");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("SearchSkill")]
        // TS_502_TC_001 Verify the sub categories for Video and animation on the home page
        public void TS_502_TC_001SearchForSubCategoriesForVideoAndAnimationOnTheHomePage()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_502_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
                StepSearchSkillObj.StepClickOnVideoSubcategory();
                StepSearchSkillObj.StepSubVideoSubcategoryShouldBeBold();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("SearchSkill")]
        // TS_503_TC_001 Verify skill by filter online
        public void TS_503_TC_001SearchSkillByFilterOnline()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_503_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
                StepSearchSkillObj.StepSearchSkillFilter(SearchSkillModel.buttonName, SearchSkillModel.SkillSearch);
                StepSearchSkillObj.StepSearchSkillFilterResultOnline();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("SearchSkill")]
        // TS_503_TC_002 Verify skill by filter onsite
        public void TS_503_TC_002SearchSkillByFilterOnsite()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_503_TC_002");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
                StepSearchSkillObj.StepSearchSkillFilter(SearchSkillModel.buttonName, SearchSkillModel.SkillSearch);
                StepSearchSkillObj.StepSearchSkillFilterResultOnsite();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("SearchSkill")]
        // TS_503_TC_003 Verify skill by filter show all
        public void TS_503_TC_003SearchSkillByFilterShowAll()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelSearchSkill.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _005ModelSearchSkill SearchSkillModel = _ModelSearchSkill.FirstOrDefault(edu => edu.TestCaseId == "TS_503_TC_003");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepSearchSkillObj.StepClickOnLink(SearchSkillModel.Skill);
                StepSearchSkillObj.StepDisplaySkillOnTheResultPage();
                StepSearchSkillObj.StepSearchSkillFilter(SearchSkillModel.buttonName, SearchSkillModel.SkillSearch);
                StepSearchSkillObj.StepSearchSkillFilterResultAll();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }
        


    }
}
