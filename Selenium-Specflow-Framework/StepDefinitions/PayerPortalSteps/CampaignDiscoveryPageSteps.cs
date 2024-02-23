using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;
using Microsoft.Extensions.Configuration;
using Ngr.Ui_Tests.Pages;
using Ngr.Ui_Tests.DataProviders;
using Self.Ui_Tests.Pages.CollectorPortal;
using Self.Ui_Tests.Pages.PayerPortal;

namespace Self.Ui_Tests.StepDefinitions.PayerPortalSteps
{
    [Binding]
    public sealed class CampaignDiscoveryPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private CampaignDiscoveryPagePOM campaignDiscoveryPagePOM;
        private SettingsFileReader settingsFile;
        public CampaignDiscoveryPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            campaignDiscoveryPagePOM = new CampaignDiscoveryPagePOM((IWebDriver)_scenarioContext["webDriver"]);
            settingsFile = new SettingsFileReader();
        }

        [Then(@"User see the Campaign Discovery page")]
        public void UserSeeTheCampaignDiscoveryPage()
        {
            Assert.IsTrue(campaignDiscoveryPagePOM.isCampaignDiscoveryPageDisplayed(), "Current page is not a Campaign Discovery page");
        }
    }
}
