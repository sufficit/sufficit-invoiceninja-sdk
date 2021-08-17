# IO.Swagger.Api.ActvitiesApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetActivities**](ActvitiesApi.md#getactivities) | **GET** /api/v1/actvities | Gets a list of actvities
[**GetActivityHistoricalEntityPdf**](ActvitiesApi.md#getactivityhistoricalentitypdf) | **GET** /api/v1/actvities/download_entity/{activity_id} | Gets a PDF for the given activity

<a name="getactivities"></a>
# **GetActivities**
> Activity GetActivities (string xApiSecret, string xApiToken, string xRequestedWith, string include = null, string index = null, decimal? rows = null)

Gets a list of actvities

Lists all activities

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetActivitiesExample
    {
        public void main()
        {
            var apiInstance = new ActvitiesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var include = include_example;  // string | Includes child relationships in the response, format is comma separated (optional) 
            var index = index_example;  // string | Replaces the default response index from data to a user specific string (optional) 
            var rows = 1.2;  // decimal? | The number of activities to return (optional) 

            try
            {
                // Gets a list of actvities
                Activity result = apiInstance.GetActivities(xApiSecret, xApiToken, xRequestedWith, include, index, rows);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActvitiesApi.GetActivities: " + e.Message );
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
 **rows** | **decimal?**| The number of activities to return | [optional] 

### Return type

[**Activity**](Activity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getactivityhistoricalentitypdf"></a>
# **GetActivityHistoricalEntityPdf**
> void GetActivityHistoricalEntityPdf (string xApiSecret, string xApiToken, string xRequestedWith, string activityId)

Gets a PDF for the given activity

Gets a PDF for the given activity

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetActivityHistoricalEntityPdfExample
    {
        public void main()
        {
            var apiInstance = new ActvitiesApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var activityId = activityId_example;  // string | The Activity Hashed ID

            try
            {
                // Gets a PDF for the given activity
                apiInstance.GetActivityHistoricalEntityPdf(xApiSecret, xApiToken, xRequestedWith, activityId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActvitiesApi.GetActivityHistoricalEntityPdf: " + e.Message );
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
 **activityId** | **string**| The Activity Hashed ID | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
