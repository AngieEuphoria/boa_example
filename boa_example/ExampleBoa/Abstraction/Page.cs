using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boa.Constrictor.WebDriver;
using OpenQA.Selenium;
using static Boa.Constrictor.WebDriver.WebLocator;

namespace boa_example
{
    public static class Page
    {
        public const string Url = "https://demoqa.com/text-box";

        public static IWebLocator LocUser =>L("Angeles", By.Id("userName"));       
        public static IWebLocator LocEmail => L("Email", By.Id("userEmail"));
        public static IWebLocator LocCurrAdress => L("Adress", By.Id("currentAddress"));
        public static IWebLocator LocPermAdress => L("Permanent Adress", By.Id("permanentAddress"));

        public static IWebLocator LocSubmit => L("Submit", By.Id("submit"));

        public static IWebLocator LocLname => L("labelname", By.Id("name"));
        public static IWebLocator LocLemail => L("label email", By.Id("email"));
        public static IWebLocator LocLcurradr => L("label current adress", By.Id("CurrentAdress"));
        public static IWebLocator LocLpermadr => L("label permanent adress", By.Id("PermanenAdress"));

    }
}
