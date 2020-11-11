using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace SpecFlowBDDTema28
{
    public class Helper
    { 
    public static void ScrollElement(IWebDriver driver, IWebElement element)
    {
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("arguments[0].scrollIntoView();", element);
    }

    public static void ClickWithScroll(IWebDriver driver, IWebElement element)
    {
        ScrollElement(driver, element);
        Thread.Sleep(500);
        element.Click();
    }
}
