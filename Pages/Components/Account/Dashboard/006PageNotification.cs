using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Utilities;

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.Account.Dashboard
{
    public class _006PageNotification
    {
        private readonly IWebDriver driver1;
        private readonly Assertions.Assertions pageAssertions;

        public _006PageNotification(IWebDriver _driver)
        {
            driver1 = _driver;
            pageAssertions = new Assertions.Assertions(driver1);
        }
        By NotificationDropdown1;
        private IWebElement NotificationDropdown;
        By SeeAllDropdown1;
        private IWebElement SeeAllDropdown;
        By SelectAll1;
        private IWebElement SelectAll;
        private IWebElement UnSelectAll;
        By deleteButton1;
        private IWebElement deleteButton;
        private IWebElement MessageDelete;
        By notificationMessage1;
        private IWebElement notificationMessage;
        By DashboardTab1;
        private IWebElement DashboardTab;
        By notification1;
        private IWebElement notification;
        By LoadMoreButton1;
        private IWebElement LoadMoreButton;
        By ShowLessButton1;
        private IWebElement ShowLessButton;
        By MarkAsRead1;
        private IWebElement MarkAsRead;
        By PopUp1;
        private IWebElement PopUp;
        private IWebElement MessageRequest;
        private IWebElement requestSkillTrade;
        private By withdrawRequest1;
        private IWebElement withdrawRequest;
        private IWebElement SearchSkill;
        private IWebElement ConfirmrequestSkillTrade;
        private IWebElement Listing;

        public void renderClickOnNotificationComponents()
        {
            try
            {
                NotificationDropdown1 = By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div");
                Wait.WaitToBeClickable(driver1, NotificationDropdown1, 15);
                NotificationDropdown = driver1.FindElement(NotificationDropdown1);
             }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderClickOnSeeAllNotificationComponents()
        {
            try
            {
                SeeAllDropdown1 = By.XPath("//div[@class='ui link item']//div//center//a");
                Wait.WaitToBeClickable(driver1, SeeAllDropdown1, 15);
                SeeAllDropdown = driver1.FindElement(SeeAllDropdown1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSelectAllLinkComponents()
        {
            try
            {
               
                SelectAll1 = By.XPath("//i[@class='mouse pointer icon']");
                SelectAll = driver1.FindElement(SelectAll1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderClickUnselectAllLinkComponents()
        {
            try
            {
              UnSelectAll = driver1.FindElement(By.XPath("//div[@class='ui icon basic button button-icon-style']"));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderUserClickDeleteAMessageComponents()
        {
            try
            {
               
                deleteButton1 = By.XPath("//div[@data-tooltip='Delete selection']");
                deleteButton = driver1.FindElement(deleteButton1);
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderMessageDeleteComponents()
        {
            try
            { 
                MessageDelete = driver1.FindElement(By.XPath("/html/body/div[1]/div"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderUserSelectAMessageComponents()
        {
            try
            {
                
                notificationMessage1 = By.XPath("//input[@value='0']");
                Wait.WaitToBeClickable(driver1, notificationMessage1, 15);
                notificationMessage = driver1.FindElement(notificationMessage1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public void renderSelectedDashboardComponents()
        {
            try
            {
                DashboardTab1 = By.XPath("//div[@class='four wide column']//div//h3");
                DashboardTab = driver1.FindElement(DashboardTab1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void rendernotificationPageComponents()
        {
            try
            { 
                notification1 = By.XPath("//h1[normalize-space()='Notifications']");
                Wait.WaitToBeClickable(driver1, notification1, 18);
                notification = driver1.FindElement(notification1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderCLickSeeMoreNotificationComponents()
        {
            try
            {
                LoadMoreButton1 = By.XPath("//a[@class='ui button']");
                Wait.WaitToBeClickable(driver1, LoadMoreButton1, 18);
                LoadMoreButton = driver1.FindElement(LoadMoreButton1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderClickShowLessNotificationComponents()
        {
            try
            {
               ShowLessButton1 = By.XPath("//div[@class='ui items segment']//div//div[1]//center[1]//a[1]");
                Wait.WaitToBeClickable(driver1, ShowLessButton1, 18);
                ShowLessButton = driver1.FindElement(ShowLessButton1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSelectMarkAsReadComponents()
        {
            try
            {
                MarkAsRead1 = By.XPath("//div[@data-tooltip='Mark selection as read']");
                Wait.WaitToBeClickable(driver1, MarkAsRead1, 18);
                MarkAsRead = driver1.FindElement(MarkAsRead1);  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderNotificationUpdatedComponents()
        {
            try
            {   
                PopUp1 = By.XPath("//div[@class='ns-box-inner']");
                Wait.WaitToBeClickable(driver1, PopUp1, 18);
                PopUp = driver1.FindElement(PopUp1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderSearchForAListingComponents()
        {
            try
            {
             By CheckSkillResultDisplay1 = By.XPath("//a[@role='listitem']//b");
             Wait.ElementIsVisible(driver1, CheckSkillResultDisplay1, 10);
             By SearchSkill1 = By.XPath("//input[@placeholder='Search skills']");
             SearchSkill = driver1.FindElement(SearchSkill1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        public void renderClickForAListingComponents()
        {
            try
            {   By Listing1 = By.XPath("//p[@class='row-padded']");
                Wait.WaitToBeClickable(driver1, Listing1, 15);
                Listing = driver1.FindElement(Listing1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderMessageRequestComponents()
        {
            try
            {
                By MessageRequest1 = By.XPath("//textarea[@placeholder='I am interested in trading my cooking skills with your coding skills..']");
                Wait.ElementIsVisible(driver1, MessageRequest1, 10);
                MessageRequest = driver1.FindElement(MessageRequest1);                    
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderrequestSkillTradeComponents()
        {
            try
            {
                By requestSkillTrade1 = By.XPath("//div[contains(@class, 'ui') and contains(@class, 'teal') and contains(@class, 'button') and .//i[contains(@class, 'send') and contains(@class, 'outline') and contains(@class, 'icon')]]");
                requestSkillTrade = driver1.FindElement(requestSkillTrade1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void renderwithdrawRequestComponents()
            {
                try
                {

                By withdrawRequest1 = By.XPath("//div[@class='ui teal button' and text()='Withdraw Request']");
                Wait.WaitToBeClickable(driver1, withdrawRequest1, 15);
                withdrawRequest = driver1.FindElement(withdrawRequest1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

        public void renderPageRequestLoadCheckComponents()
        {
            try
            {
                By PageRequestLoadCheck = By.XPath("//div[@class='active section']");
                Wait.ElementIsVisible(driver1, PageRequestLoadCheck, 15);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void renderConfirmrequestSkillComponents()
        {
            try
            {
                By ConfirmrequestSkillTrade1 = By.XPath("/html/body/div[4]/div/div[3]/button[1]");
                Wait.WaitToBeClickable(driver1, ConfirmrequestSkillTrade1, 15);
                ConfirmrequestSkillTrade = driver1.FindElement(ConfirmrequestSkillTrade1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        // ClickOnNotification
        public void ClickOnNotification()
        {
            renderClickOnNotificationComponents();
            NotificationDropdown.Click();
            renderClickOnSeeAllNotificationComponents();
            SeeAllDropdown.Click();
        }

        //SelectAllLink
        public void SelectAllLink()
        {
            renderSelectAllLinkComponents();
            Wait.WaitToBeClickable(driver1, SelectAll1, 15);
            SelectAll.Click();
            Thread.Sleep(1000);
        }


        //ClickUnselectAllLink
        public void ClickUnselectAllLink()
        {
            renderClickUnselectAllLinkComponents();
            UnSelectAll.Click();
            Thread.Sleep(1000);
        }

        //AllMessageShouldBeChecked
        public void AllMessageShouldBeChecked()
        {
            List<IWebElement> checkboxes = new List<IWebElement>(driver1.FindElements(By.XPath("//input[@type='checkbox']")));
            bool allChecked = true;

            foreach (IWebElement checkbox in checkboxes)
            {
                if (!checkbox.Selected)
                {
                    allChecked = false;
                    break; // Break out of the loop if any unchecked box is found
                }
            }

            if (allChecked)
            {
                Console.WriteLine("All checked");
            }
            else
            {
                Console.WriteLine("At least one checkbox is unchecked");
            }
        }


        //AllMessagesShouldBeUnchecked
        public void AllMessagesShouldBeUnchecked()
        {

            List<IWebElement> checkboxes = new List<IWebElement>(driver1.FindElements(By.XPath("//input[@type='checkbox']")));
            bool allChecked = false;

            foreach (IWebElement checkbox in checkboxes)
            {
                if (!checkbox.Selected)
                {
                    allChecked = true;
                    break; // Break out of the loop if any unchecked box is found
                }
            }

            if (allChecked)
            {
                Console.WriteLine("All checked");
            }
            else
            {
                Console.WriteLine("At least one checkbox is unchecked");
            }
        }


        //UserClickDeleteAMessage
        public void UserClickDeleteAMessage()
        {
            renderUserClickDeleteAMessageComponents();
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, deleteButton1, 15);
            deleteButton.Click();

        }


        public void DeleteOneNotification()
        {
            renderMessageDeleteComponents();
            Thread.Sleep(1000); // Consider using explicit waits instead of Thread.Sleep for better reliability
                                // Define the locator for the element containing the message text
            By messageLocator = By.XPath("/html/body/div[1]/div"); //MessageDelete
            string expectedStaticPart = "Notification updated";

            // Use the assertion method from the AssertionsPage
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, messageLocator);
        }

        //WhenUserSelectAMessage
        public void UserSelectAMessage()
        {
            renderUserSelectAMessageComponents();
           // Wait.WaitToBeClickable(driver1, notificationMessage1, 15);
            notificationMessage.Click();
            Thread.Sleep(1000);

        }


        public void ShowReceivedRequestsPage()
        {
            renderMessageDeleteComponents();
            Thread.Sleep(1000); // Consider using explicit waits instead of Thread.Sleep for better reliability
                                // Define the locator for the element containing the message text
            By messageLocator = By.XPath("/html/body/div[1]/div"); //MessageDelete
            string expectedStaticPart = "Received Requests";

            // Use the assertion method from the AssertionsPage
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, messageLocator);
        }

 

        //NavigateToAccountSettingsAndClickOnDashboard
        public void SelectedDashboard()
        {
            renderSelectedDashboardComponents();
            Wait.WaitToBeClickable(driver1, DashboardTab1, 8);
            DashboardTab.Click();
        }

        //
        public void notificationPage()
        {
            rendernotificationPageComponents();
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, notification1, 15);
            string actualMessage = notification.Text.Trim();

            // The static part of the message you expect
            string expectedStaticPart = "Notifications";

            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        //CLickSeeMoreNotification
        public void CLickSeeMoreNotification()
        {
            renderCLickSeeMoreNotificationComponents();
           // Wait.WaitToBeClickable(driver1, LoadMoreButton1, 18);
            LoadMoreButton.Click();
        }


        //ClickShowLessNotification
        public void ClickShowLessNotification()
        {
            renderClickShowLessNotificationComponents();
            //Wait.WaitToBeClickable(driver1, ShowLessButton1, 18);
            ShowLessButton.Click();
        }

        //ShowLessNotification
        public void ShowResultLessNotification()
        {

            // Use WebDriverWait to ensure the page has loaded and elements are clickable
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(10));

            // Find the initial count of notifications
            var initialNotificationsCount = driver1.FindElements(By.ClassName("item")).Count;

            // Locate and click the "Load More" button
            renderCLickSeeMoreNotificationComponents();
            var loadMoreButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@class='ui button']")));
            loadMoreButton.Click();

            // Wait for more notifications to load
            Thread.Sleep(2000); // It's better to use WebDriverWait here to wait for a specific condition

            // Count the number of notifications after clicking "Load More"
            var notificationsCountAfterLoadMore = driver1.FindElements(By.ClassName("item")).Count;

            // Verify that more notifications are shown
            Assert.That(notificationsCountAfterLoadMore, Is.GreaterThanOrEqualTo(10), "Number of notifications should be more after clicking 'Load More'");
            // Locate and click the "Show Less" button
            renderClickShowLessNotificationComponents();
            //Wait.WaitToBeClickable(driver1, ShowLessButton1, 8);
            ShowLessButton.Click();

            // Wait for notifications to decrease
            Thread.Sleep(2000); // Again, better to use WebDriverWait

            // Count the number of notifications after clicking "Show Less"
            var notificationsCountAfterShowLess = driver1.FindElements(By.ClassName("item")).Count;

            // Verify that the number of notifications matches the initial count
            Assert.That(notificationsCountAfterShowLess, Is.LessThanOrEqualTo(notificationsCountAfterLoadMore), "Number of notifications should be less after clicking 'Show Less'");
        }

        //ShowLessNotification
        public void ShowResultLoadMoreNotification()
        {
            // Use WebDriverWait to ensure the page has loaded and elements are clickable
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(10));
            // Find the initial count of notifications
            var initialNotificationsCount = driver1.FindElements(By.ClassName("item")).Count;
            // Locate and click the "Load More" button
            renderCLickSeeMoreNotificationComponents();
            var loadMoreButton = wait.Until(ExpectedConditions.ElementToBeClickable(LoadMoreButton1));
            loadMoreButton.Click();
            // Wait for more notifications to load
            Thread.Sleep(2000); // It's better to use WebDriverWait here to wait for a specific condition
            // Count the number of notifications after clicking "Load More"
            var notificationsCountAfterLoadMore = driver1.FindElements(By.ClassName("item")).Count;
            // Verify that more notifications are shown
            Assert.That(notificationsCountAfterLoadMore, Is.GreaterThanOrEqualTo(initialNotificationsCount), "Number of notifications should be more after clicking 'Load More'");
        }

        public void SelectMarkAsRead()
        {
            renderSelectMarkAsReadComponents();
            Wait.WaitToBeClickable(driver1, MarkAsRead1, 8);
            MarkAsRead.Click();
        }


        public void NotificationUpdated()
        {
            renderNotificationUpdatedComponents();
            Wait.ElementIsVisible(driver1, PopUp1, 15);
            Thread.Sleep(1000); // Consider using explicit waits instead of Thread.Sleep for better reliability
                                // Define the locator for the element containing the message text
            By messageLocator = By.XPath("//div[@class='ns-box-inner']"); //Popup
            string expectedStaticPart = "Notification updated";

            // Use the assertion method from the AssertionsPage
            pageAssertions.AssertElementTextContainsIWeb(expectedStaticPart, messageLocator);
        }

        public void PendingMenuPopUpShouldBeDisplay()
        {
            renderSelectMarkAsReadComponents();
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, MarkAsRead1, 15);
        }


        public void PendingMenuPopUpShouldBeGone()
        {
            renderUserSelectAMessageComponents();
            // Locate and click the input element
            var inputElement = driver1.FindElement(notificationMessage1);
            inputElement.Click();
            inputElement.Click();

            // Setup WebDriverWait
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(10));
            renderSelectMarkAsReadComponents();
            // Wait for the button to disappear
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(MarkAsRead1));

            // After the wait, check that the button is indeed gone
            bool isButtonGone = IsElementPresent(MarkAsRead1);

            // Assert that the button is gone
            Assert.That(isButtonGone, Is.True, "Button should be gone after clicking the input");

            // Helper method to check if an element is present
            bool IsElementPresent(By by)
            {
                try
                {
                    driver1.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        //SearchForAListingAndSendRequest
        public void SearchForAListingAndSendRequest(string title, string MessageRequestText)
        {
            Thread.Sleep(1000);
            renderSearchForAListingComponents();
            SearchSkill.SendKeys(title);
            SearchSkill.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            renderClickForAListingComponents();
            Listing.Click();
            renderwithdrawRequestComponents();
            var withdrawRequestButtons = driver1.FindElements(By.XPath("//div[@class='ui teal button' and text()='Withdraw Request']"));
            renderPageRequestLoadCheckComponents();
            if (withdrawRequestButtons.Any())
            {
                renderwithdrawRequestComponents();
                withdrawRequest.Click();
            }
            renderMessageRequestComponents();
            MessageRequest.SendKeys(MessageRequestText);
            renderrequestSkillTradeComponents();
            requestSkillTrade.Click();
            Thread.Sleep(2000);
            renderwithdrawRequestComponents();
            try
            {
                if (driver1.FindElement(By.XPath("//div[@class='ui teal button' and text()='Withdraw Request']")).Displayed)
                {
                    // If the button is displayed, click it
                    renderwithdrawRequestComponents();
                    driver1.FindElement(withdrawRequest1).Click();
                    Console.WriteLine("Button clicked successfully.");
                    Thread.Sleep(1000);
                    renderrequestSkillTradeComponents();
                    requestSkillTrade.Click();
                }
            }
            catch (NoSuchElementException)
            {
                renderConfirmrequestSkillComponents();
                ConfirmrequestSkillTrade.Click();
            }
        }



    }
}
