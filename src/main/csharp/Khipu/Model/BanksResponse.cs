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
  public class BanksResponse {
    
    /// <summary>
    /// Gets or Sets Banks
    /// </summary>
    [DataMember(Name="banks", EmitDefaultValue=false)]
    public BankItem Banks { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BanksResponse {\n");
      
      sb.Append("  Banks: ").Append(Banks).Append("\n");
      
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
