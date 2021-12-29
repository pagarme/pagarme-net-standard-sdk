using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

namespace Example.Order
{
    class CreateOrderCheckout
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            var request = new CreateOrderRequest
            {
                Customer = new CreateCustomerRequest
                {
                    Name = "Tony Stark",
                    Email = "tonystark@avengers.com",
                },
                Payments = new List<CreatePaymentRequest>
                {
                    new CreatePaymentRequest
                    {
                        Amount = 990,
                        PaymentMethod = "credit_card",
                        CreditCard = new CreateCreditCardPaymentRequest
                        {
                            StatementDescriptor = "AVENGERS",
                            Card = new CreateCardRequest
                            {
                                HolderName = "Tony Stark",
                                Number = "4000000000000010",
                                ExpMonth = 12,
                                ExpYear = 29,
                                Cvv = "3531",
                            }
                        }
                    },
                    new CreatePaymentRequest
                    {
                        Amount = 2000,
                        PaymentMethod = "credit_card",
                        CreditCard = new CreateCreditCardPaymentRequest
                        {
                            StatementDescriptor = "AVENGERS",
                            Card = new CreateCardRequest
                            {
                                HolderName = "Tony Stark",
                                Number = "4000000000000010",
                                ExpMonth = 12,
                                ExpYear = 29,
                                Cvv = "3531",
                            }
                        }
                    }
                },
                Items = new List<CreateOrderItemRequest> 
                {
                    new CreateOrderItemRequest
                    {
                        Amount = 2990,
                        Description = "Chaveiro do Tesseract",
                        Quantity = 1
                    }
                }
            };
            
            var response = client.Build().OrdersController.CreateOrder(request);

        }
    }
}
