# IO.Swagger.Api.ClaimLicenseApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetClaimLicense**](ClaimLicenseApi.md#getclaimlicense) | **GET** /api/v1/claim_license | Attempts to claim a white label license

<a name="getclaimlicense"></a>
# **GetClaimLicense**
> void GetClaimLicense (string xApiSecret, string xRequestedWith, string licenseKey, string productId)

Attempts to claim a white label license

Attempts to claim a white label license

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetClaimLicenseExample
    {
        public void main()
        {
            var apiInstance = new ClaimLicenseApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var licenseKey = licenseKey_example;  // string | The license hash
            var productId = productId_example;  // string | The ID of the product purchased.

            try
            {
                // Attempts to claim a white label license
                apiInstance.GetClaimLicense(xApiSecret, xRequestedWith, licenseKey, productId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ClaimLicenseApi.GetClaimLicense: " + e.Message );
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
 **licenseKey** | **string**| The license hash | 
 **productId** | **string**| The ID of the product purchased. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
