using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DemoQASite;

namespace WidgetsTesting
{
    class Tabs : Selenium_Base
    {
        public void TabTesting(IWebDriver Driver)
        {
            open("https://demoqa.com/widgets");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindXPath("//span[text()='Tabs']"));
            wait(2000);

            click(FindXPath("//a[@id='demo-tab-origin']"));
            wait(2000);

            click(FindXPath("//a[@id='demo-tab-use']"));
            wait(2000);

            close();
        }
    }
}
