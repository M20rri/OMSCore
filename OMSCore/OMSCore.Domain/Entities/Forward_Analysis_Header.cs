using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("Forward Analysis Header")]
public partial class Forward_Analysis_Header
{
    [Column("Request ID", TypeName = "int(11)")]
    public int Request_ID { get; set; }

    [Column("Request type", TypeName = "int(11)")]
    public int Request_type { get; set; }

    [Column("User Id")]
    [StringLength(45)]
    public string User_Id { get; set; }

    [StringLength(45)]
    public string Location { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [Column(TypeName = "int(11)")]
    public int Status { get; set; }

    [Column("Start Date", TypeName = "datetime")]
    public DateTime Start_Date { get; set; }

    [Column("End Date", TypeName = "datetime")]
    public DateTime End_Date { get; set; }
}
