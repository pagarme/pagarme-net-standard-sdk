using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

namespace Example.Order
{
    class CreateOrderBankTransfer
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
                    Name = "sdk customer order",
                    Email = "tonystark@avengers.com",
                    Address = new CreateAddressRequest
                    {
                        Street = "Malibu Point",
                        Number = "10880",
                        ZipCode = "90265",
                        Neighborhood = "Central Malibu",
                        City = "Malibu",
                        State = "CA",
                        Country = "US",
                    }
                },
                Payments = new List<CreatePaymentRequest>
                {
                new CreatePaymentRequest
                {
                PaymentMethod = "credit_card",
                    CreditCard = new CreateCreditCardPaymentRequest
                    {
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
                    PaymentMethod = "Boleto",
                    Amount = 1242,
                    Boleto = new CreateBoletoPaymentRequest
                    {
                        DocumentNumber = "276262",
                        Bank = "001"
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

            var response = client.Build().OrdersController.CreateOrderAsync(request);

        }
    }
}
