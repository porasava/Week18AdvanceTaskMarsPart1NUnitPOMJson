using AventStack.ExtentReports.Gherkin.Model;
using MongoDB.Driver;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Models;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Tests
{ 
    [TestFixture]
    public class _002LanguageTest : Hooks
    {
       
            private List<ModelLogin> _ModelLogin;
            private List<_002ModelLanguage> _ModelLanguage;

            [SetUp]
            public new void Initialize()
            {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string jsonFilePathLogin = Path.Combine(baseDirectory, "TestData", "TestDataLogin.json");
                _ModelLogin = JsonReader.ReadLoginData(jsonFilePathLogin);
                string jsonFilePathLanguage = Path.Combine(baseDirectory, "TestData", "002TestDataLanguage.json");
                _ModelLanguage = JsonReader.ReadLanguageData(jsonFilePathLanguage);

            }


            [Test, Category("Language")]
        // TS_201_TC_001 Verify that the user add a new Languages on the account profile page with correct mandatory
        public void TS_201_TC_001AddANewLanguagesWithCorrectMandatory()
            {
                // Ensure that _LoginModel is not empty and contains data
                if (_ModelLogin.Count > 0 && _ModelLanguage.Count > 0)
                {
                    var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                          // Find the specific test data for this test case
                    _002ModelLanguage LanguageModel = _ModelLanguage.FirstOrDefault(edu => edu.TestCaseId == "TS_201_TC_001");
                    LoginPageObj.NavigateToSkillsWeb();
                    LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                    LoginPageObj.ClickOnLogin();
                    StepLanguageObj.StepCheckExistingLanguage();
                    StepLanguageObj.StepAddNewLanguage(LanguageModel.Language, LanguageModel.LanguageLevel);
                    StepLanguageObj.StepClickOnAddLanguage();
                    StepLanguageObj.StepLanguageShouldBeAddSuccessfully(LanguageModel.Language, LanguageModel.LanguageLevel);
                    StepLanguageObj.StepRemoveLanguage();
                    StepLanguageObj.StepLanguageShouldBeRemoveSuccessful();
                }
                else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Language")]
        // TS_201_TC_002 Verify that the user add a new Languages on the account profile page with incorrect mandatory
        public void TS_201_TC_002AddANewLanguagesWithIncorrectMandatory()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelLanguage.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _002ModelLanguage LanguageModel = _ModelLanguage.FirstOrDefault(edu => edu.TestCaseId == "TS_201_TC_002");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepCheckExistingLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepErrorPleaseEnterLanguageAndLevel();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Language")]
        // TS_201_TC_003 Verify that the user add a new Languages on the account profile page with space on Add Language field
        public void TS_201_TC_003AddANewLanguagesWithSpace()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelLanguage.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _002ModelLanguage LanguageModel = _ModelLanguage.FirstOrDefault(edu => edu.TestCaseId == "TS_201_TC_003");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepCheckExistingLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepRemoveLanguage();
                StepLanguageObj.StepLanguageShouldBeRemoveSuccessful();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Language")]
        // TS_201_TC_004 Verify that the user add a new Languages on the account profile page with special character on Add Language field
        public void TS_201_TC_004AddANewLanguagesWithSpecialCharacter()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelLanguage.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _002ModelLanguage LanguageModel = _ModelLanguage.FirstOrDefault(edu => edu.TestCaseId == "TS_201_TC_004");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepCheckExistingLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepLanguageShouldBeAddSuccessfully(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepRemoveLanguage();
                StepLanguageObj.StepLanguageShouldBeRemoveSuccessful();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Language")]
        // TS_201_TC_005 Verify that the user add a new Languages on the account profile page with over 50 characters on Add Language field
        public void TS_201_TC_005AddANewLanguagesWithOver50Characters()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelLanguage.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _002ModelLanguage LanguageModel = _ModelLanguage.FirstOrDefault(edu => edu.TestCaseId == "TS_201_TC_005");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepCheckExistingLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepLanguageShouldBeAddSuccessfully(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepRemoveLanguage();
                StepLanguageObj.StepLanguageShouldBeRemoveSuccessful();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Language")]
        // TS_201_TC_006 Verify that the user add a new Languages on the account profile page with duplicate on Add Language field
        public void TS_201_TC_006AddANewLanguagesWithDuplicate()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelLanguage.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _002ModelLanguage LanguageModel = _ModelLanguage.FirstOrDefault(edu => edu.TestCaseId == "TS_201_TC_006");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepCheckExistingLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepLanguageShouldBeAddSuccessfully(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepErrorThisLanguageIsAlreadyExistInYourLanguageList();
                                StepLanguageObj.StepRemoveLanguage();
                StepLanguageObj.StepLanguageShouldBeRemoveSuccessful();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Language")]
        // TS_201_TC_007 Verify that the user add new 4 Languages on the account profile page with a paragraph on Add Language field
        public void TS_201_TC_007AddNew4Languages()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelLanguage.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _002ModelLanguage LanguageModel = _ModelLanguage.FirstOrDefault(edu => edu.TestCaseId == "TS_201_TC_007");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepCheckExistingLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language2, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language3, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language4, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepLanguageShouldBeAddSuccessfully(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepRemoveLanguage();
                StepLanguageObj.StepRemoveLanguage();
                StepLanguageObj.StepRemoveLanguage();
                StepLanguageObj.StepRemoveLanguage();
                StepLanguageObj.StepLanguageShouldBeRemoveSuccessful();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }


        [Test, Category("Language")]
        // TS_201_TC_008 Verify that the user click on cancel button on language tab
        public void TS_201_TC_008ClickOnCancelButton()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelLanguage.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _002ModelLanguage LanguageModel = _ModelLanguage.FirstOrDefault(edu => edu.TestCaseId == "TS_201_TC_008");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepCheckExistingLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnCancel();
                
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Language")]
        // TS_202_TC_001 Verify that the user edit a Languages on the account profile page
        public void TS_202_TC_001EditALanguages()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelLanguage.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _002ModelLanguage LanguageModel = _ModelLanguage.FirstOrDefault(edu => edu.TestCaseId == "TS_202_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepCheckExistingLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepLanguageShouldBeAddSuccessfully(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepEditALanguage(LanguageModel.LanguageEdit);
                StepLanguageObj.StepLanguageShouldBeEditedSuccessfully(LanguageModel.LanguageEdit);
                StepLanguageObj.StepRemoveLanguage();
                StepLanguageObj.StepLanguageShouldBeRemoveSuccessful();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }

        [Test, Category("Language")]
        // TS_203_TC_001 Verify that the user delete a Languages on the account profile page
        public void TS_203_TC_001DeleteALanguages()
        {
            // Ensure that _LoginModel is not empty and contains data
            if (_ModelLogin.Count > 0 && _ModelLanguage.Count > 0)
            {
                var loginModel = _ModelLogin.First(); // or use a specific index if needed
                                                      // Find the specific test data for this test case
                _002ModelLanguage LanguageModel = _ModelLanguage.FirstOrDefault(edu => edu.TestCaseId == "TS_203_TC_001");
                LoginPageObj.NavigateToSkillsWeb();
                LoginPageObj.InputUsernameAndPassword(loginModel.username, loginModel.password);
                LoginPageObj.ClickOnLogin();
                StepLanguageObj.StepCheckExistingLanguage();
                StepLanguageObj.StepAddNewLanguage(LanguageModel.Language, LanguageModel.LanguageLevel);
                StepLanguageObj.StepClickOnAddLanguage();
                StepLanguageObj.StepRemoveLanguage();
                StepLanguageObj.StepLanguageShouldBeRemoveSuccessful();
            }
            else
            {//Assertions to validate the login
                Assert.Fail("Login credentials not found in the test data");
            }
        }
   

    }
}
