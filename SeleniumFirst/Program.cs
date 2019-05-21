using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        ////Create reference for webdriver
        //IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {

        }


            [SetUp]
            public void Initialize()
            {
            PropertiesCollection.Driver = new ChromeDriver();
            // Open a new google page
            PropertiesCollection.Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("opened URL");

            }

            [Test]
            public void ExicuteTest()
            {

            EAPageObject page = new EAPageObject();
            page.TxtInitial.SendKeys("executeautomation");
            page.BtnSave.Click();

            ////EnterText(element, value, type)
            //SeleniumSetMethods.SelectDropDown( "TitleId", "Mr.", PropertyType.Id);
            //SeleniumSetMethods.EnterText( "Initial", "executeautomation", PropertyType.Name);
            //Console.WriteLine("Value from title is: " + SeleniumGetMethods.GetTextFromDDL( "TitleId", "", PropertyType.Id));
            //SeleniumSetMethods.click( "Save", PropertyType.Name);

            ////    //find element
            ////    IWebElement element = driver.FindElement(By.Name("q"));
            ////    //perform ops
            ////    element.SendKeys("exicute automation");
            ////Console.WriteLine("testc exicuted");

        }

            [TearDown]
            public void Clenup()
            {
            PropertiesCollection.Driver.Close();
            Console.WriteLine("closed");
            }

        
        
    }
}
