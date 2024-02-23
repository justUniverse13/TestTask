using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Ngr.Ui_Tests.Helpers;

namespace Self.Ui_Tests.Pages.CollectorPortal
{
    class AnalyticsAndReportingPagePOM
    {
#pragma warning disable CS0649
        [FindsBy(How = How.XPath, Using = "//analyticsAndReportingItem")]
        private IWebElement analyticsAndReportingItem;
        
#pragma warning restore CS0649
        private IWebDriver webdriver;
        private WebDriverWait uiWait;

        public AnalyticsAndReportingPagePOM(IWebDriver webDriver)
        {
            webdriver = webDriver;
            PageFactory.InitElements(webDriver, this);
            uiWait = WaitHelper.createWebDriverWait(webDriver, 30);
        }
        public bool isAnalyticsPageDisplayed()
        {
            return analyticsAndReportingItem.Displayed;
        }
    }
}
