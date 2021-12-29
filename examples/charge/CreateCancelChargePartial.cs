using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;

namespace Example.Charges
{
    class CreateCancelChargePartial
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            string chargeId = "ch_exRAY21fvNFVD9EX";


            var request = new CreateCancelChargeRequest
            {
                Amount = 100
            };

            client.Build().ChargesController.CancelChargeAsync(chargeId, request);

        }
    }
}
