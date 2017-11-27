using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfZadanko.DbRepo;
using WcfZadanko.dto;

namespace WcfZadanko.Services
{
    public class WniosekService : IWniosekService
    {
        public void EditWniosek(wniosekWithDecyzja _wniosekWithDecyzja)
        {
            using (var db = new Rex9())
            {
                WniosekRepositoryEF wr = new WniosekRepositoryEF(db);
                wr.UpdateWniosek(_wniosekWithDecyzja);
            }
        }

        public void EditWniosek(int id_wniosku, string klient_skrot, string xd, decimal? kwota_kredytu_brutto, double? wnisokowana_kwota_kredytu, DateTime? data_kredytu)
        {
            throw new NotImplementedException();
        }

        public wniosekWithDecyzja GetWniosek(int id_wniosek)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<wniosekWithDecyzja> GetWnioskiBetweenDates(string dateFrom, string dateTo)
        {
            using (var db = new Rex9())
            {
                WniosekRepositoryEF wr = new WniosekRepositoryEF(db);
                return wr.getWnioskiBetweenDates(dateFrom, dateTo);
            }
        }
    }
}