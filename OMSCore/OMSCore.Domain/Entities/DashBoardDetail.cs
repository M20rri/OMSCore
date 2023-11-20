using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

public partial class DashBoardDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingOrderCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingOrderBatchCount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PickSyncNAVItem { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PickSyncOFSItem { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingPickSyncWMSItem { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingForPickItem { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingOrderLine { get; set; }

    [Column(TypeName = "int(11)")]
    public int? LastHoursOrderHit { get; set; }

    [Column(TypeName = "int(11)")]
    public int? LastHourOrderDistinct { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TodayOrder { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Order1DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Order2DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Order3DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Order4DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Order5DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Order6DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TodayOrderLine { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderLine1DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderLine2DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderLine3DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderLine4DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderLine5DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? OrderLine6DayBefore { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingConversionLine { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingBatchCreationLine { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingOrderAllocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingBoxCreation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendigManifest { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendigDriverAllocation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingDelivery { get; set; }

    [Column(TypeName = "int(11)")]
    public int? BoxDetailSyncToNAV { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingSalesOrderCreationNAV { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PendingSalesOrderPostingNAV { get; set; }

    [Column(TypeName = "int(11)")]
    public int? GetEntry { get; set; }

    [Column(TypeName = "int(11)")]
    public int? QualityCheck { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InprocessQC { get; set; }

    [Column(TypeName = "int(11)")]
    public int? InventrySync { get; set; }

    [Column(TypeName = "int(11)")]
    public int? FinanceSync { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PutAway { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RefundAssignment { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RefundProcess { get; set; }

    [Column(TypeName = "int(11)")]
    public int? RefundApprove { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReturnSalesOrderPosting { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReturnSalesOrderCreation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? WarehouseItemJournal { get; set; }

    [Column(TypeName = "int(11)")]
    public int? WarehouseItemJournalError { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemJournal { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemJournalError { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReturnInventryToWHJournal { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReturnInventryToWHJournalError { get; set; }

    [Column(TypeName = "int(11)")]
    public int? GeneralJournal { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SalesInvoiceCreation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SalesInvoicePosting { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PickRegister { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PutAwayRegister { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReturnOrderCreation { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ReturnOrderPosting { get; set; }

    [Column(TypeName = "int(11)")]
    public int? POApprovalPending { get; set; }

    [Column(TypeName = "int(11)")]
    public int? POExpired { get; set; }

    [Column(TypeName = "int(11)")]
    public int? POExpireNext2Days { get; set; }

    [Column(TypeName = "int(11)")]
    public int? POExpireNext7Days { get; set; }

    [Column(TypeName = "int(11)")]
    public int? POPartialReceived { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TOApprovalPending { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TOPartialReceived { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TOPartialShipped { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SerialExpired { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SerialExpiredNext2Days { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SerialExpiredNext7Days { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Location { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? LotDiffWMSvsNAV { get; set; }

    [Column(TypeName = "int(11)")]
    public int? LotDiffNAVvsWMS { get; set; }

    [Column(TypeName = "int(11)")]
    public int? MovementJournal { get; set; }

    [Column(TypeName = "int(11)")]
    public int? MovementJournalPendingApproval { get; set; }

    [Column(TypeName = "int(11)")]
    public int? MovementJournalError { get; set; }
}
