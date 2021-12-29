using PagarmeApiSDK.Standard;

namespace Example.Charges
{
    class GetChargeById
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);
            string chargeId = "ch_exRAY21fvNFVD9EX";

            var response = client.Build().ChargesController.GetCharge(chargeId);
        }
    }
}
