
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

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `ServiceRefererName` | `string` |  |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BasicAuthCredentials` | [`BasicAuthCredentials`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/$a/https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/basic-authentication.md) | The Credentials Setter for Basic Authentication |

The API client can be initialized as follows:

```csharp
PagarmeApiSDK.Standard.PagarmeApiSDKClient client = new PagarmeApiSDK.Standard.PagarmeApiSDKClient.Builder()
    .BasicAuthCredentials(
        new BasicAuthModel.Builder(
            "BasicAuthUserName",
            "BasicAuthPassword"
        )
        .Build())
    .ServiceRefererName("ServiceRefererName")
    .Build();
```

## Authorization

This API uses the following authentication schemes.

* [`httpBasic (Basic Authentication)`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/$a/https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/basic-authentication.md)

## API Errors

Here is the list of errors that the API might throw.

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Invalid request | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/models/error-exception.md) |
| 401 | Invalid API key | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/models/error-exception.md) |
| 404 | An informed resource was not found | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/models/error-exception.md) |
| 412 | Business validation error | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/models/error-exception.md) |
| 422 | Contract validation error | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/models/error-exception.md) |
| 500 | Internal server error | [`ErrorException`](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/models/error-exception.md) |

## List of APIs

* [Subscriptions](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/subscriptions.md)
* [Orders](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/orders.md)
* [Plans](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/plans.md)
* [Invoices](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/invoices.md)
* [Customers](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/customers.md)
* [Charges](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/charges.md)
* [Recipients](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/recipients.md)
* [Tokens](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/tokens.md)
* [Transactions](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/transactions.md)
* [Transfers](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/transfers.md)
* [Payables](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/payables.md)
* [Balance Operations](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/controllers/balance-operations.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/http-request.md)
* [HttpResponse](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/http-string-response.md)
* [HttpContext](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/pagarme/pagarme-net-standard-sdk/tree/6.8.10/doc/api-exception.md)

