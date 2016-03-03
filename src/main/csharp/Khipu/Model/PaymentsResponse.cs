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
    /// Gets or Sets NotificationToken
    /// </summary>
    [DataMember(Name="notification_token", EmitDefaultValue=false)]
    public string NotificationToken { get; set; }

    
    /// <summary>
    /// Gets or Sets ReceiverId
    /// </summary>
    [DataMember(Name="receiver_id", EmitDefaultValue=false)]
    public long? ReceiverId { get; set; }

    
    /// <summary>
    /// Gets or Sets ConciliationDate
    /// </summary>
    [DataMember(Name="conciliation_date", EmitDefaultValue=false)]
    public DateTime? ConciliationDate { get; set; }

    
    /// <summary>
    /// Gets or Sets Subject
    /// </summary>
    [DataMember(Name="subject", EmitDefaultValue=false)]
    public string Subject { get; set; }

    
    /// <summary>
    /// Gets or Sets Amount
    /// </summary>
    [DataMember(Name="amount", EmitDefaultValue=false)]
    public double? Amount { get; set; }

    
    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    public string Currency { get; set; }

    
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    /// <summary>
    /// Gets or Sets StatusDetail
    /// </summary>
    [DataMember(Name="status_detail", EmitDefaultValue=false)]
    public string StatusDetail { get; set; }

    
    /// <summary>
    /// Gets or Sets Body
    /// </summary>
    [DataMember(Name="body", EmitDefaultValue=false)]
    public string Body { get; set; }

    
    /// <summary>
    /// Gets or Sets PictureUrl
    /// </summary>
    [DataMember(Name="picture_url", EmitDefaultValue=false)]
    public string PictureUrl { get; set; }

    
    /// <summary>
    /// Gets or Sets ReceiptUrl
    /// </summary>
    [DataMember(Name="receipt_url", EmitDefaultValue=false)]
    public string ReceiptUrl { get; set; }

    
    /// <summary>
    /// Gets or Sets ReturnUrl
    /// </summary>
    [DataMember(Name="return_url", EmitDefaultValue=false)]
    public string ReturnUrl { get; set; }

    
    /// <summary>
    /// Gets or Sets CancelUrl
    /// </summary>
    [DataMember(Name="cancel_url", EmitDefaultValue=false)]
    public string CancelUrl { get; set; }

    
    /// <summary>
    /// Gets or Sets NotifyUrl
    /// </summary>
    [DataMember(Name="notify_url", EmitDefaultValue=false)]
    public string NotifyUrl { get; set; }

    
    /// <summary>
    /// Gets or Sets NotifyApiVersion
    /// </summary>
    [DataMember(Name="notify_api_version", EmitDefaultValue=false)]
    public string NotifyApiVersion { get; set; }

    
    /// <summary>
    /// Gets or Sets ExpiresDate
    /// </summary>
    [DataMember(Name="expires_date", EmitDefaultValue=false)]
    public DateTime? ExpiresDate { get; set; }

    
    /// <summary>
    /// Gets or Sets AttachmentUrls
    /// </summary>
    [DataMember(Name="attachment_urls", EmitDefaultValue=false)]
    public List<string> AttachmentUrls { get; set; }

    
    /// <summary>
    /// Gets or Sets Bank
    /// </summary>
    [DataMember(Name="bank", EmitDefaultValue=false)]
    public string Bank { get; set; }

    
    /// <summary>
    /// Gets or Sets BankId
    /// </summary>
    [DataMember(Name="bank_id", EmitDefaultValue=false)]
    public string BankId { get; set; }

    
    /// <summary>
    /// Gets or Sets PayerName
    /// </summary>
    [DataMember(Name="payer_name", EmitDefaultValue=false)]
    public string PayerName { get; set; }

    
    /// <summary>
    /// Gets or Sets PayerEmail
    /// </summary>
    [DataMember(Name="payer_email", EmitDefaultValue=false)]
    public string PayerEmail { get; set; }

    
    /// <summary>
    /// Gets or Sets PersonalIdentifier
    /// </summary>
    [DataMember(Name="personal_identifier", EmitDefaultValue=false)]
    public string PersonalIdentifier { get; set; }

    
    /// <summary>
    /// Gets or Sets BankAccountNumber
    /// </summary>
    [DataMember(Name="bank_account_number", EmitDefaultValue=false)]
    public string BankAccountNumber { get; set; }

    
    /// <summary>
    /// Gets or Sets OutOfDateConciliation
    /// </summary>
    [DataMember(Name="out_of_date_conciliation", EmitDefaultValue=false)]
    public bool? OutOfDateConciliation { get; set; }

    
    /// <summary>
    /// Gets or Sets TransactionId
    /// </summary>
    [DataMember(Name="transaction_id", EmitDefaultValue=false)]
    public string TransactionId { get; set; }

    
    /// <summary>
    /// Gets or Sets Custom
    /// </summary>
    [DataMember(Name="custom", EmitDefaultValue=false)]
    public string Custom { get; set; }

    
    /// <summary>
    /// Gets or Sets ResponsibleUserEmail
    /// </summary>
    [DataMember(Name="responsible_user_email", EmitDefaultValue=false)]
    public string ResponsibleUserEmail { get; set; }

    
    /// <summary>
    /// Gets or Sets SendReminders
    /// </summary>
    [DataMember(Name="send_reminders", EmitDefaultValue=false)]
    public bool? SendReminders { get; set; }

    
    /// <summary>
    /// Gets or Sets SendEmail
    /// </summary>
    [DataMember(Name="send_email", EmitDefaultValue=false)]
    public bool? SendEmail { get; set; }

    

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
