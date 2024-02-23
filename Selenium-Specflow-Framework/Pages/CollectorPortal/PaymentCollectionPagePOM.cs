using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Ngr.Ui_Tests.Helpers;

namespace Self.Ui_Tests.Pages.CollectorPortal
{
    class PaymentCollectionPagePOM
    {
#pragma warning disable CS0649
        [FindsBy(How = How.XPath, Using = "//paymentCollectionItem")]
        private IWebElement paymentCollectionItem;

#pragma warning restore CS0649
        private IWebDriver webdriver;
        private WebDriverWait uiWait;

        public PaymentCollectionPagePOM(IWebDriver webDriver)
        {
            webdriver = webDriver;
            PageFactory.InitElements(webDriver, this);
            uiWait = WaitHelper.createWebDriverWait(webDriver, 30);
        }
        public bool isPaymentCollectionPageDisplayed()
        {
            return paymentCollectionItem.Displayed;
        }
    }
}
