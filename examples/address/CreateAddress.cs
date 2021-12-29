using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

namespace Examples.address
{
    class CreateAddress
    {
        static void Main(string[] args)
        {

            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            string customerId = "cus_PzRyp10FeNca2rVB";

            var metadata = new Dictionary<string, string>();
            metadata.Add("id", "my_address_id");

            var request = new CreateAddressRequest
            {

                Line1 = "10880, Malibu Point, Malibu Central",
                Line2 = "7º floor",
                ZipCode = "90265",
                City = "Malibu",
                State = "CA",
                Country = "US",
                Metadata = metadata,
            };

            var response = client.Build().CustomersController.CreateAddress(customerId, request);

        }
    }
}
