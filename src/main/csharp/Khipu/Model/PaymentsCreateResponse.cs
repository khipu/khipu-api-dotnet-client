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
  public class PaymentsCreateResponse {
    
    /// <summary>
    /// Identificador único del pago, es una cadena alfanumérica de 12 caracteres
    /// </summary>
    /// <value>Identificador único del pago, es una cadena alfanumérica de 12 caracteres</value>
    [DataMember(Name="payment_id", EmitDefaultValue=false)]
    public string PaymentId { get; set; }

    
    /// <summary>
    /// URL principal del pago, si el usuario no ha elegido previamente un método de pago se le muestran las opciones
    /// </summary>
    /// <value>URL principal del pago, si el usuario no ha elegido previamente un método de pago se le muestran las opciones</value>
    [DataMember(Name="payment_url", EmitDefaultValue=false)]
    public string PaymentUrl { get; set; }

    
    /// <summary>
    /// URL de pago simplificado
    /// </summary>
    /// <value>URL de pago simplificado</value>
    [DataMember(Name="simplified_transfer_url", EmitDefaultValue=false)]
    public string SimplifiedTransferUrl { get; set; }

    
    /// <summary>
    /// URL de pago normal
    /// </summary>
    /// <value>URL de pago normal</value>
    [DataMember(Name="transfer_url", EmitDefaultValue=false)]
    public string TransferUrl { get; set; }

    
    /// <summary>
    /// URL de pago usando Webpay
    /// </summary>
    /// <value>URL de pago usando Webpay</value>
    [DataMember(Name="webpay_url", EmitDefaultValue=false)]
    public string WebpayUrl { get; set; }

    
    /// <summary>
    /// URL de pago usando Hites
    /// </summary>
    /// <value>URL de pago usando Hites</value>
    [DataMember(Name="hites_url", EmitDefaultValue=false)]
    public string HitesUrl { get; set; }

    
    /// <summary>
    /// URL de pago usando Hites
    /// </summary>
    /// <value>URL de pago usando Hites</value>
    [DataMember(Name="payme_url", EmitDefaultValue=false)]
    public string PaymeUrl { get; set; }

    
    /// <summary>
    /// URL para invocar el pago desde un dispositivo móvil usando la APP de khipu
    /// </summary>
    /// <value>URL para invocar el pago desde un dispositivo móvil usando la APP de khipu</value>
    [DataMember(Name="app_url", EmitDefaultValue=false)]
    public string AppUrl { get; set; }

    
    /// <summary>
    /// Es 'true' si el pago ya cuenta con todos los datos necesarios para abrir directamente la aplicación de pagos khipu
    /// </summary>
    /// <value>Es 'true' si el pago ya cuenta con todos los datos necesarios para abrir directamente la aplicación de pagos khipu</value>
    [DataMember(Name="ready_for_terminal", EmitDefaultValue=false)]
    public bool? ReadyForTerminal { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentsCreateResponse {\n");
      
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      
      sb.Append("  PaymentUrl: ").Append(PaymentUrl).Append("\n");
      
      sb.Append("  SimplifiedTransferUrl: ").Append(SimplifiedTransferUrl).Append("\n");
      
      sb.Append("  TransferUrl: ").Append(TransferUrl).Append("\n");
      
      sb.Append("  WebpayUrl: ").Append(WebpayUrl).Append("\n");
      
      sb.Append("  HitesUrl: ").Append(HitesUrl).Append("\n");
      
      sb.Append("  PaymeUrl: ").Append(PaymeUrl).Append("\n");
      
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
