using Gauge.CSharp.Lib.Attribute;
using Scenarios.Pages;

namespace Scenarios.Steps{

    public class StandardUserJourney{

        private StandardUser _standardUser = new StandardUser();

        [Step("Open the landing page of the store Saucedemo")]
        public void OpenLandingPage(){
            
            _standardUser.NavigateToLandingPage();

        }

        [Step("Check that the landing page of the store is succesfully opened")]
        public void SuccesfulLandingPage(){

             _standardUser.VerifyLandingPage();
            
        }

        [Step("Fill in the standard user details and attempt to login")]
        public void FillInLoggingDetails(){
            
             _standardUser.LoginOnLandingPage();
        }

        [Step("Verify if whether  standard user has succesfully logged in")]
        public void VerifySuccesfulLogin(){
            
             _standardUser.VerifyUserLoggedIn();
        }

    }




}