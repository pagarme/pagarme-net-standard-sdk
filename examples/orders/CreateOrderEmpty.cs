using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

namespace Example.Order
{
    class CreateOrderEmpty
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);
            
            var request = new CreateOrderRequest()
            {
                Customer = new CreateCustomerRequest()
                {
                    Name = "sdk customer order",
                    Email = "tonystark@avengers.com"
                },

                Items = new List<CreateOrderItemRequest>
                {
                    new CreateOrderItemRequest
                    {
                        Amount = 2990,
                        Description = "Chaveiro do Tesseract",
                        Quantity = 1,
                    }
                },
                Payments = new List<CreatePaymentRequest>
                {
                    new CreatePaymentRequest
                    {
                        BankTransfer = new CreateBankTransferPaymentRequest
                        {
                            Bank = "001"
                        }
                    }
                }
            };


            var response = client.Build().OrdersController.CreateOrderAsync(request);

        }
    }
}
