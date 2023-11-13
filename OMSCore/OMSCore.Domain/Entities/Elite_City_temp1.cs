using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace OMSCore.Domain.Entities;

[Keyless]
[Table("Elite_City_temp1")]
public partial class Elite_City_temp1
{
    [StringLength(50)]
    public string Countrycode { get; set; }

    [StringLength(50)]
    public string Country { get; set; }

    [StringLength(50)]
    public string CityCode { get; set; }

    [StringLength(50)]
    public string CityName { get; set; }
}
