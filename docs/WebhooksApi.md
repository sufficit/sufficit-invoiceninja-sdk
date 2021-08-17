# IO.Swagger.Api.WebhooksApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkWebhooks**](WebhooksApi.md#bulkwebhooks) | **POST** /api/v1/webhooks/bulk | Performs bulk actions on an array of Webhooks
[**DeleteWebhook**](WebhooksApi.md#deletewebhook) | **DELETE** /api/v1/webhooks/{id} | Deletes a Webhook
[**EditWebhook**](WebhooksApi.md#editwebhook) | **GET** /api/v1/webhooks/{id}/edit | Shows a Webhook for editting
[**GetWebhooks**](WebhooksApi.md#getwebhooks) | **GET** /api/v1/webhooks | Gets a list of Webhooks
[**GetWebhooksCreate**](WebhooksApi.md#getwebhookscreate) | **GET** /api/v1/webhooks/create | Gets a new blank Webhook object
[**ShowWebhook**](WebhooksApi.md#showwebhook) | **GET** /api/v1/webhooks/{id} | Shows a Webhook
[**StoreWebhook**](WebhooksApi.md#storewebhook) | **POST** /api/v1/webhooks | Adds a Webhook
[**UpdateWebhook**](WebhooksApi.md#updatewebhook) | **PUT** /api/v1/webhooks/{id} | Updates a Webhook

<a name="bulkwebhooks"></a>
# **BulkWebhooks**
> Webhook BulkWebhooks (List<int?> body, string xApiSecret, string xApiToken, string xRequestedWith, string index = null)

Performs bulk actions on an array of Webhooks

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkWebhooksExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var body = new List<int?>(); // List<int?> | User credentials
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Performs bulk actions on an array of Webhooks
                Webhook result = apiInstance.BulkWebhooks(body, xApiSecret, xApiToken, xRequestedWith, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.BulkWebhooks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;int?&gt;**](int?.md)| User credentials | 
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **index** | **string**| Replaces the default response index from data to a user specific string | [optional] 

### Return type

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletewebhook"></a>
# **DeleteWebhook**
> void DeleteWebhook (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Deletes a Webhook

Handles the deletion of a Webhook by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteWebhookExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Webhook Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Deletes a Webhook
                apiInstance.DeleteWebhook(xApiSecret, xApiToken, xRequestedWith, id, include);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhook: " + e.Message );
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
 **id** | **string**| The Webhook Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editwebhook"></a>
# **EditWebhook**
> Webhook EditWebhook (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows a Webhook for editting

Displays a Webhook by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditWebhookExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Webhook Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows a Webhook for editting
                Webhook result = apiInstance.EditWebhook(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.EditWebhook: " + e.Message );
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
 **id** | **string**| The Webhook Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhooks"></a>
# **GetWebhooks**
> Webhook GetWebhooks (string xApiSecret, string xApiToken, string xRequestedWith, string include = null, string index = null)

Gets a list of Webhooks

Lists Webhooks, search and filters allow fine grained lists to be generated.      *      *      Query parameters can be added to performed more fine grained filtering of the Webhooks, these are handled by the WebhookFilters class which defines the methods available

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetWebhooksExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Gets a list of Webhooks
                Webhook result = apiInstance.GetWebhooks(xApiSecret, xApiToken, xRequestedWith, include, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhooks: " + e.Message );
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

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwebhookscreate"></a>
# **GetWebhooksCreate**
> Webhook GetWebhooksCreate (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Gets a new blank Webhook object

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
    public class GetWebhooksCreateExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Gets a new blank Webhook object
                Webhook result = apiInstance.GetWebhooksCreate(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.GetWebhooksCreate: " + e.Message );
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

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="showwebhook"></a>
# **ShowWebhook**
> Webhook ShowWebhook (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows a Webhook

Displays a Webhook by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShowWebhookExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Webhook Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows a Webhook
                Webhook result = apiInstance.ShowWebhook(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.ShowWebhook: " + e.Message );
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
 **id** | **string**| The Webhook Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storewebhook"></a>
# **StoreWebhook**
> Webhook StoreWebhook (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Adds a Webhook

Adds an Webhook to a company

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoreWebhookExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Adds a Webhook
                Webhook result = apiInstance.StoreWebhook(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.StoreWebhook: " + e.Message );
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

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatewebhook"></a>
# **UpdateWebhook**
> Webhook UpdateWebhook (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Updates a Webhook

Handles the updating of a Webhook by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateWebhookExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Webhook Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Updates a Webhook
                Webhook result = apiInstance.UpdateWebhook(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.UpdateWebhook: " + e.Message );
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
 **id** | **string**| The Webhook Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Webhook**](Webhook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
