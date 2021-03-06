﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// このソース コードは Microsoft.VSDesigner、バージョン 4.0.30319.42000 によって自動生成されました。
// 
#pragma warning disable 1591

namespace neggs.web {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServicesSoap", Namespace="http://neggs_server/")]
    public partial class Services : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConnectionStringOperationCompleted;
        
        private System.Threading.SendOrPostCallback DatabaseSizeOperationCompleted;
        
        private System.Threading.SendOrPostCallback ProviderNameOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Services() {
            this.Url = global::neggs.Properties.Settings.Default.neggsWEB;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ConnectionStringCompletedEventHandler ConnectionStringCompleted;
        
        /// <remarks/>
        public event DatabaseSizeCompletedEventHandler DatabaseSizeCompleted;
        
        /// <remarks/>
        public event ProviderNameCompletedEventHandler ProviderNameCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://neggs_server/ConnectionString", RequestNamespace="http://neggs_server/", ResponseNamespace="http://neggs_server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public dbioResult ConnectionString() {
            object[] results = this.Invoke("ConnectionString", new object[0]);
            return ((dbioResult)(results[0]));
        }
        
        /// <remarks/>
        public void ConnectionStringAsync() {
            this.ConnectionStringAsync(null);
        }
        
        /// <remarks/>
        public void ConnectionStringAsync(object userState) {
            if ((this.ConnectionStringOperationCompleted == null)) {
                this.ConnectionStringOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConnectionStringOperationCompleted);
            }
            this.InvokeAsync("ConnectionString", new object[0], this.ConnectionStringOperationCompleted, userState);
        }
        
        private void OnConnectionStringOperationCompleted(object arg) {
            if ((this.ConnectionStringCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConnectionStringCompleted(this, new ConnectionStringCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://neggs_server/DatabaseSize", RequestNamespace="http://neggs_server/", ResponseNamespace="http://neggs_server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public dbioResultOfTableInfo DatabaseSize() {
            object[] results = this.Invoke("DatabaseSize", new object[0]);
            return ((dbioResultOfTableInfo)(results[0]));
        }
        
        /// <remarks/>
        public void DatabaseSizeAsync() {
            this.DatabaseSizeAsync(null);
        }
        
        /// <remarks/>
        public void DatabaseSizeAsync(object userState) {
            if ((this.DatabaseSizeOperationCompleted == null)) {
                this.DatabaseSizeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDatabaseSizeOperationCompleted);
            }
            this.InvokeAsync("DatabaseSize", new object[0], this.DatabaseSizeOperationCompleted, userState);
        }
        
        private void OnDatabaseSizeOperationCompleted(object arg) {
            if ((this.DatabaseSizeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DatabaseSizeCompleted(this, new DatabaseSizeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://neggs_server/ProviderName", RequestNamespace="http://neggs_server/", ResponseNamespace="http://neggs_server/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public dbioResult ProviderName() {
            object[] results = this.Invoke("ProviderName", new object[0]);
            return ((dbioResult)(results[0]));
        }
        
        /// <remarks/>
        public void ProviderNameAsync() {
            this.ProviderNameAsync(null);
        }
        
        /// <remarks/>
        public void ProviderNameAsync(object userState) {
            if ((this.ProviderNameOperationCompleted == null)) {
                this.ProviderNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OnProviderNameOperationCompleted);
            }
            this.InvokeAsync("ProviderName", new object[0], this.ProviderNameOperationCompleted, userState);
        }
        
        private void OnProviderNameOperationCompleted(object arg) {
            if ((this.ProviderNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ProviderNameCompleted(this, new ProviderNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://neggs_server/")]
    public partial class dbioResult {
        
        private bool isSuccessField;
        
        private string causeField;
        
        private string diagnosisField;
        
        private string commentsField;
        
        /// <remarks/>
        public bool IsSuccess {
            get {
                return this.isSuccessField;
            }
            set {
                this.isSuccessField = value;
            }
        }
        
        /// <remarks/>
        public string Cause {
            get {
                return this.causeField;
            }
            set {
                this.causeField = value;
            }
        }
        
        /// <remarks/>
        public string Diagnosis {
            get {
                return this.diagnosisField;
            }
            set {
                this.diagnosisField = value;
            }
        }
        
        /// <remarks/>
        public string Comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://neggs_server/")]
    public partial class TableInfo {
        
        private int markerField;
        
        private string schemaField;
        
        private string nameField;
        
        private long rowsField;
        
        private long reservedField;
        
        private long dat_sizeField;
        
        private long idx_sizeField;
        
        private long unusedField;
        
        /// <remarks/>
        public int marker {
            get {
                return this.markerField;
            }
            set {
                this.markerField = value;
            }
        }
        
        /// <remarks/>
        public string schema {
            get {
                return this.schemaField;
            }
            set {
                this.schemaField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public long rows {
            get {
                return this.rowsField;
            }
            set {
                this.rowsField = value;
            }
        }
        
        /// <remarks/>
        public long reserved {
            get {
                return this.reservedField;
            }
            set {
                this.reservedField = value;
            }
        }
        
        /// <remarks/>
        public long dat_size {
            get {
                return this.dat_sizeField;
            }
            set {
                this.dat_sizeField = value;
            }
        }
        
        /// <remarks/>
        public long idx_size {
            get {
                return this.idx_sizeField;
            }
            set {
                this.idx_sizeField = value;
            }
        }
        
        /// <remarks/>
        public long unused {
            get {
                return this.unusedField;
            }
            set {
                this.unusedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3190.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://neggs_server/")]
    public partial class dbioResultOfTableInfo {
        
        private bool isSuccessField;
        
        private string causeField;
        
        private string diagnosisField;
        
        private string commentsField;
        
        private TableInfo[] listField;
        
        /// <remarks/>
        public bool IsSuccess {
            get {
                return this.isSuccessField;
            }
            set {
                this.isSuccessField = value;
            }
        }
        
        /// <remarks/>
        public string Cause {
            get {
                return this.causeField;
            }
            set {
                this.causeField = value;
            }
        }
        
        /// <remarks/>
        public string Diagnosis {
            get {
                return this.diagnosisField;
            }
            set {
                this.diagnosisField = value;
            }
        }
        
        /// <remarks/>
        public string Comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }
        
        /// <remarks/>
        public TableInfo[] List {
            get {
                return this.listField;
            }
            set {
                this.listField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void ConnectionStringCompletedEventHandler(object sender, ConnectionStringCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConnectionStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConnectionStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public dbioResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((dbioResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void DatabaseSizeCompletedEventHandler(object sender, DatabaseSizeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DatabaseSizeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DatabaseSizeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public dbioResultOfTableInfo Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((dbioResultOfTableInfo)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void ProviderNameCompletedEventHandler(object sender, ProviderNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ProviderNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ProviderNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public dbioResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((dbioResult)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591