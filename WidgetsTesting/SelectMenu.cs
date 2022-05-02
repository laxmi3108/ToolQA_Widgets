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
    class SelectMenu : Selenium_Base
    {
        public void SelectValue(IWebDriver Driver)
        {
            open("https://demoqa.com/widgets");
            wait(500);

            scrollPage(0, 700);
            wait(500);

            click(FindXPath("//span[text()='Select Menu']"));
            wait(2000);
        }
        public void OldStyleSelectMenu(IWebDriver Driver)
        {
            scrollPage(0, 500);

            click(FindXPath("//select[@id='oldSelectMenu']"));
            wait(2000);

            click(FindXPath("//option[text()='Purple']"));
            wait(2000);
        }
        public void StandardMultiSelect(IWebDriver Driver)
        {
            getAction().KeyDown(Keys.LeftControl)
                .MoveToElement(FindAllBy(By.XPath("//select[@id='cars']//option"))[1])
                .Click()
                .MoveToElement(FindAllBy(By.XPath("//select[@id='cars']//option"))[0])
                .Click()
                .Release()
                .Build()
                .Perform();

            wait(1000);

            close();
        }
    }
}
