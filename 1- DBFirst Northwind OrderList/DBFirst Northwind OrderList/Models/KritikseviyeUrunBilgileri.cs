using System;
using System.Collections.Generic;

namespace Enes_Kurt_Odev___24._04._2023.Models;

public partial class KritikseviyeUrunBilgileri
{
    public string ÜrünAdı { get; set; } = null!;

    public string Kategori { get; set; } = null!;

    public string TedarikçiFirma { get; set; } = null!;

    public short? MinimumSiparişAdedi { get; set; }

    public decimal? BirimFiyat { get; set; }
}
