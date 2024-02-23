using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Ngr.Ui_Tests.Helpers;

namespace Self.Ui_Tests.Pages.PayerPortal
{
    class CampaignDiscoveryPagePOM
    {
#pragma warning disable CS0649
        [FindsBy(How = How.XPath, Using = "//campaignDiscoveryItem")]
        private IWebElement campaignDiscoveryItem;

#pragma warning restore CS0649
        private IWebDriver webdriver;
        private WebDriverWait uiWait;

        public CampaignDiscoveryPagePOM(IWebDriver webDriver)
        {
            webdriver = webDriver;
            PageFactory.InitElements(webDriver, this);
            uiWait = WaitHelper.createWebDriverWait(webDriver, 30);
        }
        public bool isCampaignDiscoveryPageDisplayed()
        {
            return campaignDiscoveryItem.Displayed;
        }
    }
}
