using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("TicketRefundTransactionDateDetailLog")]
[Index("TicketId", Name = "IX_TicketRefundTransactionDateDetailLog")]
public partial class TicketRefundTransactionDateDetailLog
{
    [StringLength(50)]
    public string TicketId { get; set; }

    [StringLength(100)]
    public string RefundTransactionDate { get; set; }
}
