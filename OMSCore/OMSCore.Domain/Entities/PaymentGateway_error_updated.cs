using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities;

[Keyless]
[Table("PaymentGateway error_updated")]
public partial class PaymentGateway_error_updated
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string PaymentGateway { get; set; }

    [Column("Revised Payment Gateway")]
    [StringLength(50)]
    public string Revised_Payment_Gateway { get; set; }
}
