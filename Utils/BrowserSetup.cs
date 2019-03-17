using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace dotnet_mstest
{
    class BrowserSetup
    {
        private static Dictionary<string, Func<IWebDriver>> Browsers = new Dictionary<string, Func<IWebDriver>>(){
            {"Chrome", () => new ChromeDriver("drivers/")},
            {"Firefox", () => new FirefoxDriver()}
        };

        public static IWebDriver GetDriver(string browserType) =>
            (Browsers.ContainsKey(browserType)) ? Browsers[browserType].Invoke() :
            throw new NullReferenceException($"IWebDriver instance was not initialized: [{browserType}] is not a valid Browser type");
    }
}