# IO.Swagger.Api.PaymentsApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionPayment**](PaymentsApi.md#actionpayment) | **GET** /api/v1/payments/{id}/{action} | Performs a custom action on an Payment
[**BulkPayments**](PaymentsApi.md#bulkpayments) | **POST** /api/v1/payments/bulk | Performs bulk actions on an array of payments
[**DeletePayment**](PaymentsApi.md#deletepayment) | **DELETE** /api/v1/payments/{id} | Deletes a Payment
[**EditPayment**](PaymentsApi.md#editpayment) | **GET** /api/v1/payments/{id}/edit | Shows an Payment for editting
[**GetPayments**](PaymentsApi.md#getpayments) | **GET** /api/v1/payments | Gets a list of payments
[**GetPaymentsCreate**](PaymentsApi.md#getpaymentscreate) | **GET** /api/v1/payments/create | Gets a new blank Payment object
[**ShowPayment**](PaymentsApi.md#showpayment) | **GET** /api/v1/payments/{id} | Shows an Payment
[**StorePayment**](PaymentsApi.md#storepayment) | **POST** /api/v1/payments | Adds a Payment
[**StoreRefund**](PaymentsApi.md#storerefund) | **POST** /api/v1/payments/refund | Adds a Refund
[**UpdatePayment**](PaymentsApi.md#updatepayment) | **PUT** /api/v1/payments/{id} | Updates an Payment
[**UploadPayment**](PaymentsApi.md#uploadpayment) | **PUT** /api/v1/payments/{id}/upload | Uploads a document to a payment

<a name="actionpayment"></a>
# **ActionPayment**
> Payment ActionPayment (string xApiSecret, string xApiToken, string xRequestedWith, string id, string action, string include = null)

Performs a custom action on an Payment

Performs a custom action on an Payment.      The current range of actions are as follows     - clone_to_Payment     - clone_to_quote     - history     - delivery_note     - mark_paid     - download     - archive     - delete     - email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActionPaymentExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Payment Hashed ID
            var action = action_example;  // string | The action string to be performed
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Performs a custom action on an Payment
                Payment result = apiInstance.ActionPayment(xApiSecret, xApiToken, xRequestedWith, id, action, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.ActionPayment: " + e.Message );
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
 **id** | **string**| The Payment Hashed ID | 
 **action** | **string**| The action string to be performed | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="bulkpayments"></a>
# **BulkPayments**
> Payment BulkPayments (List<int?> body, string xApiSecret, string xApiToken, string xRequestedWith, string index = null)

Performs bulk actions on an array of payments

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkPaymentsExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var body = new List<int?>(); // List<int?> | User credentials
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Performs bulk actions on an array of payments
                Payment result = apiInstance.BulkPayments(body, xApiSecret, xApiToken, xRequestedWith, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.BulkPayments: " + e.Message );
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

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepayment"></a>
# **DeletePayment**
> void DeletePayment (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Deletes a Payment

Handles the deletion of an Payment by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeletePaymentExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Payment Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Deletes a Payment
                apiInstance.DeletePayment(xApiSecret, xApiToken, xRequestedWith, id, include);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.DeletePayment: " + e.Message );
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
 **id** | **string**| The Payment Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="editpayment"></a>
# **EditPayment**
> Payment EditPayment (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows an Payment for editting

Displays an Payment by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditPaymentExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Payment Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows an Payment for editting
                Payment result = apiInstance.EditPayment(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.EditPayment: " + e.Message );
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
 **id** | **string**| The Payment Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpayments"></a>
# **GetPayments**
> Payment GetPayments (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Gets a list of payments

Lists payments, search and filters allow fine grained lists to be generated.          Query parameters can be added to performed more fine grained filtering of the payments, these are handled by the PaymentFilters class which defines the methods available

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetPaymentsExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Gets a list of payments
                Payment result = apiInstance.GetPayments(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPayments: " + e.Message );
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

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpaymentscreate"></a>
# **GetPaymentsCreate**
> Payment GetPaymentsCreate (string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Gets a new blank Payment object

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
    public class GetPaymentsCreateExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Gets a new blank Payment object
                Payment result = apiInstance.GetPaymentsCreate(xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPaymentsCreate: " + e.Message );
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

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="showpayment"></a>
# **ShowPayment**
> Payment ShowPayment (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Shows an Payment

Displays an Payment by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShowPaymentExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Payment Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Shows an Payment
                Payment result = apiInstance.ShowPayment(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.ShowPayment: " + e.Message );
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
 **id** | **string**| The Payment Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storepayment"></a>
# **StorePayment**
> Payment StorePayment (Payment body, string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Adds a Payment

Adds an Payment to the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StorePaymentExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var body = new Payment(); // Payment | The payment request
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Adds a Payment
                Payment result = apiInstance.StorePayment(body, xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.StorePayment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Payment**](Payment.md)| The payment request | 
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="storerefund"></a>
# **StoreRefund**
> Payment StoreRefund (Payment body, string xApiSecret, string xApiToken, string xRequestedWith, string include = null)

Adds a Refund

Adds an Refund to the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class StoreRefundExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var body = new Payment(); // Payment | The refund request
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Adds a Refund
                Payment result = apiInstance.StoreRefund(body, xApiSecret, xApiToken, xRequestedWith, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.StoreRefund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Payment**](Payment.md)| The refund request | 
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepayment"></a>
# **UpdatePayment**
> Payment UpdatePayment (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Updates an Payment

Handles the updating of an Payment by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePaymentExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Payment Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Updates an Payment
                Payment result = apiInstance.UpdatePayment(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.UpdatePayment: " + e.Message );
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
 **id** | **string**| The Payment Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="uploadpayment"></a>
# **UploadPayment**
> Payment UploadPayment (string xApiSecret, string xApiToken, string xRequestedWith, string id, string include = null)

Uploads a document to a payment

Handles the uploading of a document to a payment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadPaymentExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The Payment Hashed ID
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 

            try
            {
                // Uploads a document to a payment
                Payment result = apiInstance.UploadPayment(xApiSecret, xApiToken, xRequestedWith, id, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.UploadPayment: " + e.Message );
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
 **id** | **string**| The Payment Hashed ID | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
