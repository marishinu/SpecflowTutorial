using System;
using TechTalk.SpecFlow;
using Json.NET.Web;
using RestSharp;

namespace SpecflowTutorial.cs
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        [Given(@"Connect to (.*)")]
        public void GivenConnectToHttpWddcedglws(string server)
        {
            try
            {
                CommonVariables.serverconnect = new RestClient(server);

                Console.WriteLine("Connected successfully to {0} server", server);
                Console.WriteLine("_________________________________");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to connect to the {0}. Following exception occured: {1}", server, ex.Message);
            }
        }
        
        [Given(@"API url is (.*)")]
        public void GivenAPIUrlIsOrders(String uri)
        {
            try
            {
                CommonVariables.apiUri = new RestRequest(uri);

                Console.WriteLine("Request instance for {0} created successfully", uri);
                Console.WriteLine("_________________________________");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to create Request instance for {0}. Following exception occured: {1}", uri, ex.Message);
            }
        }
        
        [Given(@"The API method is POST")]
        public void GivenTheAPIMethodIsPOST()
        {
            CommonVariables.apiUri.Method = Method.POST;
            
            Console.WriteLine("_________________________________");
        }
        
        [Given(@"Request params are added")]
        public void GivenRequestParamsAreAdded()
        {
           CommonVariables.apiUri.AddParameter("ContactId", "49856109");
           CommonVariables.apiUri.AddParameter("SubsidiaryCode", "CA");
           CommonVariables.apiUri.AddParameter("Culture", "en-CA");
           CommonVariables.apiUri.AddParameter("OrderType", "1");
           
           Console.WriteLine("_________________________________");
        }
        
        [When(@"The request is executed")]
        public void WhenTheRequestIsExecuted()
        {
            CommonVariables.response = CommonVariables.serverconnect.Execute(CommonVariables.apiUri);

            Console.WriteLine("Request has been executed and response is as follows: {0}", CommonVariables.response.Content);
            Console.WriteLine("_________________________________");
        }
        
        [Then(@"the Status code should be (.*)")]
        public void ThenTheStatusCodeShouldBe(String StatusCode)
        {

            if (CommonVariables.response.StatusCode.ToString() == StatusCode)
            {                
                Console.WriteLine(CommonVariables.response.StatusDescription);
            }
            else
            {
                Console.WriteLine("The status code is not matched. Status code is:" + CommonVariables.response.StatusCode.ToString());
                throw new StatusCodeException();
                
            }
            Console.WriteLine("_________________________________");
        }
    }
}
