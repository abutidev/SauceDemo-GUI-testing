using System;
using Gauge.CSharp.Lib.Atttribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Scenarios
{
    public class GaugeSupport{

        private static IWebDriver _driver;

        public static IWebDriver Driver{
            get => _driver;
            private set => _driver = value;

        }

        [BeforeSpec]
        public void BeforeSpec(){
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

         [AfterSpec]
        public void AfterSpec(){
            // _driver.Quit()
            _driver.Close();
        }

    }
}


