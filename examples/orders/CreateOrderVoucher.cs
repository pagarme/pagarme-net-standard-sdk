using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

namespace Example.Order
{
    class CreateOrderVoucher
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            var request = new CreateOrderRequest
            {
                Payments = new List<CreatePaymentRequest> 
                {
                    new CreatePaymentRequest 
                    {
                        PaymentMethod = "voucher",
                            Voucher = new CreateVoucherPaymentRequest
                            {
                                StatementDescriptor = "Text applies on card invoice.",
                                CardId = "or_9j8m1E4f6HonwYA0"
                            },

                    },
                    new CreatePaymentRequest
                    {
                        BankTransfer = new CreateBankTransferPaymentRequest
                        {
                            Bank = "001",
                        }
                    }
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
                Customer = new CreateCustomerRequest()
                {
                    Name = "sdk customer order",
                    Email = "tonystark@avengers.com"
                }

            };

            var response = client.Build().OrdersController.CreateOrderAsync(request);

        }
    }
}
