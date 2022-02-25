// <copyright file="PagarmeApiSDKClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeApiSDK.Standard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
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
        private static readonly Dictionary<Environment, Dictionary<Server, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Server, string>>
        {
            {
                Environment.Production, new Dictionary<Server, string>
                {
                    { Server.Default, "https://api.pagar.me/core/v5" },
                }
            },
        };

        private readonly IDictionary<string, IAuthManager> authManagers;
        private readonly IHttpClient httpClient;
        private readonly BasicAuthManager basicAuthManager;

        private readonly Lazy<IOrdersController> orders;
        private readonly Lazy<IPlansController> plans;
        private readonly Lazy<ISubscriptionsController> subscriptions;
        private readonly Lazy<IInvoicesController> invoices;
        private readonly Lazy<ICustomersController> customers;
        private readonly Lazy<IRecipientsController> recipients;
        private readonly Lazy<IChargesController> charges;
        private readonly Lazy<ITokensController> tokens;
        private readonly Lazy<ITransfersController> transfers;
        private readonly Lazy<ITransactionsController> transactions;

        private PagarmeApiSDKClient(
            Environment environment,
            string basicAuthUserName,
            string basicAuthPassword,
            IDictionary<string, IAuthManager> authManagers,
            IHttpClient httpClient,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpClient = httpClient;
            this.authManagers = (authManagers == null) ? new Dictionary<string, IAuthManager>() : new Dictionary<string, IAuthManager>(authManagers);
            this.HttpClientConfiguration = httpClientConfiguration;

            this.orders = new Lazy<IOrdersController>(
                () => new OrdersController(this, this.httpClient, this.authManagers));
            this.plans = new Lazy<IPlansController>(
                () => new PlansController(this, this.httpClient, this.authManagers));
            this.subscriptions = new Lazy<ISubscriptionsController>(
                () => new SubscriptionsController(this, this.httpClient, this.authManagers));
            this.invoices = new Lazy<IInvoicesController>(
                () => new InvoicesController(this, this.httpClient, this.authManagers));
            this.customers = new Lazy<ICustomersController>(
                () => new CustomersController(this, this.httpClient, this.authManagers));
            this.recipients = new Lazy<IRecipientsController>(
                () => new RecipientsController(this, this.httpClient, this.authManagers));
            this.charges = new Lazy<IChargesController>(
                () => new ChargesController(this, this.httpClient, this.authManagers));
            this.tokens = new Lazy<ITokensController>(
                () => new TokensController(this, this.httpClient, this.authManagers));
            this.transfers = new Lazy<ITransfersController>(
                () => new TransfersController(this, this.httpClient, this.authManagers));
            this.transactions = new Lazy<ITransactionsController>(
                () => new TransactionsController(this, this.httpClient, this.authManagers));

            if (this.authManagers.ContainsKey("global"))
            {
                this.basicAuthManager = (BasicAuthManager)this.authManagers["global"];
            }

            if (!this.authManagers.ContainsKey("global")
                || !this.BasicAuthCredentials.Equals(basicAuthUserName, basicAuthPassword))
            {
                this.basicAuthManager = new BasicAuthManager(basicAuthUserName, basicAuthPassword);
                this.authManagers["global"] = this.basicAuthManager;
            }
        }

        /// <summary>
        /// Gets OrdersController controller.
        /// </summary>
        public IOrdersController OrdersController => this.orders.Value;

        /// <summary>
        /// Gets PlansController controller.
        /// </summary>
        public IPlansController PlansController => this.plans.Value;

        /// <summary>
        /// Gets SubscriptionsController controller.
        /// </summary>
        public ISubscriptionsController SubscriptionsController => this.subscriptions.Value;

        /// <summary>
        /// Gets InvoicesController controller.
        /// </summary>
        public IInvoicesController InvoicesController => this.invoices.Value;

        /// <summary>
        /// Gets CustomersController controller.
        /// </summary>
        public ICustomersController CustomersController => this.customers.Value;

        /// <summary>
        /// Gets RecipientsController controller.
        /// </summary>
        public IRecipientsController RecipientsController => this.recipients.Value;

        /// <summary>
        /// Gets ChargesController controller.
        /// </summary>
        public IChargesController ChargesController => this.charges.Value;

        /// <summary>
        /// Gets TokensController controller.
        /// </summary>
        public ITokensController TokensController => this.tokens.Value;

        /// <summary>
        /// Gets TransfersController controller.
        /// </summary>
        public ITransfersController TransfersController => this.transfers.Value;

        /// <summary>
        /// Gets TransactionsController controller.
        /// </summary>
        public ITransactionsController TransactionsController => this.transactions.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets auth managers.
        /// </summary>
        internal IDictionary<string, IAuthManager> AuthManagers => this.authManagers;

        /// <summary>
        /// Gets http client.
        /// </summary>
        internal IHttpClient HttpClient => this.httpClient;

        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        public IBasicAuthCredentials BasicAuthCredentials => this.basicAuthManager;

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            StringBuilder url = new StringBuilder(EnvironmentsMap[this.Environment][alias]);
            ApiHelper.AppendUrlWithTemplateParameters(url, this.GetBaseUriParameters());

            return url.ToString();
        }

        /// <summary>
        /// Creates an object of the PagarmeApiSDKClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .BasicAuthCredentials(this.basicAuthManager.BasicAuthUserName, this.basicAuthManager.BasicAuthPassword)
                .HttpClient(this.httpClient)
                .AuthManagers(this.authManagers)
                .HttpClientConfig(config => config.Build());

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
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

            string environment = System.Environment.GetEnvironmentVariable("PAGARME_API_SDK_STANDARD_ENVIRONMENT");
            string basicAuthUserName = System.Environment.GetEnvironmentVariable("PAGARME_API_SDK_STANDARD_BASIC_AUTH_USER_NAME");
            string basicAuthPassword = System.Environment.GetEnvironmentVariable("PAGARME_API_SDK_STANDARD_BASIC_AUTH_PASSWORD");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (basicAuthUserName != null && basicAuthPassword != null)
            {
                builder.BasicAuthCredentials(basicAuthUserName, basicAuthPassword);
            }

            return builder.Build();
        }

        /// <summary>
        /// Makes a list of the BaseURL parameters.
        /// </summary>
        /// <returns>Returns the parameters list.</returns>
        private List<KeyValuePair<string, object>> GetBaseUriParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList;
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = PagarmeApiSDK.Standard.Environment.Production;
            private string basicAuthUserName = "";
            private string basicAuthPassword = "";
            private IDictionary<string, IAuthManager> authManagers = new Dictionary<string, IAuthManager>();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private IHttpClient httpClient;

            /// <summary>
            /// Sets credentials for BasicAuth.
            /// </summary>
            /// <param name="basicAuthUserName">BasicAuthUserName.</param>
            /// <param name="basicAuthPassword">BasicAuthPassword.</param>
            /// <returns>Builder.</returns>
            public Builder BasicAuthCredentials(string basicAuthUserName, string basicAuthPassword)
            {
                this.basicAuthUserName = basicAuthUserName ?? throw new ArgumentNullException(nameof(basicAuthUserName));
                this.basicAuthPassword = basicAuthPassword ?? throw new ArgumentNullException(nameof(basicAuthPassword));
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
            /// Sets the IHttpClient for the Builder.
            /// </summary>
            /// <param name="httpClient"> http client. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpClient(IHttpClient httpClient)
            {
                this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
                return this;
            }

            /// <summary>
            /// Sets the authentication managers for the Builder.
            /// </summary>
            /// <param name="authManagers"> auth managers. </param>
            /// <returns>Builder.</returns>
            internal Builder AuthManagers(IDictionary<string, IAuthManager> authManagers)
            {
                this.authManagers = authManagers ?? throw new ArgumentNullException(nameof(authManagers));
                return this;
            }

            /// <summary>
            /// Creates an object of the PagarmeApiSDKClient using the values provided for the builder.
            /// </summary>
            /// <returns>PagarmeApiSDKClient.</returns>
            public PagarmeApiSDKClient Build()
            {
                this.httpClient = new HttpClientWrapper(this.httpClientConfig.Build());

                return new PagarmeApiSDKClient(
                    this.environment,
                    this.basicAuthUserName,
                    this.basicAuthPassword,
                    this.authManagers,
                    this.httpClient,
                    this.httpClientConfig.Build());
            }
        }
    }
}
