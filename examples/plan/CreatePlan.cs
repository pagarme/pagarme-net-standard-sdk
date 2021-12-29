using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

namespace Example.Plan
{
    class CreatePlan
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            var metadata = new Dictionary<string, string>();
            metadata.Add("id", "my_plan_id");

            var items = new List<CreatePlanItemRequest> 
            {
                new CreatePlanItemRequest 
                {
                    Name = "Musculação",
                    Quantity = 1,
                    PricingScheme = new CreatePricingSchemeRequest
                    {
                        Price = 18990
                    }
                },
                 new CreatePlanItemRequest
                 {
                     Name = "Musculação",
                     Cycles = 1,
                     Quantity =1,
                     PricingScheme = new CreatePricingSchemeRequest
                     {
                         Price = 5990
                     }
                 }
            };

            var request = new CreatePlanRequest
            {

                Name = "Plano Gold",
                Installments = new List<int> { 3 },
                BillingType = "prepaid",
                StatementDescriptor = "Spotify",
                Items = items,
                Metadata = metadata
            };

            var response = client.Build().PlansController.CreatePlan(request);
        }

    }
}
