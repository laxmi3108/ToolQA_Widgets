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
    class Slider : Selenium_Base
    {
        public void SliderTesting(IWebDriver Driver)
        {
            open("https://demoqa.com/widgets");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindXPath("//span[text()='Slider']"));
            wait(2000);

            var slide = FindXPath("//input[@class='range-slider range-slider--primary']");

            dragAndDropOffset(slide, 47, 0);
            wait(2000);

            dragAndDropOffset(slide, -55, 0);
            wait(2000);

            close();
        }
    }
}
