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
    public interface IPaymentsApi
    {
        
        /// <summary>
        /// Obtener información de un pago
        /// </summary>
        /// <remarks>
        /// Información completa del pago. Datos con los que fue creado y el estado actual del pago. Se obtiene del notification_token que envia khipu cuando el pago es conciliado.
        /// </remarks>
        /// <param name="notificationToken">Token de notifiación recibido usando la API de notificaiones 1.3 o superior.</param>
        /// <returns>PaymentsResponse</returns>
        PaymentsResponse PaymentsGet (string notificationToken);
  
        /// <summary>
        /// Obtener información de un pago
        /// </summary>
        /// <remarks>
        /// Información completa del pago. Datos con los que fue creado y el estado actual del pago. Se obtiene del notification_token que envia khipu cuando el pago es conciliado.
        /// </remarks>
        /// <param name="notificationToken">Token de notifiación recibido usando la API de notificaiones 1.3 o superior.</param>
        /// <returns>PaymentsResponse</returns>
        System.Threading.Tasks.Task<PaymentsResponse> PaymentsGetAsync (string notificationToken);
        
        /// <summary>
        /// Crear un pago
        /// </summary>
        /// <remarks>
        /// Crea un pago en khipu y obtiene las URLs para redirección al usuario para que complete el pago.
        /// </remarks>
        /// <param name="subject">Motivo</param>
        /// <param name="currency">El código de moneda en formato ISO-4217</param>
        /// <param name="amount">El monto del cobro. Sin separador de miles y usando &#39;.&#39; como separador de decimales. Hasta 4 lugares decimales, dependiendo de la moneda</param>
        /// <param name="transactionId">Identificador propio de la  transacción. Ej: número de factura u orden de compra</param>
        /// <param name="custom">Parámetro para enviar información personalizada de la transacción. Ej: documento XML con el detalle del carro de compra</param>
        /// <param name="body">Descripción del cobro</param>
        /// <param name="bankId">Identificador del banco para usar en el pago</param>
        /// <param name="returnUrl">La dirección URL a donde enviar al cliente mientras el pago está siendo verificado</param>
        /// <param name="cancelUrl">La dirección URL a donde enviar al cliente si decide no hacer hacer la transacción</param>
        /// <param name="pictureUrl">Una dirección URL de una foto de tu producto o servicio</param>
        /// <param name="notifyUrl">La dirección del web-service que utilizará khipu para notificar cuando el pago esté conciliado</param>
        /// <param name="contractUrl">La dirección URL del archivo PDF con el contrato a firmar mediante este pago. El cobrador debe estar habilitado para este servicio y el campo &#39;fixed_payer_personal_identifier&#39; es obgligatorio</param>
        /// <param name="notifyApiVersion">Versión de la API de notifiaciones para recibir avisos por web-service</param>
        /// <param name="expiresDate">Fecha de expiración del cobro. Pasada esta fecha el cobro es inválido. Formato ISO-8601. Ej: 2017-03-01T13:00:00Z</param>
        /// <param name="sendEmail">Si es &#39;true&#39;, se enviará una solicitud de cobro al correo especificado en &#39;payer_email&#39;</param>
        /// <param name="payerName">Nombre del pagador. Es obligatorio cuando send_email es &#39;true&#39;</param>
        /// <param name="payerEmail">Correo del pagador. Es obligatorio cuando send_email es &#39;true&#39;</param>
        /// <param name="sendReminders">Si es &#39;true&#39;, se enviarán recordatorios de cobro.</param>
        /// <param name="responsibleUserEmail">Correo electrónico del responsable de este cobro, debe corresponder a un usuario khipu con permisos para cobrar usando esta cuenta de cobro</param>
        /// <param name="fixedPayerPersonalIdentifier">Identificador personal. Si se especifica, solo podrá ser pagado usando ese identificador</param>
        /// <param name="integratorFee">Comisión para el integrador. Sólo es válido si la cuenta de cobro tiene una cuenta de integrador asociada</param>
        /// <returns>PaymentsCreateResponse</returns>
        PaymentsCreateResponse PaymentsPost (string subject, string currency, double? amount, string transactionId, string custom, string body, string bankId, string returnUrl, string cancelUrl, string pictureUrl, string notifyUrl, string contractUrl, string notifyApiVersion, DateTime? expiresDate, bool? sendEmail, string payerName, string payerEmail, bool? sendReminders, string responsibleUserEmail, string fixedPayerPersonalIdentifier, double? integratorFee);
  
        /// <summary>
        /// Crear un pago
        /// </summary>
        /// <remarks>
        /// Crea un pago en khipu y obtiene las URLs para redirección al usuario para que complete el pago.
        /// </remarks>
        /// <param name="subject">Motivo</param>
        /// <param name="currency">El código de moneda en formato ISO-4217</param>
        /// <param name="amount">El monto del cobro. Sin separador de miles y usando &#39;.&#39; como separador de decimales. Hasta 4 lugares decimales, dependiendo de la moneda</param>
        /// <param name="transactionId">Identificador propio de la  transacción. Ej: número de factura u orden de compra</param>
        /// <param name="custom">Parámetro para enviar información personalizada de la transacción. Ej: documento XML con el detalle del carro de compra</param>
        /// <param name="body">Descripción del cobro</param>
        /// <param name="bankId">Identificador del banco para usar en el pago</param>
        /// <param name="returnUrl">La dirección URL a donde enviar al cliente mientras el pago está siendo verificado</param>
        /// <param name="cancelUrl">La dirección URL a donde enviar al cliente si decide no hacer hacer la transacción</param>
        /// <param name="pictureUrl">Una dirección URL de una foto de tu producto o servicio</param>
        /// <param name="notifyUrl">La dirección del web-service que utilizará khipu para notificar cuando el pago esté conciliado</param>
        /// <param name="contractUrl">La dirección URL del archivo PDF con el contrato a firmar mediante este pago. El cobrador debe estar habilitado para este servicio y el campo &#39;fixed_payer_personal_identifier&#39; es obgligatorio</param>
        /// <param name="notifyApiVersion">Versión de la API de notifiaciones para recibir avisos por web-service</param>
        /// <param name="expiresDate">Fecha de expiración del cobro. Pasada esta fecha el cobro es inválido. Formato ISO-8601. Ej: 2017-03-01T13:00:00Z</param>
        /// <param name="sendEmail">Si es &#39;true&#39;, se enviará una solicitud de cobro al correo especificado en &#39;payer_email&#39;</param>
        /// <param name="payerName">Nombre del pagador. Es obligatorio cuando send_email es &#39;true&#39;</param>
        /// <param name="payerEmail">Correo del pagador. Es obligatorio cuando send_email es &#39;true&#39;</param>
        /// <param name="sendReminders">Si es &#39;true&#39;, se enviarán recordatorios de cobro.</param>
        /// <param name="responsibleUserEmail">Correo electrónico del responsable de este cobro, debe corresponder a un usuario khipu con permisos para cobrar usando esta cuenta de cobro</param>
        /// <param name="fixedPayerPersonalIdentifier">Identificador personal. Si se especifica, solo podrá ser pagado usando ese identificador</param>
        /// <param name="integratorFee">Comisión para el integrador. Sólo es válido si la cuenta de cobro tiene una cuenta de integrador asociada</param>
        /// <returns>PaymentsCreateResponse</returns>
        System.Threading.Tasks.Task<PaymentsCreateResponse> PaymentsPostAsync (string subject, string currency, double? amount, string transactionId, string custom, string body, string bankId, string returnUrl, string cancelUrl, string pictureUrl, string notifyUrl, string contractUrl, string notifyApiVersion, DateTime? expiresDate, bool? sendEmail, string payerName, string payerEmail, bool? sendReminders, string responsibleUserEmail, string fixedPayerPersonalIdentifier, double? integratorFee);
        
        /// <summary>
        /// Obtener información de un pago
        /// </summary>
        /// <remarks>
        /// Información completa del pago. Datos con los que fue creado y el estado actual del pago.
        /// </remarks>
        /// <param name="id">Identificador del pago</param>
        /// <returns>PaymentsResponse</returns>
        PaymentsResponse PaymentsIdGet (string id);
  
        /// <summary>
        /// Obtener información de un pago
        /// </summary>
        /// <remarks>
        /// Información completa del pago. Datos con los que fue creado y el estado actual del pago.
        /// </remarks>
        /// <param name="id">Identificador del pago</param>
        /// <returns>PaymentsResponse</returns>
        System.Threading.Tasks.Task<PaymentsResponse> PaymentsIdGetAsync (string id);
        
        /// <summary>
        /// Borrar un pago
        /// </summary>
        /// <remarks>
        /// Solo se pueden borrar pagos que estén pendientes de pagar. Esta operación no puede deshacerse.
        /// </remarks>
        /// <param name="id">Identificador del pago</param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse PaymentsIdDelete (string id);
  
        /// <summary>
        /// Borrar un pago
        /// </summary>
        /// <remarks>
        /// Solo se pueden borrar pagos que estén pendientes de pagar. Esta operación no puede deshacerse.
        /// </remarks>
        /// <param name="id">Identificador del pago</param>
        /// <returns>SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> PaymentsIdDeleteAsync (string id);
        
        /// <summary>
        /// Reembolsar total o parcialmente un pago
        /// </summary>
        /// <remarks>
        /// Reembolsa total o parcialmente el monto de un pago. Esta operación solo se puede realizar en los comercios que recauden en cuenta khipu y antes de la rendición de los fondos correspondientes.
        /// </remarks>
        /// <param name="id">Identificador del pago</param>
        /// <param name="amount">El monto a devolver. Sin separador de miles y usando &#39;.&#39; como separador de decimales. Hasta 4 lugares decimales, dependiendo de la moneda. Si se omite el reembolso se hará por el total del monto del pago.</param>
        /// <returns>SuccessResponse</returns>
        SuccessResponse PaymentsIdRefundsPost (string id, double? amount);
  
        /// <summary>
        /// Reembolsar total o parcialmente un pago
        /// </summary>
        /// <remarks>
        /// Reembolsa total o parcialmente el monto de un pago. Esta operación solo se puede realizar en los comercios que recauden en cuenta khipu y antes de la rendición de los fondos correspondientes.
        /// </remarks>
        /// <param name="id">Identificador del pago</param>
        /// <param name="amount">El monto a devolver. Sin separador de miles y usando &#39;.&#39; como separador de decimales. Hasta 4 lugares decimales, dependiendo de la moneda. Si se omite el reembolso se hará por el total del monto del pago.</param>
        /// <returns>SuccessResponse</returns>
        System.Threading.Tasks.Task<SuccessResponse> PaymentsIdRefundsPostAsync (string id, double? amount);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PaymentsApi : IPaymentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PaymentsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsApi(String basePath)
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
        /// Obtener información de un pago Información completa del pago. Datos con los que fue creado y el estado actual del pago. Se obtiene del notification_token que envia khipu cuando el pago es conciliado.
        /// </summary>
        /// <param name="notificationToken">Token de notifiación recibido usando la API de notificaiones 1.3 o superior.</param> 
        /// <returns>PaymentsResponse</returns>            
        public PaymentsResponse PaymentsGet (string notificationToken)
        {
            
            // verify the required parameter 'notificationToken' is set
            if (notificationToken == null) throw new ApiException(400, "Missing required parameter 'notificationToken' when calling PaymentsGet");
            
    
            var path = "/payments";
    
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
            
            if (notificationToken != null) queryParams.Add("notification_token", ApiClient.ParameterToString(notificationToken)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaymentsResponse) ApiClient.Deserialize(response.Content, typeof(PaymentsResponse), response.Headers);
        }
    
        /// <summary>
        /// Obtener información de un pago Información completa del pago. Datos con los que fue creado y el estado actual del pago. Se obtiene del notification_token que envia khipu cuando el pago es conciliado.
        /// </summary>
        /// <param name="notificationToken">Token de notifiación recibido usando la API de notificaiones 1.3 o superior.</param>
        /// <returns>PaymentsResponse</returns>
        public async System.Threading.Tasks.Task<PaymentsResponse> PaymentsGetAsync (string notificationToken)
        {
            // verify the required parameter 'notificationToken' is set
            if (notificationToken == null) throw new ApiException(400, "Missing required parameter 'notificationToken' when calling PaymentsGet");
            
    
            var path = "/payments";
    
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
            
            if (notificationToken != null) queryParams.Add("notification_token", ApiClient.ParameterToString(notificationToken)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsGet: " + response.Content, response.Content);

            return (PaymentsResponse) ApiClient.Deserialize(response.Content, typeof(PaymentsResponse), response.Headers);
        }
        
        /// <summary>
        /// Crear un pago Crea un pago en khipu y obtiene las URLs para redirección al usuario para que complete el pago.
        /// </summary>
        /// <param name="subject">Motivo</param> 
        /// <param name="currency">El código de moneda en formato ISO-4217</param> 
        /// <param name="amount">El monto del cobro. Sin separador de miles y usando &#39;.&#39; como separador de decimales. Hasta 4 lugares decimales, dependiendo de la moneda</param> 
        /// <param name="transactionId">Identificador propio de la  transacción. Ej: número de factura u orden de compra</param> 
        /// <param name="custom">Parámetro para enviar información personalizada de la transacción. Ej: documento XML con el detalle del carro de compra</param> 
        /// <param name="body">Descripción del cobro</param> 
        /// <param name="bankId">Identificador del banco para usar en el pago</param> 
        /// <param name="returnUrl">La dirección URL a donde enviar al cliente mientras el pago está siendo verificado</param> 
        /// <param name="cancelUrl">La dirección URL a donde enviar al cliente si decide no hacer hacer la transacción</param> 
        /// <param name="pictureUrl">Una dirección URL de una foto de tu producto o servicio</param> 
        /// <param name="notifyUrl">La dirección del web-service que utilizará khipu para notificar cuando el pago esté conciliado</param> 
        /// <param name="contractUrl">La dirección URL del archivo PDF con el contrato a firmar mediante este pago. El cobrador debe estar habilitado para este servicio y el campo &#39;fixed_payer_personal_identifier&#39; es obgligatorio</param> 
        /// <param name="notifyApiVersion">Versión de la API de notifiaciones para recibir avisos por web-service</param> 
        /// <param name="expiresDate">Fecha de expiración del cobro. Pasada esta fecha el cobro es inválido. Formato ISO-8601. Ej: 2017-03-01T13:00:00Z</param> 
        /// <param name="sendEmail">Si es &#39;true&#39;, se enviará una solicitud de cobro al correo especificado en &#39;payer_email&#39;</param> 
        /// <param name="payerName">Nombre del pagador. Es obligatorio cuando send_email es &#39;true&#39;</param> 
        /// <param name="payerEmail">Correo del pagador. Es obligatorio cuando send_email es &#39;true&#39;</param> 
        /// <param name="sendReminders">Si es &#39;true&#39;, se enviarán recordatorios de cobro.</param> 
        /// <param name="responsibleUserEmail">Correo electrónico del responsable de este cobro, debe corresponder a un usuario khipu con permisos para cobrar usando esta cuenta de cobro</param> 
        /// <param name="fixedPayerPersonalIdentifier">Identificador personal. Si se especifica, solo podrá ser pagado usando ese identificador</param> 
        /// <param name="integratorFee">Comisión para el integrador. Sólo es válido si la cuenta de cobro tiene una cuenta de integrador asociada</param> 
        /// <returns>PaymentsCreateResponse</returns>            
        public PaymentsCreateResponse PaymentsPost (string subject, string currency, double? amount, string transactionId = null, string custom = null, string body = null, string bankId = null, string returnUrl = null, string cancelUrl = null, string pictureUrl = null, string notifyUrl = null, string contractUrl = null, string notifyApiVersion = null, DateTime? expiresDate = null, bool? sendEmail = null, string payerName = null, string payerEmail = null, bool? sendReminders = null, string responsibleUserEmail = null, string fixedPayerPersonalIdentifier = null, double? integratorFee = null)
        {
            
            // verify the required parameter 'subject' is set
            if (subject == null) throw new ApiException(400, "Missing required parameter 'subject' when calling PaymentsPost");
            
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling PaymentsPost");
            
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling PaymentsPost");
            
    
            var path = "/payments";
    
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
            
            
            
            if (subject != null) formParams.Add("subject", ApiClient.ParameterToString(subject)); // form parameter
            if (currency != null) formParams.Add("currency", ApiClient.ParameterToString(currency)); // form parameter
            if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
            if (transactionId != null) formParams.Add("transaction_id", ApiClient.ParameterToString(transactionId)); // form parameter
            if (custom != null) formParams.Add("custom", ApiClient.ParameterToString(custom)); // form parameter
            if (body != null) formParams.Add("body", ApiClient.ParameterToString(body)); // form parameter
            if (bankId != null) formParams.Add("bank_id", ApiClient.ParameterToString(bankId)); // form parameter
            if (returnUrl != null) formParams.Add("return_url", ApiClient.ParameterToString(returnUrl)); // form parameter
            if (cancelUrl != null) formParams.Add("cancel_url", ApiClient.ParameterToString(cancelUrl)); // form parameter
            if (pictureUrl != null) formParams.Add("picture_url", ApiClient.ParameterToString(pictureUrl)); // form parameter
            if (notifyUrl != null) formParams.Add("notify_url", ApiClient.ParameterToString(notifyUrl)); // form parameter
            if (contractUrl != null) formParams.Add("contract_url", ApiClient.ParameterToString(contractUrl)); // form parameter
            if (notifyApiVersion != null) formParams.Add("notify_api_version", ApiClient.ParameterToString(notifyApiVersion)); // form parameter
            if (expiresDate != null) formParams.Add("expires_date", ApiClient.ParameterToString(expiresDate)); // form parameter
            if (sendEmail != null) formParams.Add("send_email", ApiClient.ParameterToString(sendEmail)); // form parameter
            if (payerName != null) formParams.Add("payer_name", ApiClient.ParameterToString(payerName)); // form parameter
            if (payerEmail != null) formParams.Add("payer_email", ApiClient.ParameterToString(payerEmail)); // form parameter
            if (sendReminders != null) formParams.Add("send_reminders", ApiClient.ParameterToString(sendReminders)); // form parameter
            if (responsibleUserEmail != null) formParams.Add("responsible_user_email", ApiClient.ParameterToString(responsibleUserEmail)); // form parameter
            if (fixedPayerPersonalIdentifier != null) formParams.Add("fixed_payer_personal_identifier", ApiClient.ParameterToString(fixedPayerPersonalIdentifier)); // form parameter
            if (integratorFee != null) formParams.Add("integrator_fee", ApiClient.ParameterToString(integratorFee)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaymentsCreateResponse) ApiClient.Deserialize(response.Content, typeof(PaymentsCreateResponse), response.Headers);
        }
    
        /// <summary>
        /// Crear un pago Crea un pago en khipu y obtiene las URLs para redirección al usuario para que complete el pago.
        /// </summary>
        /// <param name="subject">Motivo</param>
        /// <param name="currency">El código de moneda en formato ISO-4217</param>
        /// <param name="amount">El monto del cobro. Sin separador de miles y usando &#39;.&#39; como separador de decimales. Hasta 4 lugares decimales, dependiendo de la moneda</param>
        /// <param name="transactionId">Identificador propio de la  transacción. Ej: número de factura u orden de compra</param>
        /// <param name="custom">Parámetro para enviar información personalizada de la transacción. Ej: documento XML con el detalle del carro de compra</param>
        /// <param name="body">Descripción del cobro</param>
        /// <param name="bankId">Identificador del banco para usar en el pago</param>
        /// <param name="returnUrl">La dirección URL a donde enviar al cliente mientras el pago está siendo verificado</param>
        /// <param name="cancelUrl">La dirección URL a donde enviar al cliente si decide no hacer hacer la transacción</param>
        /// <param name="pictureUrl">Una dirección URL de una foto de tu producto o servicio</param>
        /// <param name="notifyUrl">La dirección del web-service que utilizará khipu para notificar cuando el pago esté conciliado</param>
        /// <param name="contractUrl">La dirección URL del archivo PDF con el contrato a firmar mediante este pago. El cobrador debe estar habilitado para este servicio y el campo &#39;fixed_payer_personal_identifier&#39; es obgligatorio</param>
        /// <param name="notifyApiVersion">Versión de la API de notifiaciones para recibir avisos por web-service</param>
        /// <param name="expiresDate">Fecha de expiración del cobro. Pasada esta fecha el cobro es inválido. Formato ISO-8601. Ej: 2017-03-01T13:00:00Z</param>
        /// <param name="sendEmail">Si es &#39;true&#39;, se enviará una solicitud de cobro al correo especificado en &#39;payer_email&#39;</param>
        /// <param name="payerName">Nombre del pagador. Es obligatorio cuando send_email es &#39;true&#39;</param>
        /// <param name="payerEmail">Correo del pagador. Es obligatorio cuando send_email es &#39;true&#39;</param>
        /// <param name="sendReminders">Si es &#39;true&#39;, se enviarán recordatorios de cobro.</param>
        /// <param name="responsibleUserEmail">Correo electrónico del responsable de este cobro, debe corresponder a un usuario khipu con permisos para cobrar usando esta cuenta de cobro</param>
        /// <param name="fixedPayerPersonalIdentifier">Identificador personal. Si se especifica, solo podrá ser pagado usando ese identificador</param>
        /// <param name="integratorFee">Comisión para el integrador. Sólo es válido si la cuenta de cobro tiene una cuenta de integrador asociada</param>
        /// <returns>PaymentsCreateResponse</returns>
        public async System.Threading.Tasks.Task<PaymentsCreateResponse> PaymentsPostAsync (string subject, string currency, double? amount, string transactionId = null, string custom = null, string body = null, string bankId = null, string returnUrl = null, string cancelUrl = null, string pictureUrl = null, string notifyUrl = null, string contractUrl = null, string notifyApiVersion = null, DateTime? expiresDate = null, bool? sendEmail = null, string payerName = null, string payerEmail = null, bool? sendReminders = null, string responsibleUserEmail = null, string fixedPayerPersonalIdentifier = null, double? integratorFee = null)
        {
            // verify the required parameter 'subject' is set
            if (subject == null) throw new ApiException(400, "Missing required parameter 'subject' when calling PaymentsPost");
            // verify the required parameter 'currency' is set
            if (currency == null) throw new ApiException(400, "Missing required parameter 'currency' when calling PaymentsPost");
            // verify the required parameter 'amount' is set
            if (amount == null) throw new ApiException(400, "Missing required parameter 'amount' when calling PaymentsPost");
            
    
            var path = "/payments";
    
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
            
            
            
            if (subject != null) formParams.Add("subject", ApiClient.ParameterToString(subject)); // form parameter
            if (currency != null) formParams.Add("currency", ApiClient.ParameterToString(currency)); // form parameter
            if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
            if (transactionId != null) formParams.Add("transaction_id", ApiClient.ParameterToString(transactionId)); // form parameter
            if (custom != null) formParams.Add("custom", ApiClient.ParameterToString(custom)); // form parameter
            if (body != null) formParams.Add("body", ApiClient.ParameterToString(body)); // form parameter
            if (bankId != null) formParams.Add("bank_id", ApiClient.ParameterToString(bankId)); // form parameter
            if (returnUrl != null) formParams.Add("return_url", ApiClient.ParameterToString(returnUrl)); // form parameter
            if (cancelUrl != null) formParams.Add("cancel_url", ApiClient.ParameterToString(cancelUrl)); // form parameter
            if (pictureUrl != null) formParams.Add("picture_url", ApiClient.ParameterToString(pictureUrl)); // form parameter
            if (notifyUrl != null) formParams.Add("notify_url", ApiClient.ParameterToString(notifyUrl)); // form parameter
            if (contractUrl != null) formParams.Add("contract_url", ApiClient.ParameterToString(contractUrl)); // form parameter
            if (notifyApiVersion != null) formParams.Add("notify_api_version", ApiClient.ParameterToString(notifyApiVersion)); // form parameter
            if (expiresDate != null) formParams.Add("expires_date", ApiClient.ParameterToString(expiresDate)); // form parameter
            if (sendEmail != null) formParams.Add("send_email", ApiClient.ParameterToString(sendEmail)); // form parameter
            if (payerName != null) formParams.Add("payer_name", ApiClient.ParameterToString(payerName)); // form parameter
            if (payerEmail != null) formParams.Add("payer_email", ApiClient.ParameterToString(payerEmail)); // form parameter
            if (sendReminders != null) formParams.Add("send_reminders", ApiClient.ParameterToString(sendReminders)); // form parameter
            if (responsibleUserEmail != null) formParams.Add("responsible_user_email", ApiClient.ParameterToString(responsibleUserEmail)); // form parameter
            if (fixedPayerPersonalIdentifier != null) formParams.Add("fixed_payer_personal_identifier", ApiClient.ParameterToString(fixedPayerPersonalIdentifier)); // form parameter
            if (integratorFee != null) formParams.Add("integrator_fee", ApiClient.ParameterToString(integratorFee)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsPost: " + response.Content, response.Content);

            return (PaymentsCreateResponse) ApiClient.Deserialize(response.Content, typeof(PaymentsCreateResponse), response.Headers);
        }
        
        /// <summary>
        /// Obtener información de un pago Información completa del pago. Datos con los que fue creado y el estado actual del pago.
        /// </summary>
        /// <param name="id">Identificador del pago</param> 
        /// <returns>PaymentsResponse</returns>            
        public PaymentsResponse PaymentsIdGet (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentsIdGet");
            
    
            var path = "/payments/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (PaymentsResponse) ApiClient.Deserialize(response.Content, typeof(PaymentsResponse), response.Headers);
        }
    
        /// <summary>
        /// Obtener información de un pago Información completa del pago. Datos con los que fue creado y el estado actual del pago.
        /// </summary>
        /// <param name="id">Identificador del pago</param>
        /// <returns>PaymentsResponse</returns>
        public async System.Threading.Tasks.Task<PaymentsResponse> PaymentsIdGetAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentsIdGet");
            
    
            var path = "/payments/{id}";
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsIdGet: " + response.Content, response.Content);

            return (PaymentsResponse) ApiClient.Deserialize(response.Content, typeof(PaymentsResponse), response.Headers);
        }
        
        /// <summary>
        /// Borrar un pago Solo se pueden borrar pagos que estén pendientes de pagar. Esta operación no puede deshacerse.
        /// </summary>
        /// <param name="id">Identificador del pago</param> 
        /// <returns>SuccessResponse</returns>            
        public SuccessResponse PaymentsIdDelete (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentsIdDelete");
            
    
            var path = "/payments/{id}";
    
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SuccessResponse) ApiClient.Deserialize(response.Content, typeof(SuccessResponse), response.Headers);
        }
    
        /// <summary>
        /// Borrar un pago Solo se pueden borrar pagos que estén pendientes de pagar. Esta operación no puede deshacerse.
        /// </summary>
        /// <param name="id">Identificador del pago</param>
        /// <returns>SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> PaymentsIdDeleteAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentsIdDelete");
            
    
            var path = "/payments/{id}";
    
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
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsIdDelete: " + response.Content, response.Content);

            return (SuccessResponse) ApiClient.Deserialize(response.Content, typeof(SuccessResponse), response.Headers);
        }
        
        /// <summary>
        /// Reembolsar total o parcialmente un pago Reembolsa total o parcialmente el monto de un pago. Esta operación solo se puede realizar en los comercios que recauden en cuenta khipu y antes de la rendición de los fondos correspondientes.
        /// </summary>
        /// <param name="id">Identificador del pago</param> 
        /// <param name="amount">El monto a devolver. Sin separador de miles y usando &#39;.&#39; como separador de decimales. Hasta 4 lugares decimales, dependiendo de la moneda. Si se omite el reembolso se hará por el total del monto del pago.</param> 
        /// <returns>SuccessResponse</returns>            
        public SuccessResponse PaymentsIdRefundsPost (string id, double? amount = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentsIdRefundsPost");
            
    
            var path = "/payments/{id}/refunds";
    
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
            
            
            
            if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsIdRefundsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsIdRefundsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SuccessResponse) ApiClient.Deserialize(response.Content, typeof(SuccessResponse), response.Headers);
        }
    
        /// <summary>
        /// Reembolsar total o parcialmente un pago Reembolsa total o parcialmente el monto de un pago. Esta operación solo se puede realizar en los comercios que recauden en cuenta khipu y antes de la rendición de los fondos correspondientes.
        /// </summary>
        /// <param name="id">Identificador del pago</param>
        /// <param name="amount">El monto a devolver. Sin separador de miles y usando &#39;.&#39; como separador de decimales. Hasta 4 lugares decimales, dependiendo de la moneda. Si se omite el reembolso se hará por el total del monto del pago.</param>
        /// <returns>SuccessResponse</returns>
        public async System.Threading.Tasks.Task<SuccessResponse> PaymentsIdRefundsPostAsync (string id, double? amount = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PaymentsIdRefundsPost");
            
    
            var path = "/payments/{id}/refunds";
    
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
            
            
            
            if (amount != null) formParams.Add("amount", ApiClient.ParameterToString(amount)); // form parameter
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "khipu" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PaymentsIdRefundsPost: " + response.Content, response.Content);

            return (SuccessResponse) ApiClient.Deserialize(response.Content, typeof(SuccessResponse), response.Headers);
        }
        
    }
    
}
