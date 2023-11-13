using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("PaymentGatewayerror_updated")]
public partial class PaymentGatewayerror_updated
{
    [StringLength(50)]
    public string WebOrderNo { get; set; }

    [StringLength(50)]
    public string PaymentGateway { get; set; }

    [Column("Revised Payment Gateway")]
    [StringLength(50)]
    public string Revised_Payment_Gateway { get; set; }
}
