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
    public interface IBanksApi
    {
        
        /// <summary>
        /// Obtener listado de bancos
        /// </summary>
        /// <remarks>
        /// Obtiene el listado de bancos que pueden usarse para pagar a esta cuenta de cobro.
        /// </remarks>
        /// <returns>BanksResponse</returns>
        BanksResponse BanksGet ();
  
        /// <summary>
        /// Obtener listado de bancos
        /// </summary>
        /// <remarks>
        /// Obtiene el listado de bancos que pueden usarse para pagar a esta cuenta de cobro.
        /// </remarks>
        /// <returns>BanksResponse</returns>
        System.Threading.Tasks.Task<BanksResponse> BanksGetAsync ();
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BanksApi : IBanksApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BanksApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BanksApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BanksApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BanksApi(String basePath)
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
        /// Obtener listado de bancos Obtiene el listado de bancos que pueden usarse para pagar a esta cuenta de cobro.
        /// </summary>
        /// <returns>BanksResponse</returns>            
        public BanksResponse BanksGet ()
        {
            
    
            var path = "/banks";
    
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
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BanksGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BanksGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (BanksResponse) ApiClient.Deserialize(response.Content, typeof(BanksResponse), response.Headers);
        }
    
        /// <summary>
        /// Obtener listado de bancos Obtiene el listado de bancos que pueden usarse para pagar a esta cuenta de cobro.
        /// </summary>
        /// <returns>BanksResponse</returns>
        public async System.Threading.Tasks.Task<BanksResponse> BanksGetAsync ()
        {
            
    
            var path = "/banks";
    
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
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            RestResponse response = (RestResponse) await ApiClient.CallApiAsync(path, Method.Get, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BanksGet: " + response.Content, response.Content);

            return (BanksResponse) ApiClient.Deserialize(response.Content, typeof(BanksResponse), response.Headers);
        }
        
    }
    
}
