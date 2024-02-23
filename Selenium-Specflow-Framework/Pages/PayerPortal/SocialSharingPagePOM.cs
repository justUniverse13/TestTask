using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Ngr.Ui_Tests.Helpers;

namespace Self.Ui_Tests.Pages.PayerPortal
{
    class SocialSharingPagePOM
    {
#pragma warning disable CS0649
        [FindsBy(How = How.XPath, Using = "//a[@href='/login']")]
        private IWebElement loginLink;

#pragma warning restore CS0649
        private IWebDriver webdriver;
        private WebDriverWait uiWait;

        public SocialSharingPagePOM(IWebDriver webDriver)
        {
            webdriver = webDriver;
            PageFactory.InitElements(webDriver, this);
            uiWait = WaitHelper.createWebDriverWait(webDriver, 30);
        }
    }
}
