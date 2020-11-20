using FluentAssertions;
using Lab6.Extenions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Lab6.Steps
{
    [Binding]
    public class ContactFormStepDefinitions
    {
        private readonly IWebDriver _webDriver;

        public ContactFormStepDefinitions(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given("I added (.*) value in name field")]
        public void IAddedValueInNameField(string value)
        {
            var input = _webDriver.FindElement(By.CssSelector(".contact-form input[name='Name']"));
            input = _webDriver.WaitForElementToBeClickable(20, input);
            input.SendKeys(value);
        }

        [Given("I added (.*) value in email field")]
        public void IAddedValueInEmailField(string value)
        {
            var input = _webDriver.FindElement(By.CssSelector(".contact-form input[name='Email']"));
            input = _webDriver.WaitForElementToBeClickable(10, input);
            input.SendKeys(value);
        }

        [Given("I added (.*) value in subject field")]
        public void IAddedValueInSubjectField(string value)
        {
            var input = _webDriver.FindElement(By.CssSelector(".contact-form input[name='Subject']"));
            input = _webDriver.WaitForElementToBeClickable(10, input);
            input.SendKeys(value);
        }

        [Given("I added (.*) value in message field")]
        public void IAddedValueInMessageField(string value)
        {
            var input = _webDriver.FindElement(By.CssSelector(".contact-form input[name='Message']"));
            input = _webDriver.WaitForElementToBeClickable(10, input);
            input.SendKeys(value);
        }
        [When("I clicked on send button")]
        public void IClickedOnSendButton()
        {
            var button = _webDriver.FindElement(By.CssSelector(".contact-form input[value='SEND']"));
            button = _webDriver.WaitForElementToBeClickable(10, button);
            button.Click();
        }

        [Then("An error message should be shown")]
        public void AnErroMessageShouldBeShown()
        {
            var popup = _webDriver.FindElement(By.CssSelector("input:invalid"));
            popup.Should().NotBeNull();
        }

        [Then("I should see a confirmation pop-up")]
        public void IShouldSeeAConfirmationPopUp()
        {
            var popup = _webDriver.FindElement(By.Name("Success"));
            popup.Should().NotBeNull();
        }
    }
}
