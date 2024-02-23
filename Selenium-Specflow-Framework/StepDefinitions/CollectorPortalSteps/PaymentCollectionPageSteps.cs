using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;
using Microsoft.Extensions.Configuration;
using Ngr.Ui_Tests.Pages;
using Ngr.Ui_Tests.DataProviders;
using Self.Ui_Tests.Pages.CollectorPortal;

namespace Self.Ui_Tests.StepDefinitions.CollectorPortalSteps
{
    [Binding]
    public sealed class PaymentCollectionPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private PaymentCollectionPagePOM paymentCollectionPagePOM;
        private SettingsFileReader settingsFile;
        public PaymentCollectionPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            paymentCollectionPagePOM = new PaymentCollectionPagePOM((IWebDriver)_scenarioContext["webDriver"]);
            settingsFile = new SettingsFileReader();
        }

        [Then(@"User see the Payment Collection page")]
        public void UserSeeThePaymentCollectionPage()
        {
            Assert.IsTrue(paymentCollectionPagePOM.isPaymentCollectionPageDisplayed(), "Current page is not a PaymentCollection page");
        }
    }
}
