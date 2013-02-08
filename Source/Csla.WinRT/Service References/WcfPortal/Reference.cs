﻿#pragma warning disable
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 11.0.50727.1
// 
namespace Csla.WcfPortal {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CriteriaRequest", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Mobile")]
    public partial class CriteriaRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] ClientContextField;
        
        private string ClientCultureField;
        
        private string ClientUICultureField;
        
        private byte[] CriteriaDataField;
        
        private byte[] GlobalContextField;
        
        private byte[] PrincipalField;
        
        private string TypeNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ClientContext {
            get {
                return this.ClientContextField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientContextField, value) != true)) {
                    this.ClientContextField = value;
                    this.RaisePropertyChanged("ClientContext");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientCulture {
            get {
                return this.ClientCultureField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientCultureField, value) != true)) {
                    this.ClientCultureField = value;
                    this.RaisePropertyChanged("ClientCulture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientUICulture {
            get {
                return this.ClientUICultureField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientUICultureField, value) != true)) {
                    this.ClientUICultureField = value;
                    this.RaisePropertyChanged("ClientUICulture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] CriteriaData {
            get {
                return this.CriteriaDataField;
            }
            set {
                if ((object.ReferenceEquals(this.CriteriaDataField, value) != true)) {
                    this.CriteriaDataField = value;
                    this.RaisePropertyChanged("CriteriaData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] GlobalContext {
            get {
                return this.GlobalContextField;
            }
            set {
                if ((object.ReferenceEquals(this.GlobalContextField, value) != true)) {
                    this.GlobalContextField = value;
                    this.RaisePropertyChanged("GlobalContext");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Principal {
            get {
                return this.PrincipalField;
            }
            set {
                if ((object.ReferenceEquals(this.PrincipalField, value) != true)) {
                    this.PrincipalField = value;
                    this.RaisePropertyChanged("Principal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TypeName {
            get {
                return this.TypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeNameField, value) != true)) {
                    this.TypeNameField = value;
                    this.RaisePropertyChanged("TypeName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="WcfResponse", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Mobile")]
    public partial class WcfResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Csla.WcfPortal.WcfErrorInfo ErrorDataField;
        
        private byte[] GlobalContextField;
        
        private byte[] ObjectDataField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Csla.WcfPortal.WcfErrorInfo ErrorData {
            get {
                return this.ErrorDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorDataField, value) != true)) {
                    this.ErrorDataField = value;
                    this.RaisePropertyChanged("ErrorData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] GlobalContext {
            get {
                return this.GlobalContextField;
            }
            set {
                if ((object.ReferenceEquals(this.GlobalContextField, value) != true)) {
                    this.GlobalContextField = value;
                    this.RaisePropertyChanged("GlobalContext");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ObjectData {
            get {
                return this.ObjectDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectDataField, value) != true)) {
                    this.ObjectDataField = value;
                    this.RaisePropertyChanged("ObjectData");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="WcfErrorInfo", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Mobile")]
    public partial class WcfErrorInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string ExceptionTypeNameField;
        
        private Csla.WcfPortal.WcfErrorInfo InnerErrorField;
        
        private string MessageField;
        
        private string SourceField;
        
        private string StackTraceField;
        
        private string TargetSiteNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ExceptionTypeName {
            get {
                return this.ExceptionTypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionTypeNameField, value) != true)) {
                    this.ExceptionTypeNameField = value;
                    this.RaisePropertyChanged("ExceptionTypeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Csla.WcfPortal.WcfErrorInfo InnerError {
            get {
                return this.InnerErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.InnerErrorField, value) != true)) {
                    this.InnerErrorField = value;
                    this.RaisePropertyChanged("InnerError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Source {
            get {
                return this.SourceField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceField, value) != true)) {
                    this.SourceField = value;
                    this.RaisePropertyChanged("Source");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TargetSiteName {
            get {
                return this.TargetSiteNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TargetSiteNameField, value) != true)) {
                    this.TargetSiteNameField = value;
                    this.RaisePropertyChanged("TargetSiteName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateRequest", Namespace="http://schemas.datacontract.org/2004/07/Csla.Server.Hosts.Mobile")]
    public partial class UpdateRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] ClientContextField;
        
        private string ClientCultureField;
        
        private string ClientUICultureField;
        
        private byte[] GlobalContextField;
        
        private byte[] ObjectDataField;
        
        private byte[] PrincipalField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ClientContext {
            get {
                return this.ClientContextField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientContextField, value) != true)) {
                    this.ClientContextField = value;
                    this.RaisePropertyChanged("ClientContext");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientCulture {
            get {
                return this.ClientCultureField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientCultureField, value) != true)) {
                    this.ClientCultureField = value;
                    this.RaisePropertyChanged("ClientCulture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientUICulture {
            get {
                return this.ClientUICultureField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientUICultureField, value) != true)) {
                    this.ClientUICultureField = value;
                    this.RaisePropertyChanged("ClientUICulture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] GlobalContext {
            get {
                return this.GlobalContextField;
            }
            set {
                if ((object.ReferenceEquals(this.GlobalContextField, value) != true)) {
                    this.GlobalContextField = value;
                    this.RaisePropertyChanged("GlobalContext");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ObjectData {
            get {
                return this.ObjectDataField;
            }
            set {
                if ((object.ReferenceEquals(this.ObjectDataField, value) != true)) {
                    this.ObjectDataField = value;
                    this.RaisePropertyChanged("ObjectData");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Principal {
            get {
                return this.PrincipalField;
            }
            set {
                if ((object.ReferenceEquals(this.PrincipalField, value) != true)) {
                    this.PrincipalField = value;
                    this.RaisePropertyChanged("Principal");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.lhotka.net/WcfDataPortal", ConfigurationName="WcfPortal.IWcfPortal")]
    public interface IWcfPortal {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Create", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/CreateResponse")]
        System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> CreateAsync(Csla.WcfPortal.CriteriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Fetch", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/FetchResponse")]
        System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> FetchAsync(Csla.WcfPortal.CriteriaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Update", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/UpdateResponse")]
        System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> UpdateAsync(Csla.WcfPortal.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/Delete", ReplyAction="http://ws.lhotka.net/WcfDataPortal/IWcfPortal/DeleteResponse")]
        System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> DeleteAsync(Csla.WcfPortal.CriteriaRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWcfPortalChannel : Csla.WcfPortal.IWcfPortal, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WcfPortalClient : System.ServiceModel.ClientBase<Csla.WcfPortal.IWcfPortal>, Csla.WcfPortal.IWcfPortal {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WcfPortalClient() : 
                base(WcfPortalClient.GetDefaultBinding(), WcfPortalClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IWcfPortal.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WcfPortalClient(EndpointConfiguration endpointConfiguration) : 
                base(WcfPortalClient.GetBindingForEndpoint(endpointConfiguration), WcfPortalClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WcfPortalClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WcfPortalClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WcfPortalClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WcfPortalClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WcfPortalClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> CreateAsync(Csla.WcfPortal.CriteriaRequest request) {
            return base.Channel.CreateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> FetchAsync(Csla.WcfPortal.CriteriaRequest request) {
            return base.Channel.FetchAsync(request);
        }
        
        public System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> UpdateAsync(Csla.WcfPortal.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Csla.WcfPortal.WcfResponse> DeleteAsync(Csla.WcfPortal.CriteriaRequest request) {
            return base.Channel.DeleteAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWcfPortal)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IWcfPortal)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:19454/MobilePortal.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return WcfPortalClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IWcfPortal);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return WcfPortalClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IWcfPortal);
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IWcfPortal,
        }
    }
}
