﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.DbServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="wniosekWithDecyzja", Namespace="http://schemas.datacontract.org/2004/07/WcfZadanko.dto")]
    [System.SerializableAttribute()]
    public partial class wniosekWithDecyzja : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Data_rejestracji_wnioskuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Id_wniosekField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Klient_skrotField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> Kwota_kredytu_bruttoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Numer_wnioskuField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<double> Wnioskowana_kwota_kredytuField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Data_rejestracji_wniosku {
            get {
                return this.Data_rejestracji_wnioskuField;
            }
            set {
                if ((this.Data_rejestracji_wnioskuField.Equals(value) != true)) {
                    this.Data_rejestracji_wnioskuField = value;
                    this.RaisePropertyChanged("Data_rejestracji_wniosku");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id_wniosek {
            get {
                return this.Id_wniosekField;
            }
            set {
                if ((this.Id_wniosekField.Equals(value) != true)) {
                    this.Id_wniosekField = value;
                    this.RaisePropertyChanged("Id_wniosek");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Klient_skrot {
            get {
                return this.Klient_skrotField;
            }
            set {
                if ((object.ReferenceEquals(this.Klient_skrotField, value) != true)) {
                    this.Klient_skrotField = value;
                    this.RaisePropertyChanged("Klient_skrot");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Kwota_kredytu_brutto {
            get {
                return this.Kwota_kredytu_bruttoField;
            }
            set {
                if ((this.Kwota_kredytu_bruttoField.Equals(value) != true)) {
                    this.Kwota_kredytu_bruttoField = value;
                    this.RaisePropertyChanged("Kwota_kredytu_brutto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Numer_wniosku {
            get {
                return this.Numer_wnioskuField;
            }
            set {
                if ((object.ReferenceEquals(this.Numer_wnioskuField, value) != true)) {
                    this.Numer_wnioskuField = value;
                    this.RaisePropertyChanged("Numer_wniosku");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<double> Wnioskowana_kwota_kredytu {
            get {
                return this.Wnioskowana_kwota_kredytuField;
            }
            set {
                if ((this.Wnioskowana_kwota_kredytuField.Equals(value) != true)) {
                    this.Wnioskowana_kwota_kredytuField = value;
                    this.RaisePropertyChanged("Wnioskowana_kwota_kredytu");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DbServiceRef.IDbService")]
    public interface IDbService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbService/GetWnioskiBetweenDates", ReplyAction="http://tempuri.org/IDbService/GetWnioskiBetweenDatesResponse")]
        WebApp.DbServiceRef.wniosekWithDecyzja[] GetWnioskiBetweenDates(string dateFrom, string dateTo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbService/GetWnioskiBetweenDates", ReplyAction="http://tempuri.org/IDbService/GetWnioskiBetweenDatesResponse")]
        System.Threading.Tasks.Task<WebApp.DbServiceRef.wniosekWithDecyzja[]> GetWnioskiBetweenDatesAsync(string dateFrom, string dateTo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbService/GetWniosek", ReplyAction="http://tempuri.org/IDbService/GetWniosekResponse")]
        WebApp.DbServiceRef.wniosekWithDecyzja GetWniosek(int id_wniosek);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbService/GetWniosek", ReplyAction="http://tempuri.org/IDbService/GetWniosekResponse")]
        System.Threading.Tasks.Task<WebApp.DbServiceRef.wniosekWithDecyzja> GetWniosekAsync(int id_wniosek);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbService/EditWniosek", ReplyAction="http://tempuri.org/IDbService/EditWniosekResponse")]
        void EditWniosek(int idw, string ks, string xd, System.Nullable<decimal> kkb, System.Nullable<double> wkk, System.Nullable<System.DateTime> drw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDbService/EditWniosek", ReplyAction="http://tempuri.org/IDbService/EditWniosekResponse")]
        System.Threading.Tasks.Task EditWniosekAsync(int idw, string ks, string xd, System.Nullable<decimal> kkb, System.Nullable<double> wkk, System.Nullable<System.DateTime> drw);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDbServiceChannel : WebApp.DbServiceRef.IDbService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DbServiceClient : System.ServiceModel.ClientBase<WebApp.DbServiceRef.IDbService>, WebApp.DbServiceRef.IDbService {
        
        public DbServiceClient() {
        }
        
        public DbServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DbServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DbServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DbServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApp.DbServiceRef.wniosekWithDecyzja[] GetWnioskiBetweenDates(string dateFrom, string dateTo) {
            return base.Channel.GetWnioskiBetweenDates(dateFrom, dateTo);
        }
        
        public System.Threading.Tasks.Task<WebApp.DbServiceRef.wniosekWithDecyzja[]> GetWnioskiBetweenDatesAsync(string dateFrom, string dateTo) {
            return base.Channel.GetWnioskiBetweenDatesAsync(dateFrom, dateTo);
        }
        
        public WebApp.DbServiceRef.wniosekWithDecyzja GetWniosek(int id_wniosek) {
            return base.Channel.GetWniosek(id_wniosek);
        }
        
        public System.Threading.Tasks.Task<WebApp.DbServiceRef.wniosekWithDecyzja> GetWniosekAsync(int id_wniosek) {
            return base.Channel.GetWniosekAsync(id_wniosek);
        }
        
        public void EditWniosek(int idw, string ks, string xd, System.Nullable<decimal> kkb, System.Nullable<double> wkk, System.Nullable<System.DateTime> drw) {
            base.Channel.EditWniosek(idw, ks, xd, kkb, wkk, drw);
        }
        
        public System.Threading.Tasks.Task EditWniosekAsync(int idw, string ks, string xd, System.Nullable<decimal> kkb, System.Nullable<double> wkk, System.Nullable<System.DateTime> drw) {
            return base.Channel.EditWniosekAsync(idw, ks, xd, kkb, wkk, drw);
        }
    }
}
