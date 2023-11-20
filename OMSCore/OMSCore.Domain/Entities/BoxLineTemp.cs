using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("BoxLineTemp")]
[Index("BoxID", Name = "IDX_BoxLineTemp_BoxID")]
[Index("BoxID", "ItemNo", Name = "INDEX_BoxLineTemp")]
[Index("WebOrderNo", "ItemId", Name = "INDEX_BoxLineTemp_WeborderNoItemId")]
[Index("WebOrderNo", Name = "INDEX_InboundOrderAddress_WeborderNo")]
public partial class BoxLineTemp
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ItemId { get; set; }

    [Column(TypeName = "int(5)")]
    public int? BatchId { get; set; }

    [StringLength(20)]
    public string ItemNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [StringLength(50)]
    public string BoxID { get; set; }

    [StringLength(20)]
    public string DspCode { get; set; }

    [StringLength(20)]
    public string AWBNo { get; set; }

    [StringLength(20)]
    public string InvoiceNo { get; set; }

    [StringLength(45)]
    public string ReferanceOrderNo { get; set; }

    [StringLength(100)]
    public string BundleID { get; set; }

    [StringLength(100)]
    public string BundleSeqID { get; set; }

    [StringLength(20)]
    public string SerialNo { get; set; }

    [StringLength(20)]
    public string LotNo { get; set; }
}
