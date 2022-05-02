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
    class ToolTips : Selenium_Base
    {
        public void ToolsTips(IWebDriver Driver)
        {
            open("https://demoqa.com/widgets");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindXPath("//span[text()='Tool Tips']"));
            wait(2000);

            click(FindXPath("//button[text()='Hover me to see']"));
            wait(2000);

            click(FindXPath("//input[@id='toolTipTextField']"));
            wait(2000);

            close();
        }
    }
}
