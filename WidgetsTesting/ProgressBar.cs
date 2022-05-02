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
    class ProgressBar : Selenium_Base
    {
        public void ProgressTesting(IWebDriver Driver)
        {
            open("https://demoqa.com/widgets");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindXPath("//span[text()='Progress Bar']"));
            wait(2000);

            click(FindXPath("//button[@id='startStopButton']"));
            wait(3000);

            click(FindXPath("//button[@id='startStopButton']"));
            wait(2000);

            close();
        }

    }
}
