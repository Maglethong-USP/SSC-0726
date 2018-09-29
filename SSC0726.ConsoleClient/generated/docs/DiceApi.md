# IO.Swagger.Api.DiceApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiDiceGet**](DiceApi.md#apidiceget) | **GET** /api/dice | 


<a name="apidiceget"></a>
# **ApiDiceGet**
> DiceDto ApiDiceGet (int? sides = null, int? amount = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiDiceGetExample
    {
        public void main()
        {
            var apiInstance = new DiceApi();
            var sides = 56;  // int? |  (optional)  (default to 6)
            var amount = 56;  // int? |  (optional)  (default to 1)

            try
            {
                DiceDto result = apiInstance.ApiDiceGet(sides, amount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiceApi.ApiDiceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sides** | **int?**|  | [optional] [default to 6]
 **amount** | **int?**|  | [optional] [default to 1]

### Return type

[**DiceDto**](DiceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

