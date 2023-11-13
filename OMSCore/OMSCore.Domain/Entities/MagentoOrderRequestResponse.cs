using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("MagentoOrderRequestResponse")]
[Index("AppOrderNo", Name = "IDX_MagentoOrderRequestResponse_AppOrderNo")]
[Index("TicketId", Name = "IDX_MagentoOrderRequestResponse_TicketId")]
[Index("TicketType", Name = "IDX_MagentoOrderRequestResponse_TicketType")]
[Index("WebOrderNo", Name = "IDX_MagentoOrderRequestResponse_WebOrderNo")]
public partial class MagentoOrderRequestResponse
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string AppOrderNo { get; set; }

    [StringLength(50)]
    public string TicketId { get; set; }

    [StringLength(50)]
    public string TicketType { get; set; }

    [Column(TypeName = "json")]
    public string SkuJson { get; set; }

    [Column(TypeName = "json")]
    public string ExchangeJson { get; set; }

    [Column(TypeName = "json")]
    public string ReturnJson { get; set; }

    [Column(TypeName = "json")]
    public string OrderResponseJson { get; set; }

    [Column(TypeName = "json")]
    public string OrderRequest { get; set; }

    [Column(TypeName = "json")]
    public string OrderResponse { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsProcessed { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? RetryCount { get; set; }

    [StringLength(500)]
    public string ErrorMessage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }

    [StringLength(50)]
    public string InsertedBy { get; set; }
}
