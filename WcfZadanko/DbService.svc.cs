using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfZadanko.DbRepo;
using WcfZadanko.dto;
using WcfZadanko.Services;

namespace WcfZadanko
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DbService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DbService.svc or DbService.svc.cs at the Solution Explorer and start debugging.
    public class DbService : IDbService
    {
        private readonly IWniosekService _wniosekService;

        public DbService(IWniosekService wniosekService)
        {
            _wniosekService = wniosekService;
        }

        public IEnumerable<wniosekWithDecyzja> GetWnioskiBetweenDates(string dateFrom, string dateTo)
        {
            IEnumerable<wniosekWithDecyzja>  result = _wniosekService.GetWnioskiBetweenDates(dateFrom, dateTo);
            return result;
        }

        public void EditWniosek(int id_wniosku, string klient_skrot, string xd, decimal? kwota_kredytu_brutto, double? wnisokowana_kwota_kredytu, DateTime? data_kredytu)
        {
            using (var db = new Rex9())
            {
                try
            {
                wnioski wniosek = db.wnioski.FirstOrDefault(x => x.id_wniosek == id_wniosku);
                wniosek.klient_skrot = xd;
                wniosek.wnioskowana_kwota_kredytu = wnisokowana_kwota_kredytu;
                wniosek.data_rejestracji_wniosku = data_kredytu;
                    db.Entry(wniosek).State = EntityState.Modified;
                    db.SaveChanges();
                decyzje dec = db.decyzje.FirstOrDefault(x => x.id_wniosek == wniosek.id_wniosek);
                dec.kwota_kredytu_brutto = kwota_kredytu_brutto;
                    db.Entry(dec).State = EntityState.Modified;
                    db.SaveChanges();
             
            }
            catch
            {
              
            }
            }

        }
        public void EditWniosek(wniosekWithDecyzja wwd)
        {
            using (var db = new Rex9())
            {
                try
                {
                    _wniosekService.EditWniosek(wwd);
                }
                catch
                {

                }
            }
        }
        public wniosekWithDecyzja GetWniosek(int id_wniosek)
        {
            wniosekWithDecyzja wwd = new wniosekWithDecyzja();
            using (var db = new Rex9())
            {
                try
                {
                    wnioski wniosek = db.wnioski.FirstOrDefault(x => x.id_wniosek == id_wniosek);
                    wwd.Id_wniosek = id_wniosek;
                    wwd.Klient_skrot = wniosek.klient_skrot;
                    wwd.Wnioskowana_kwota_kredytu= wniosek.wnioskowana_kwota_kredytu;
                    wwd.Data_rejestracji_wniosku = (DateTime)wniosek.data_rejestracji_wniosku;
                    wwd.Numer_wniosku = wniosek.numer_wniosku;
                    decyzje dec = db.decyzje.FirstOrDefault(x => x.id_wniosek == wniosek.id_wniosek);
                    wwd.Kwota_kredytu_brutto=dec.kwota_kredytu_brutto;
                    return wwd;

                }
                catch
                {
                    return null;
                }
            }

        }
    }
}
