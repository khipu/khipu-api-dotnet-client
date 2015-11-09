using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;
using System.Security.Cryptography;

namespace Khipu.Client
{
    /// <summary>
    /// API client is mainly responible for making the HTTP call to the API backend.
    /// </summary>
    public class ApiClient
    {
        private readonly Dictionary<String, String> _defaultHeaderMap = new Dictionary<String, String>();
  
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClient" /> class.
        /// </summary>
        /// <param name="basePath">The base path.</param>
        public ApiClient(String basePath="https://khipu.com/api/2.0")
        {
            BasePath = basePath;
            RestClient = new RestClient(BasePath);
        }
    
        /// <summary>
        /// Gets or sets the base path.
        /// </summary>
        /// <value>The base path</value>
        public string BasePath { get; set; }
    
        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        public RestClient RestClient { get; set; }
    
        /// <summary>
        /// Gets the default header.
        /// </summary>
        public Dictionary<String, String> DefaultHeader
        {
            get { return _defaultHeaderMap; }
        }

        /// <summary>
        /// Gets the status code of the previous request
        /// </summary>
        public int StatusCode { get; private set; }

        /// <summary>
        /// Gets the response headers of the previous request
        /// </summary>
        public Dictionary<String, String> ResponseHeaders { get; private set; } 
    
        // Creates and sets up a RestRequest prior to a call.
        private RestRequest PrepareRequest(
            String path, RestSharp.Method method, Dictionary<String, String> queryParams, String postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams, String[] authSettings)
        {
            var request = new RestRequest(path, method);

            String epath = path;
            foreach(var v in pathParams)
                epath = epath.Replace("{" + v.Key + "}", v.Value);
   
            UpdateParamsForAuth(epath, method, queryParams, headerParams, formParams, authSettings);

            // add default header, if any
            foreach(var defaultHeader in _defaultHeaderMap)
                request.AddHeader(defaultHeader.Key, defaultHeader.Value);

            // add path parameter, if any
            foreach(var param in pathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment); 

            // add header parameter, if any
            foreach(var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            // add query parameter, if any
            foreach(var param in queryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // add form parameter, if any
            foreach(var param in formParams)
                request.AddParameter(param.Key, param.Value);

            // add file parameter, if any
            foreach(var param in fileParams)
                request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentType);

            if (postBody != null) // http body (model) parameter
                request.AddParameter("application/json", postBody, ParameterType.RequestBody);
    
            return request;
        }

        /// <summary>
        /// Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="authSettings">Authentication settings.</param>
        /// <returns>Object</returns>
        public Object CallApi(
            String path, RestSharp.Method method, Dictionary<String, String> queryParams, String postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams, String[] authSettings)
        {
            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            var response = RestClient.Execute(request);
            StatusCode = (int) response.StatusCode;
            ResponseHeaders = response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());
            return (Object) response;
        }

        /// <summary>
        /// Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="authSettings">Authentication settings.</param>
        /// <returns>The Task instance.</returns>
        public async System.Threading.Tasks.Task<Object> CallApiAsync(
            String path, RestSharp.Method method, Dictionary<String, String> queryParams, String postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams, String[] authSettings)
        {
            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            var response = await RestClient.ExecuteTaskAsync(request);
            StatusCode = (int)response.StatusCode;
            ResponseHeaders = response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());
            return (Object)response;
        }
    
        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        public void AddDefaultHeader(string key, string value)
        {
            _defaultHeaderMap.Add(key, value);
        }
    
        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="str">String to be escaped.</param>
        /// <returns>Escaped string.</returns>
        public string EscapeString(string str)
        {
            return RestSharp.Extensions.StringExtensions.UrlEncode(str);
        }
    
        /// <summary>
        /// Create FileParameter based on Stream.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        public FileParameter ParameterToFile(string name, Stream stream)
        {
            if (stream is FileStream)
                return FileParameter.Create(name, stream.ReadAsBytes(), Path.GetFileName(((FileStream)stream).Name));
            else
                return FileParameter.Create(name, stream.ReadAsBytes(), "no_file_name_provided");
        }
    
        /// <summary>
        /// If parameter is DateTime, output in ISO8601 format.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            if (obj is DateTime)
                return ((DateTime)obj).ToString ("yyyy-MM-ddTHH:mm:ss.fffK");
            else if (obj is IList) {
                string flattenString = "";
                string separator = ",";
                foreach (var param in (IList)obj) {
                    flattenString += param.ToString() + separator;
                }
                return flattenString.Remove(flattenString.Length - 1);;
            }
            else
                return Convert.ToString (obj);
        }
    
        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="content">HTTP body (e.g. string, JSON).</param>
        /// <param name="type">Object type.</param>
        /// <param name="headers"></param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize(string content, Type type, IList<Parameter> headers=null)
        {
            if (type == typeof(Object)) // return an object
            {
                return content;
            }

            if (type == typeof(Stream))
            {
                var filePath = String.IsNullOrEmpty(Configuration.TempFolderPath)
                    ? Path.GetTempPath()
                    : Configuration.TempFolderPath;

                var fileName = filePath + Guid.NewGuid();
                if (headers != null)
                {
                    var regex = new Regex(@"Content-Disposition:.*filename=['""]?([^'""\s]+)['""]?$");
                    var match = regex.Match(headers.ToString());
                    if (match.Success)
                        fileName = filePath + match.Value.Replace("\"", "").Replace("'", "");
                }
                File.WriteAllText(fileName, content);
                return new FileStream(fileName, FileMode.Open);

            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(content,  null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(String) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return ConvertType(content, type); 
            }
    
            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(content, type);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }
    
        /// <summary>
        /// Serialize an object into JSON string.
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public string Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }
    
        /// <summary>
        /// Get the API key with prefix.
        /// </summary>
        /// <param name="apiKeyIdentifier">API key identifier (authentication scheme).</param>
        /// <returns>API key with prefix.</returns>
        public string GetApiKeyWithPrefix (string apiKeyIdentifier)
        {
            var apiKeyValue = "";
            Configuration.ApiKey.TryGetValue (apiKeyIdentifier, out apiKeyValue);
            var apiKeyPrefix = "";
            if (Configuration.ApiKeyPrefix.TryGetValue (apiKeyIdentifier, out apiKeyPrefix))
                return apiKeyPrefix + " " + apiKeyValue;
            else
                return apiKeyValue;
        }

        /// <summary>
        /// Calculates hmac
        /// </summary>
        /// <param name="secret">Secret.</param>
        /// <param name="data">Data.</param>
        public String HmacSha256(string secret, string data){
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret))) {
                byte[] hashValue = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString (hashValue).Replace("-", string.Empty).ToLower();
            }
        }

        /// <summary>
        /// Calculates the khipu auth header value
        /// </summary>
        /// <param name="path">Request path.</param>
        /// <param name="method">Request method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        public String AuthHeader(String path, RestSharp.Method method, Dictionary<String, String> queryParams, Dictionary<String, String> formParams) {
            Dictionary<String, String> ps = new Dictionary<String, String>();
            queryParams.ToList().ForEach(x => ps[x.Key] = x.Value);
            formParams.ToList().ForEach(x => ps[x.Key] = x.Value);

            List<String> keys = new List<String>(ps.Keys.OrderBy(q => q));
            String toSign = method + "&" + Uri.EscapeDataString(BasePath + path);

            foreach(var key in keys)
                toSign += "&" + Uri.EscapeDataString(key) + "=" + Uri.EscapeDataString(ps[key]);

            String hmac = HmacSha256(Configuration.Secret, toSign);
            return Configuration.ReceiverId + ":" + hmac;
        }
    
        /// <summary>
        /// Update parameters based on authentication.
        /// </summary>
        /// <param name="path">Request path.</param>
        /// <param name="method">Request method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="authSettings">Authentication settings.</param>
        public void UpdateParamsForAuth(String path, RestSharp.Method method, Dictionary<String, String> queryParams, Dictionary<String, String> headerParams, Dictionary<String, String> formParams, string[] authSettings)
        {
            if (authSettings == null || authSettings.Length == 0)
                return;

            foreach (string auth in authSettings)
            {
                // determine which one to use
                switch(auth)
                {
                    
                    case "khipu":
                        
                        
                        headerParams["Authorization"] = AuthHeader(path, method, queryParams, formParams);
                        break;
                    
                    default:
                        //TODO show warning about security definition not found
                        break;
                }
            }
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public String SelectHeaderAccept(String[] accepts) {
            if (accepts.Length == 0)
                return null;
            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";
            return String.Join(",", accepts);
        }
 
        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            var textByte = System.Text.Encoding.UTF8.GetBytes(text);
            return System.Convert.ToBase64String(textByte);
        }
    
        /// <summary>
        /// Dynamically cast the object into target type.
        /// Ref: http://stackoverflow.com/questions/4925718/c-dynamic-runtime-cast
        /// </summary>
        /// <param name="source">Object to be casted</param>
        /// <param name="dest">Target type</param>
        /// <returns>Casted object</returns>
        public static dynamic ConvertType(dynamic source, Type dest) {
            return Convert.ChangeType(source, dest);
        }
  
    }
}
