using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfZadanko.dto
{
    public class wniosekWithDecyzja
    {
        public int Id_wniosek { get; set; }
        public string Numer_wniosku { get; set; }
        public string Klient_skrot { get; set; }
        public double? Wnioskowana_kwota_kredytu { get; set; }
        public DateTime Data_rejestracji_wniosku { get; set; }
        public decimal? Kwota_kredytu_brutto { get; set; }
    }
}