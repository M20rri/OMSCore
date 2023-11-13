using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

public partial class tempOrder
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int ID { get; set; }

    [StringLength(250)]
    public string ORDERNO { get; set; }

    [StringLength(250)]
    public string STATUS { get; set; }

    [Column(TypeName = "int(11)")]
    public int? SUCCESS { get; set; }

    [StringLength(250)]
    public string MESSAGE { get; set; }
}
