using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;



namespace SeleniumFirst
{
   
    class EAPageObject
    {
        public EAPageObject()
        {

            PageFactory.InitElements(PropertiesCollection.Driver, this );

        }


        [FindsBy(How = How.Id, Using = "TitleId")]
        public  IWebElement DDLTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public  IWebElement TxtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public  IWebElement BtnSave { get; set; }
    }
}
