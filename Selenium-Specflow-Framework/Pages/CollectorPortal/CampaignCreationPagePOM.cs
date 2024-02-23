using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Ngr.Ui_Tests.Helpers;

namespace Self.Ui_Tests.Pages.CollectorPortal
{
    class CampaignCreationPagePOM
    {
#pragma warning disable CS0649
        [FindsBy(How = How.XPath, Using = "//campaignCreationItem")]
        private IWebElement campaignCreationItem;

#pragma warning restore CS0649
        private IWebDriver webdriver;
        private WebDriverWait uiWait;

        public CampaignCreationPagePOM(IWebDriver webDriver)
        {
            webdriver = webDriver;
            PageFactory.InitElements(webDriver, this);
            uiWait = WaitHelper.createWebDriverWait(webDriver, 30);
        }
        public bool isCampaignCreationPageDisplayed()
        {
            return campaignCreationItem.Displayed;
        }
    }
}
