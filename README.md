
# Getting Started with PagarmeApiSDK

## Introduction

Pagarme API

## Building

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore is enabled, these dependencies will be installed automatically. Therefore, you will need internet access for build.

* Open the solution (PagarmeApiSDK.sln) file.

Invoke the build process using Ctrl + Shift + B shortcut key or using the Build menu as shown below.

The build process generates a portable class library, which can be used like a normal class library. More information on how to use can be found at the MSDN Portable Class Libraries documentation.

The supported version is **.NET Standard 2.0**. For checking compatibility of your .NET implementation with the generated library, [click here](https://dotnet.microsoft.com/en-us/platform/dotnet-standard#versions).

## Installation

The following section explains how to use the PagarmeApiSDK.Standard library in a new project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the solution explorer and choose `Add -> New Project`.

![Add a new project in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=PagarmeApiSDK-CSharp&workspaceName=PagarmeApiSDK&projectName=PagarmeApiSDK.Standard&rootNamespace=PagarmeApiSDK.Standard&step=addProject)

Next, choose `Console Application`, provide `TestConsoleProject` as the project name and click OK.

![Create a new Console Application in Visual Studio](https://apidocs.io/illustration/cs?workspaceFolder=PagarmeApiSDK-CSharp&workspaceName=PagarmeApiSDK&projectName=PagarmeApiSDK.Standard&rootNamespace=PagarmeApiSDK.Standard&step=createProject)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the `TestConsoleProject` as the start-up project. To do this, right-click on the `TestConsoleProject` and choose `Set as StartUp Project` form the context menu.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=PagarmeApiSDK-CSharp&workspaceName=PagarmeApiSDK&projectName=PagarmeApiSDK.Standard&rootNamespace=PagarmeApiSDK.Standard&step=setStartup)

### 3. Add reference of the library project

In order to use the `PagarmeApiSDK.Standard` library in the new project, first we must add a project reference to the `TestConsoleProject`. First, right click on the `References` node in the solution explorer and click `Add Reference...`

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=PagarmeApiSDK-CSharp&workspaceName=PagarmeApiSDK&projectName=PagarmeApiSDK.Standard&rootNamespace=PagarmeApiSDK.Standard&step=addReference)

Next, a window will be displayed where we must set the `checkbox` on `PagarmeApiSDK.Standard` and click `OK`. By doing this, we have added a reference of the `PagarmeApiSDK.Standard` project into the new `TestConsoleProject`.

![Creating a project reference](https://apidocs.io/illustration/cs?workspaceFolder=PagarmeApiSDK-CSharp&workspaceName=PagarmeApiSDK&projectName=PagarmeApiSDK.Standard&rootNamespace=PagarmeApiSDK.Standard&step=createReference)

### 4. Write sample code

Once the `TestConsoleProject` is created, a file named `Program.cs` will be visible in the solution explorer with an empty `Main` method. This is the entry point for the execution of the entire solution. Here, you can add code to initialize the client library and acquire the instance of a Controller class. Sample code to initialize the client library and using Controller methods is given in the subsequent sections.

![Adding a project reference](https://apidocs.io/illustration/cs?workspaceFolder=PagarmeApiSDK-CSharp&workspaceName=PagarmeApiSDK&projectName=PagarmeApiSDK.Standard&rootNamespace=PagarmeApiSDK.Standard&step=addCode)

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| ServiceRefererName | `string` |  |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |
| BasicAuthCredentials | [`BasicAuthCredentials`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/auth/basic-authentication.md) | The Credentials Setter for Basic Authentication |

The API client can be initialized as follows:

### Code-Based Initialization

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

### Configuration-Based Initialization

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

See the [Configuration-Based Initialization](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/configuration-based-initialization.md) section for details.

## Authorization

This API uses the following authentication schemes.

* [`httpBasic (Basic Authentication)`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/auth/basic-authentication.md)

## API Errors

Here is the list of errors that the API might throw.

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid request | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/models/error-exception.md) |
| 401 | Invalid API key | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/models/error-exception.md) |
| 404 | An informed resource was not found | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/models/error-exception.md) |
| 412 | Business validation error | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/models/error-exception.md) |
| 422 | Contract validation error | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/models/error-exception.md) |
| 500 | Internal server error | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/models/error-exception.md) |

## List of APIs

* [Charges](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/controllers/charges.md)
* [Customers](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/controllers/customers.md)
* [Invoices](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/controllers/invoices.md)
* [Orders](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/controllers/orders.md)
* [Payables](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/controllers/payables.md)
* [Plans](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/controllers/plans.md)
* [Recipients](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/controllers/recipients.md)
* [Subscriptions](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/controllers/subscriptions.md)
* [Tokens](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/controllers/tokens.md)
* [Transactions](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/controllers/transactions.md)
* [Transfers](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/controllers/transfers.md)

## SDK Infrastructure

### Configuration

* [Configuration-Based Initialization](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/configuration-based-initialization.md)
* [HttpClientConfiguration](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/http-client-configuration-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/http-callback.md)
* [HttpContext](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/http-context.md)
* [HttpRequest](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/http-request.md)
* [HttpResponse](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/api-exception.md)
* [ApiHelper](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/api-helper.md)
* [CustomDateTimeConverter](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/7.0.1/doc/unix-date-time-converter.md)

