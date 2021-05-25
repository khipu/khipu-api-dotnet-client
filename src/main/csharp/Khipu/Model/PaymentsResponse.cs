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
  public class PaymentsResponse {
    
    /// <summary>
    /// Identificador único del pago, es una cadena alfanumérica de 12 caracteres. Cómo este identificador es único, se puede usar, por ejemplo, para evitar procesar una notificación repetida. (Khipu espera un código 200 al notificar un pago, si esto no ocurre se reintenta hasta por dos días).
    /// </summary>
    /// <value>Identificador único del pago, es una cadena alfanumérica de 12 caracteres. Cómo este identificador es único, se puede usar, por ejemplo, para evitar procesar una notificación repetida. (Khipu espera un código 200 al notificar un pago, si esto no ocurre se reintenta hasta por dos días).</value>
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
    /// URL de pago con Webpay
    /// </summary>
    /// <value>URL de pago con Webpay</value>
    [DataMember(Name="webpay_url", EmitDefaultValue=false)]
    public string WebpayUrl { get; set; }

    
    /// <summary>
    /// URL de pago con Hites
    /// </summary>
    /// <value>URL de pago con Hites</value>
    [DataMember(Name="hites_url", EmitDefaultValue=false)]
    public string HitesUrl { get; set; }

    
    /// <summary>
    /// URL de pago con Hites
    /// </summary>
    /// <value>URL de pago con Hites</value>
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
    /// Cadena de caracteres alfanuméricos que identifican unicamente al pago, es el identificador que el servidor de khipu enviará al servidor del comercio cuando notifique que un pago está conciliado
    /// </summary>
    /// <value>Cadena de caracteres alfanuméricos que identifican unicamente al pago, es el identificador que el servidor de khipu enviará al servidor del comercio cuando notifique que un pago está conciliado</value>
    [DataMember(Name="notification_token", EmitDefaultValue=false)]
    public string NotificationToken { get; set; }

    
    /// <summary>
    /// Identificador único de una cuenta de cobro
    /// </summary>
    /// <value>Identificador único de una cuenta de cobro</value>
    [DataMember(Name="receiver_id", EmitDefaultValue=false)]
    public long? ReceiverId { get; set; }

    
    /// <summary>
    /// Fecha y hora de conciliación del pago. Formato ISO-8601. Ej: 2017-03-01T13:00:00Z
    /// </summary>
    /// <value>Fecha y hora de conciliación del pago. Formato ISO-8601. Ej: 2017-03-01T13:00:00Z</value>
    [DataMember(Name="conciliation_date", EmitDefaultValue=false)]
    public DateTime? ConciliationDate { get; set; }

    
    /// <summary>
    /// Motivo del pago
    /// </summary>
    /// <value>Motivo del pago</value>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    public string Subject { get; set; }

    
    /// <summary>
    /// Monto del pago, sin separador de miles y usando '.' como separador de decimales.
    /// </summary>
    /// <value>Monto del pago, sin separador de miles y usando '.' como separador de decimales.</value>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    public double? Amount { get; set; }

    
    /// <summary>
    /// El código de moneda en formato ISO-4217
    /// </summary>
    /// <value>El código de moneda en formato ISO-4217</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    public string Currency { get; set; }

    
    /// <summary>
    /// Estado del pago, puede ser 'pending' (el pagador aún no comienza a pagar), 'verifying' (se está verificando el pago) o 'done', cuando el pago ya está confirmado
    /// </summary>
    /// <value>Estado del pago, puede ser 'pending' (el pagador aún no comienza a pagar), 'verifying' (se está verificando el pago) o 'done', cuando el pago ya está confirmado</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    /// <summary>
    /// Detalle del estado del pago, 'pending' (el pagadon aún no comienza a pagar), 'normal' (el pago fue verificado y fue cancelado por algún medio de pago estandar), 'marked-paid-by-receiver' (el cobrador marco el cobro como pagado por otro medio), 'rejected-by-payer' (el pagador declaró que no pagará), 'marked-as-abuse' (el pagador declaró que no pagará y que el cobro fue no solicitado) y 'reversed' (el pago fue anulado por el comercio, el dinero fue devuelto al pagador).
    /// </summary>
    /// <value>Detalle del estado del pago, 'pending' (el pagadon aún no comienza a pagar), 'normal' (el pago fue verificado y fue cancelado por algún medio de pago estandar), 'marked-paid-by-receiver' (el cobrador marco el cobro como pagado por otro medio), 'rejected-by-payer' (el pagador declaró que no pagará), 'marked-as-abuse' (el pagador declaró que no pagará y que el cobro fue no solicitado) y 'reversed' (el pago fue anulado por el comercio, el dinero fue devuelto al pagador).</value>
    [DataMember(Name="status_detail", EmitDefaultValue=false)]
    public string StatusDetail { get; set; }

    
    /// <summary>
    /// Detalle del cobro
    /// </summary>
    /// <value>Detalle del cobro</value>
    [DataMember(Name="body", EmitDefaultValue=false)]
    public string Body { get; set; }

    
    /// <summary>
    /// URL de cobro
    /// </summary>
    /// <value>URL de cobro</value>
    [DataMember(Name="picture_url", EmitDefaultValue=false)]
    public string PictureUrl { get; set; }

    
    /// <summary>
    /// URL del comprobante de pago
    /// </summary>
    /// <value>URL del comprobante de pago</value>
    [DataMember(Name="receipt_url", EmitDefaultValue=false)]
    public string ReceiptUrl { get; set; }

    
    /// <summary>
    /// URL donde se redirige al pagador luego que termina el pago
    /// </summary>
    /// <value>URL donde se redirige al pagador luego que termina el pago</value>
    [DataMember(Name="return_url", EmitDefaultValue=false)]
    public string ReturnUrl { get; set; }

    
    /// <summary>
    /// URL donde se redirige al pagador luego de que desiste hacer el pago
    /// </summary>
    /// <value>URL donde se redirige al pagador luego de que desiste hacer el pago</value>
    [DataMember(Name="cancel_url", EmitDefaultValue=false)]
    public string CancelUrl { get; set; }

    
    /// <summary>
    /// URL del webservice donde se notificará el pago
    /// </summary>
    /// <value>URL del webservice donde se notificará el pago</value>
    [DataMember(Name="notify_url", EmitDefaultValue=false)]
    public string NotifyUrl { get; set; }

    
    /// <summary>
    /// Versión de la api de notificación
    /// </summary>
    /// <value>Versión de la api de notificación</value>
    [DataMember(Name="notify_api_version", EmitDefaultValue=false)]
    public string NotifyApiVersion { get; set; }

    
    /// <summary>
    /// Fecha de expiración del pago. En formato ISO-8601
    /// </summary>
    /// <value>Fecha de expiración del pago. En formato ISO-8601</value>
    [DataMember(Name="expires_date", EmitDefaultValue=false)]
    public DateTime? ExpiresDate { get; set; }

    
    /// <summary>
    /// URLs de archivos adjuntos al pago
    /// </summary>
    /// <value>URLs de archivos adjuntos al pago</value>
    [DataMember(Name="attachment_urls", EmitDefaultValue=false)]
    public List<string> AttachmentUrls { get; set; }

    
    /// <summary>
    /// Nombre del banco seleccionado por el pagador
    /// </summary>
    /// <value>Nombre del banco seleccionado por el pagador</value>
    [DataMember(Name="bank", EmitDefaultValue=false)]
    public string Bank { get; set; }

    
    /// <summary>
    /// Identificador del banco seleccionado por el pagador
    /// </summary>
    /// <value>Identificador del banco seleccionado por el pagador</value>
    [DataMember(Name="bank_id", EmitDefaultValue=false)]
    public string BankId { get; set; }

    
    /// <summary>
    /// Nombre del pagador
    /// </summary>
    /// <value>Nombre del pagador</value>
    [DataMember(Name="payer_name", EmitDefaultValue=false)]
    public string PayerName { get; set; }

    
    /// <summary>
    /// Correo electrónico del pagador
    /// </summary>
    /// <value>Correo electrónico del pagador</value>
    [DataMember(Name="payer_email", EmitDefaultValue=false)]
    public string PayerEmail { get; set; }

    
    /// <summary>
    /// Identificador personal del pagador
    /// </summary>
    /// <value>Identificador personal del pagador</value>
    [DataMember(Name="personal_identifier", EmitDefaultValue=false)]
    public string PersonalIdentifier { get; set; }

    
    /// <summary>
    /// Número de cuenta bancaria del pagador
    /// </summary>
    /// <value>Número de cuenta bancaria del pagador</value>
    [DataMember(Name="bank_account_number", EmitDefaultValue=false)]
    public string BankAccountNumber { get; set; }

    
    /// <summary>
    /// Es 'true' si la conciliación del pago fue hecha luego de la fecha de expiración
    /// </summary>
    /// <value>Es 'true' si la conciliación del pago fue hecha luego de la fecha de expiración</value>
    [DataMember(Name="out_of_date_conciliation", EmitDefaultValue=false)]
    public bool? OutOfDateConciliation { get; set; }

    
    /// <summary>
    /// Identificador del pago asignado por el cobrador
    /// </summary>
    /// <value>Identificador del pago asignado por el cobrador</value>
    [DataMember(Name="transaction_id", EmitDefaultValue=false)]
    public string TransactionId { get; set; }

    
    /// <summary>
    /// Campo genérico que asigna el cobrador al momento de hacer el pago
    /// </summary>
    /// <value>Campo genérico que asigna el cobrador al momento de hacer el pago</value>
    [DataMember(Name="custom", EmitDefaultValue=false)]
    public string Custom { get; set; }

    
    /// <summary>
    /// Correo electrónico de la persona responsable del pago
    /// </summary>
    /// <value>Correo electrónico de la persona responsable del pago</value>
    [DataMember(Name="responsible_user_email", EmitDefaultValue=false)]
    public string ResponsibleUserEmail { get; set; }

    
    /// <summary>
    /// Es 'true' cuando este es un cobro por correo electrónico y khipu enviará recordatorios
    /// </summary>
    /// <value>Es 'true' cuando este es un cobro por correo electrónico y khipu enviará recordatorios</value>
    [DataMember(Name="send_reminders", EmitDefaultValue=false)]
    public bool? SendReminders { get; set; }

    
    /// <summary>
    /// Es 'true' cuando khipu enviará el cobro por correo electrónico
    /// </summary>
    /// <value>Es 'true' cuando khipu enviará el cobro por correo electrónico</value>
    [DataMember(Name="send_email", EmitDefaultValue=false)]
    public bool? SendEmail { get; set; }

    
    /// <summary>
    /// Método de pago usado por el pagador, puede ser 'regular_transfer' (transferencia normal), 'simplified_transfer' (transferencia simplificada) o 'not_available' (para un pago marcado como realizado por otro medio por el cobrador).
    /// </summary>
    /// <value>Método de pago usado por el pagador, puede ser 'regular_transfer' (transferencia normal), 'simplified_transfer' (transferencia simplificada) o 'not_available' (para un pago marcado como realizado por otro medio por el cobrador).</value>
    [DataMember(Name="payment_method", EmitDefaultValue=false)]
    public string PaymentMethod { get; set; }

    
    /// <summary>
    /// Origen de fondos usado por el pagador, puede ser 'debit' para pago con débito, 'prepaid' para pago con prepago, 'credit' para pago con crédito o vacío en el caso de que se haya pagado mediante transferencia bancaria.
    /// </summary>
    /// <value>Origen de fondos usado por el pagador, puede ser 'debit' para pago con débito, 'prepaid' para pago con prepago, 'credit' para pago con crédito o vacío en el caso de que se haya pagado mediante transferencia bancaria.</value>
    [DataMember(Name="funds_source", EmitDefaultValue=false)]
    public string FundsSource { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentsResponse {\n");
      
      sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
      
      sb.Append("  PaymentUrl: ").Append(PaymentUrl).Append("\n");
      
      sb.Append("  SimplifiedTransferUrl: ").Append(SimplifiedTransferUrl).Append("\n");
      
      sb.Append("  TransferUrl: ").Append(TransferUrl).Append("\n");
      
      sb.Append("  WebpayUrl: ").Append(WebpayUrl).Append("\n");
      
      sb.Append("  HitesUrl: ").Append(HitesUrl).Append("\n");
      
      sb.Append("  PaymeUrl: ").Append(PaymeUrl).Append("\n");
      
      sb.Append("  AppUrl: ").Append(AppUrl).Append("\n");
      
      sb.Append("  ReadyForTerminal: ").Append(ReadyForTerminal).Append("\n");
      
      sb.Append("  NotificationToken: ").Append(NotificationToken).Append("\n");
      
      sb.Append("  ReceiverId: ").Append(ReceiverId).Append("\n");
      
      sb.Append("  ConciliationDate: ").Append(ConciliationDate).Append("\n");
      
      sb.Append("  Subject: ").Append(Subject).Append("\n");
      
      sb.Append("  Amount: ").Append(Amount).Append("\n");
      
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  StatusDetail: ").Append(StatusDetail).Append("\n");
      
      sb.Append("  Body: ").Append(Body).Append("\n");
      
      sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
      
      sb.Append("  ReceiptUrl: ").Append(ReceiptUrl).Append("\n");
      
      sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
      
      sb.Append("  CancelUrl: ").Append(CancelUrl).Append("\n");
      
      sb.Append("  NotifyUrl: ").Append(NotifyUrl).Append("\n");
      
      sb.Append("  NotifyApiVersion: ").Append(NotifyApiVersion).Append("\n");
      
      sb.Append("  ExpiresDate: ").Append(ExpiresDate).Append("\n");
      
      sb.Append("  AttachmentUrls: ").Append(AttachmentUrls).Append("\n");
      
      sb.Append("  Bank: ").Append(Bank).Append("\n");
      
      sb.Append("  BankId: ").Append(BankId).Append("\n");
      
      sb.Append("  PayerName: ").Append(PayerName).Append("\n");
      
      sb.Append("  PayerEmail: ").Append(PayerEmail).Append("\n");
      
      sb.Append("  PersonalIdentifier: ").Append(PersonalIdentifier).Append("\n");
      
      sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
      
      sb.Append("  OutOfDateConciliation: ").Append(OutOfDateConciliation).Append("\n");
      
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
      
      sb.Append("  Custom: ").Append(Custom).Append("\n");
      
      sb.Append("  ResponsibleUserEmail: ").Append(ResponsibleUserEmail).Append("\n");
      
      sb.Append("  SendReminders: ").Append(SendReminders).Append("\n");
      
      sb.Append("  SendEmail: ").Append(SendEmail).Append("\n");
      
      sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
      
      sb.Append("  FundsSource: ").Append(FundsSource).Append("\n");
      
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
