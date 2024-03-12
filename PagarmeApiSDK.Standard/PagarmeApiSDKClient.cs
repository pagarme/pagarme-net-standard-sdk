// <copyright file="PagarmeApiSDKClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using APIMatic.Core;
    using APIMatic.Core.Authentication;
    using APIMatic.Core.Types;
    using PagarmeApiSDK.Standard.Authentication;
    using PagarmeApiSDK.Standard.Controllers;
    using PagarmeApiSDK.Standard.Http.Client;
    using PagarmeApiSDK.Standard.Utilities;

    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class PagarmeApiSDKClient : IPagarmeApiSDKClient
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api.pagar.me/core/v5" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "PagarmeApiSDK - DotNet 6.8.7";
        private readonly Lazy<ISubscriptionsController> subscriptions;
        private readonly Lazy<IOrdersController> orders;
        private readonly Lazy<IPlansController> plans;
        private readonly Lazy<IInvoicesController> invoices;
        private readonly Lazy<ICustomersController> customers;
        private readonly Lazy<IChargesController> charges;
        private readonly Lazy<IRecipientsController> recipients;
        private readonly Lazy<ITokensController> tokens;
        private readonly Lazy<ITransactionsController> transactions;
        private readonly Lazy<ITransfersController> transfers;
        private readonly Lazy<IPayablesController> payables;
        private readonly Lazy<IBalanceOperationsController> balanceOperations;

        private PagarmeApiSDKClient(
            string serviceRefererName,
            Environment environment,
            BasicAuthModel basicAuthModel,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.ServiceRefererName = serviceRefererName;
            this.Environment = environment;
            this.HttpClientConfiguration = httpClientConfiguration;
            BasicAuthModel = basicAuthModel;
            var basicAuthManager = new BasicAuthManager(basicAuthModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"httpBasic", basicAuthManager},
                })
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .Parameters(globalParameter => globalParameter
                    .Header(headerParameter => headerParameter.Setup("ServiceRefererName", this.ServiceRefererName))
)
                .UserAgent(userAgent)
                .Build();

            BasicAuthCredentials = basicAuthManager;

            this.subscriptions = new Lazy<ISubscriptionsController>(
                () => new SubscriptionsController(globalConfiguration));
            this.orders = new Lazy<IOrdersController>(
                () => new OrdersController(globalConfiguration));
            this.plans = new Lazy<IPlansController>(
                () => new PlansController(globalConfiguration));
            this.invoices = new Lazy<IInvoicesController>(
                () => new InvoicesController(globalConfiguration));
            this.customers = new Lazy<ICustomersController>(
                () => new CustomersController(globalConfiguration));
            this.charges = new Lazy<IChargesController>(
                () => new ChargesController(globalConfiguration));
            this.recipients = new Lazy<IRecipientsController>(
                () => new RecipientsController(globalConfiguration));
            this.tokens = new Lazy<ITokensController>(
                () => new TokensController(globalConfiguration));
            this.transactions = new Lazy<ITransactionsController>(
                () => new TransactionsController(globalConfiguration));
            this.transfers = new Lazy<ITransfersController>(
                () => new TransfersController(globalConfiguration));
            this.payables = new Lazy<IPayablesController>(
                () => new PayablesController(globalConfiguration));
            this.balanceOperations = new Lazy<IBalanceOperationsController>(
                () => new BalanceOperationsController(globalConfiguration));
        }

        /// <summary>
        /// Gets SubscriptionsController controller.
        /// </summary>
        public ISubscriptionsController SubscriptionsController => this.subscriptions.Value;

        /// <summary>
        /// Gets OrdersController controller.
        /// </summary>
        public IOrdersController OrdersController => this.orders.Value;

        /// <summary>
        /// Gets PlansController controller.
        /// </summary>
        public IPlansController PlansController => this.plans.Value;

        /// <summary>
        /// Gets InvoicesController controller.
        /// </summary>
        public IInvoicesController InvoicesController => this.invoices.Value;

        /// <summary>
        /// Gets CustomersController controller.
        /// </summary>
        public ICustomersController CustomersController => this.customers.Value;

        /// <summary>
        /// Gets ChargesController controller.
        /// </summary>
        public IChargesController ChargesController => this.charges.Value;

        /// <summary>
        /// Gets RecipientsController controller.
        /// </summary>
        public IRecipientsController RecipientsController => this.recipients.Value;

        /// <summary>
        /// Gets TokensController controller.
        /// </summary>
        public ITokensController TokensController => this.tokens.Value;

        /// <summary>
        /// Gets TransactionsController controller.
        /// </summary>
        public ITransactionsController TransactionsController => this.transactions.Value;

        /// <summary>
        /// Gets TransfersController controller.
        /// </summary>
        public ITransfersController TransfersController => this.transfers.Value;

        /// <summary>
        /// Gets PayablesController controller.
        /// </summary>
        public IPayablesController PayablesController => this.payables.Value;

        /// <summary>
        /// Gets BalanceOperationsController controller.
        /// </summary>
        public IBalanceOperationsController BalanceOperationsController => this.balanceOperations.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
         /// Gets ServiceRefererName.
        /// </summary>
        public string ServiceRefererName { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }


        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        public IBasicAuthCredentials BasicAuthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BasicAuth.
        /// </summary>
        public BasicAuthModel BasicAuthModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the PagarmeApiSDKClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .ServiceRefererName(this.ServiceRefererName)
                .Environment(this.Environment)
                .HttpClientConfig(config => config.Build());

            if (BasicAuthModel != null)
            {
                builder.BasicAuthCredentials(BasicAuthModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"ServiceRefererName = {this.ServiceRefererName}, " +
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> PagarmeApiSDKClient.</returns>
        internal static PagarmeApiSDKClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string serviceRefererName = System.Environment.GetEnvironmentVariable("PAGARME_API_SDK_STANDARD_SERVICE_REFERER_NAME");
            string environment = System.Environment.GetEnvironmentVariable("PAGARME_API_SDK_STANDARD_ENVIRONMENT");
            string basicAuthUserName = System.Environment.GetEnvironmentVariable("PAGARME_API_SDK_STANDARD_BASIC_AUTH_USER_NAME");
            string basicAuthPassword = System.Environment.GetEnvironmentVariable("PAGARME_API_SDK_STANDARD_BASIC_AUTH_PASSWORD");

            if (serviceRefererName != null)
            {
                builder.ServiceRefererName(serviceRefererName);
            }

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (basicAuthUserName != null && basicAuthPassword != null)
            {
                builder.BasicAuthCredentials(new BasicAuthModel
                .Builder(basicAuthUserName, basicAuthPassword)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private string serviceRefererName = String.Empty;
            private Environment environment = PagarmeApiSDK.Standard.Environment.Production;
            private BasicAuthModel basicAuthModel = new BasicAuthModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();

            /// <summary>
            /// Sets credentials for BasicAuth.
            /// </summary>
            /// <param name="basicAuthUserName">BasicAuthUserName.</param>
            /// <param name="basicAuthPassword">BasicAuthPassword.</param>
            /// <returns>Builder.</returns>
            [Obsolete("This method is deprecated. Use BasicAuthCredentials(basicAuthModel) instead.")]
            public Builder BasicAuthCredentials(string basicAuthUserName, string basicAuthPassword)
            {
                basicAuthModel = basicAuthModel.ToBuilder()
                    .Username(basicAuthUserName)
                    .Password(basicAuthPassword)
                    .Build();
                return this;
            }

            /// <summary>
            /// Sets credentials for BasicAuth.
            /// </summary>
            /// <param name="basicAuthModel">BasicAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder BasicAuthCredentials(BasicAuthModel basicAuthModel)
            {
                if (basicAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(basicAuthModel));
                }

                this.basicAuthModel = basicAuthModel;
                return this;
            }

            /// <summary>
            /// Sets ServiceRefererName.
            /// </summary>
            /// <param name="serviceRefererName"> ServiceRefererName. </param>
            /// <returns> Builder. </returns>
            public Builder ServiceRefererName(string serviceRefererName)
            {
                this.serviceRefererName = serviceRefererName ?? throw new ArgumentNullException(nameof(serviceRefererName));
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }

           

            /// <summary>
            /// Creates an object of the PagarmeApiSDKClient using the values provided for the builder.
            /// </summary>
            /// <returns>PagarmeApiSDKClient.</returns>
            public PagarmeApiSDKClient Build()
            {

                if (basicAuthModel.Username == null || basicAuthModel.Password == null)
                {
                    basicAuthModel = null;
                }
                return new PagarmeApiSDKClient(
                    serviceRefererName,
                    environment,
                    basicAuthModel,
                    httpClientConfig.Build());
            }
        }
    }
}
