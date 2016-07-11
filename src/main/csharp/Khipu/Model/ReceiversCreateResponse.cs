using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Khipu.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ReceiversCreateResponse {
    
    /// <summary>
    /// Identificador único de la cuenta de cobro
    /// </summary>
    /// <value>Identificador único de la cuenta de cobro</value>
    [DataMember(Name="receiver_id", EmitDefaultValue=false)]
    public string ReceiverId { get; set; }

    
    /// <summary>
    /// Llave secreta de la cuenta de cobro, se usa para firmar todas las peticiones
    /// </summary>
    /// <value>Llave secreta de la cuenta de cobro, se usa para firmar todas las peticiones</value>
    [DataMember(Name="secret", EmitDefaultValue=false)]
    public string Secret { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReceiversCreateResponse {\n");
      
      sb.Append("  ReceiverId: ").Append(ReceiverId).Append("\n");
      
      sb.Append("  Secret: ").Append(Secret).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
