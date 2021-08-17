# IO.Swagger.Api.MigrationApi

All URIs are relative to *https://ninja.test*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostPurgeCompany**](MigrationApi.md#postpurgecompany) | **POST** /api/v1/migration/purge/{company} | Attempts to purge a company record and all its child records
[**PostPurgeCompanySaveSettings**](MigrationApi.md#postpurgecompanysavesettings) | **POST** /api/v1/migration/purge_save_settings/{company} | Attempts to purge a companies child records but save the company record and its settings
[**PostStartMigration**](MigrationApi.md#poststartmigration) | **POST** /api/v1/migration/start | Starts the migration from previous version of Invoice Ninja

<a name="postpurgecompany"></a>
# **PostPurgeCompany**
> void PostPurgeCompany (string xApiSecret, string xApiToken, string xRequestedWith, string company)

Attempts to purge a company record and all its child records

Attempts to purge a company record and all its child records

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostPurgeCompanyExample
    {
        public void main()
        {
            var apiInstance = new MigrationApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var company = company_example;  // string | The Company Hashed ID

            try
            {
                // Attempts to purge a company record and all its child records
                apiInstance.PostPurgeCompany(xApiSecret, xApiToken, xRequestedWith, company);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationApi.PostPurgeCompany: " + e.Message );
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
 **company** | **string**| The Company Hashed ID | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postpurgecompanysavesettings"></a>
# **PostPurgeCompanySaveSettings**
> void PostPurgeCompanySaveSettings (string xApiSecret, string xApiToken, string xRequestedWith, string company)

Attempts to purge a companies child records but save the company record and its settings

Attempts to purge a companies child records but save the company record and its settings

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostPurgeCompanySaveSettingsExample
    {
        public void main()
        {
            var apiInstance = new MigrationApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var company = company_example;  // string | The Company Hashed ID

            try
            {
                // Attempts to purge a companies child records but save the company record and its settings
                apiInstance.PostPurgeCompanySaveSettings(xApiSecret, xApiToken, xRequestedWith, company);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationApi.PostPurgeCompanySaveSettings: " + e.Message );
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
 **company** | **string**| The Company Hashed ID | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="poststartmigration"></a>
# **PostStartMigration**
> void PostStartMigration (string xApiSecret, string xApiToken, string xRequestedWith, string xApiPassword, Object migration)

Starts the migration from previous version of Invoice Ninja

Starts the migration from previous version of Invoice Ninja

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PostStartMigrationExample
    {
        public void main()
        {
            var apiInstance = new MigrationApi();
            var xApiSecret = xApiSecret_example;  // string | The API secret as defined by the .env variable API_SECRET
            var xApiToken = xApiToken_example;  // string | The API token to be used for authentication
            var xRequestedWith = xRequestedWith_example;  // string | Used to send the XMLHttpRequest header
            var xApiPassword = xApiPassword_example;  // string | The login password when challenged
            var migration = new Object(); // Object | The migraton file

            try
            {
                // Starts the migration from previous version of Invoice Ninja
                apiInstance.PostStartMigration(xApiSecret, xApiToken, xRequestedWith, xApiPassword, migration);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MigrationApi.PostStartMigration: " + e.Message );
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
 **xApiPassword** | **string**| The login password when challenged | 
 **migration** | [**Object**](Object.md)| The migraton file | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
