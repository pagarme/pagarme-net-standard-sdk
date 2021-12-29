using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;

namespace Example.Subscription
{
    class CreateCancelSubscription
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            string subscrptionId = "sub_WeEMlp2FXFMjVq3Q";

            var request = new CreateCancelSubscriptionRequest
            {
                CancelPendingInvoices = true
            };

            var response = client.Build().SubscriptionsController.CancelSubscription(subscrptionId, request);
        }
    }
}
