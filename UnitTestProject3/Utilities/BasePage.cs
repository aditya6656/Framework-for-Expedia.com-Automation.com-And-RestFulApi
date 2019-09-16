using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.Utilities
{
    public class BasePage
    {


        public static IWebDriver driver;
        public void invokeDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        public void closeDriver()
        {
            driver.Close();
        }

       
       public void elementclick(string a)
        {
        driver.FindElement(By.XPath(a)).Click();

        }

        public void elementsendkeys(string a,string Place)
        {
            driver.FindElement(By.XPath(a)).SendKeys(Place);
        }

    }
}
