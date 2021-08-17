# IO.Swagger.Api.TaxRatesApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkTaxRates**](TaxRatesApi.md#bulktaxrates) | **POST** /api/v1/tax_rates/bulk | Performs bulk actions on an array of TaxRates
[**DeleteTaxRate**](TaxRatesApi.md#deletetaxrate) | **DELETE** /api/v1/tax_rates/{id} | Deletes a TaxRate
[**EditTaxRate**](TaxRatesApi.md#edittaxrate) | **GET** /api/v1/tax_rates/{id}/edit | Shows a Tax Rate for editting
[**GetTaxRateCreate**](TaxRatesApi.md#gettaxratecreate) | **GET** /api/v1/tax_rates/create | Gets a new blank Tax Rate object
[**GetTaxRates**](TaxRatesApi.md#gettaxrates) | **GET** /api/v1/tax_rates | Gets a list of tax_rates
[**ShowTaxRate**](TaxRatesApi.md#showtaxrate) | **GET** /api/v1/tax_rates/{id} | Shows a Tax Rate
[**UpdateTaxRate**](TaxRatesApi.md#updatetaxrate) | **PUT** /api/v1/tax_rates/{id} | Updates a tax rate

<a name="bulktaxrates"></a>
# **BulkTaxRates**
> Webhook BulkTaxRates (List<int?> body, string xApiSecret, string xApiToken, string xRequestedWith, string index = null)

Performs bulk actions on an array of TaxRates

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BulkTaxRatesExample
    {
        public void main()
        {
            var apiInstance = new TaxRatesApi();
            var body = new List<int?>(); // List<int?> | Tax Rates
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Performs bulk actions on an array of TaxRates
                Webhook result = apiInstance.BulkTaxRates(body, xApiSecret, xApiToken, xRequestedWith, index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxRatesApi.BulkTaxRates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;int?&gt;**](int?.md)| Tax Rates | 
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
<a name="deletetaxrate"></a>
# **DeleteTaxRate**
> void DeleteTaxRate (string xApiSecret, string xApiToken, string xRequestedWith, string id)

Deletes a TaxRate

Handles the deletion of an TaxRate by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteTaxRateExample
    {
        public void main()
        {
            var apiInstance = new TaxRatesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The TaxRate Hashed ID

            try
            {
                // Deletes a TaxRate
                apiInstance.DeleteTaxRate(xApiSecret, xApiToken, xRequestedWith, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxRatesApi.DeleteTaxRate: " + e.Message );
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
 **id** | **string**| The TaxRate Hashed ID | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="edittaxrate"></a>
# **EditTaxRate**
> TaxRate EditTaxRate (string xApiSecret, string xApiToken, string xRequestedWith, string id)

Shows a Tax Rate for editting

Displays a Tax Rate by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EditTaxRateExample
    {
        public void main()
        {
            var apiInstance = new TaxRatesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The TaxRate Hashed ID

            try
            {
                // Shows a Tax Rate for editting
                TaxRate result = apiInstance.EditTaxRate(xApiSecret, xApiToken, xRequestedWith, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxRatesApi.EditTaxRate: " + e.Message );
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
 **id** | **string**| The TaxRate Hashed ID | 

### Return type

[**TaxRate**](TaxRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettaxratecreate"></a>
# **GetTaxRateCreate**
> TaxRate GetTaxRateCreate (string xApiSecret, string xApiToken, string xRequestedWith)

Gets a new blank Tax Rate object

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
    public class GetTaxRateCreateExample
    {
        public void main()
        {
            var apiInstance = new TaxRatesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Gets a new blank Tax Rate object
                TaxRate result = apiInstance.GetTaxRateCreate(xApiSecret, xApiToken, xRequestedWith);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxRatesApi.GetTaxRateCreate: " + e.Message );
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

[**TaxRate**](TaxRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettaxrates"></a>
# **GetTaxRates**
> TaxRate GetTaxRates (string index = null)

Gets a list of tax_rates

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
    public class GetTaxRatesExample
    {
        public void main()
        {
            var apiInstance = new TaxRatesApi();
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 

            try
            {
                // Gets a list of tax_rates
                TaxRate result = apiInstance.GetTaxRates(index);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxRatesApi.GetTaxRates: " + e.Message );
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

[**TaxRate**](TaxRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="showtaxrate"></a>
# **ShowTaxRate**
> TaxRate ShowTaxRate (string xApiSecret, string xApiToken, string xRequestedWith, string id)

Shows a Tax Rate

Displays an TaxRate by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ShowTaxRateExample
    {
        public void main()
        {
            var apiInstance = new TaxRatesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The TaxRate Hashed ID

            try
            {
                // Shows a Tax Rate
                TaxRate result = apiInstance.ShowTaxRate(xApiSecret, xApiToken, xRequestedWith, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxRatesApi.ShowTaxRate: " + e.Message );
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
 **id** | **string**| The TaxRate Hashed ID | 

### Return type

[**TaxRate**](TaxRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatetaxrate"></a>
# **UpdateTaxRate**
> TaxRate UpdateTaxRate (string xApiSecret, string xApiToken, string xRequestedWith, string id)

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
    public class UpdateTaxRateExample
    {
        public void main()
        {
            var apiInstance = new TaxRatesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var id = id_example;  // string | The TaxRate Hashed ID

            try
            {
                // Updates a tax rate
                TaxRate result = apiInstance.UpdateTaxRate(xApiSecret, xApiToken, xRequestedWith, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxRatesApi.UpdateTaxRate: " + e.Message );
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
 **id** | **string**| The TaxRate Hashed ID | 

### Return type

[**TaxRate**](TaxRate.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
