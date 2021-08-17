# IO.Swagger.Api.ClientGatewayTokensApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteClientGatewayToken**](ClientGatewayTokensApi.md#deleteclientgatewaytoken) | **DELETE** /api/v1/client_gateway_tokens/{id} | Deletes a client
[**EditClientGatewayToken**](ClientGatewayTokensApi.md#editclientgatewaytoken) | **GET** /api/v1/client_gateway_tokens/{id}/edit | Shows a client for editting
[**GetClientGatewayTokens**](ClientGatewayTokensApi.md#getclientgatewaytokens) | **GET** /api/v1/client_gateway_tokens | Gets a list of client_gateway_tokens
[**GetClientGatewayTokensCreate**](ClientGatewayTokensApi.md#getclientgatewaytokenscreate) | **GET** /api/v1/client_gateway_tokens/create | Gets a new blank client object
[**ShowClientGatewayToken**](ClientGatewayTokensApi.md#showclientgatewaytoken) | **GET** /api/v1/client_gateway_tokens/{id} | Shows a client
[**StoreClientGatewayToken**](ClientGatewayTokensApi.md#storeclientgatewaytoken) | **POST** /api/v1/client_gateway_tokens | Adds a client
[**UpdateClientGatewayToken**](ClientGatewayTokensApi.md#updateclientgatewaytoken) | **PUT** /api/v1/client_gateway_tokens/{id} | Updates a client

<a name="deleteclientgatewaytoken"></a>
# **DeleteClientGatewayToken**
> void DeleteClientGatewayToken (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Deletes a client

Handles the deletion of a client by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteClientGatewayTokenExample
    {
        public void main()
        {
            var apiInstance = new ClientGatewayTokensApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The ClientGatewayToken Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Deletes a client
                apiInstance.DeleteClientGatewayToken(xApiSecret, xApiToken, xRequestedWith, id, include);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientGatewayTokensApi.DeleteClientGatewayToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **id** | **string**| The ClientGatewayToken Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editclientgatewaytoken"></a>
# **EditClientGatewayToken**
> ClientGatewayToken EditClientGatewayToken (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows a client for editting

Displays a client by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditClientGatewayTokenExample
    {
        public void main()
        {
            var apiInstance = new ClientGatewayTokensApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The ClientGatewayToken Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows a client for editting
                ClientGatewayToken result = apiInstance.EditClientGatewayToken(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientGatewayTokensApi.EditClientGatewayToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **id** | **string**| The ClientGatewayToken Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**ClientGatewayToken**](ClientGatewayToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getclientgatewaytokens"></a>
# **GetClientGatewayTokens**
> ClientGatewayToken GetClientGatewayTokens (string xApiSecret, string xApiToken, string xRequestedWith, string include = null, string index = null)

Gets a list of client_gateway_tokens

Lists client_gateway_tokens, search and filters allow fine grained lists to be generated.      Query parameters can be added to performed more fine grained filtering of the client_gateway_tokens, these are handled by the ClientGatewayTokenFilters class which defines the methods available

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientGatewayTokensExample
    {
        public void main()
        {
            var apiInstance = new ClientGatewayTokensApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Gets a list of client_gateway_tokens
                ClientGatewayToken result = apiInstance.GetClientGatewayTokens(xApiSecret, xApiToken, xRequestedWith, include, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientGatewayTokensApi.GetClientGatewayTokens: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 
 **index** | **string**| Replaces the default response index from data to a user specific string | [optional] 

### Return type

[**ClientGatewayToken**](ClientGatewayToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getclientgatewaytokenscreate"></a>
# **GetClientGatewayTokensCreate**
> ClientGatewayToken GetClientGatewayTokensCreate (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Gets a new blank client object

Returns a blank object with default values

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClientGatewayTokensCreateExample
    {
        public void main()
        {
            var apiInstance = new ClientGatewayTokensApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Gets a new blank client object
                ClientGatewayToken result = apiInstance.GetClientGatewayTokensCreate(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientGatewayTokensApi.GetClientGatewayTokensCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**ClientGatewayToken**](ClientGatewayToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="showclientgatewaytoken"></a>
# **ShowClientGatewayToken**
> ClientGatewayToken ShowClientGatewayToken (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows a client

Displays a client by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShowClientGatewayTokenExample
    {
        public void main()
        {
            var apiInstance = new ClientGatewayTokensApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The ClientGatewayToken Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows a client
                ClientGatewayToken result = apiInstance.ShowClientGatewayToken(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientGatewayTokensApi.ShowClientGatewayToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **id** | **string**| The ClientGatewayToken Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**ClientGatewayToken**](ClientGatewayToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storeclientgatewaytoken"></a>
# **StoreClientGatewayToken**
> ClientGatewayToken StoreClientGatewayToken (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Adds a client

Adds an client to a company

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoreClientGatewayTokenExample
    {
        public void main()
        {
            var apiInstance = new ClientGatewayTokensApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Adds a client
                ClientGatewayToken result = apiInstance.StoreClientGatewayToken(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientGatewayTokensApi.StoreClientGatewayToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**ClientGatewayToken**](ClientGatewayToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateclientgatewaytoken"></a>
# **UpdateClientGatewayToken**
> ClientGatewayToken UpdateClientGatewayToken (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Updates a client

Handles the updating of a client by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateClientGatewayTokenExample
    {
        public void main()
        {
            var apiInstance = new ClientGatewayTokensApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The ClientGatewayToken Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Updates a client
                ClientGatewayToken result = apiInstance.UpdateClientGatewayToken(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClientGatewayTokensApi.UpdateClientGatewayToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **id** | **string**| The ClientGatewayToken Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**ClientGatewayToken**](ClientGatewayToken.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
