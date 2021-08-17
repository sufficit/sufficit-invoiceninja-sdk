# IO.Swagger.Api.RecurringInvoicesApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionRecurringInvoice**](RecurringInvoicesApi.md#actionrecurringinvoice) | **GET** /api/v1/recurring_invoices/{id}/{action} | Performs a custom action on an RecurringInvoice
[**BulkRecurringInvoices**](RecurringInvoicesApi.md#bulkrecurringinvoices) | **POST** /api/v1/recurring_invoices/bulk | Performs bulk actions on an array of recurring_invoices
[**DeleteRecurringInvoice**](RecurringInvoicesApi.md#deleterecurringinvoice) | **DELETE** /api/v1/recurring_invoices/{id} | Deletes a RecurringInvoice
[**EditRecurringInvoice**](RecurringInvoicesApi.md#editrecurringinvoice) | **GET** /api/v1/recurring_invoices/{id}/edit | Shows an RecurringInvoice for editting
[**GetRecurringInvoices**](RecurringInvoicesApi.md#getrecurringinvoices) | **GET** /api/v1/recurring_invoices | Gets a list of recurring_invoices
[**GetRecurringInvoicesCreate**](RecurringInvoicesApi.md#getrecurringinvoicescreate) | **GET** /api/v1/recurring_invoices/create | Gets a new blank RecurringInvoice object
[**ShowRecurringInvoice**](RecurringInvoicesApi.md#showrecurringinvoice) | **GET** /api/v1/recurring_invoices/{id} | Shows an RecurringInvoice
[**StoreRecurringInvoice**](RecurringInvoicesApi.md#storerecurringinvoice) | **POST** /api/v1/recurring_invoices | Adds a RecurringInvoice
[**UpdateRecurringInvoice**](RecurringInvoicesApi.md#updaterecurringinvoice) | **PUT** /api/v1/recurring_invoices/{id} | Updates an RecurringInvoice
[**UploadRecurringInvoice**](RecurringInvoicesApi.md#uploadrecurringinvoice) | **PUT** /api/v1/recurring_invoices/{id}/upload | Uploads a document to a recurring_invoice

<a name="actionrecurringinvoice"></a>
# **ActionRecurringInvoice**
> RecurringInvoice ActionRecurringInvoice (string xApiSecret, string xApiToken, string xRequestedWith, string id, string action, string include = null)

Performs a custom action on an RecurringInvoice

Performs a custom action on an RecurringInvoice.      The current range of actions are as follows     - clone_to_RecurringInvoice     - clone_to_quote     - history     - delivery_note     - mark_paid     - download     - archive     - delete     - email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionRecurringInvoiceExample
    {
        public void main()
        {
            var apiInstance = new RecurringInvoicesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The RecurringInvoice Hashed ID
            var action = action_example;  // string | The action string to be performed
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Performs a custom action on an RecurringInvoice
                RecurringInvoice result = apiInstance.ActionRecurringInvoice(xApiSecret, xApiToken, xRequestedWith, id, action, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringInvoicesApi.ActionRecurringInvoice: " + e.Message );
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
 **id** | **string**| The RecurringInvoice Hashed ID | 
 **action** | **string**| The action string to be performed | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="bulkrecurringinvoices"></a>
# **BulkRecurringInvoices**
> RecurringInvoice BulkRecurringInvoices (List<int?> body, string xApiSecret, string xApiToken, string xRequestedWith, string index = null)

Performs bulk actions on an array of recurring_invoices

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkRecurringInvoicesExample
    {
        public void main()
        {
            var apiInstance = new RecurringInvoicesApi();
            var body = new List<int?>(); // List<int?> | Hashed IDs
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Performs bulk actions on an array of recurring_invoices
                RecurringInvoice result = apiInstance.BulkRecurringInvoices(body, xApiSecret, xApiToken, xRequestedWith, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringInvoicesApi.BulkRecurringInvoices: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;int?&gt;**](int?.md)| Hashed IDs | 
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **index** | **string**| Replaces the default response index from data to a user specific string | [optional] 

### Return type

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleterecurringinvoice"></a>
# **DeleteRecurringInvoice**
> void DeleteRecurringInvoice (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Deletes a RecurringInvoice

Handles the deletion of an RecurringInvoice by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRecurringInvoiceExample
    {
        public void main()
        {
            var apiInstance = new RecurringInvoicesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The RecurringInvoice Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Deletes a RecurringInvoice
                apiInstance.DeleteRecurringInvoice(xApiSecret, xApiToken, xRequestedWith, id, include);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringInvoicesApi.DeleteRecurringInvoice: " + e.Message );
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
 **id** | **string**| The RecurringInvoice Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editrecurringinvoice"></a>
# **EditRecurringInvoice**
> RecurringInvoice EditRecurringInvoice (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows an RecurringInvoice for editting

Displays an RecurringInvoice by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditRecurringInvoiceExample
    {
        public void main()
        {
            var apiInstance = new RecurringInvoicesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The RecurringInvoice Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows an RecurringInvoice for editting
                RecurringInvoice result = apiInstance.EditRecurringInvoice(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringInvoicesApi.EditRecurringInvoice: " + e.Message );
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
 **id** | **string**| The RecurringInvoice Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrecurringinvoices"></a>
# **GetRecurringInvoices**
> RecurringInvoice GetRecurringInvoices (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Gets a list of recurring_invoices

Lists recurring_invoices, search and filters allow fine grained lists to be generated.          Query parameters can be added to performed more fine grained filtering of the recurring_invoices, these are handled by the RecurringInvoiceFilters class which defines the methods available

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRecurringInvoicesExample
    {
        public void main()
        {
            var apiInstance = new RecurringInvoicesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Gets a list of recurring_invoices
                RecurringInvoice result = apiInstance.GetRecurringInvoices(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringInvoicesApi.GetRecurringInvoices: " + e.Message );
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

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getrecurringinvoicescreate"></a>
# **GetRecurringInvoicesCreate**
> RecurringInvoice GetRecurringInvoicesCreate (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Gets a new blank RecurringInvoice object

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
    public class GetRecurringInvoicesCreateExample
    {
        public void main()
        {
            var apiInstance = new RecurringInvoicesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Gets a new blank RecurringInvoice object
                RecurringInvoice result = apiInstance.GetRecurringInvoicesCreate(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringInvoicesApi.GetRecurringInvoicesCreate: " + e.Message );
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

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="showrecurringinvoice"></a>
# **ShowRecurringInvoice**
> RecurringInvoice ShowRecurringInvoice (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows an RecurringInvoice

Displays an RecurringInvoice by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShowRecurringInvoiceExample
    {
        public void main()
        {
            var apiInstance = new RecurringInvoicesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The RecurringInvoice Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows an RecurringInvoice
                RecurringInvoice result = apiInstance.ShowRecurringInvoice(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringInvoicesApi.ShowRecurringInvoice: " + e.Message );
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
 **id** | **string**| The RecurringInvoice Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storerecurringinvoice"></a>
# **StoreRecurringInvoice**
> RecurringInvoice StoreRecurringInvoice (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Adds a RecurringInvoice

Adds an RecurringInvoice to the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoreRecurringInvoiceExample
    {
        public void main()
        {
            var apiInstance = new RecurringInvoicesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Adds a RecurringInvoice
                RecurringInvoice result = apiInstance.StoreRecurringInvoice(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringInvoicesApi.StoreRecurringInvoice: " + e.Message );
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

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updaterecurringinvoice"></a>
# **UpdateRecurringInvoice**
> RecurringInvoice UpdateRecurringInvoice (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Updates an RecurringInvoice

Handles the updating of an RecurringInvoice by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRecurringInvoiceExample
    {
        public void main()
        {
            var apiInstance = new RecurringInvoicesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The RecurringInvoice Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Updates an RecurringInvoice
                RecurringInvoice result = apiInstance.UpdateRecurringInvoice(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringInvoicesApi.UpdateRecurringInvoice: " + e.Message );
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
 **id** | **string**| The RecurringInvoice Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadrecurringinvoice"></a>
# **UploadRecurringInvoice**
> RecurringInvoice UploadRecurringInvoice (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Uploads a document to a recurring_invoice

Handles the uploading of a document to a recurring_invoice

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadRecurringInvoiceExample
    {
        public void main()
        {
            var apiInstance = new RecurringInvoicesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The RecurringInvoice Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Uploads a document to a recurring_invoice
                RecurringInvoice result = apiInstance.UploadRecurringInvoice(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RecurringInvoicesApi.UploadRecurringInvoice: " + e.Message );
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
 **id** | **string**| The RecurringInvoice Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
