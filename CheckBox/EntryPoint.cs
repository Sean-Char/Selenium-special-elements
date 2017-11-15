using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class EntryPoint
{
    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
        string option = "3";
        string cssPath = "#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child("+ option +")"; // supported by most browser & works faster than xpath

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
       
        if (cssPathElement.GetAttribute("checked") == "true")
            GreenMessage("The checkbox is checked!");
        else
            RedMessage("The checkbox is NOT checked!");

        driver.Quit();
    }

    private static void RedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void GreenMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}