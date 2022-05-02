using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WidgetsTesting
{
    class AutoComplete
    {
        public static void MultipleColor(IWebDriver Driver)
        {
            Driver.FindElement(By.XPath("//span[text()='Auto Complete']")).Click();
            Thread.Sleep(2000);

            //Driver.FindElement(By.XPath("//div[@class='auto-complete__value-container auto-complete__value-container--is-multi css-1hwfws3']")).SendKeys("b");
            Thread.Sleep(2000);
        }
    }
}
