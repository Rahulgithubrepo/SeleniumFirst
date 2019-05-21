using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {
        public static string GetText( string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return PropertiesCollection.Driver.FindElement(By.Id(element)).GetAttribute(value);
            if (elementtype == PropertyType.Name)
                return PropertiesCollection.Driver.FindElement(By.Name(element)).GetAttribute(value);
            else return string.Empty;
        }
        public static string GetTextFromDDL( string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Id(element))).AllSelectedOptions.FirstOrDefault().Text;
            if (elementtype == PropertyType.Name)
                return new SelectElement(PropertiesCollection.Driver.FindElement(By.Name(element))).AllSelectedOptions.FirstOrDefault().Text;
            else return string.Empty;
        }
    }
}
