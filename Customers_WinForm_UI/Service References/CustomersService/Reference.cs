﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Customers_WinForm_UI.CustomersService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultObject", Namespace="http://schemas.datacontract.org/2004/07/Customers_self_hosted_service")]
    [System.SerializableAttribute()]
    public partial class ResultObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ContainsErrorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Customers_WinForm_UI.CustomersService.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Customers_WinForm_UI.CustomersService.Customer[] CustomersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMessageField;
        
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
        public bool ContainsErrors {
            get {
                return this.ContainsErrorsField;
            }
            set {
                if ((this.ContainsErrorsField.Equals(value) != true)) {
                    this.ContainsErrorsField = value;
                    this.RaisePropertyChanged("ContainsErrors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Customers_WinForm_UI.CustomersService.Customer Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Customers_WinForm_UI.CustomersService.Customer[] Customers {
            get {
                return this.CustomersField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomersField, value) != true)) {
                    this.CustomersField = value;
                    this.RaisePropertyChanged("Customers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/Customers_self_hosted_service")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostalAddressCityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostalAddressCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostalAddressStreetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNumber {
            get {
                return this.PhoneNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNumberField, value) != true)) {
                    this.PhoneNumberField = value;
                    this.RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalAddressCity {
            get {
                return this.PostalAddressCityField;
            }
            set {
                if ((object.ReferenceEquals(this.PostalAddressCityField, value) != true)) {
                    this.PostalAddressCityField = value;
                    this.RaisePropertyChanged("PostalAddressCity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalAddressCode {
            get {
                return this.PostalAddressCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostalAddressCodeField, value) != true)) {
                    this.PostalAddressCodeField = value;
                    this.RaisePropertyChanged("PostalAddressCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostalAddressStreet {
            get {
                return this.PostalAddressStreetField;
            }
            set {
                if ((object.ReferenceEquals(this.PostalAddressStreetField, value) != true)) {
                    this.PostalAddressStreetField = value;
                    this.RaisePropertyChanged("PostalAddressStreet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerListFilter", Namespace="http://schemas.datacontract.org/2004/07/Customers_self_hosted_service")]
    [System.SerializableAttribute()]
    public partial class CustomerListFilter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Customers_WinForm_UI.CustomersService.FilterConditions ConditionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Customers_WinForm_UI.CustomersService.FilterFieldsNames FieldNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FieldValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsEnabledField;
        
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
        public Customers_WinForm_UI.CustomersService.FilterConditions Condition {
            get {
                return this.ConditionField;
            }
            set {
                if ((this.ConditionField.Equals(value) != true)) {
                    this.ConditionField = value;
                    this.RaisePropertyChanged("Condition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Customers_WinForm_UI.CustomersService.FilterFieldsNames FieldName {
            get {
                return this.FieldNameField;
            }
            set {
                if ((this.FieldNameField.Equals(value) != true)) {
                    this.FieldNameField = value;
                    this.RaisePropertyChanged("FieldName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FieldValue {
            get {
                return this.FieldValueField;
            }
            set {
                if ((object.ReferenceEquals(this.FieldValueField, value) != true)) {
                    this.FieldValueField = value;
                    this.RaisePropertyChanged("FieldValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsEnabled {
            get {
                return this.IsEnabledField;
            }
            set {
                if ((this.IsEnabledField.Equals(value) != true)) {
                    this.IsEnabledField = value;
                    this.RaisePropertyChanged("IsEnabled");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilterConditions", Namespace="http://schemas.datacontract.org/2004/07/Customers_self_hosted_service")]
    public enum FilterConditions : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IS_EQUAL = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CONTAINS = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FilterFieldsNames", Namespace="http://schemas.datacontract.org/2004/07/Customers_self_hosted_service")]
    public enum FilterFieldsNames : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NAME = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SURNAME = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PHONE = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CITY = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        STREET = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        POSTCODE = 5,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CustomersService.ICustomersService")]
    public interface ICustomersService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomersService/GetCustomer", ReplyAction="http://tempuri.org/ICustomersService/GetCustomerResponse")]
        Customers_WinForm_UI.CustomersService.ResultObject GetCustomer(int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomersService/GetCustomer", ReplyAction="http://tempuri.org/ICustomersService/GetCustomerResponse")]
        System.Threading.Tasks.Task<Customers_WinForm_UI.CustomersService.ResultObject> GetCustomerAsync(int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomersService/GetCustomerList", ReplyAction="http://tempuri.org/ICustomersService/GetCustomerListResponse")]
        Customers_WinForm_UI.CustomersService.ResultObject GetCustomerList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomersService/GetCustomerList", ReplyAction="http://tempuri.org/ICustomersService/GetCustomerListResponse")]
        System.Threading.Tasks.Task<Customers_WinForm_UI.CustomersService.ResultObject> GetCustomerListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomersService/GetCustomerListByFilter", ReplyAction="http://tempuri.org/ICustomersService/GetCustomerListByFilterResponse")]
        Customers_WinForm_UI.CustomersService.ResultObject GetCustomerListByFilter(Customers_WinForm_UI.CustomersService.CustomerListFilter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomersService/GetCustomerListByFilter", ReplyAction="http://tempuri.org/ICustomersService/GetCustomerListByFilterResponse")]
        System.Threading.Tasks.Task<Customers_WinForm_UI.CustomersService.ResultObject> GetCustomerListByFilterAsync(Customers_WinForm_UI.CustomersService.CustomerListFilter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomersService/SaveCustomer", ReplyAction="http://tempuri.org/ICustomersService/SaveCustomerResponse")]
        Customers_WinForm_UI.CustomersService.ResultObject SaveCustomer(Customers_WinForm_UI.CustomersService.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomersService/SaveCustomer", ReplyAction="http://tempuri.org/ICustomersService/SaveCustomerResponse")]
        System.Threading.Tasks.Task<Customers_WinForm_UI.CustomersService.ResultObject> SaveCustomerAsync(Customers_WinForm_UI.CustomersService.Customer customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomersService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomersService/DeleteCustomerResponse")]
        Customers_WinForm_UI.CustomersService.ResultObject DeleteCustomer(int customerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICustomersService/DeleteCustomer", ReplyAction="http://tempuri.org/ICustomersService/DeleteCustomerResponse")]
        System.Threading.Tasks.Task<Customers_WinForm_UI.CustomersService.ResultObject> DeleteCustomerAsync(int customerID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICustomersServiceChannel : Customers_WinForm_UI.CustomersService.ICustomersService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustomersServiceClient : System.ServiceModel.ClientBase<Customers_WinForm_UI.CustomersService.ICustomersService>, Customers_WinForm_UI.CustomersService.ICustomersService {
        
        public CustomersServiceClient() {
        }
        
        public CustomersServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustomersServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomersServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustomersServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Customers_WinForm_UI.CustomersService.ResultObject GetCustomer(int customerID) {
            return base.Channel.GetCustomer(customerID);
        }
        
        public System.Threading.Tasks.Task<Customers_WinForm_UI.CustomersService.ResultObject> GetCustomerAsync(int customerID) {
            return base.Channel.GetCustomerAsync(customerID);
        }
        
        public Customers_WinForm_UI.CustomersService.ResultObject GetCustomerList() {
            return base.Channel.GetCustomerList();
        }
        
        public System.Threading.Tasks.Task<Customers_WinForm_UI.CustomersService.ResultObject> GetCustomerListAsync() {
            return base.Channel.GetCustomerListAsync();
        }
        
        public Customers_WinForm_UI.CustomersService.ResultObject GetCustomerListByFilter(Customers_WinForm_UI.CustomersService.CustomerListFilter filter) {
            return base.Channel.GetCustomerListByFilter(filter);
        }
        
        public System.Threading.Tasks.Task<Customers_WinForm_UI.CustomersService.ResultObject> GetCustomerListByFilterAsync(Customers_WinForm_UI.CustomersService.CustomerListFilter filter) {
            return base.Channel.GetCustomerListByFilterAsync(filter);
        }
        
        public Customers_WinForm_UI.CustomersService.ResultObject SaveCustomer(Customers_WinForm_UI.CustomersService.Customer customer) {
            return base.Channel.SaveCustomer(customer);
        }
        
        public System.Threading.Tasks.Task<Customers_WinForm_UI.CustomersService.ResultObject> SaveCustomerAsync(Customers_WinForm_UI.CustomersService.Customer customer) {
            return base.Channel.SaveCustomerAsync(customer);
        }
        
        public Customers_WinForm_UI.CustomersService.ResultObject DeleteCustomer(int customerID) {
            return base.Channel.DeleteCustomer(customerID);
        }
        
        public System.Threading.Tasks.Task<Customers_WinForm_UI.CustomersService.ResultObject> DeleteCustomerAsync(int customerID) {
            return base.Channel.DeleteCustomerAsync(customerID);
        }
    }
}
