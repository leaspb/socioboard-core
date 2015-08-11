﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34014.
// 
#pragma warning disable 1591

namespace Socioboard.Api.EwalletWithdrawRequest {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EwalletWithdrawRequestSoap", Namespace="http://tempuri.org/")]
    public partial class EwalletWithdrawRequest : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddRequestToWithdrawOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public EwalletWithdrawRequest() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_EwalletWithdrawRequest_EwalletWithdrawRequest;
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
        public event AddRequestToWithdrawCompletedEventHandler AddRequestToWithdrawCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddRequestToWithdraw", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddRequestToWithdraw(string WithdrawAmount, string PaymentMethod, string PaypalEmail, int Status, string UserID) {
            this.Invoke("AddRequestToWithdraw", new object[] {
                        WithdrawAmount,
                        PaymentMethod,
                        PaypalEmail,
                        Status,
                        UserID});
        }
        
        /// <remarks/>
        public void AddRequestToWithdrawAsync(string WithdrawAmount, string PaymentMethod, string PaypalEmail, int Status, string UserID) {
            this.AddRequestToWithdrawAsync(WithdrawAmount, PaymentMethod, PaypalEmail, Status, UserID, null);
        }
        
        /// <remarks/>
        public void AddRequestToWithdrawAsync(string WithdrawAmount, string PaymentMethod, string PaypalEmail, int Status, string UserID, object userState) {
            if ((this.AddRequestToWithdrawOperationCompleted == null)) {
                this.AddRequestToWithdrawOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddRequestToWithdrawOperationCompleted);
            }
            this.InvokeAsync("AddRequestToWithdraw", new object[] {
                        WithdrawAmount,
                        PaymentMethod,
                        PaypalEmail,
                        Status,
                        UserID}, this.AddRequestToWithdrawOperationCompleted, userState);
        }
        
        private void OnAddRequestToWithdrawOperationCompleted(object arg) {
            if ((this.AddRequestToWithdrawCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddRequestToWithdrawCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void AddRequestToWithdrawCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591