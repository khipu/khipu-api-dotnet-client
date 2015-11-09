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
  public class CreateResponse {
    
    /// <summary>
    /// Gets or Sets PaymentId
    /// </summary>
    [DataMember(Name="payment_id", EmitDefaultValue=false)]
    public string PaymentId { get; set; }

    
    /// <summary>
    /// Gets or Sets PaymentUrl
    /// </summary>
    [DataMember(Name="payment_url", EmitDefaultValue=false)]
    public string PaymentUrl { get; set; }

    
    /// <summary>
    /// Gets or Sets SimplifiedTransferUrl
    /// </summary>
    [DataMember(Name="simplified_transfer_url", EmitDefaultValue=false)]
    public string SimplifiedTransferUrl { get; set; }

    
    /// <summary>
    /// Gets or Sets TransferUrl
    /// </summary>
    [DataMember(Name="transfer_url", EmitDefaultValue=false)]
    public string TransferUrl { get; set; }

    
    /// <summary>
    /// Gets or Sets AppUrl
    /// </summary>
    [DataMember(Name="app_url", EmitDefaultValue=false)]
    public string AppUrl { get; set; }

    
    /// <summary>
    /// Gets or Sets ReadyForTerminal
    /// </summary>
    [DataMember(Name="ready_for_terminal", EmitDefaultValue=false)]
    public bool? ReadyForTerminal { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateResponse {\n");
      
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      
      sb.Append("  PaymentUrl: ").Append(PaymentUrl).Append("\n");
      
      sb.Append("  SimplifiedTransferUrl: ").Append(SimplifiedTransferUrl).Append("\n");
      
      sb.Append("  TransferUrl: ").Append(TransferUrl).Append("\n");
      
      sb.Append("  AppUrl: ").Append(AppUrl).Append("\n");
      
      sb.Append("  ReadyForTerminal: ").Append(ReadyForTerminal).Append("\n");
      
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
