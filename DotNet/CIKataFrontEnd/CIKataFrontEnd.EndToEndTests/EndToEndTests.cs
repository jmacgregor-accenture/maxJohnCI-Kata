using System;
using System.Threading;
using OpenQA.Selenium.Firefox;
using Shouldly;
using Xunit;

namespace CIKataFrontEnd.EndToEndTests
{
    public class EndToEndTests
    {
        [Fact]
        public void SmokeTest()
        {
            var options = new FirefoxOptions();
            options.AddArgument("--headless");
            var driver = new FirefoxDriver(options);
            
            try
            {
                driver.Navigate().GoToUrl("http://localhost:5001");

                driver.FindElementByTagName("button").Click();
                
                Thread.Sleep(TimeSpan.FromSeconds(2));
                
                var element = driver.FindElementById("root");
                
                element.Text.ShouldContain("successful");
            }
            finally
            {
                driver.Quit();
            }
            
        }
    }
}