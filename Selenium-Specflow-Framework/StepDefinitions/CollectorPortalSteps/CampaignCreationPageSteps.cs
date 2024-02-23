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
    public sealed class CampaignCreationPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private CampaignCreationPagePOM campaignCreationPagePOM;
        private SettingsFileReader settingsFile;
        public CampaignCreationPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            campaignCreationPagePOM = new CampaignCreationPagePOM((IWebDriver)_scenarioContext["webDriver"]);
            settingsFile = new SettingsFileReader();
        }

        [Then(@"User see the Campaign Creation page")]
        public void UserSeeTheCampaignCreationPage()
        {
            Assert.IsTrue(campaignCreationPagePOM.isCampaignCreationPageDisplayed(), "Current page is not a CampaignCreation page");
        }
    }
}
