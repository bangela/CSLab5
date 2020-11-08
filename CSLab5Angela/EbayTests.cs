using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSLab5Angela
{
    public class EbayTests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("C:\\");
        }

        [Test]
        public void TestEbayLogoIsPresent()
        {
            driver.Url = "https://www.ebay.com/";
            var input = driver.FindElement(By.Id("gh-ac"));
            input.SendKeys("Computer");
            input.SendKeys(Keys.Enter);
            var ebayLogo = driver.FindElement(By.Id("gh-logo"));
            Assert.NotNull(ebayLogo);
        }
        [TearDown]
        public void CloseDriver()
        {
            driver.Close();
        }
    }
}