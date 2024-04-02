using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Component.Account.Dashboard;
using static Week18AdvanceTaskMarsPart1NUnitPOMJson.Pages.Components.SignIn.Login;


namespace Week18AdvanceTaskMarsPart1NUnitPOMJson.Steps
{
    public class _006StepNotification
    {
        private readonly IWebDriver driver1;
        private readonly PageLogin loginPageObj;
        private readonly _006PageNotification pageNotificationObj;

        public _006StepNotification(IWebDriver _driver)
        {
            driver1 = _driver;
            loginPageObj = new PageLogin(driver1);
            pageNotificationObj = new _006PageNotification(driver1);
        }


        public void StepUserClickOnNotificationOnTheTopRightOfThePage()
        {
            pageNotificationObj.ClickOnNotification();
        }

        public void StepUserClickSelectAllLink()
        {
            pageNotificationObj.SelectAllLink();
        }

        public void StepAllMessageShouldBeChecked()
        {
            pageNotificationObj.AllMessageShouldBeChecked();
        }

        public void StepClickUnselectAllLink()
        {
            pageNotificationObj.ClickUnselectAllLink();
        }

        public void StepAllMessagesShouldBeUnchecked()
        {
            pageNotificationObj.AllMessagesShouldBeUnchecked();
        }

        public void StepClickDeleteAMessage()
        {
            pageNotificationObj.UserClickDeleteAMessage();
        }

        public void StepDeleteOneNotificationFromTheNotificationPage()
        {
            pageNotificationObj.DeleteOneNotification();
        }

        public void StepSelectAMessage()
        {
            pageNotificationObj.UserSelectAMessage();
        }

        public void StepShowReceivedRequestsPage()
        {
            pageNotificationObj.ShowReceivedRequestsPage();
        }

  
        public void StepClickOnDashboard()
        {
            pageNotificationObj.SelectedDashboard();
        }

        public void StepShowNotificationPage()
        {
            pageNotificationObj.notificationPage();

        }
        public void StepCLickSeeMoreNotification()
        {
            pageNotificationObj.CLickSeeMoreNotification();

        }

        public void StepClickShowLessNotification()
        {
            pageNotificationObj.ClickShowLessNotification();

        }

        public void StepResultShowLessNotification()
        {
            pageNotificationObj.ShowResultLessNotification();

        }

         public void StepResultLoadMoreNotification()
        {
            pageNotificationObj.ShowResultLoadMoreNotification();

        }

        public void StepSelectMarkAsRead()
        {
            pageNotificationObj.SelectMarkAsRead();

        }
        public void StepNotificationUpdated()
        {
            pageNotificationObj.NotificationUpdated();

        }
        public void StepPendingMenuPopUpShouldBeDisplay()
        {
            pageNotificationObj.PendingMenuPopUpShouldBeDisplay();

        }

        public void StepUnselectAMessage()
        {
            pageNotificationObj.UserSelectAMessage();

        }

        public void StepPendingMenuPopUpShouldBeGone()
        {
            pageNotificationObj.PendingMenuPopUpShouldBeGone();

        }
        public void StepSearchForAListingAndSendRequest(string title, string MessageRequestText)
        {
            pageNotificationObj.SearchForAListingAndSendRequest(title, MessageRequestText);

        }


    }
}
