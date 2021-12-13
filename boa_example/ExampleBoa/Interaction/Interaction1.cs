using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;


namespace boa_example.ExampleBoa
{
    public class Interaction1 : ITask
    { 
        public string User { get; }
        public string Email { get; }
        public string CurrAdr{ get; }
        public string PermAdr { get; }

        private Interaction1(string user, string email, string curradr, string permadr)
        { 
            User = user; 
            Email = email;
            CurrAdr = curradr;
            PermAdr = permadr;

        }
            
        public static Interaction1 For(string user, string email, string curradr, string permadr) =>
              new Interaction1(user, email,curradr,permadr);
        

        public void PerformAs(IActor Actor)
        {
            Actor.AttemptsTo(SendKeys.To(Page.LocUser, User));
            //Actor.AttemptsTo(Click.On(Page.LocUser));
            Actor.AttemptsTo(SendKeys.To(Page.LocEmail, Email));
            //Actor.AttemptsTo(Click.On(Page.LocEmail));
            Actor.AttemptsTo(SendKeys.To(Page.LocCurrAdress, CurrAdr));
            //Actor.AttemptsTo(Click.On(Page.LocCurrAdress));
            Actor.AttemptsTo(SendKeys.To(Page.LocPermAdress, PermAdr));
            Actor.AttemptsTo(Click.On(Page.LocSubmit));
            Actor.AttemptsTo(JavaScriptClick.On(Page.LocSubmit));
        }
    }
}
