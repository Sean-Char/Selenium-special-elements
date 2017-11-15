﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/text-input-field/";

        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));

        textBox.SendKeys("Test text"); // puts text into selected input field

        Thread.Sleep(3000);

        System.Console.WriteLine(textBox.GetAttribute("maxlength")); // shows attribuite of 10

        Thread.Sleep(3000);

        driver.Quit();
    }
}

