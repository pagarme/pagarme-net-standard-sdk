
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| ServiceRefererName | `string` |  |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](../doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| BasicAuthCredentials | [`BasicAuthCredentials`](auth/basic-authentication.md) | The Credentials Setter for Basic Authentication |

The API client can be initialized as follows:

## Code-Based Initialization

```csharp
using PagarmeApiSDK.Standard;
using PagarmeApiSDK.Standard.Authentication;

namespace ConsoleApp;

PagarmeApiSDKClient client = new PagarmeApiSDKClient.Builder()
    .BasicAuthCredentials(
        new BasicAuthModel.Builder(
            "BasicAuthUserName",
            "BasicAuthPassword"
        )
        .Build())
    .HttpClientConfig(httpClientConfig =>
        httpClientConfig.Timeout(TimeSpan.FromSeconds(100)))
    .ServiceRefererName("ServiceRefererName")
    .Build();
```

## Configuration-Based Initialization

```csharp
using PagarmeApiSDK.Standard;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK and configure it from IConfiguration
var client = PagarmeApiSDKClient
    .FromConfiguration(configuration.GetSection("PagarmeApiSDK"));
```

See the [Configuration-Based Initialization](../doc/configuration-based-initialization.md) section for details.

## PagarmeApiSDKClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| SubscriptionsController | Gets SubscriptionsController controller. |
| OrdersController | Gets OrdersController controller. |
| PlansController | Gets PlansController controller. |
| InvoicesController | Gets InvoicesController controller. |
| CustomersController | Gets CustomersController controller. |
| ChargesController | Gets ChargesController controller. |
| RecipientsController | Gets RecipientsController controller. |
| TokensController | Gets TokensController controller. |
| TransactionsController | Gets TransactionsController controller. |
| TransfersController | Gets TransfersController controller. |
| PayablesController | Gets PayablesController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](../doc/http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| ServiceRefererName | - | `string` |
| Environment | Current API environment. | `Environment` |
| BasicAuthCredentials | Gets the credentials to use with BasicAuth. | [`IBasicAuthCredentials`](auth/basic-authentication.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the PagarmeApiSDKClient using the values provided for the builder. | `Builder` |

## PagarmeApiSDKClient Builder Class

Class to build instances of PagarmeApiSDKClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](../doc/http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `ServiceRefererName(string serviceRefererName)` | - | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `BasicAuthCredentials(Action<BasicAuthModel.Builder> action)` | Sets credentials for BasicAuth. | `Builder` |

