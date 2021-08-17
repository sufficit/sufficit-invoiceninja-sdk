# IO.Swagger.Api.CompanyUserApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UpdateCompanyUser**](CompanyUserApi.md#updatecompanyuser) | **POST** /api/v1/company_users | Update a company user record

<a name="updatecompanyuser"></a>
# **UpdateCompanyUser**
> CompanyUser UpdateCompanyUser (string xApiSecret, string xRequestedWith)

Update a company user record

Attempts to update a company user record. A company user can modify only their settings fields. Full access for Admin users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCompanyUserExample
    {
        public void main()
        {
            var apiInstance = new CompanyUserApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header

            try
            {
                // Update a company user record
                CompanyUser result = apiInstance.UpdateCompanyUser(xApiSecret, xRequestedWith);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompanyUserApi.UpdateCompanyUser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xApiSecret** | **string**| The API secret as defined by the .env variable API_SECRET | 
 **xRequestedWith** | **string**| Used to send the XMLHttpRequest header | 

### Return type

[**CompanyUser**](CompanyUser.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
