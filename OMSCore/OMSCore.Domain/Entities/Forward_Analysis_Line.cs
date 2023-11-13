using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("Forward Analysis Line")]
public partial class Forward_Analysis_Line
{
    [Column("Request ID", TypeName = "int(11)")]
    public int Request_ID { get; set; }

    [Column("Line No", TypeName = "int(11)")]
    public int Line_No { get; set; }

    [Column("Order NO")]
    [StringLength(45)]
    public string Order_NO { get; set; }

    [Column("Item ID")]
    [StringLength(45)]
    public string Item_ID { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(45)]
    public string BoxId { get; set; }

    [StringLength(45)]
    public string BarCode { get; set; }

    [StringLength(45)]
    public string Location { get; set; }

    [Column("Process Error")]
    [StringLength(250)]
    public string Process_Error { get; set; }

    [Column("Process Error1")]
    [StringLength(250)]
    public string Process_Error1 { get; set; }

    [Column("Process Next Step")]
    [StringLength(250)]
    public string Process_Next_Step { get; set; }

    [Column("Process Next Step1")]
    [StringLength(250)]
    public string Process_Next_Step1 { get; set; }

    [Column(TypeName = "int(11)")]
    public int Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }
}
