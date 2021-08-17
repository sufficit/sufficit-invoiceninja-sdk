# IO.Swagger.Api.SubscriptionsApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkSubscriptions**](SubscriptionsApi.md#bulksubscriptions) | **POST** /api/v1/subscriptions/bulk | Performs bulk actions on an array of subscriptions
[**DeleteSubscription**](SubscriptionsApi.md#deletesubscription) | **DELETE** /api/v1/subscriptions/{id} | Deletes a subscriptions
[**EditSubscription**](SubscriptionsApi.md#editsubscription) | **GET** /api/v1/subscriptions/{id}/edit | Shows an subscriptions for editting
[**GetSubscriptions**](SubscriptionsApi.md#getsubscriptions) | **GET** /api/v1/subscriptions | Gets a list of subscriptions
[**GetSubscriptionsCreate**](SubscriptionsApi.md#getsubscriptionscreate) | **GET** /api/v1/subscriptions/create | Gets a new blank subscriptions object
[**ShowSubscription**](SubscriptionsApi.md#showsubscription) | **GET** /api/v1/subscriptions/{id} | Shows an subscriptions
[**StoreSubscription**](SubscriptionsApi.md#storesubscription) | **POST** /api/v1/subscriptions | Adds a subscriptions
[**UpdateSubscription**](SubscriptionsApi.md#updatesubscription) | **PUT** /api/v1/subscriptions/{id} | Updates an subscriptions

<a name="bulksubscriptions"></a>
# **BulkSubscriptions**
> Subscription BulkSubscriptions (List<int?> body, string xApiSecret, string xApiToken, string xRequestedWith, string index = null)

Performs bulk actions on an array of subscriptions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkSubscriptionsExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var body = new List<int?>(); // List<int?> | User credentials
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Performs bulk actions on an array of subscriptions
                Subscription result = apiInstance.BulkSubscriptions(body, xApiSecret, xApiToken, xRequestedWith, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.BulkSubscriptions: " + e.Message );
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

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesubscription"></a>
# **DeleteSubscription**
> void DeleteSubscription (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Deletes a subscriptions

Handles the deletion of an subscriptions by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Subscription Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Deletes a subscriptions
                apiInstance.DeleteSubscription(xApiSecret, xApiToken, xRequestedWith, id, include);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.DeleteSubscription: " + e.Message );
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
 **id** | **string**| The Subscription Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editsubscription"></a>
# **EditSubscription**
> Subscription EditSubscription (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows an subscriptions for editting

Displays an subscriptions by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Subscription Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows an subscriptions for editting
                Subscription result = apiInstance.EditSubscription(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.EditSubscription: " + e.Message );
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
 **id** | **string**| The Subscription Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubscriptions"></a>
# **GetSubscriptions**
> Subscription GetSubscriptions (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Gets a list of subscriptions

Lists subscriptions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetSubscriptionsExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Gets a list of subscriptions
                Subscription result = apiInstance.GetSubscriptions(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetSubscriptions: " + e.Message );
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

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubscriptionscreate"></a>
# **GetSubscriptionsCreate**
> Subscription GetSubscriptionsCreate (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Gets a new blank subscriptions object

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
    public class GetSubscriptionsCreateExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Gets a new blank subscriptions object
                Subscription result = apiInstance.GetSubscriptionsCreate(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetSubscriptionsCreate: " + e.Message );
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

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="showsubscription"></a>
# **ShowSubscription**
> Subscription ShowSubscription (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows an subscriptions

Displays an subscriptions by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShowSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Subscription Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows an subscriptions
                Subscription result = apiInstance.ShowSubscription(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.ShowSubscription: " + e.Message );
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
 **id** | **string**| The Subscription Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storesubscription"></a>
# **StoreSubscription**
> Subscription StoreSubscription (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Adds a subscriptions

Adds an subscriptions to the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoreSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Adds a subscriptions
                Subscription result = apiInstance.StoreSubscription(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.StoreSubscription: " + e.Message );
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

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesubscription"></a>
# **UpdateSubscription**
> Subscription UpdateSubscription (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Updates an subscriptions

Handles the updating of an subscriptions by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateSubscriptionExample
    {
        public void main()
        {
            var apiInstance = new SubscriptionsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Subscription Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Updates an subscriptions
                Subscription result = apiInstance.UpdateSubscription(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.UpdateSubscription: " + e.Message );
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
 **id** | **string**| The Subscription Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
