# IO.Swagger.Api.LoginApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostLogin**](LoginApi.md#postlogin) | **POST** /api/v1/login | Attempts authentication

<a name="postlogin"></a>
# **PostLogin**
> CompanyUser PostLogin (Body2 body, string xApiSecret, string xApiToken, string xRequestedWith, string include = null, string includeStatic = null, string clearCache = null)

Attempts authentication

Returns a CompanyUser object on success

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostLoginExample
    {
        public void main()
        {
            var apiInstance = new LoginApi();
            var body = new Body2(); // Body2 | User credentials
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 
            var includeStatic = includeStatic_example;  // string | Returns static variables (optional) 
            var clearCache = clearCache_example;  // string | Clears the static cache (optional) 

            try
            {
                // Attempts authentication
                CompanyUser result = apiInstance.PostLogin(body, xApiSecret, xApiToken, xRequestedWith, include, includeStatic, clearCache);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LoginApi.PostLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body2**](Body2.md)| User credentials | 
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xApiToken** | **string**| The API token to be used for authentication | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **include** | **string**| Includes child relationships in the response, format is comma separated | [optional] 
 **includeStatic** | **string**| Returns static variables | [optional] 
 **clearCache** | **string**| Clears the static cache | [optional] 

### Return type

[**CompanyUser**](CompanyUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
