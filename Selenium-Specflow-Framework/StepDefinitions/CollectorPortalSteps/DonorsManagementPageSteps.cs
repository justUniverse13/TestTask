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
    public sealed class DonorsManagementPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private DonorsManagementPagePOM donorsManagementPagePOM;
        private SettingsFileReader settingsFile;
        public DonorsManagementPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            donorsManagementPagePOM = new DonorsManagementPagePOM((IWebDriver)_scenarioContext["webDriver"]);
            settingsFile = new SettingsFileReader();
        }

        [Then(@"User see the Donors Management page")]
        public void UserSeeTheDonorsManagementPage()
        {
            Assert.IsTrue(donorsManagementPagePOM.isDonorsManagementPageDisplayed(), "Current page is not a DonorsManagement page");
        }
    }
}
