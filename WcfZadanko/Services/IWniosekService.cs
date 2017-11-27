using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfZadanko.dto;

namespace WcfZadanko.Services
{
    public interface IWniosekService
    {
        wniosekWithDecyzja GetWniosek(int id_wniosek);
        void EditWniosek(int id_wniosku, string klient_skrot, string xd, decimal? kwota_kredytu_brutto, double? wnisokowana_kwota_kredytu, DateTime? data_kredytu);
        void EditWniosek(wniosekWithDecyzja _wniosekWithDecyzja);
        IEnumerable<wniosekWithDecyzja> GetWnioskiBetweenDates(string dateFrom, string dateTo);
    }
}