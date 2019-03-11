using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using Khipu.Client;
using Khipu.Model;

namespace Khipu.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentMethodsApi
    {
        
        /// <summary>
        /// Obtener listado de medios de pago disponible para una cuenta de cobrador
        /// </summary>
        /// <remarks>
        /// Obtiene el listado de medios de pago que pueden usarse para pagar a esta cuenta de cobro.
        /// </remarks>
        /// <param name="id">Identificador del merchant</param>
        /// <returns>PaymentMethodsResponse</returns>
        PaymentMethodsResponse MerchantsIdPaymentMethodsGet (string id);
  
        /// <summary>
        /// Obtener listado de medios de pago disponible para una cuenta de cobrador
        /// </summary>
        /// <remarks>
        /// Obtiene el listado de medios de pago que pueden usarse para pagar a esta cuenta de cobro.
        /// </remarks>
        /// <param name="id">Identificador del merchant</param>
        /// <returns>PaymentMethodsResponse</returns>
        System.Threading.Tasks.Task<PaymentMethodsResponse> MerchantsIdPaymentMethodsGetAsync (string id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentMethodsApi : IPaymentMethodsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentMethodsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentMethodsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Obtener listado de medios de pago disponible para una cuenta de cobrador Obtiene el listado de medios de pago que pueden usarse para pagar a esta cuenta de cobro.
        /// </summary>
        /// <param name="id">Identificador del merchant</param> 
        /// <returns>PaymentMethodsResponse</returns>            
        public PaymentMethodsResponse MerchantsIdPaymentMethodsGet (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MerchantsIdPaymentMethodsGet");
            
    
            var path = "/merchants/{id}/paymentMethods";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MerchantsIdPaymentMethodsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MerchantsIdPaymentMethodsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaymentMethodsResponse) ApiClient.Deserialize(response.Content, typeof(PaymentMethodsResponse), response.Headers);
        }
    
        /// <summary>
        /// Obtener listado de medios de pago disponible para una cuenta de cobrador Obtiene el listado de medios de pago que pueden usarse para pagar a esta cuenta de cobro.
        /// </summary>
        /// <param name="id">Identificador del merchant</param>
        /// <returns>PaymentMethodsResponse</returns>
        public async System.Threading.Tasks.Task<PaymentMethodsResponse> MerchantsIdPaymentMethodsGetAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MerchantsIdPaymentMethodsGet");
            
    
            var path = "/merchants/{id}/paymentMethods";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MerchantsIdPaymentMethodsGet: " + response.Content, response.Content);

            return (PaymentMethodsResponse) ApiClient.Deserialize(response.Content, typeof(PaymentMethodsResponse), response.Headers);
        }
        
    }
    
}
