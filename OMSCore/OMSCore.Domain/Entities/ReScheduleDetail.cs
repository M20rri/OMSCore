using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Index("AWBNo", "IsActive", Name = "IDX_ReScheduleDetails")]
[Index("AWBNo", Name = "IDX_ReScheduleDetails_AWBNo")]
[Index("TicketId", Name = "IDX_ReScheduleDetails_TicketId")]
public partial class ReScheduleDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(10)]
    public string RescheduleDate { get; set; }

    public bool? IsActive { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DriverId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(255)]
    public string InsertedBy { get; set; }

    [StringLength(255)]
    public string UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [Column(TypeName = "int(11)")]
    public int? DeliveryTimeSlotId { get; set; }
}
