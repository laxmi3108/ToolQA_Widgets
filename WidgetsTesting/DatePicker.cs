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
    class DatePicker : Selenium_Base
    {
        public void Date(IWebDriver Driver)
        {
            open("https://demoqa.com/widgets");
            wait(500);

            scrollPage(0, 500);
            wait(500);

            click(FindXPath("//span[text()='Date Picker']"));
            wait(2000);

            click(FindXPath("//input[@id='datePickerMonthYearInput']"));
            wait(2000);

            click(FindXPath("//select[@class='react-datepicker__month-select']"));
            wait(2000);

            click(FindXPath("//option[text()='August']"));
            wait(2000);

            scrollPage(0, 300);

            click(FindXPath("//select[@class='react-datepicker__year-select']"));
            wait(2000);

            click(FindXPath("//option[text()='2001']"));
            wait(2000);

            click(FindXPath("//div[@class='react-datepicker__day react-datepicker__day--031']"));
            wait(2000);

        }

        public void DateTime(IWebDriver Driver)
        {
            click(FindXPath("//input[@id='dateAndTimePickerInput']"));
            wait(2000);
            click(FindXPath("//button[text()='Next Month']"));
            wait(2000);
            click(FindXPath("//button[text()='Next Month']"));
            wait(2000);
            click(FindXPath("//button[text()='Next Month']"));
            wait(2000);
            click(FindXPath("//div[@class='react-datepicker__year-read-view']"));
            wait(2000);
            click(FindXPath("//a[@class='react-datepicker__navigation react-datepicker__navigation--years react-datepicker__navigation--years-previous']"));
            wait(2000);
            click(FindXPath("//div[text()='2016']"));
            wait(2000);
            click(FindXPath("//div[text()='21']"));
            wait(2000);
            click(FindXPath("//li[text()='14:15']"));
            wait(2000);

            close();
        }
    }
}
