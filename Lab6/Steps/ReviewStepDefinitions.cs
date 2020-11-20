using FluentAssertions;
using Lab6.Extenions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Lab6.Steps
{
    [Binding]
    public class ReviewStepDefinitions
    {
        private readonly IWebDriver _webDriver;

        public ReviewStepDefinitions(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given("I opened Reviews tab")]
        public void IOpenedReviewsTab()
        {
            var tab = _webDriver.FindElement(By.CssSelector("li[aria-controls='tab_item-1'"));
            tab.Click();
        }

        [Given("I completed first field with (.*) value")]
        public void ICompletedFirstFieldWithValue(string value)
        {
            var input = _webDriver.FindElement(By.CssSelector(".add-review input[name='Name']"));
            input = _webDriver.WaitForElementToBeClickable(10, input);
            input.SendKeys(value);
        }
        [Given("I completed email field with (.*) value")]
        public void ICompletedEmailkFieldWithValue(string value)
        {
            var input = _webDriver.FindElement(By.CssSelector(".add-review input[name='Email']"));
            input = _webDriver.WaitForElementToBeClickable(20, input);
            input.SendKeys(value);
        }
        [Given("I added(.*) text in box for comments")]
        public void IAddedATextInBoxForComments(string value)
        {
            var input = _webDriver.FindElement(By.CssSelector(".add-review textarea[name='Message']"));
            input = _webDriver.WaitForElementToBeClickable(20, input);
            input.SendKeys(value);
        }
        [When("I clicked on SEND button")]
        public void IClickedOnSendButton()
        {
            var button = _webDriver.FindElement(By.CssSelector("input[value='SEND']"));
            button.Click();
        }

        [Then("The review should contains (.*) message")]
        public void ThenTheReviewShouldBeAdded(string message)
        {
            var review = _webDriver.PageSource.Contains(message);
            review.Should().BeTrue();
        }
    }
}
