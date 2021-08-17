# IO.Swagger.Api.ResetPasswordApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ResetPassword**](ResetPasswordApi.md#resetpassword) | **POST** /api/v1/reset_password | Attempts to reset the users password

<a name="resetpassword"></a>
# **ResetPassword**
> List<string> ResetPassword (Body1 body, string xApiSecret, string xRequestedWith)

Attempts to reset the users password

Resets a users email password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ResetPasswordExample
    {
        public void main()
        {
            var apiInstance = new ResetPasswordApi();
            var body = new Body1(); // Body1 | Password reset email
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Attempts to reset the users password
                List&lt;string&gt; result = apiInstance.ResetPassword(body, xApiSecret, xRequestedWith);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResetPasswordApi.ResetPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body1**](Body1.md)| Password reset email | 
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
