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
    public sealed class AnalyticsAndReportingPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private AnalyticsAndReportingPagePOM analyticsAndReportingPagePOM;
        private SettingsFileReader settingsFile;
        public AnalyticsAndReportingPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            analyticsAndReportingPagePOM = new AnalyticsAndReportingPagePOM((IWebDriver)_scenarioContext["webDriver"]);
            settingsFile = new SettingsFileReader();
        }

        [Then(@"User see the Analytics and Reporting page")]
        public void UserSeeTheAnalyticsAndReportingPage()
        {
            Assert.IsTrue(analyticsAndReportingPagePOM.isAnalyticsPageDisplayed(), "Current page is not a Analytics and Reporting page");
        }
    }
}
