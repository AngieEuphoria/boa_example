using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boa.Constrictor.Logging;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
namespace boa_example.ExampleBoa
{
    
    
    public class UITestDemoQA
    {
        private IActor Actor;
        [SetUp]
        public void Initialize()
        {
            Actor = new Actor(name: "angeles", logger: new ConsoleLogger());
            Actor.Can(BrowseTheWeb.With(new ChromeDriver()));
            
        }

        [TearDown]
        public void QuitBrowser()
        {
            System.Threading.Thread.Sleep(4000);
            Actor.AttemptsTo(QuitWebDriver.ForBrowser());
        }

        [Test]
        public void TestDemoQA()
        {
            
            Actor.AttemptsTo(Navigate.ToUrl(Page.Url));
            Actor.AttemptsTo(Interaction1.For("Angeles", "angeles@gmail.com", "my current direction", "my permanent direction")); 
            
            Actor.AskingFor(ValueAttribute.Of(Page.LocLname)).Should().NotBeNullOrEmpty();
            //Actor.AskingFor(ValueAttribute.Of(Page.LocLemail)).Should().NotBeNullOrEmpty();
            //Actor.AskingFor(ValueAttribute.Of(Page.LocLcurradr)).Should().NotBeNullOrEmpty();
            //Actor.AskingFor(ValueAttribute.Of(Page.LocLpermadr)).Should().NotBeNullOrEmpty();


        }
        
        
    }
}
