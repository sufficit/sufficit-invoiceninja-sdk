# IO.Swagger.Api.ExpensesApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkExpenses**](ExpensesApi.md#bulkexpenses) | **POST** /api/v1/expenses/bulk | Performs bulk actions on an array of expenses
[**DeleteExpense**](ExpensesApi.md#deleteexpense) | **DELETE** /api/v1/expenses/{id} | Deletes a client
[**EditExpense**](ExpensesApi.md#editexpense) | **GET** /api/v1/expenses/{id}/edit | Shows a client for editting
[**GetExpenses**](ExpensesApi.md#getexpenses) | **GET** /api/v1/expenses | Gets a list of expenses
[**GetExpensesCreate**](ExpensesApi.md#getexpensescreate) | **GET** /api/v1/expenses/create | Gets a new blank client object
[**ShowExpense**](ExpensesApi.md#showexpense) | **GET** /api/v1/expenses/{id} | Shows a client
[**StoreExpense**](ExpensesApi.md#storeexpense) | **POST** /api/v1/expenses | Adds a client
[**UpdateExpense**](ExpensesApi.md#updateexpense) | **PUT** /api/v1/expenses/{id} | Updates a client

<a name="bulkexpenses"></a>
# **BulkExpenses**
> Expense BulkExpenses (List<int?> body, string xApiSecret, string xApiToken, string xRequestedWith, string index = null)

Performs bulk actions on an array of expenses

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkExpensesExample
    {
        public void main()
        {
            var apiInstance = new ExpensesApi();
            var body = new List<int?>(); // List<int?> | User credentials
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Performs bulk actions on an array of expenses
                Expense result = apiInstance.BulkExpenses(body, xApiSecret, xApiToken, xRequestedWith, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpensesApi.BulkExpenses: " + e.Message );
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

[**Expense**](Expense.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteexpense"></a>
# **DeleteExpense**
> void DeleteExpense (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

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
    public class DeleteExpenseExample
    {
        public void main()
        {
            var apiInstance = new ExpensesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Expense Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Deletes a client
                apiInstance.DeleteExpense(xApiSecret, xApiToken, xRequestedWith, id, include);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpensesApi.DeleteExpense: " + e.Message );
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
 **id** | **string**| The Expense Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editexpense"></a>
# **EditExpense**
> Expense EditExpense (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

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
    public class EditExpenseExample
    {
        public void main()
        {
            var apiInstance = new ExpensesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Expense Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows a client for editting
                Expense result = apiInstance.EditExpense(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpensesApi.EditExpense: " + e.Message );
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
 **id** | **string**| The Expense Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Expense**](Expense.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getexpenses"></a>
# **GetExpenses**
> Expense GetExpenses (string xApiSecret, string xApiToken, string xRequestedWith, string include = null, string index = null)

Gets a list of expenses

Lists expenses, search and filters allow fine grained lists to be generated.      Query parameters can be added to performed more fine grained filtering of the expenses, these are handled by the ExpenseFilters class which defines the methods available

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExpensesExample
    {
        public void main()
        {
            var apiInstance = new ExpensesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Gets a list of expenses
                Expense result = apiInstance.GetExpenses(xApiSecret, xApiToken, xRequestedWith, include, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpensesApi.GetExpenses: " + e.Message );
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

[**Expense**](Expense.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getexpensescreate"></a>
# **GetExpensesCreate**
> Expense GetExpensesCreate (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

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
    public class GetExpensesCreateExample
    {
        public void main()
        {
            var apiInstance = new ExpensesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Gets a new blank client object
                Expense result = apiInstance.GetExpensesCreate(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpensesApi.GetExpensesCreate: " + e.Message );
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

[**Expense**](Expense.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="showexpense"></a>
# **ShowExpense**
> Expense ShowExpense (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

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
    public class ShowExpenseExample
    {
        public void main()
        {
            var apiInstance = new ExpensesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Expense Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows a client
                Expense result = apiInstance.ShowExpense(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpensesApi.ShowExpense: " + e.Message );
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
 **id** | **string**| The Expense Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Expense**](Expense.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storeexpense"></a>
# **StoreExpense**
> Expense StoreExpense (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

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
    public class StoreExpenseExample
    {
        public void main()
        {
            var apiInstance = new ExpensesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Adds a client
                Expense result = apiInstance.StoreExpense(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpensesApi.StoreExpense: " + e.Message );
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

[**Expense**](Expense.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateexpense"></a>
# **UpdateExpense**
> Expense UpdateExpense (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

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
    public class UpdateExpenseExample
    {
        public void main()
        {
            var apiInstance = new ExpensesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Expense Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Updates a client
                Expense result = apiInstance.UpdateExpense(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpensesApi.UpdateExpense: " + e.Message );
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
 **id** | **string**| The Expense Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Expense**](Expense.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
