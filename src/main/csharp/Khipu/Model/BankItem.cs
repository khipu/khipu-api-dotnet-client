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
  public class BankItem {
    
    /// <summary>
    /// Identificador del banco
    /// </summary>
    /// <value>Identificador del banco</value>
    [DataMember(Name="bank_id", EmitDefaultValue=false)]
    public string BankId { get; set; }

    
    /// <summary>
    /// Nombre del banco
    /// </summary>
    /// <value>Nombre del banco</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Mensaje con particularidades del banco
    /// </summary>
    /// <value>Mensaje con particularidades del banco</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    public string Message { get; set; }

    
    /// <summary>
    /// Monto mínimo que acepta el banco en un pago
    /// </summary>
    /// <value>Monto mínimo que acepta el banco en un pago</value>
    [DataMember(Name="min_amount", EmitDefaultValue=false)]
    public double? MinAmount { get; set; }

    
    /// <summary>
    /// Tipo de banco
    /// </summary>
    /// <value>Tipo de banco</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// Identificador del banco padre (si un banco tiene banca personas y empresas, el primero será el padre del segundo)
    /// </summary>
    /// <value>Identificador del banco padre (si un banco tiene banca personas y empresas, el primero será el padre del segundo)</value>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    public string Parent { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BankItem {\n");
      
      sb.Append("  BankId: ").Append(BankId).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Message: ").Append(Message).Append("\n");
      
      sb.Append("  MinAmount: ").Append(MinAmount).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      
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
