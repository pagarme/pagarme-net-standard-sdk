using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;

namespace Example.Charges
{
    class CaptureCharge
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);
            string chargeId = "ch_exRAY21fvNFVD9EX";

            // Opcional
            var request = new CreateCaptureChargeRequest
            {
                Amount = 100,
                Code = "ABCDE123"
            };

            var response = client.Build().ChargesController.CaptureCharge(chargeId, request);

        }

    }
}
