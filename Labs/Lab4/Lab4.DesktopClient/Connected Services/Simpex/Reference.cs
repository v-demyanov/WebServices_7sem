﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab4.DesktopClient.Simpex {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="A", Namespace="http://dvr/")]
    [System.SerializableAttribute()]
    public partial class A : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SField;
        
        private int KField;
        
        private float FField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string S {
            get {
                return this.SField;
            }
            set {
                if ((object.ReferenceEquals(this.SField, value) != true)) {
                    this.SField = value;
                    this.RaisePropertyChanged("S");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=1)]
        public int K {
            get {
                return this.KField;
            }
            set {
                if ((this.KField.Equals(value) != true)) {
                    this.KField = value;
                    this.RaisePropertyChanged("K");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public float F {
            get {
                return this.FField;
            }
            set {
                if ((this.FField.Equals(value) != true)) {
                    this.FField = value;
                    this.RaisePropertyChanged("F");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dvr/", ConfigurationName="Simpex.SimplexSoap")]
    public interface SimplexSoap {
        
        // CODEGEN: Generating message contract since the wrapper name (Simplex.Add) of message Simplex.Add does not match the default value (Add)
        [System.ServiceModel.OperationContractAttribute(Action="http://dvr/Simplex.Add", ReplyAction="*")]
        Lab4.DesktopClient.Simpex.SimplexAdd1 Add(Lab4.DesktopClient.Simpex.SimplexAdd request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvr/Simplex.Add", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexAdd1> AddAsync(Lab4.DesktopClient.Simpex.SimplexAdd request);
        
        // CODEGEN: Generating message contract since the wrapper name (Simplex.Adds) of message Simplex.Adds does not match the default value (Adds)
        [System.ServiceModel.OperationContractAttribute(Action="http://dvr/Simplex.Adds", ReplyAction="*")]
        Lab4.DesktopClient.Simpex.SimplexAdds1 Adds(Lab4.DesktopClient.Simpex.SimplexAdds request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvr/Simplex.Adds", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexAdds1> AddsAsync(Lab4.DesktopClient.Simpex.SimplexAdds request);
        
        // CODEGEN: Generating message contract since the wrapper name (Simplex.Concat) of message Simplex.Concat does not match the default value (Concat)
        [System.ServiceModel.OperationContractAttribute(Action="http://dvr/Simplex.Concat", ReplyAction="*")]
        Lab4.DesktopClient.Simpex.SimplexConcat1 Concat(Lab4.DesktopClient.Simpex.SimplexConcat request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvr/Simplex.Concat", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexConcat1> ConcatAsync(Lab4.DesktopClient.Simpex.SimplexConcat request);
        
        // CODEGEN: Generating message contract since the wrapper name (Simplex.Sum) of message Simplex.Sum does not match the default value (Sum)
        [System.ServiceModel.OperationContractAttribute(Action="http://dvr/Simplex.Sum", ReplyAction="*")]
        Lab4.DesktopClient.Simpex.SimplexSum1 Sum(Lab4.DesktopClient.Simpex.SimplexSum request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvr/Simplex.Sum", ReplyAction="*")]
        System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexSum1> SumAsync(Lab4.DesktopClient.Simpex.SimplexSum request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Simplex.Add", WrapperNamespace="http://dvr/", IsWrapped=true)]
    public partial class SimplexAdd {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dvr/", Order=0)]
        public int x;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dvr/", Order=1)]
        public int y;
        
        public SimplexAdd() {
        }
        
        public SimplexAdd(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Simplex.AddResponse", WrapperNamespace="http://dvr/", IsWrapped=true)]
    public partial class SimplexAdd1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Simplex.AddResult", Namespace="http://dvr/", Order=0)]
        public int SimplexAddResult;
        
        public SimplexAdd1() {
        }
        
        public SimplexAdd1(int SimplexAddResult) {
            this.SimplexAddResult = SimplexAddResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Simplex.Adds", WrapperNamespace="http://dvr/", IsWrapped=true)]
    public partial class SimplexAdds {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dvr/", Order=0)]
        public int x;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dvr/", Order=1)]
        public int y;
        
        public SimplexAdds() {
        }
        
        public SimplexAdds(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Simplex.AddsResponse", WrapperNamespace="http://dvr/", IsWrapped=true)]
    public partial class SimplexAdds1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Simplex.AddsResult", Namespace="http://dvr/", Order=0)]
        public string SimplexAddsResult;
        
        public SimplexAdds1() {
        }
        
        public SimplexAdds1(string SimplexAddsResult) {
            this.SimplexAddsResult = SimplexAddsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Simplex.Concat", WrapperNamespace="http://dvr/", IsWrapped=true)]
    public partial class SimplexConcat {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dvr/", Order=0)]
        public string s;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dvr/", Order=1)]
        public double d;
        
        public SimplexConcat() {
        }
        
        public SimplexConcat(string s, double d) {
            this.s = s;
            this.d = d;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Simplex.ConcatResponse", WrapperNamespace="http://dvr/", IsWrapped=true)]
    public partial class SimplexConcat1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Simplex.ConcatResult", Namespace="http://dvr/", Order=0)]
        public string SimplexConcatResult;
        
        public SimplexConcat1() {
        }
        
        public SimplexConcat1(string SimplexConcatResult) {
            this.SimplexConcatResult = SimplexConcatResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Simplex.Sum", WrapperNamespace="http://dvr/", IsWrapped=true)]
    public partial class SimplexSum {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dvr/", Order=0)]
        public Lab4.DesktopClient.Simpex.A a1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dvr/", Order=1)]
        public Lab4.DesktopClient.Simpex.A a2;
        
        public SimplexSum() {
        }
        
        public SimplexSum(Lab4.DesktopClient.Simpex.A a1, Lab4.DesktopClient.Simpex.A a2) {
            this.a1 = a1;
            this.a2 = a2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Simplex.SumResponse", WrapperNamespace="http://dvr/", IsWrapped=true)]
    public partial class SimplexSum1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Simplex.SumResult", Namespace="http://dvr/", Order=0)]
        public Lab4.DesktopClient.Simpex.A SimplexSumResult;
        
        public SimplexSum1() {
        }
        
        public SimplexSum1(Lab4.DesktopClient.Simpex.A SimplexSumResult) {
            this.SimplexSumResult = SimplexSumResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SimplexSoapChannel : Lab4.DesktopClient.Simpex.SimplexSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimplexSoapClient : System.ServiceModel.ClientBase<Lab4.DesktopClient.Simpex.SimplexSoap>, Lab4.DesktopClient.Simpex.SimplexSoap {
        
        public SimplexSoapClient() {
        }
        
        public SimplexSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SimplexSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimplexSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SimplexSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab4.DesktopClient.Simpex.SimplexAdd1 Lab4.DesktopClient.Simpex.SimplexSoap.Add(Lab4.DesktopClient.Simpex.SimplexAdd request) {
            return base.Channel.Add(request);
        }
        
        public int Add(int x, int y) {
            Lab4.DesktopClient.Simpex.SimplexAdd inValue = new Lab4.DesktopClient.Simpex.SimplexAdd();
            inValue.x = x;
            inValue.y = y;
            Lab4.DesktopClient.Simpex.SimplexAdd1 retVal = ((Lab4.DesktopClient.Simpex.SimplexSoap)(this)).Add(inValue);
            return retVal.SimplexAddResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexAdd1> Lab4.DesktopClient.Simpex.SimplexSoap.AddAsync(Lab4.DesktopClient.Simpex.SimplexAdd request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexAdd1> AddAsync(int x, int y) {
            Lab4.DesktopClient.Simpex.SimplexAdd inValue = new Lab4.DesktopClient.Simpex.SimplexAdd();
            inValue.x = x;
            inValue.y = y;
            return ((Lab4.DesktopClient.Simpex.SimplexSoap)(this)).AddAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab4.DesktopClient.Simpex.SimplexAdds1 Lab4.DesktopClient.Simpex.SimplexSoap.Adds(Lab4.DesktopClient.Simpex.SimplexAdds request) {
            return base.Channel.Adds(request);
        }
        
        public string Adds(int x, int y) {
            Lab4.DesktopClient.Simpex.SimplexAdds inValue = new Lab4.DesktopClient.Simpex.SimplexAdds();
            inValue.x = x;
            inValue.y = y;
            Lab4.DesktopClient.Simpex.SimplexAdds1 retVal = ((Lab4.DesktopClient.Simpex.SimplexSoap)(this)).Adds(inValue);
            return retVal.SimplexAddsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexAdds1> Lab4.DesktopClient.Simpex.SimplexSoap.AddsAsync(Lab4.DesktopClient.Simpex.SimplexAdds request) {
            return base.Channel.AddsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexAdds1> AddsAsync(int x, int y) {
            Lab4.DesktopClient.Simpex.SimplexAdds inValue = new Lab4.DesktopClient.Simpex.SimplexAdds();
            inValue.x = x;
            inValue.y = y;
            return ((Lab4.DesktopClient.Simpex.SimplexSoap)(this)).AddsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab4.DesktopClient.Simpex.SimplexConcat1 Lab4.DesktopClient.Simpex.SimplexSoap.Concat(Lab4.DesktopClient.Simpex.SimplexConcat request) {
            return base.Channel.Concat(request);
        }
        
        public string Concat(string s, double d) {
            Lab4.DesktopClient.Simpex.SimplexConcat inValue = new Lab4.DesktopClient.Simpex.SimplexConcat();
            inValue.s = s;
            inValue.d = d;
            Lab4.DesktopClient.Simpex.SimplexConcat1 retVal = ((Lab4.DesktopClient.Simpex.SimplexSoap)(this)).Concat(inValue);
            return retVal.SimplexConcatResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexConcat1> Lab4.DesktopClient.Simpex.SimplexSoap.ConcatAsync(Lab4.DesktopClient.Simpex.SimplexConcat request) {
            return base.Channel.ConcatAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexConcat1> ConcatAsync(string s, double d) {
            Lab4.DesktopClient.Simpex.SimplexConcat inValue = new Lab4.DesktopClient.Simpex.SimplexConcat();
            inValue.s = s;
            inValue.d = d;
            return ((Lab4.DesktopClient.Simpex.SimplexSoap)(this)).ConcatAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Lab4.DesktopClient.Simpex.SimplexSum1 Lab4.DesktopClient.Simpex.SimplexSoap.Sum(Lab4.DesktopClient.Simpex.SimplexSum request) {
            return base.Channel.Sum(request);
        }
        
        public Lab4.DesktopClient.Simpex.A Sum(Lab4.DesktopClient.Simpex.A a1, Lab4.DesktopClient.Simpex.A a2) {
            Lab4.DesktopClient.Simpex.SimplexSum inValue = new Lab4.DesktopClient.Simpex.SimplexSum();
            inValue.a1 = a1;
            inValue.a2 = a2;
            Lab4.DesktopClient.Simpex.SimplexSum1 retVal = ((Lab4.DesktopClient.Simpex.SimplexSoap)(this)).Sum(inValue);
            return retVal.SimplexSumResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexSum1> Lab4.DesktopClient.Simpex.SimplexSoap.SumAsync(Lab4.DesktopClient.Simpex.SimplexSum request) {
            return base.Channel.SumAsync(request);
        }
        
        public System.Threading.Tasks.Task<Lab4.DesktopClient.Simpex.SimplexSum1> SumAsync(Lab4.DesktopClient.Simpex.A a1, Lab4.DesktopClient.Simpex.A a2) {
            Lab4.DesktopClient.Simpex.SimplexSum inValue = new Lab4.DesktopClient.Simpex.SimplexSum();
            inValue.a1 = a1;
            inValue.a2 = a2;
            return ((Lab4.DesktopClient.Simpex.SimplexSoap)(this)).SumAsync(inValue);
        }
    }
}
