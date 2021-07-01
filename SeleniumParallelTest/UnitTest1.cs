using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumParallelTest
{
    [TestFixture]
    public class FirefoxTesting : Hooks
    {
        [Test]
        public void FirefoxGoogleTest()
        {

            Driver.Navigate().GoToUrl("https://www.google.com.br");
            Driver.FindElement(By.Name("q")).SendKeys("selenium");
            Driver.FindElement(By.XPath("(//input[@name='btnK'])[2]")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true), "The text selenium doensn't exist");

        }
    }

    [TestFixture]
    public class ChromeTesting : Hooks
    {
        [Test]
        public void ChromeGoogleTest()
        {

            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Resident evil 2 remake");
            Driver.FindElement(By.XPath("(//input[@name='btnK'])[2]")).Click();
            Assert.That(Driver.PageSource.Contains("Resident evil 2 remake"), Is.EqualTo(true), "The text Resident evil 2 remake doensn't exist");


        }
    }
}
