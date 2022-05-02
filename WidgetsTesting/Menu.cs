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
    class Menu : Selenium_Base
    {
        public void MenuList(IWebDriver Driver)
        {
            open("https://demoqa.com/widgets");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindXPath("//span[text()='Menu']"));
            wait(2000);

            hoverOnto(FindXPath("//a[text()='Main Item 1']"));
            wait(2000);

            hoverOnto(FindXPath("//a[text()='Main Item 2']"));
            wait(2000);

            hoverOnto(FindXPath("//a[text()='SUB SUB LIST »']"));
            wait(2000);

            hoverOnto(FindXPath("//a[text()='Sub Sub Item 2']"));
            wait(2000);

            hoverOnto(FindXPath("//a[text()='Main Item 3']"));
            wait(2000);

            close();
        }
    }
}
