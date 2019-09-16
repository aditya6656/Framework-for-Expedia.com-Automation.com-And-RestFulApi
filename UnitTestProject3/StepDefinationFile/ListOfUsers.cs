using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject3.StepDefinationFile
{
    [Binding]
    public class TakingTheListOfUserSteps
    {
        RestClient client;
        RestRequest request;
        [Given(@"We initiate the reuest and response")]
        public void GivenWeInitiateTheReuestAndResponse()
        {
            client = new RestClient("https://reqres.in/.");
            request = new RestRequest("/api/users?page=2", Method.GET);
        }
        
        [When(@"Get the corresponding Rsponse")]
        public void WhenGetTheCorrespondingRsponse()
        {
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            Console.WriteLine(content);
            Api deserializedProduct = JsonConvert.DeserializeObject<Api>(content);

            Assert.AreEqual(deserializedProduct.page, 2);
            Assert.AreEqual(deserializedProduct.total, 12);
        }
        
        [Then(@"AGenerate the tokens")]
        public void AThenGenerateTheTokens()
        {
           
        }
    }
}
