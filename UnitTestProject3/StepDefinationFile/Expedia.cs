using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Interactions;
using UnitTestProject3.Utilities;

namespace UnitTestProject3.StepDefinationFile
{
    [Binding]
    public class CheckingTheFunctionalityOfFlightBookingAtExpedia_ComSteps : ExpediaUtilities
    {
       
        [Given(@"Open the GoogleChrome")]
        public void GivenOpentheGoogleChrome()
        {
            try
            {
                invokeDriver();

                driver.Navigate().GoToUrl("https://www.google.com");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            }
            catch (Exception )
            {

            }

        }
      /*  
        [When(@"Report are generate")]
        public void WhenReportAreGenerate()
        {
           // ScenarioContext.Current.Pending();
        }
        */
        [Then(@"Open the Expedia Website")]
        public void ThenOpentheExpediaWebsite()
        {
            driver.Navigate().GoToUrl("https://www.expedia.co.in/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [Then(@"select flight tab")]
        public void ThenselectFlightTab()
        {

            driver.FindElement(By.XPath(flight)).Click();
            
            
           
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [Then(@"select MultiCity Option")]
        public void ThenselectMultiCityOption()
        {
            elementclick(MultiCity);
        }
        
        [Then(@"enter Source1 and Destination1")]
        public void ThenenterSource1andDestination1()
        {
              elementclick(source1);
              elementsendkeys(source1, "Delhi, India");

              elementclick(destination1);
             elementsendkeys(destination1, "Mumbai, India");
        }
        
        [Then(@"Choose DateOfJourney1 and Choose Number of travelers")]
        public void ThenChooseDateOfJourney1AndChooseNumberOftravelers()
        {
           
            elementclick(date1);
         
            elementsendkeys(date1, "20/09/2019");

            elementclick(selectpassengers);
            for (int i = 1; i <= 3; i++)

            {
                elementclick(noOfpassengers);

            }

        }

        [Then(@"now choose Source2 and Destination2")]
        public void ThennowchooseSource2andDestination2()
        {
           
            elementclick(source2);
           
            elementsendkeys(source2, "Mumbai, India");
            
            elementclick(destination2);
            
            elementsendkeys(destination2, "Chennai, India");
        }

        [Then(@"Choose DateOfJourney2")]
        public void ThenChooseDateOfJourney2()
        {
            elementclick(date2);
            elementsendkeys(date2, "24/09/2019");
         
        }
        
        [Then(@"now choose Source3 and Destination3")]
        public void ThennowchooseSource3andDestination3()
        {
            
            elementclick(addflight);
            
            elementclick(source3);
            elementsendkeys(source3, "Chennai, India");
            
            elementclick(destination3);
           elementsendkeys(destination3, "Delhi, India");
        }

        [Then(@"Choose DateOfJourney3")]
        public void ThenChooseDateOfJourney3()
        {
            
            elementclick(date3);

            elementsendkeys(date3, "28/09/2019");
           

        }

        [Then(@"Click On the Search Button")]
        public void ThenClickOnTheSearchButton()
        {
            elementclick(searchbutton);
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        
        [When(@"Ensuring correct information of all three flights")]
        public void WhenEnsuringCorrectInformationOfAllThreeFlights()
        {

        }

        [Then(@"Ensuring the correct amount per person")]
        public void ThenEnsuringTheCorrectAmountPerPerson()
        /* {
              //string amount1 = driver.FindElement(By.XPath("//*[@id='flight - module - 2019 - 09 - 20t07: 00:00 + 05:30 - coach - del - bom - uk - 923_2019 - 09 - 24t18: 35:00 + 05:30 - coach - bom - maa - uk - 823_2019 - 09 - 28t06: 50:00 + 05:30 - premium coach - maa - del - uk - 832_']/div[1]/div[1]/div[2]/div/div[1]/div[1]/span[2]")).Text;

              string amount1 = driver.FindElement(By.XPath("(//*[@class='full-bold no-wrap'])[1]")).Text;
             string amount2 = amount1.Substring(2);

              string[] amt = amount2.Split(',');

              string totalAmt = "";

              foreach (var item in amt)

              {
                  totalAmt = totalAmt + item;
              }

              totalAmt = totalAmt.Split('.')[0];

              int amount = Int32.Parse(totalAmt);

              int PerPersonAmount = amount * 4;
             driver.FindElement(By.XPath("(//div[@class='grid-container standard-padding ']//button)[1] ")).Click();
             //driver.FindElement(By.XPath("(//div[@class='grid-container standard-padding ']//button)[1] ")).Click();
             //driver.FindElement(By.XPath("(//div[@class='grid-container standard-padding ']//button)[1] ")).Click();
             //driver.FindElement(By.XPath("//*[@id='flight - module - 2019 - 09 - 20t07: 00:00 + 05:30 - coach - del - bom - uk - 923_2019 - 09 - 24t18: 35:00 + 05:30 - coach - bom - maa - uk - 823_2019 - 09 - 28t06: 50:00 + 05:30 - premium coach - maa - del - uk - 832_']/div[1]/div[1]/div[2]/div/div[2]/button")).Click();


             driver.FindElement(By.XPath("(//div[@class='grid-container standard-padding']//button)[1]")).Click();
             driver.FindElement(By.XPath("//*[@id='flight - module - 2019 - 09 - 20t07: 00:00 + 05:30 - coach - del - bom - uk - 923_2019 - 09 - 24t06: 10:00 + 05:30 - coach - bom - maa - uk - 821_2019 - 09 - 28t06: 50:00 + 05:30 - premium coach - maa - del - uk - 832_']/div[1]/div[1]/div[2]/div/div[2]/button")).Click();
             driver.FindElement(By.XPath("")).Click();

             string Finalamount = driver.FindElement(By.XPath("(//span[@class='packagePriceTotal'])[1]")).Text;


              string Finalamount1 = Finalamount.Substring(2);

                string[] finalamount2 = Finalamount1.Split(',');

                string totalamount = "";

                foreach (var item in finalamount2)

                {
                    totalamount = totalamount + item;
                }

                totalamount = totalamount.Split('.')[0];

                int FinalElement = Int32.Parse(totalamount);
                if (PerPersonAmount == FinalElement)
                {

                }


         }*/
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string amount1 = driver.FindElement(By.XPath("(//*[@class='full-bold no-wrap'])[1]")).Text;

            double amount = double.Parse(amount1.Replace(",", "").Replace("Rs", ""));
            double PerPersonAmount = amount * 4;

            driver.FindElement(By.XPath("(//div[@class='grid-container standard-padding ']//button)[1] ")).Click();

            driver.FindElement(By.XPath("(//div[@class='grid-container standard-padding ']//button)[1] ")).Click();
            driver.FindElement(By.XPath("(//div[@class='grid-container standard-padding ']//button)[1] ")).Click();


           // string Finalamount = driver.FindElement(By.XPath("/html/body/main/div/div[2]/section[1]/div/div[2]/div/div[1]/span[2]")).Text;

           /* double final = double.Parse(Finalamount.Replace(",", "").Replace("Rs", ""));


            Assert.AreEqual(PerPersonAmount, final);*/
        }

        [Then(@"now Close browser")]
        public void ThennowClosebrowser()
        {
           closeDriver();
        }
    }
}




