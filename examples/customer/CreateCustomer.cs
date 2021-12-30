using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

namespace Example.Customer
{
    class CreateCustomer
    {
        static void Main(string[] args)
        {
           // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication
            
            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            var metadata = new Dictionary<string, string>();
            metadata.Add("id", "my_customer_id");

            var request = new CreateCustomerRequest
            {
                Name = "Tony Stark",
                Email = "tonystark@avengers.com",
                Type = "individual",
                Document = "93095135270",
                Gender = "male",
                Code = "MY_CUSTOMER_001",
                Phones = new CreatePhonesRequest
                {
                HomePhone = new CreatePhoneRequest
                    {
                        AreaCode = "21",
                        CountryCode = "55",
                        Number = "000000000"
                    },
                MobilePhone = new CreatePhoneRequest
                    {
                        AreaCode = "21",
                        CountryCode = "55",
                        Number = "000000000"
                    },
                },
                Address = new CreateAddressRequest
                {
                    Line1 = "375, Av. General Justo, Centro",
                    Line2 = "8º andar",
                    ZipCode = "20021130",
                    City = "Rio de Janeiro",
                    State = "RJ",
                    Country = "BR"
                },
                Metadata = metadata
                };

            var response = client.Build().CustomersController.CreateCustomer(request);

        }

    }
}
