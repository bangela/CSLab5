using FluentAssertions;
using Lab6.Extenions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Lab6.Steps
{
    [Binding]
    public class SignInStepDefinitions
    {
        private readonly IWebDriver _webDriver;
        private IWebElement _signInModal;
        public SignInStepDefinitions(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given("I click on sign-in button")]
        public void GivenUserClickOnSignUpButton()
        {
            var _signUpButton = _webDriver.FindElement(By.CssSelector("a[data-target='#myModal'"));
            _signUpButton.Should().NotBeNull();
            _signUpButton.Click();
            _signInModal = _webDriver.WaitForElementToAppear(10, By.Id("myModal"));
        }

        [Given("I have entered (.*) in name field")]
        public void WhenUserInsertedName(string data)
        {
            var name = _signInModal.FindElement(By.CssSelector("input[name='Name'"));
            var element = _webDriver.WaitForElementToBeClickable(5, name);
            element.SendKeys(data);
        }

        [Given("I have entered (.*) in password field")]
        public void GibenUserInsertedPassword(string data)
        {
            var password = _signInModal.FindElement(By.CssSelector("input[name='password'"));
            var element = _webDriver.WaitForElementToBeClickable(5, password);
            element.SendKeys(data);
        }

        [When("I press the facebook button")]
        public void IPressTheFacebookButton()
        {
            var button = _webDriver.FindElement(By.CssSelector("a[class='facebook']"));
            button.Click();
        }
        [Then("I should be redirected to facebook")]
        public void IShouldBeRedirectedToFaceBook()
        {
            var url = _webDriver.Url;
            url.Should().Contain("facebook");
        }

        [When("I press the sign-in button")]
        public void IPressTheSignInButton()
        {
            var buttonSingUp = _signInModal.FindElement(By.CssSelector("input[value='Sign In'"));
            buttonSingUp.Click();
        }
    }
}
