using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Lab6.Steps
{
    [Binding]
    public class NavigationStepDefinitons
    {
        private readonly IWebDriver _webDriver;

        public NavigationStepDefinitons(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given("I have navigated to website")]
        public void UserAccessTheSite()
        {
            _webDriver.Url = Constants.Url.Base;
        }

        [Given("I have navigated to women cloths")]
        public void IHaveNavigatedToWomenCloths()
        {
            _webDriver.Navigate().GoToUrl(Constants.Url.WomenCloths);
        }

        [Given("I have navigated to product page")]
        public void IHaveNavigatedToProductPage()
        {
            _webDriver.Navigate().GoToUrl(Constants.Url.ProductPage);
        }

        [Given("I have navigated to contact page")]
        public void IHaveNavigatedToContactPage()
        {
            _webDriver.Navigate().GoToUrl(Constants.Url.Contact);
        }
    }
}
