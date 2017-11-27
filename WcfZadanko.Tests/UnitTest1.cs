using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfZadanko.Services;

namespace WcfZadanko.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IWniosekService _wniosekService;

        public UnitTest1(IWniosekService wniosekService)
        {
            _wniosekService = wniosekService;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var result = _wniosekService.GetWnioskiBetweenDates("2016-01-01", "2016-05-30");

            Assert.IsNotNull(result);
        }
    }
}
