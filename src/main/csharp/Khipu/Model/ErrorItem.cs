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
  public class ErrorItem {
    
    /// <summary>
    /// Campo que tiene el error de validación
    /// </summary>
    /// <value>Campo que tiene el error de validación</value>
    [DataMember(Name="field", EmitDefaultValue=false)]
    public string Field { get; set; }

    
    /// <summary>
    /// Motivo del error de validación
    /// </summary>
    /// <value>Motivo del error de validación</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ErrorItem {\n");
      
      sb.Append("  Field: ").Append(Field).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
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
