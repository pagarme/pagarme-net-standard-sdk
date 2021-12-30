using PagarmeApiSDK.Standard;

namespace Example.Order
{
    class GetOrderById
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            string orderId = "or_9j8m1E4f6HonwYA0";


            var response = client.Build().OrdersController.GetOrder(orderId);
        }

    }
}
