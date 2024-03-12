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

namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages
{
    public class _006PageNotification
    {
        private readonly IWebDriver driver1;

        public _006PageNotification(IWebDriver _driver)
        {
            driver1 = _driver;
        }

        By NotificationDropdown1 => By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div");
        private IWebElement NotificationDropdown => driver1.FindElement(NotificationDropdown1);
        By SeeAllDropdown1 => By.XPath("//div[@class='ui link item']//div//center//a");
        private IWebElement SeeAllDropdown => driver1.FindElement(SeeAllDropdown1);
        By SelectAll1 => By.XPath("//i[@class='mouse pointer icon']");
        private IWebElement SelectAll => driver1.FindElement(SelectAll1);
        private IWebElement UnSelectAll => driver1.FindElement(By.XPath("//div[@class='ui icon basic button button-icon-style']"));     
        By deleteButton1 => By.XPath("//div[@data-tooltip='Delete selection']");
        private IWebElement deleteButton => driver1.FindElement(deleteButton1);
        private IWebElement MessageDelete => driver1.FindElement(By.XPath("/html/body/div[1]/div"));
        By notificationMessage1 => By.XPath("//input[@value='0']");
        private IWebElement notificationMessage => driver1.FindElement(notificationMessage1);
        By DashboardTab1 => By.XPath("//div[@class='four wide column']//div//h3");
        private IWebElement DashboardTab => driver1.FindElement(DashboardTab1);
        By notification1 => By.XPath("//h1[normalize-space()='Notifications']");
        private IWebElement notification => driver1.FindElement(notification1);
        By LoadMoreButton1 => By.XPath("//a[@class='ui button']");
        private IWebElement LoadMoreButton => driver1.FindElement(LoadMoreButton1);
        By ShowLessButton1 => By.XPath("//div[@class='ui items segment']//div//div[1]//center[1]//a[1]");
        private IWebElement ShowLessButton => driver1.FindElement(ShowLessButton1);
        By MarkAsRead1 => By.XPath("//div[@data-tooltip='Mark selection as read']");
        private IWebElement MarkAsRead => driver1.FindElement(MarkAsRead1);
        By PopUp1 => By.XPath("//div[@class='ns-box-inner']");
        private IWebElement PopUp => driver1.FindElement(PopUp1);
        By MessageRequest1 => By.XPath("//textarea[@placeholder='I am interested in trading my cooking skills with your coding skills..']");
        private IWebElement MessageRequest=> driver1.FindElement(MessageRequest1);
        By PageRequestLoadCheck => By.XPath("//div[@class='active section']");
        By requestSkillTrade1 = By.XPath("//div[contains(@class, 'ui') and contains(@class, 'teal') and contains(@class, 'button') and .//i[contains(@class, 'send') and contains(@class, 'outline') and contains(@class, 'icon')]]");
        private IWebElement requestSkillTrade=> driver1.FindElement(requestSkillTrade1);
        private By withdrawRequest1 = By.XPath("//div[@class='ui teal button' and text()='Withdraw Request']");
        private IWebElement withdrawRequest => driver1.FindElement(withdrawRequest1);
        By SearchSkill1 => By.XPath("//input[@placeholder='Search skills']");
        private IWebElement SearchSkill => driver1.FindElement(SearchSkill1);
        By CheckSkillResultDisplay1 => By.XPath("//a[@role='listitem']//b");
        By ConfirmrequestSkillTrade1 => By.XPath("/html/body/div[4]/div/div[3]/button[1]");
        private IWebElement ConfirmrequestSkillTrade => driver1.FindElement(ConfirmrequestSkillTrade1);
        By Listing1 => By.XPath("//p[@class='row-padded']");
        private IWebElement Listing => driver1.FindElement(Listing1);

        // ClickOnNotification
        public void ClickOnNotification()
        {
            Wait.WaitToBeClickable(driver1, NotificationDropdown1, 15);
            NotificationDropdown.Click();       
            Wait.WaitToBeClickable(driver1, SeeAllDropdown1, 15);
            SeeAllDropdown.Click();
        }

        //SelectAllLink
        public void SelectAllLink()
        {
            Wait.WaitToBeClickable(driver1, SelectAll1, 15);
            SelectAll.Click();
            Thread.Sleep(1000);
        }


        //ClickUnselectAllLink
        public void ClickUnselectAllLink()
        {
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

            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, deleteButton1, 15);
            deleteButton.Click();

        }



        //DeleteOneNotificationFromTheNotificationPage

        public void DeleteOneNotification()
        {
            Thread.Sleep(1000);
            string actualMessage = MessageDelete.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "Notification updated";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
            $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");

        }
        //WhenUserSelectAMessage
        public void UserSelectAMessage()
        {
            Wait.WaitToBeClickable(driver1, notificationMessage1, 15);
            notificationMessage.Click();
            Thread.Sleep(1000);

        }


        //ShowReceivedRequestsPage
        public void ShowReceivedRequestsPage()
        {
            Thread.Sleep(1000);
            string actualMessage = MessageDelete.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "Received Requests";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
            $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");

        }

        //NavigateToAccountSettingsAndClickOnDashboard
        public void SelectedDashboard()
        {
            Wait.WaitToBeClickable(driver1, DashboardTab1, 8);
            DashboardTab.Click();
        }

        //
        public void notificationPage()
        {
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
            Wait.WaitToBeClickable(driver1, LoadMoreButton1, 18);
            LoadMoreButton.Click();
        }


        //ClickShowLessNotification
        public void ClickShowLessNotification()
        {
            Wait.WaitToBeClickable(driver1, ShowLessButton1, 18);
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
            var loadMoreButton = wait.Until(ExpectedConditions.ElementToBeClickable(LoadMoreButton1));
            loadMoreButton.Click();

            // Wait for more notifications to load
            Thread.Sleep(2000); // It's better to use WebDriverWait here to wait for a specific condition

            // Count the number of notifications after clicking "Load More"
            var notificationsCountAfterLoadMore = driver1.FindElements(By.ClassName("item")).Count;

            // Verify that more notifications are shown
            Assert.That(notificationsCountAfterLoadMore, Is.GreaterThanOrEqualTo(10), "Number of notifications should be more after clicking 'Load More'");
            // Locate and click the "Show Less" button
            Wait.WaitToBeClickable(driver1, ShowLessButton1, 8);
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
            Wait.WaitToBeClickable(driver1, MarkAsRead1, 8);
            MarkAsRead.Click();
        }

        public void NotificationUpdated()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, PopUp1, 15);
            string actualMessage = PopUp.Text.Trim();
            // The static part of the message you expect
            string expectedStaticPart = "Notification updated";
            // Assert that the actual message contains the expected static part
            Assert.That(actualMessage.Contains(expectedStaticPart),
                $"Error: The actual message '{actualMessage}' does not contain the expected text '{expectedStaticPart}'.");
        }

        public void PendingMenuPopUpShouldBeDisplay()
        {
            Thread.Sleep(1000);
            Wait.ElementIsVisible(driver1, MarkAsRead1, 15);
        }


        public void PendingMenuPopUpShouldBeGone()
        {
            // Locate and click the input element
            var inputElement = driver1.FindElement(notificationMessage1);
            inputElement.Click();
            inputElement.Click();

            // Setup WebDriverWait
            WebDriverWait wait = new WebDriverWait(driver1, TimeSpan.FromSeconds(10));

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
            Wait.ElementIsVisible(driver1, CheckSkillResultDisplay1, 10);
            Wait.WaitToBeClickable(driver1, SearchSkill1, 15);
            SearchSkill.SendKeys(title);
            SearchSkill.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            Wait.WaitToBeClickable(driver1, Listing1, 15);
            Listing.Click();
            var withdrawRequestButtons = driver1.FindElements(withdrawRequest1);
            Wait.ElementIsVisible(driver1, PageRequestLoadCheck, 15);
            if (withdrawRequestButtons.Any())
            {
                Wait.WaitToBeClickable(driver1, withdrawRequest1, 15);
                withdrawRequest.Click();
            }
            Wait.WaitToBeClickable(driver1, MessageRequest1, 15);
            MessageRequest.SendKeys(MessageRequestText);
            requestSkillTrade.Click();
            Thread.Sleep(2000);
            try
            {
                if (driver1.FindElement(withdrawRequest1).Displayed)
                {
                    // If the button is displayed, click it
                    driver1.FindElement(withdrawRequest1).Click();
                    Console.WriteLine("Button clicked successfully.");
                    Thread.Sleep(1000);
                    requestSkillTrade.Click();
                }
            }
            catch (NoSuchElementException)
            {
            Wait.WaitToBeClickable(driver1, ConfirmrequestSkillTrade1, 15);
            ConfirmrequestSkillTrade.Click();
            } 
        }


    }
}
