using System;
using System.Collections.Generic;

namespace Enes_Kurt_Odev___24._04._2023.Models;

public partial class SummaryOfSalesByYear
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
