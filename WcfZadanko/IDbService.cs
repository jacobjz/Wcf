using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfZadanko.dto;

namespace WcfZadanko
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDbService" in both code and config file together.
    [ServiceContract]
    public interface IDbService
    {
        [OperationContract]
        IEnumerable<wniosekWithDecyzja> GetWnioskiBetweenDates(string dateFrom, string dateTo);
        [OperationContract]
        wniosekWithDecyzja GetWniosek(int id_wniosek);
        [OperationContract]
        void EditWniosek(int idw, string ks, string xd, decimal? kkb, double? wkk, DateTime? drw);
        void EditWniosek(wniosekWithDecyzja _wniosekWithDecyzja);
    }
}
