using PagarmeApiSDK.Standard;

namespace Example.Customer
{
    class GetCustomerById
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            string customerId = "cus_6l5dMWZ0hkHZ4XnE";

            var response = client.Build().CustomersController.GetCustomer(customerId);
        }
    }
}
