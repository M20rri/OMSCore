using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("PaymentGatewayMaster")]
[Index("GatewayID", "IsActive", "IsForward", Name = "IDX_PaymentGatewayMaster")]
[Index("GatewayName", Name = "IDX_PaymentGatewayMaster_GatewayName")]
public partial class PaymentGatewayMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int GatewayID { get; set; }

    [StringLength(45)]
    public string GatewayName { get; set; }

    [StringLength(100)]
    public string PaymentType { get; set; }

    [Required]
    public bool? IsTransactionIDMandatory { get; set; }

    [Required]
    public bool? IsAuthorizeNoMandatory { get; set; }

    [Required]
    public bool? IsForward { get; set; }

    [Required]
    public bool? IsReturn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InsertedOn { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }

    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Required]
    public bool? IsActive { get; set; }

    public bool? IsAccountNo { get; set; }

    public bool? IsSwiftCode { get; set; }

    public bool? IsBankName { get; set; }

    public bool? IsIFSCCode { get; set; }

    public bool? IsMandatetory1 { get; set; }

    public bool? IsMandatetory2 { get; set; }

    [Column(TypeName = "enum('G/L Account','Customer','Vendor','Bank Account','Fixed Asset','IC Partner')")]
    public string AccountType { get; set; }

    [StringLength(100)]
    public string AccountNumber { get; set; }

    public bool? IsBC { get; set; }

    public bool? IsTransactionDate { get; set; }

    public bool? IsCashAccount { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsMangement { get; set; }

    public bool? IsChangePayment { get; set; }

    public bool? IsSearchFilter { get; set; }

    public bool? IsRefundEnable { get; set; }

    public bool? IsBCToCash { get; set; }

    public bool? IsExchangeable { get; set; }

    public bool? ApprovalRequired { get; set; }

    public bool? CheckExchangeThreshold { get; set; }

    public bool? IsEditAllow { get; set; }

    [Precision(10, 5)]
    public decimal? CollectionChargePercent { get; set; }

    [Precision(10, 5)]
    public decimal? FixedCollectionCharge { get; set; }

    [Precision(10, 5)]
    public decimal? VatPercent { get; set; }

    [Column(TypeName = "enum('Fixed','Variable','Mixed')")]
    public string CollectionType { get; set; }

    public bool? CollectionInvReq { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CompanyId { get; set; }
}
