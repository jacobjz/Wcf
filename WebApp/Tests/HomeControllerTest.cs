using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApp.Controllers;
using WebApp.DbServiceRef;
namespace WebApp.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestDetailsViewData()
        {
            IEnumerable<wniosekWithDecyzja> wwdList;
            var controller = new HomeController();
            var result = controller.ListaWnioskow("2011-09-09","2012-09-09") as ViewResult;
            var list = (IEnumerable<wniosekWithDecyzja>)result.ViewData.Model;
            using (DbServiceClient client = new DbServiceClient())
            {
               wwdList = client.GetWnioskiBetweenDates("2011-09-09", "2012-09-09");

            }
            Assert.AreEqual(wwdList.Count(), list.Count());
        }
    }
}