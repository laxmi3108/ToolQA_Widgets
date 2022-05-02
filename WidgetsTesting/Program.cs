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
    internal class Program : Selenium_Base
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = null;

            Accordian accordian = new Accordian();

            accordian.AccordianTesting(Driver);
            Thread.Sleep(2000);

            //AutoComplete.MultipleColor(Driver);
            //Thread.Sleep(2000);

            DatePicker datePicker = new DatePicker();

            datePicker.Date(Driver);

            datePicker.DateTime(Driver);

            Slider slider = new Slider();

            slider.SliderTesting(Driver);

            ProgressBar progressBar = new ProgressBar();

            progressBar.ProgressTesting(Driver);

            Tabs tabs = new Tabs();

            tabs.TabTesting(Driver);

            ToolTips toolTips = new ToolTips();

            toolTips.ToolsTips(Driver);

            Menu menu = new Menu();

            menu.MenuList(Driver);

            SelectMenu selectMenu = new SelectMenu();

            selectMenu.SelectValue(Driver);

            selectMenu.OldStyleSelectMenu(Driver);

            selectMenu.StandardMultiSelect(Driver);

            Driver.Close();
        }
    }
}
