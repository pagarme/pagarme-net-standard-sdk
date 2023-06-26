
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `ServiceRefererName` | `string` |  |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BasicAuthUserName` | `string` | The username to use with basic authentication |
| `BasicAuthPassword` | `string` | The password to use with basic authentication |

The API client can be initialized as follows:

```csharp
PagarmeApiSDK.Standard.PagarmeApiSDKClient client = new PagarmeApiSDK.Standard.PagarmeApiSDKClient.Builder()
    .BasicAuthCredentials("BasicAuthUserName", "BasicAuthPassword")
    .ServiceRefererName("ServiceRefererName")
    .Build();
```

## PagarmeApiSDKClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| OrdersController | Gets OrdersController controller. |
| PlansController | Gets PlansController controller. |
| SubscriptionsController | Gets SubscriptionsController controller. |
| InvoicesController | Gets InvoicesController controller. |
| CustomersController | Gets CustomersController controller. |
| RecipientsController | Gets RecipientsController controller. |
| ChargesController | Gets ChargesController controller. |
| TokensController | Gets TokensController controller. |
| TransfersController | Gets TransfersController controller. |
| TransactionsController | Gets TransactionsController controller. |
| PayablesController | Gets PayablesController controller. |
| BalanceOperationsController | Gets BalanceOperationsController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| ServiceRefererName | - | `string` |
| Environment | Current API environment. | `Environment` |

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
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `ServiceRefererName(string serviceRefererName)` | - | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |

