# IO.Swagger.Api.RecurringQuotesApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionRecurringQuote**](RecurringQuotesApi.md#actionrecurringquote) | **GET** /api/v1/recurring_quotes/{id}/{action} | Performs a custom action on an RecurringQuote
[**BulkRecurringQuotes**](RecurringQuotesApi.md#bulkrecurringquotes) | **POST** /api/v1/recurring_quotes/bulk | Performs bulk actions on an array of recurring_quotes
[**DeleteRecurringQuote**](RecurringQuotesApi.md#deleterecurringquote) | **DELETE** /api/v1/recurring_quotes/{id} | Deletes a RecurringQuote
[**EditRecurringQuote**](RecurringQuotesApi.md#editrecurringquote) | **GET** /api/v1/recurring_quotes/{id}/edit | Shows an RecurringQuote for editting
[**GetRecurringQuotes**](RecurringQuotesApi.md#getrecurringquotes) | **GET** /api/v1/recurring_quotes | Gets a list of recurring_quotes
[**GetRecurringQuotesCreate**](RecurringQuotesApi.md#getrecurringquotescreate) | **GET** /api/v1/recurring_quotes/create | Gets a new blank RecurringQuote object
[**ShowRecurringQuote**](RecurringQuotesApi.md#showrecurringquote) | **GET** /api/v1/recurring_quotes/{id} | Shows an RecurringQuote
[**StoreRecurringQuote**](RecurringQuotesApi.md#storerecurringquote) | **POST** /api/v1/recurring_quotes | Adds a RecurringQuote
[**UpdateRecurringQuote**](RecurringQuotesApi.md#updaterecurringquote) | **PUT** /api/v1/recurring_quotes/{id} | Updates an RecurringQuote

<a name="actionrecurringquote"></a>
# **ActionRecurringQuote**
> RecurringQuote ActionRecurringQuote (string xApiSecret, string xApiToken, string xRequestedWith, string id, string action, string include = null)

Performs a custom action on an RecurringQuote

Performs a custom action on an RecurringQuote.      The current range of actions are as follows     - clone_to_RecurringQuote     - clone_to_quote     - history     - delivery_note     - mark_paid     - download     - archive     - delete     - email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionRecurringQuoteExample
    {
        public void main()
        {
            var apiInstance = new RecurringQuotesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The RecurringQuote Hashed ID
            var action = action_example;  // string | The action string to be performed
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Performs a custom action on an RecurringQuote
                RecurringQuote result = apiInstance.ActionRecurringQuote(xApiSecret, xApiToken, xRequestedWith, id, action, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringQuotesApi.ActionRecurringQuote: " + e.Message );
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
 **id** | **string**| The RecurringQuote Hashed ID | 
 **action** | **string**| The action string to be performed | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**RecurringQuote**](RecurringQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="bulkrecurringquotes"></a>
# **BulkRecurringQuotes**
> RecurringQuote BulkRecurringQuotes (List<int?> body, string xApiSecret, string xApiToken, string xRequestedWith, string index = null)

Performs bulk actions on an array of recurring_quotes

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkRecurringQuotesExample
    {
        public void main()
        {
            var apiInstance = new RecurringQuotesApi();
            var body = new List<int?>(); // List<int?> | Hashed ids
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Performs bulk actions on an array of recurring_quotes
                RecurringQuote result = apiInstance.BulkRecurringQuotes(body, xApiSecret, xApiToken, xRequestedWith, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringQuotesApi.BulkRecurringQuotes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;int?&gt;**](int?.md)| Hashed ids | 
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **index** | **string**| Replaces the default response index from data to a user specific string | [optional] 

### Return type

[**RecurringQuote**](RecurringQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleterecurringquote"></a>
# **DeleteRecurringQuote**
> void DeleteRecurringQuote (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Deletes a RecurringQuote

Handles the deletion of an RecurringQuote by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRecurringQuoteExample
    {
        public void main()
        {
            var apiInstance = new RecurringQuotesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The RecurringQuote Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Deletes a RecurringQuote
                apiInstance.DeleteRecurringQuote(xApiSecret, xApiToken, xRequestedWith, id, include);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringQuotesApi.DeleteRecurringQuote: " + e.Message );
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
 **id** | **string**| The RecurringQuote Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editrecurringquote"></a>
# **EditRecurringQuote**
> RecurringQuote EditRecurringQuote (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows an RecurringQuote for editting

Displays an RecurringQuote by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditRecurringQuoteExample
    {
        public void main()
        {
            var apiInstance = new RecurringQuotesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The RecurringQuote Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows an RecurringQuote for editting
                RecurringQuote result = apiInstance.EditRecurringQuote(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringQuotesApi.EditRecurringQuote: " + e.Message );
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
 **id** | **string**| The RecurringQuote Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**RecurringQuote**](RecurringQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrecurringquotes"></a>
# **GetRecurringQuotes**
> RecurringQuote GetRecurringQuotes (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Gets a list of recurring_quotes

Lists recurring_quotes, search and filters allow fine grained lists to be generated.          Query parameters can be added to performed more fine grained filtering of the recurring_quotes, these are handled by the RecurringQuoteFilters class which defines the methods available

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRecurringQuotesExample
    {
        public void main()
        {
            var apiInstance = new RecurringQuotesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Gets a list of recurring_quotes
                RecurringQuote result = apiInstance.GetRecurringQuotes(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringQuotesApi.GetRecurringQuotes: " + e.Message );
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

[**RecurringQuote**](RecurringQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrecurringquotescreate"></a>
# **GetRecurringQuotesCreate**
> RecurringQuote GetRecurringQuotesCreate (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Gets a new blank RecurringQuote object

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
    public class GetRecurringQuotesCreateExample
    {
        public void main()
        {
            var apiInstance = new RecurringQuotesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Gets a new blank RecurringQuote object
                RecurringQuote result = apiInstance.GetRecurringQuotesCreate(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringQuotesApi.GetRecurringQuotesCreate: " + e.Message );
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

[**RecurringQuote**](RecurringQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="showrecurringquote"></a>
# **ShowRecurringQuote**
> RecurringQuote ShowRecurringQuote (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows an RecurringQuote

Displays an RecurringQuote by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShowRecurringQuoteExample
    {
        public void main()
        {
            var apiInstance = new RecurringQuotesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The RecurringQuote Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows an RecurringQuote
                RecurringQuote result = apiInstance.ShowRecurringQuote(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringQuotesApi.ShowRecurringQuote: " + e.Message );
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
 **id** | **string**| The RecurringQuote Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**RecurringQuote**](RecurringQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storerecurringquote"></a>
# **StoreRecurringQuote**
> RecurringQuote StoreRecurringQuote (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Adds a RecurringQuote

Adds an RecurringQuote to the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoreRecurringQuoteExample
    {
        public void main()
        {
            var apiInstance = new RecurringQuotesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Adds a RecurringQuote
                RecurringQuote result = apiInstance.StoreRecurringQuote(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringQuotesApi.StoreRecurringQuote: " + e.Message );
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

[**RecurringQuote**](RecurringQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updaterecurringquote"></a>
# **UpdateRecurringQuote**
> RecurringQuote UpdateRecurringQuote (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Updates an RecurringQuote

Handles the updating of an RecurringQuote by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRecurringQuoteExample
    {
        public void main()
        {
            var apiInstance = new RecurringQuotesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The RecurringQuote Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Updates an RecurringQuote
                RecurringQuote result = apiInstance.UpdateRecurringQuote(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringQuotesApi.UpdateRecurringQuote: " + e.Message );
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
 **id** | **string**| The RecurringQuote Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**RecurringQuote**](RecurringQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
