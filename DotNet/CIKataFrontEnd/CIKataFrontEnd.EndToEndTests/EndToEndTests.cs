using System;
using System.Threading;
using OpenQA.Selenium.Firefox;
using Shouldly;
using Xunit;

namespace CIKataFrontEnd.EndToEndTests
{
    public class EndToEndTests
    {
        private string _driverFileName = GetGeckoDriverFile();

        private static string GetGeckoDriverFile()
        {
            var fileName = Environment.GetEnvironmentVariable("GeckoDriverName");

            if (string.IsNullOrEmpty(fileName))
            {
                return "geckodriver";
            }

            return fileName;
        }
        
        [Fact]
        public void SmokeTest()
        {
            var firefoxService = FirefoxDriverService.CreateDefaultService(Environment.CurrentDirectory, _driverFileName);
            var options = new FirefoxOptions();
            options.AddArgument("--headless");
            var driver = new FirefoxDriver(firefoxService, options);
            
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