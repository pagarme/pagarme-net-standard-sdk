using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

namespace Examples.card
{
    class CreateCard
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            string customerId = "cus_YL6zwglSxhg2X14g";

            var metadata = new Dictionary<string, string>();
            metadata.Add("company", "Avengers");

            var billingAddress = new CreateAddressRequest
            {
                Line1 = "375, Av. General Justo, Centro",
                Line2 = "7º andar",
                ZipCode = "22000111",
                City = "Rio de Janeiro",
                State = "RJ",
                Country = "BR"
            };

            var request = new CreateCardRequest
            {
                Number = "4000000000000010",
                HolderName = "Tony Starkk",
                HolderDocument = "93095135273",
                ExpMonth = 1,
                ExpYear = 25,
                Cvv = "351",
                Brand = "Mastercard",
                PrivateLabel = false,
                BillingAddress = billingAddress,
                Metadata = metadata,

            };

            var response = client.Build().CustomersController.CreateCard(customerId, request);
        }
    }
}
