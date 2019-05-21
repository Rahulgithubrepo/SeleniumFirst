using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //EnterText 
        public static void EnterText( string element, string value, PropertyType elementtype)
        {
            if(elementtype == PropertyType.Id)
                PropertiesCollection.Driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertiesCollection.Driver.FindElement(By.Name(element)).SendKeys(value);

        }

        //Click into a Button, CheckBox
        public static void click( string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.Driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                PropertiesCollection.Driver.FindElement(By.Name(element)).Click();
        }

        // Select from DropDown control
        public static void SelectDropDown( string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).SelectByText(value);

        }


    }
}
