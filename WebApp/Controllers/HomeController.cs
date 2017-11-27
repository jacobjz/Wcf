using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApp.DbServiceRef;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        static string data1;
        static string data2;
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(InputModel model)
        {
          
            data1 = model.dateFrom;
           data2 = model.dateTo;
            return RedirectToAction("ListaWnioskow", new { data1 = data1, data2 = data2 });
        }

        public ActionResult ListaWnioskow(string data1, string data2)
        {
            using (DbServiceClient client = new DbServiceClient())
            {
                IEnumerable<wniosekWithDecyzja> wwdList = client.GetWnioskiBetweenDates(data1, data2);

                return View(wwdList);
            }
        }
        public ActionResult Edit(int id_wniosek)
        {
            wniosekWithDecyzja wwd;
            using (DbServiceClient client = new DbServiceClient())
            {
              wwd=  client.GetWniosek(id_wniosek);
            }
            ViewBag.Date1 = data1;
            ViewBag.Date2 = data2;
                return View(wwd);
        }
        public ActionResult Update(wniosekWithDecyzja wwd)
        {
        
            using (DbServiceClient client = new DbServiceClient())
            {
                client.EditWniosek(wwd.Id_wniosek,wwd.Klient_skrot,wwd.Klient_skrot,wwd.Kwota_kredytu_brutto,wwd.Wnioskowana_kwota_kredytu,wwd.Data_rejestracji_wniosku);
            }
            return RedirectToAction("ListaWnioskow", new { data1 = data1, data2 = data2 });
        }



    }
}
