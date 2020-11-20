using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Lab6.Steps
{
    [Binding]
    public class GeneralStepDefinitions
    {
        private readonly IWebDriver _webDriver;

        public GeneralStepDefinitions(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Then("I should be loged in app")]
        public void ThenIShouldBeLogedInApp()
        {
            var url = _webDriver.Url;
            url.Should().Be("https://loving-hermann-e2094b.netlify.app/");
            var elemts = _webDriver.FindElements(By.CssSelector("a[data-target='#myModal2'"));
            elemts.Should().BeEmpty();
        }
    }
}
