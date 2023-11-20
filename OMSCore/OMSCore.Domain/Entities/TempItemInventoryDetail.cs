using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Table("TempItemInventoryDetail")]
[Index("TransactionNo", "ItemNo", "ItemCategoryCode", "Brand", Name = "IDX_TransactionNoItemNo")]
[Index("ItemNo", Name = "index_ItemNo")]
public partial class TempItemInventoryDetail
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TransactionNo { get; set; }

    [StringLength(50)]
    public string ItemNo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TotalQuantity { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AvailableQuantity { get; set; }

    [StringLength(250)]
    public string Description { get; set; }

    [StringLength(250)]
    public string Description2 { get; set; }

    [StringLength(250)]
    public string ItemCategoryCode { get; set; }

    [StringLength(250)]
    public string ProductGroupCode { get; set; }

    [StringLength(250)]
    public string Category3 { get; set; }

    [StringLength(250)]
    public string Category4 { get; set; }

    [StringLength(250)]
    public string Brand { get; set; }

    [Column(TypeName = "int(11)")]
    public int InsertedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InsertedOn { get; set; }
}
