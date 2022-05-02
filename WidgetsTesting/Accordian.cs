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
    class Accordian : Selenium_Base
    {
        public void AccordianTesting(IWebDriver Driver)
        {
            open("https://demoqa.com/widgets");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindXPath("//span[text()='Accordian']"));
            wait(2000);

            scrollPage(0, 300);
            wait(1000);

            click(FindXPath("//div[@id='section2Heading']"));
            wait(2000);

            scrollPage(0, 300);
            wait(1000);

            click(FindXPath("//div[@id='section3Heading']"));
            wait(2000);

            close();
        }
    }
}
