using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;

namespace Example.Subscription
{
    class UpdateSubscription
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            string subscrptionId = "sub_05jkdIfGYPfN26mI";
            var request = new UpdateSubscriptionCardRequest
            {

                Card = new CreateCardRequest
                {

                    Number = "4024007149094251",
                    HolderName = "Tony Stark",
                    ExpMonth = 6,
                    ExpYear = 30,
                    Cvv = "680",
                    BillingAddress = new CreateAddressRequest
                    {
                        Line1 = "375, Av. General Justo, Centro",
                        Line2 = "8º andar",
                        ZipCode = "20021130",
                        City = "Rio de Janeiro",
                        State = "RJ",
                        Country = "BR"
                    }
                }
            };

            var response = client.Build().SubscriptionsController.UpdateSubscriptionCard(subscrptionId, request);
        }
    }
}
