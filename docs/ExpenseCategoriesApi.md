# IO.Swagger.Api.ExpenseCategoriesApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkExpenseCategorys**](ExpenseCategoriesApi.md#bulkexpensecategorys) | **POST** /api/v1/expense_categories/bulk | Performs bulk actions on an array of ExpenseCategorys
[**DeleteExpenseCategory**](ExpenseCategoriesApi.md#deleteexpensecategory) | **DELETE** /api/v1/expense_categories/{id} | Deletes a ExpenseCategory
[**EditExpenseCategory**](ExpenseCategoriesApi.md#editexpensecategory) | **GET** /api/v1/expense_categories/{id}/edit | Shows a Expens Category for editting
[**GetExpenseCategoryCreate**](ExpenseCategoriesApi.md#getexpensecategorycreate) | **GET** /api/v1/expense_categories/create | Gets a new blank Expens Category object
[**GetExpenseCategorys**](ExpenseCategoriesApi.md#getexpensecategorys) | **GET** /api/v1/expense_categories | Gets a list of expense_categories
[**ShowExpenseCategory**](ExpenseCategoriesApi.md#showexpensecategory) | **GET** /api/v1/expense_categories/{id} | Shows a Expens Category
[**UpdateExpenseCategory**](ExpenseCategoriesApi.md#updateexpensecategory) | **PUT** /api/v1/expense_categories/{id} | Updates a tax rate

<a name="bulkexpensecategorys"></a>
# **BulkExpenseCategorys**
> Webhook BulkExpenseCategorys (List<int?> body, string xApiSecret, string xApiToken, string xRequestedWith, string index = null)

Performs bulk actions on an array of ExpenseCategorys

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkExpenseCategorysExample
    {
        public void main()
        {
            var apiInstance = new ExpenseCategoriesApi();
            var body = new List<int?>(); // List<int?> | Expens Categorys
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Performs bulk actions on an array of ExpenseCategorys
                Webhook result = apiInstance.BulkExpenseCategorys(body, xApiSecret, xApiToken, xRequestedWith, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpenseCategoriesApi.BulkExpenseCategorys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;int?&gt;**](int?.md)| Expens Categorys | 
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
<a name="deleteexpensecategory"></a>
# **DeleteExpenseCategory**
> void DeleteExpenseCategory (string xApiSecret, string xApiToken, string xRequestedWith, string id)

Deletes a ExpenseCategory

Handles the deletion of an ExpenseCategory by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteExpenseCategoryExample
    {
        public void main()
        {
            var apiInstance = new ExpenseCategoriesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The ExpenseCategory Hashed ID

            try
            {
                // Deletes a ExpenseCategory
                apiInstance.DeleteExpenseCategory(xApiSecret, xApiToken, xRequestedWith, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpenseCategoriesApi.DeleteExpenseCategory: " + e.Message );
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
 **id** | **string**| The ExpenseCategory Hashed ID | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editexpensecategory"></a>
# **EditExpenseCategory**
> ExpenseCategory EditExpenseCategory (string xApiSecret, string xApiToken, string xRequestedWith, string id)

Shows a Expens Category for editting

Displays a Expens Category by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditExpenseCategoryExample
    {
        public void main()
        {
            var apiInstance = new ExpenseCategoriesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The ExpenseCategory Hashed ID

            try
            {
                // Shows a Expens Category for editting
                ExpenseCategory result = apiInstance.EditExpenseCategory(xApiSecret, xApiToken, xRequestedWith, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpenseCategoriesApi.EditExpenseCategory: " + e.Message );
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
 **id** | **string**| The ExpenseCategory Hashed ID | 

### Return type

[**ExpenseCategory**](ExpenseCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getexpensecategorycreate"></a>
# **GetExpenseCategoryCreate**
> ExpenseCategory GetExpenseCategoryCreate (string xApiSecret, string xApiToken, string xRequestedWith)

Gets a new blank Expens Category object

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
    public class GetExpenseCategoryCreateExample
    {
        public void main()
        {
            var apiInstance = new ExpenseCategoriesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Gets a new blank Expens Category object
                ExpenseCategory result = apiInstance.GetExpenseCategoryCreate(xApiSecret, xApiToken, xRequestedWith);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpenseCategoriesApi.GetExpenseCategoryCreate: " + e.Message );
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

### Return type

[**ExpenseCategory**](ExpenseCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getexpensecategorys"></a>
# **GetExpenseCategorys**
> ExpenseCategory GetExpenseCategorys (string index = null)

Gets a list of expense_categories

Lists tax rates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExpenseCategorysExample
    {
        public void main()
        {
            var apiInstance = new ExpenseCategoriesApi();
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Gets a list of expense_categories
                ExpenseCategory result = apiInstance.GetExpenseCategorys(index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpenseCategoriesApi.GetExpenseCategorys: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **index** | **string**| Replaces the default response index from data to a user specific string | [optional] 

### Return type

[**ExpenseCategory**](ExpenseCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="showexpensecategory"></a>
# **ShowExpenseCategory**
> ExpenseCategory ShowExpenseCategory (string xApiSecret, string xApiToken, string xRequestedWith, string id)

Shows a Expens Category

Displays an ExpenseCategory by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShowExpenseCategoryExample
    {
        public void main()
        {
            var apiInstance = new ExpenseCategoriesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The ExpenseCategory Hashed ID

            try
            {
                // Shows a Expens Category
                ExpenseCategory result = apiInstance.ShowExpenseCategory(xApiSecret, xApiToken, xRequestedWith, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpenseCategoriesApi.ShowExpenseCategory: " + e.Message );
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
 **id** | **string**| The ExpenseCategory Hashed ID | 

### Return type

[**ExpenseCategory**](ExpenseCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateexpensecategory"></a>
# **UpdateExpenseCategory**
> ExpenseCategory UpdateExpenseCategory (string xApiSecret, string xApiToken, string xRequestedWith, string id)

Updates a tax rate

Handles the updating of a tax rate by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateExpenseCategoryExample
    {
        public void main()
        {
            var apiInstance = new ExpenseCategoriesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The ExpenseCategory Hashed ID

            try
            {
                // Updates a tax rate
                ExpenseCategory result = apiInstance.UpdateExpenseCategory(xApiSecret, xApiToken, xRequestedWith, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExpenseCategoriesApi.UpdateExpenseCategory: " + e.Message );
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
 **id** | **string**| The ExpenseCategory Hashed ID | 

### Return type

[**ExpenseCategory**](ExpenseCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
