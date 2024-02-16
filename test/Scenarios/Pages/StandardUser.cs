using FluentAssertions;
using OpenQA.Selenium;
using static Scenarios.GaugeSupport;

namespace StandardUser
{
    public class StandardUser{

        //link to the website in question
        public const string Url = "https://www.saucedemo.com/";

        public IwebDriver Driver = GaugeSupport.Driver;


        private IwebElement Username => Driver.FindElement(By.Id("user-name"));

        private const string  usr_name = "standard_user";

        private IwebElement Password => Driver.FindElement(By.Id("password"));

        private const string  usr_password = "secret_sauce";

        private IwebElement LoginButton => Driver.FindElement(By.Id("login-button"));

        private IwebElement AddBackpackToCartButton => Driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));

        private IwebElement AddBikeLightToCartButton => Driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));

        private IwebElement RemoveBackpackToCartButton => Driver.FindElement(By.Id("remove-cart-sauce-labs-backpack"));

        private IwebElement RemoveBikeLightToCartButton => Driver.FindElement(By.Id("remove-cart-sauce-labs-bike-light"));
   
        private IwebElement CheckoutButton => Driver.FindElement(By.Id("checkout"));

        private IwebElement FirstNameInput => Driver.FindElement(By.Id("first-name"));
    
        private const string  FirstName = "Peter";

        private IwebElement LastNameInput => Driver.FindElement(By.Id("last-name"));
        
        private const string  LastName = "Pan";

        private IwebElement  PostalCodeInput => Driver.FindElement(By.Id("postal-code"));
   
        private const int  PostalCode = 4000;

        private IwebElement  SubmitCheckoutButton => Driver.FindElement(By.Id("continue"));


        public void NavigateToLandingPage(){

            Driver.Navigate().GoToUrl(Url);

        }

        public void VerifyLandingPage(){

            //Act
            var ButtonText = LoginButton.GetAttribute("value");

            //Assert
            LoginButton.Should().NotBeNull();
            ButtonText.Should().Be("Login");
            
        }    
    
        public void LoginOnLandingPage(){

            //Act
            
            Username.SendKeys(usr_name);
            Password.SendKeys(usr_password);

            LoginButton.Click();
            
        } 

         public void VerifyUserLoggedIn(){

            
            // Find the element with the class name "inventory_container"
            IWebElement inventoryContainer = driver.FindElement(By.ClassName("inventory_container"));

            // Assert that the element exists
            Assert.NotNull(inventoryContainer);
                
        } 
   
    }

}

   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
    }

}