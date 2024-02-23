using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Ngr.Ui_Tests.Helpers;

namespace Self.Ui_Tests.Pages.CollectorPortal
{
    class DonorsManagementPagePOM
    {
#pragma warning disable CS0649
        [FindsBy(How = How.XPath, Using = "//donorsManagementItem")]
        private IWebElement donorsManagementItem;

#pragma warning restore CS0649
        private IWebDriver webdriver;
        private WebDriverWait uiWait;

        public DonorsManagementPagePOM(IWebDriver webDriver)
        {
            webdriver = webDriver;
            PageFactory.InitElements(webDriver, this);
            uiWait = WaitHelper.createWebDriverWait(webDriver, 30);
        }
        public bool isDonorsManagementPageDisplayed()
        {
            return donorsManagementItem.Displayed;
        }
    }
}
