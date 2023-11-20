﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("PostedReturnQC")]
[Index("DocumentNo", "ReturnType", Name = "IDX_PostedReturnQC")]
[Index("IsSync", Name = "IDX_PostedReturnQC_IsSync")]
[Index("WebOrderNo", "ItemId", Name = "IDX_PostedReturnQC_WebOrderNo_ItemId")]
[Index("InsertedBy", Name = "IX_PostedReturnQC_InsertedBy")]
[Index("QCStatus", Name = "IX_PostedReturnQC_QCStatus")]
[Index("TicketId", Name = "IX_PostedReturnQC_TicketId")]
[Index("ReturnType", "InsertedOn", Name = "idx_ReturnType_InsertedOn")]
public partial class PostedReturnQC
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Key]
    [Column(TypeName = "int(11)")]
    public int ItemId { get; set; }

    [StringLength(50)]
    public string RPCLocation { get; set; }

    [StringLength(50)]
    public string PacketId { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(50)]
    public string ForwardDSPCode { get; set; }

    [Column(TypeName = "enum('','NDR','CIR')")]
    public string ReturnType { get; set; }

    [StringLength(250)]
    public string ItemName { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [StringLength(50)]
    public string SKU { get; set; }

    [StringLength(20)]
    public string RAWBNo { get; set; }

    [StringLength(50)]
    public string ReturnDSPCode { get; set; }

    [Column(TypeName = "enum('','Pass','Fail','Refurnish')")]
    public string QCStatus { get; set; }

    [StringLength(250)]
    public string AgentComment { get; set; }

    [StringLength(250)]
    public string QCRemarks { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? CUID { get; set; }

    [StringLength(50)]
    public string DocumentNo { get; set; }

    [StringLength(45)]
    public string PassBin { get; set; }

    [StringLength(45)]
    public string FailBin { get; set; }

    [StringLength(45)]
    public string RefurnishBin { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ReadyForArchive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(100)]
    public string InsertedBy { get; set; }

    [StringLength(100)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsHeader { get; set; }

    [StringLength(100)]
    public string ReturnCategory { get; set; }

    [StringLength(100)]
    public string ReturnSubCategory { get; set; }

    [Column(TypeName = "int(11)")]
    public int? CustomisationOrder { get; set; }

    [StringLength(100)]
    public string DefectType { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsSync { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SyncedOn { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? ProductsNotReturned { get; set; }

    [StringLength(100)]
    public string ReturnReasonCode { get; set; }

    [StringLength(20)]
    public string Lot { get; set; }

    [StringLength(20)]
    public string SerialNo { get; set; }

    [StringLength(50)]
    public string PickLocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RetryCounter { get; set; }

    [StringLength(200)]
    public string ErrorMessage { get; set; }

    [StringLength(45)]
    public string TableId { get; set; }

    [StringLength(20)]
    public string IsExpired { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    [StringLength(100)]
    public string BarCode { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsUID { get; set; }

    [StringLength(500)]
    public string ReturnReason { get; set; }

    [StringLength(500)]
    public string PNRReason { get; set; }

    [StringLength(100)]
    public string PNRReasonCode { get; set; }
}
