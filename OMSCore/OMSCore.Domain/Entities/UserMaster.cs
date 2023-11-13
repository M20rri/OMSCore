using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Table("UserMaster")]
[Index("Id", "Blocked", "IsCashier", Name = "IDX_UserMaster_Id")]
[Index("Id", "Department", Name = "IX_UserMaster")]
[Index("Id", Name = "IX_UserMaster_IdIndex")]
[Index("Name", Name = "IX_UserMaster_Name")]
[Index("UserId", Name = "IX_UserMaster_UserId")]
[Index("UserId", "IsLoggedIn", Name = "IX_UserMaster_UserId_IsLoggedIn")]
public partial class UserMaster
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(50)]
    public string UserId { get; set; }

    [StringLength(500)]
    public string Name { get; set; }

    [StringLength(50)]
    public string Department { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Location { get; set; }

    [StringLength(250)]
    public string EmailId { get; set; }

    [StringLength(20)]
    public string Phone { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ManagerId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CrerationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ValidTill { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? Blocked { get; set; }

    [StringLength(500)]
    public string BlockedMessage { get; set; }

    [StringLength(500)]
    public string Password { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsNewPassword { get; set; }

    [Column(TypeName = "int(11)")]
    public int? UpdatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedOn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastActivityTime { get; set; }

    [StringLength(45)]
    public string MachineName { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? IsLoggedIn { get; set; }

    [StringLength(45)]
    public string BrowserName { get; set; }

    [Column(TypeName = "int(11)")]
    public int? PackagingLocation { get; set; }

    [StringLength(100)]
    public string ReturnLocation { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte? QcAdmin { get; set; }

    [StringLength(45)]
    public string SubDepartment { get; set; }

    [Precision(8, 2)]
    public decimal? Amount { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Company { get; set; }

    public bool? IsCashier { get; set; }

    [StringLength(1000)]
    public string HostName { get; set; }
}
