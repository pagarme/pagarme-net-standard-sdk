using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Models;
using System.Collections.Generic;

namespace Example.Subscription
{
    class CreateSubscriptionPrePaidBankSlip
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
            string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
            string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

            var client = new PagarmeApiSDKClient.Builder().BasicAuthCredentials(basicAuthPassword, basicAuthUserName);

            string planId = "plan_21r4CTG0ux77Qv13";

            var metadata = new Dictionary<string, string>();
            metadata.Add("id", "my_subscription_id");

            var billinAddress = new CreateAddressRequest
            {
                Line1 = "375, Av. General Justo, Centro",
                Line2 = "8º andar",
                ZipCode = "20021130",
                City = "Rio de Janeiro",
                State = "RJ",
                Country = "BR"
            };

            var request = new CreateSubscriptionRequest
            {
                PlanId = planId,
                PaymentMethod = "boleto",
                Currency = "BRL",
                Interval = "month",
                IntervalCount = 3,
                BillingType = "prepaid",
                Installments = 3,
                Customer = new CreateCustomerRequest
                {
                    Name = "Tony Stark",
                    Email = "tonystark@avengers.com",
                },
                Card = new CreateCardRequest
                {
                    HolderName = "Tony Stark",
                    Number = "4532464862385322",
                    ExpMonth = 1,
                    ExpYear = 30,
                    Cvv = "903",
                    BillingAddress = billinAddress
                },
                Discounts = new List<CreateDiscountRequest>
                {
                    new CreateDiscountRequest
                    {
                        Cycles = 3,
                        MValue = 10,
                        DiscountType = "percentage"
                    }
                },
                Metadata = metadata,
            };

            var response = client.Build().SubscriptionsController.CreateSubscription(request);
        }
    }
}
