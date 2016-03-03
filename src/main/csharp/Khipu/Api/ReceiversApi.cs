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
    public interface IReceiversApi
    {
        
        /// <summary>
        /// Crear una nueva cuenta de cobro
        /// </summary>
        /// <remarks>
        /// Crear una nueva cuenta de cobro asociada a un integrador. Necesita datos de la cuenta de usuario asociada, datos de facturación y datos de contacto.
        /// </remarks>
        /// <param name="adminFirstName">Nombre de pila del administrador de la cuenta de cobro a crear.</param>
        /// <param name="adminLastName">Apellido del administrador de la cuenta de cobro a crear.</param>
        /// <param name="adminEmail">Correo electrónico del administrador de la cuenta de cobro a crear.</param>
        /// <param name="countryCode">Código alfanumérico de dos caractéres ISO 3166-1 del país de la cuenta de cobro a crear.</param>
        /// <param name="businessIdentifier">Identificador tributario del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessCategory">Categoría tributaria o rubro tributario del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessName">Nombre tributario del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessPhone">Teléfono del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessAddressLine1">Dirección del cobrador de la cuenta de cobro a crear.</param>
        /// <param name="businessAddressLine2">Segunda línea de la dirección del cobrador de la cuenta de cobro a crear.</param>
        /// <param name="businessAddressLine3">Tercera línea de la dirección del cobrador de la cuenta de cobro a crear.</param>
        /// <param name="contactFullName">Nombre del contacto del cobrador.</param>
        /// <param name="contactJobTitle">Cargo del contacto del cobrador.</param>
        /// <param name="contactEmail">Correo electrónico del contacto del cobrador.</param>
        /// <param name="contactPhone">Teléfono del contacto del cobrador.</param>
        /// <returns>ReceiversCreateResponse</returns>
        ReceiversCreateResponse ReceiversPost (string adminFirstName, string adminLastName, string adminEmail, string countryCode, string businessIdentifier, string businessCategory, string businessName, string businessPhone, string businessAddressLine1, string businessAddressLine2, string businessAddressLine3, string contactFullName, string contactJobTitle, string contactEmail, string contactPhone);
  
        /// <summary>
        /// Crear una nueva cuenta de cobro
        /// </summary>
        /// <remarks>
        /// Crear una nueva cuenta de cobro asociada a un integrador. Necesita datos de la cuenta de usuario asociada, datos de facturación y datos de contacto.
        /// </remarks>
        /// <param name="adminFirstName">Nombre de pila del administrador de la cuenta de cobro a crear.</param>
        /// <param name="adminLastName">Apellido del administrador de la cuenta de cobro a crear.</param>
        /// <param name="adminEmail">Correo electrónico del administrador de la cuenta de cobro a crear.</param>
        /// <param name="countryCode">Código alfanumérico de dos caractéres ISO 3166-1 del país de la cuenta de cobro a crear.</param>
        /// <param name="businessIdentifier">Identificador tributario del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessCategory">Categoría tributaria o rubro tributario del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessName">Nombre tributario del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessPhone">Teléfono del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessAddressLine1">Dirección del cobrador de la cuenta de cobro a crear.</param>
        /// <param name="businessAddressLine2">Segunda línea de la dirección del cobrador de la cuenta de cobro a crear.</param>
        /// <param name="businessAddressLine3">Tercera línea de la dirección del cobrador de la cuenta de cobro a crear.</param>
        /// <param name="contactFullName">Nombre del contacto del cobrador.</param>
        /// <param name="contactJobTitle">Cargo del contacto del cobrador.</param>
        /// <param name="contactEmail">Correo electrónico del contacto del cobrador.</param>
        /// <param name="contactPhone">Teléfono del contacto del cobrador.</param>
        /// <returns>ReceiversCreateResponse</returns>
        System.Threading.Tasks.Task<ReceiversCreateResponse> ReceiversPostAsync (string adminFirstName, string adminLastName, string adminEmail, string countryCode, string businessIdentifier, string businessCategory, string businessName, string businessPhone, string businessAddressLine1, string businessAddressLine2, string businessAddressLine3, string contactFullName, string contactJobTitle, string contactEmail, string contactPhone);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ReceiversApi : IReceiversApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiversApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ReceiversApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiversApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReceiversApi(String basePath)
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
        /// Crear una nueva cuenta de cobro Crear una nueva cuenta de cobro asociada a un integrador. Necesita datos de la cuenta de usuario asociada, datos de facturación y datos de contacto.
        /// </summary>
        /// <param name="adminFirstName">Nombre de pila del administrador de la cuenta de cobro a crear.</param> 
        /// <param name="adminLastName">Apellido del administrador de la cuenta de cobro a crear.</param> 
        /// <param name="adminEmail">Correo electrónico del administrador de la cuenta de cobro a crear.</param> 
        /// <param name="countryCode">Código alfanumérico de dos caractéres ISO 3166-1 del país de la cuenta de cobro a crear.</param> 
        /// <param name="businessIdentifier">Identificador tributario del cobrador asociado a la cuenta de cobro a crear.</param> 
        /// <param name="businessCategory">Categoría tributaria o rubro tributario del cobrador asociado a la cuenta de cobro a crear.</param> 
        /// <param name="businessName">Nombre tributario del cobrador asociado a la cuenta de cobro a crear.</param> 
        /// <param name="businessPhone">Teléfono del cobrador asociado a la cuenta de cobro a crear.</param> 
        /// <param name="businessAddressLine1">Dirección del cobrador de la cuenta de cobro a crear.</param> 
        /// <param name="businessAddressLine2">Segunda línea de la dirección del cobrador de la cuenta de cobro a crear.</param> 
        /// <param name="businessAddressLine3">Tercera línea de la dirección del cobrador de la cuenta de cobro a crear.</param> 
        /// <param name="contactFullName">Nombre del contacto del cobrador.</param> 
        /// <param name="contactJobTitle">Cargo del contacto del cobrador.</param> 
        /// <param name="contactEmail">Correo electrónico del contacto del cobrador.</param> 
        /// <param name="contactPhone">Teléfono del contacto del cobrador.</param> 
        /// <returns>ReceiversCreateResponse</returns>            
        public ReceiversCreateResponse ReceiversPost (string adminFirstName, string adminLastName, string adminEmail, string countryCode, string businessIdentifier, string businessCategory, string businessName, string businessPhone, string businessAddressLine1, string businessAddressLine2, string businessAddressLine3, string contactFullName, string contactJobTitle, string contactEmail, string contactPhone)
        {
            
            // verify the required parameter 'adminFirstName' is set
            if (adminFirstName == null) throw new ApiException(400, "Missing required parameter 'adminFirstName' when calling ReceiversPost");
            
            // verify the required parameter 'adminLastName' is set
            if (adminLastName == null) throw new ApiException(400, "Missing required parameter 'adminLastName' when calling ReceiversPost");
            
            // verify the required parameter 'adminEmail' is set
            if (adminEmail == null) throw new ApiException(400, "Missing required parameter 'adminEmail' when calling ReceiversPost");
            
            // verify the required parameter 'countryCode' is set
            if (countryCode == null) throw new ApiException(400, "Missing required parameter 'countryCode' when calling ReceiversPost");
            
            // verify the required parameter 'businessIdentifier' is set
            if (businessIdentifier == null) throw new ApiException(400, "Missing required parameter 'businessIdentifier' when calling ReceiversPost");
            
            // verify the required parameter 'businessCategory' is set
            if (businessCategory == null) throw new ApiException(400, "Missing required parameter 'businessCategory' when calling ReceiversPost");
            
            // verify the required parameter 'businessName' is set
            if (businessName == null) throw new ApiException(400, "Missing required parameter 'businessName' when calling ReceiversPost");
            
            // verify the required parameter 'businessPhone' is set
            if (businessPhone == null) throw new ApiException(400, "Missing required parameter 'businessPhone' when calling ReceiversPost");
            
            // verify the required parameter 'businessAddressLine1' is set
            if (businessAddressLine1 == null) throw new ApiException(400, "Missing required parameter 'businessAddressLine1' when calling ReceiversPost");
            
            // verify the required parameter 'businessAddressLine2' is set
            if (businessAddressLine2 == null) throw new ApiException(400, "Missing required parameter 'businessAddressLine2' when calling ReceiversPost");
            
            // verify the required parameter 'businessAddressLine3' is set
            if (businessAddressLine3 == null) throw new ApiException(400, "Missing required parameter 'businessAddressLine3' when calling ReceiversPost");
            
            // verify the required parameter 'contactFullName' is set
            if (contactFullName == null) throw new ApiException(400, "Missing required parameter 'contactFullName' when calling ReceiversPost");
            
            // verify the required parameter 'contactJobTitle' is set
            if (contactJobTitle == null) throw new ApiException(400, "Missing required parameter 'contactJobTitle' when calling ReceiversPost");
            
            // verify the required parameter 'contactEmail' is set
            if (contactEmail == null) throw new ApiException(400, "Missing required parameter 'contactEmail' when calling ReceiversPost");
            
            // verify the required parameter 'contactPhone' is set
            if (contactPhone == null) throw new ApiException(400, "Missing required parameter 'contactPhone' when calling ReceiversPost");
            
    
            var path = "/receivers";
    
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
            
            
            
            if (adminFirstName != null) formParams.Add("admin_first_name", ApiClient.ParameterToString(adminFirstName)); // form parameter
            if (adminLastName != null) formParams.Add("admin_last_name", ApiClient.ParameterToString(adminLastName)); // form parameter
            if (adminEmail != null) formParams.Add("admin_email", ApiClient.ParameterToString(adminEmail)); // form parameter
            if (countryCode != null) formParams.Add("country_code", ApiClient.ParameterToString(countryCode)); // form parameter
            if (businessIdentifier != null) formParams.Add("business_identifier", ApiClient.ParameterToString(businessIdentifier)); // form parameter
            if (businessCategory != null) formParams.Add("business_category", ApiClient.ParameterToString(businessCategory)); // form parameter
            if (businessName != null) formParams.Add("business_name", ApiClient.ParameterToString(businessName)); // form parameter
            if (businessPhone != null) formParams.Add("business_phone", ApiClient.ParameterToString(businessPhone)); // form parameter
            if (businessAddressLine1 != null) formParams.Add("business_address_line_1", ApiClient.ParameterToString(businessAddressLine1)); // form parameter
            if (businessAddressLine2 != null) formParams.Add("business_address_line_2", ApiClient.ParameterToString(businessAddressLine2)); // form parameter
            if (businessAddressLine3 != null) formParams.Add("business_address_line_3", ApiClient.ParameterToString(businessAddressLine3)); // form parameter
            if (contactFullName != null) formParams.Add("contact_full_name", ApiClient.ParameterToString(contactFullName)); // form parameter
            if (contactJobTitle != null) formParams.Add("contact_job_title", ApiClient.ParameterToString(contactJobTitle)); // form parameter
            if (contactEmail != null) formParams.Add("contact_email", ApiClient.ParameterToString(contactEmail)); // form parameter
            if (contactPhone != null) formParams.Add("contact_phone", ApiClient.ParameterToString(contactPhone)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReceiversPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ReceiversPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ReceiversCreateResponse) ApiClient.Deserialize(response.Content, typeof(ReceiversCreateResponse), response.Headers);
        }
    
        /// <summary>
        /// Crear una nueva cuenta de cobro Crear una nueva cuenta de cobro asociada a un integrador. Necesita datos de la cuenta de usuario asociada, datos de facturación y datos de contacto.
        /// </summary>
        /// <param name="adminFirstName">Nombre de pila del administrador de la cuenta de cobro a crear.</param>
        /// <param name="adminLastName">Apellido del administrador de la cuenta de cobro a crear.</param>
        /// <param name="adminEmail">Correo electrónico del administrador de la cuenta de cobro a crear.</param>
        /// <param name="countryCode">Código alfanumérico de dos caractéres ISO 3166-1 del país de la cuenta de cobro a crear.</param>
        /// <param name="businessIdentifier">Identificador tributario del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessCategory">Categoría tributaria o rubro tributario del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessName">Nombre tributario del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessPhone">Teléfono del cobrador asociado a la cuenta de cobro a crear.</param>
        /// <param name="businessAddressLine1">Dirección del cobrador de la cuenta de cobro a crear.</param>
        /// <param name="businessAddressLine2">Segunda línea de la dirección del cobrador de la cuenta de cobro a crear.</param>
        /// <param name="businessAddressLine3">Tercera línea de la dirección del cobrador de la cuenta de cobro a crear.</param>
        /// <param name="contactFullName">Nombre del contacto del cobrador.</param>
        /// <param name="contactJobTitle">Cargo del contacto del cobrador.</param>
        /// <param name="contactEmail">Correo electrónico del contacto del cobrador.</param>
        /// <param name="contactPhone">Teléfono del contacto del cobrador.</param>
        /// <returns>ReceiversCreateResponse</returns>
        public async System.Threading.Tasks.Task<ReceiversCreateResponse> ReceiversPostAsync (string adminFirstName, string adminLastName, string adminEmail, string countryCode, string businessIdentifier, string businessCategory, string businessName, string businessPhone, string businessAddressLine1, string businessAddressLine2, string businessAddressLine3, string contactFullName, string contactJobTitle, string contactEmail, string contactPhone)
        {
            // verify the required parameter 'adminFirstName' is set
            if (adminFirstName == null) throw new ApiException(400, "Missing required parameter 'adminFirstName' when calling ReceiversPost");
            // verify the required parameter 'adminLastName' is set
            if (adminLastName == null) throw new ApiException(400, "Missing required parameter 'adminLastName' when calling ReceiversPost");
            // verify the required parameter 'adminEmail' is set
            if (adminEmail == null) throw new ApiException(400, "Missing required parameter 'adminEmail' when calling ReceiversPost");
            // verify the required parameter 'countryCode' is set
            if (countryCode == null) throw new ApiException(400, "Missing required parameter 'countryCode' when calling ReceiversPost");
            // verify the required parameter 'businessIdentifier' is set
            if (businessIdentifier == null) throw new ApiException(400, "Missing required parameter 'businessIdentifier' when calling ReceiversPost");
            // verify the required parameter 'businessCategory' is set
            if (businessCategory == null) throw new ApiException(400, "Missing required parameter 'businessCategory' when calling ReceiversPost");
            // verify the required parameter 'businessName' is set
            if (businessName == null) throw new ApiException(400, "Missing required parameter 'businessName' when calling ReceiversPost");
            // verify the required parameter 'businessPhone' is set
            if (businessPhone == null) throw new ApiException(400, "Missing required parameter 'businessPhone' when calling ReceiversPost");
            // verify the required parameter 'businessAddressLine1' is set
            if (businessAddressLine1 == null) throw new ApiException(400, "Missing required parameter 'businessAddressLine1' when calling ReceiversPost");
            // verify the required parameter 'businessAddressLine2' is set
            if (businessAddressLine2 == null) throw new ApiException(400, "Missing required parameter 'businessAddressLine2' when calling ReceiversPost");
            // verify the required parameter 'businessAddressLine3' is set
            if (businessAddressLine3 == null) throw new ApiException(400, "Missing required parameter 'businessAddressLine3' when calling ReceiversPost");
            // verify the required parameter 'contactFullName' is set
            if (contactFullName == null) throw new ApiException(400, "Missing required parameter 'contactFullName' when calling ReceiversPost");
            // verify the required parameter 'contactJobTitle' is set
            if (contactJobTitle == null) throw new ApiException(400, "Missing required parameter 'contactJobTitle' when calling ReceiversPost");
            // verify the required parameter 'contactEmail' is set
            if (contactEmail == null) throw new ApiException(400, "Missing required parameter 'contactEmail' when calling ReceiversPost");
            // verify the required parameter 'contactPhone' is set
            if (contactPhone == null) throw new ApiException(400, "Missing required parameter 'contactPhone' when calling ReceiversPost");
            
    
            var path = "/receivers";
    
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
            
            
            
            if (adminFirstName != null) formParams.Add("admin_first_name", ApiClient.ParameterToString(adminFirstName)); // form parameter
            if (adminLastName != null) formParams.Add("admin_last_name", ApiClient.ParameterToString(adminLastName)); // form parameter
            if (adminEmail != null) formParams.Add("admin_email", ApiClient.ParameterToString(adminEmail)); // form parameter
            if (countryCode != null) formParams.Add("country_code", ApiClient.ParameterToString(countryCode)); // form parameter
            if (businessIdentifier != null) formParams.Add("business_identifier", ApiClient.ParameterToString(businessIdentifier)); // form parameter
            if (businessCategory != null) formParams.Add("business_category", ApiClient.ParameterToString(businessCategory)); // form parameter
            if (businessName != null) formParams.Add("business_name", ApiClient.ParameterToString(businessName)); // form parameter
            if (businessPhone != null) formParams.Add("business_phone", ApiClient.ParameterToString(businessPhone)); // form parameter
            if (businessAddressLine1 != null) formParams.Add("business_address_line_1", ApiClient.ParameterToString(businessAddressLine1)); // form parameter
            if (businessAddressLine2 != null) formParams.Add("business_address_line_2", ApiClient.ParameterToString(businessAddressLine2)); // form parameter
            if (businessAddressLine3 != null) formParams.Add("business_address_line_3", ApiClient.ParameterToString(businessAddressLine3)); // form parameter
            if (contactFullName != null) formParams.Add("contact_full_name", ApiClient.ParameterToString(contactFullName)); // form parameter
            if (contactJobTitle != null) formParams.Add("contact_job_title", ApiClient.ParameterToString(contactJobTitle)); // form parameter
            if (contactEmail != null) formParams.Add("contact_email", ApiClient.ParameterToString(contactEmail)); // form parameter
            if (contactPhone != null) formParams.Add("contact_phone", ApiClient.ParameterToString(contactPhone)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ReceiversPost: " + response.Content, response.Content);

            return (ReceiversCreateResponse) ApiClient.Deserialize(response.Content, typeof(ReceiversCreateResponse), response.Headers);
        }
        
    }
    
}
