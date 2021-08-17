# IO.Swagger.Api.SignupApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostSignup**](SignupApi.md#postsignup) | **POST** /api/v1/signup | Attempts a new account signup

<a name="postsignup"></a>
# **PostSignup**
> CompanyUser PostSignup (Body body, string xApiSecret, string xRequestedWith, string tokenName)

Attempts a new account signup

Attempts a new account signup and returns a CompanyUser object on success

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostSignupExample
    {
        public void main()
        {
            var apiInstance = new SignupApi();
            var body = new Body(); // Body | Signup credentials
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var tokenName = tokenName_example;  // string | A custom name for the user company token

            try
            {
                // Attempts a new account signup
                CompanyUser result = apiInstance.PostSignup(body, xApiSecret, xRequestedWith, tokenName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SignupApi.PostSignup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| Signup credentials | 
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 
 **tokenName** | **string**| A custom name for the user company token | 

### Return type

[**CompanyUser**](CompanyUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
