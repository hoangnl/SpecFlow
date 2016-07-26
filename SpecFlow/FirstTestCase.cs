using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow
{
    class FirstTestCase
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            driver.Url = "http://www.demoqa.com";
        }
    }
}
