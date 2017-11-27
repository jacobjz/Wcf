using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfZadanko.dto;
namespace WcfZadanko.DbRepo
{

        public class WniosekRepositoryEF 
        {
            private Rex9 context;

            public WniosekRepositoryEF(Rex9 context)
            {
                this.context = context;
            }
            public void Dispose()
            {
                context.Dispose();
            }

            public wnioski GetWniosekByID(int wniosekId)
            {
                return context.wnioski.FirstOrDefault(x => x.id_wniosek == wniosekId);
            }

            public IEnumerable<wnioski> GetWnioski()
            {
                return context.wnioski.ToList();

            }
            public IEnumerable<wniosekWithDecyzja> getWnioskiBetweenDates(string dateFrom, string dateTo)
            {
                List<wniosekWithDecyzja> _wwdList = new List<wniosekWithDecyzja>();
                try
                {
                    DateTime dateF = DateTime.Parse(dateFrom);
                    DateTime dateT = DateTime.Parse(dateTo);

                    IEnumerable<wnioski> wnioskiList = new List<wnioski>();
                    wnioskiList = context.wnioski.Where(w => w.data_rejestracji_wniosku >= dateF && w.data_rejestracji_wniosku < dateT).OrderBy(w => w.id_wniosek).Take(20);
                    foreach (wnioski w in wnioskiList)
                    {
                        wniosekWithDecyzja _wwd = new wniosekWithDecyzja();
                        decyzje d = context.decyzje.FirstOrDefault(x => x.id_wniosek == w.id_wniosek);
                        _wwd.Id_wniosek = w.id_wniosek;
                        _wwd.Klient_skrot = w.klient_skrot;
                        _wwd.Numer_wniosku = w.numer_wniosku;
                        _wwd.Wnioskowana_kwota_kredytu = w.wnioskowana_kwota_kredytu;
                        _wwd.Data_rejestracji_wniosku = (DateTime)w.data_rejestracji_wniosku;
                        _wwd.Kwota_kredytu_brutto = d.kwota_kredytu_brutto;
                        _wwdList.Add(_wwd);
                    }
                    return _wwdList;
                }
                catch (Exception e)
                {
                    Console.WriteLine(String.Format("{0}", e));
                    return _wwdList;
                }

            }
            public void Save()
            {
                context.SaveChanges();
            }

            public void UpdateWniosek(wnioski wniosek)
            {

                context.Entry(wniosek).State = EntityState.Modified;
                context.SaveChanges();

            }
            public bool UpdateWniosek(int id_wniosku, string klient_skrot, string xd, decimal? kwota_kredytu_brutto, double? wnisokowana_kwota_kredytu, DateTime? data_kredytu)
        {

                try
                {


                    wnioski wniosek = context.wnioski.FirstOrDefault(x => x.id_wniosek == id_wniosku);
                    wniosek.klient_skrot = xd;
                    wniosek.wnioskowana_kwota_kredytu = wnisokowana_kwota_kredytu;
                    wniosek.data_rejestracji_wniosku = data_kredytu;
                    context.Entry(wniosek).State = EntityState.Modified;
                    context.SaveChanges();
                    decyzje dec = context.decyzje.FirstOrDefault(x => x.id_wniosek == wniosek.id_wniosek);
                    dec.kwota_kredytu_brutto = kwota_kredytu_brutto;
                    context.Entry(dec).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        public void UpdateWniosek(wniosekWithDecyzja _wniosekWithDecyzja)
        {

            try
            {


                wnioski wniosek = context.wnioski.FirstOrDefault(x => x.id_wniosek == _wniosekWithDecyzja.Id_wniosek);
                wniosek.klient_skrot = _wniosekWithDecyzja.Klient_skrot;
                wniosek.wnioskowana_kwota_kredytu = _wniosekWithDecyzja.Wnioskowana_kwota_kredytu;
                wniosek.data_rejestracji_wniosku = _wniosekWithDecyzja.Data_rejestracji_wniosku;
                context.Entry(wniosek).State = EntityState.Modified;
                context.SaveChanges();
                decyzje dec = context.decyzje.FirstOrDefault(x => x.id_wniosek == wniosek.id_wniosek);
                dec.kwota_kredytu_brutto = _wniosekWithDecyzja.Kwota_kredytu_brutto;
                context.Entry(dec).State = EntityState.Modified;
                context.SaveChanges();
              
            }
            catch
            {
              
            }
        }
        }
    }

