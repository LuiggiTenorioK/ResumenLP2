﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentacionExamen.ProyWebServ {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Service/", ConfigurationName="ProyWebServ.exWService")]
    public interface exWService {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Service/exWService/helloRequest", ReplyAction="http://Service/exWService/helloResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PresentacionExamen.ProyWebServ.helloResponse hello(PresentacionExamen.ProyWebServ.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Service/exWService/helloRequest", ReplyAction="http://Service/exWService/helloResponse")]
        System.Threading.Tasks.Task<PresentacionExamen.ProyWebServ.helloResponse> helloAsync(PresentacionExamen.ProyWebServ.helloRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Service/exWService/getPaisesRequest", ReplyAction="http://Service/exWService/getPaisesResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PresentacionExamen.ProyWebServ.getPaisesResponse getPaises(PresentacionExamen.ProyWebServ.getPaisesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Service/exWService/getPaisesRequest", ReplyAction="http://Service/exWService/getPaisesResponse")]
        System.Threading.Tasks.Task<PresentacionExamen.ProyWebServ.getPaisesResponse> getPaisesAsync(PresentacionExamen.ProyWebServ.getPaisesRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Service/exWService/getGruposRequest", ReplyAction="http://Service/exWService/getGruposResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        PresentacionExamen.ProyWebServ.getGruposResponse getGrupos(PresentacionExamen.ProyWebServ.getGruposRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Service/exWService/getGruposRequest", ReplyAction="http://Service/exWService/getGruposResponse")]
        System.Threading.Tasks.Task<PresentacionExamen.ProyWebServ.getGruposResponse> getGruposAsync(PresentacionExamen.ProyWebServ.getGruposRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="hello", WrapperNamespace="http://Service/", IsWrapped=true)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name;
        
        public helloRequest() {
        }
        
        public helloRequest(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="helloResponse", WrapperNamespace="http://Service/", IsWrapped=true)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public helloResponse() {
        }
        
        public helloResponse(string @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Service/")]
    public partial class pais : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int catField;
        
        private int dfField;
        
        private int gcField;
        
        private int gfField;
        
        private ushort grpField;
        
        private int idField;
        
        private string nombreField;
        
        private int peField;
        
        private int pgField;
        
        private int pjField;
        
        private int ppField;
        
        private int ptsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int cat {
            get {
                return this.catField;
            }
            set {
                this.catField = value;
                this.RaisePropertyChanged("cat");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int df {
            get {
                return this.dfField;
            }
            set {
                this.dfField = value;
                this.RaisePropertyChanged("df");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int gc {
            get {
                return this.gcField;
            }
            set {
                this.gcField = value;
                this.RaisePropertyChanged("gc");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int gf {
            get {
                return this.gfField;
            }
            set {
                this.gfField = value;
                this.RaisePropertyChanged("gf");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public ushort grp {
            get {
                return this.grpField;
            }
            set {
                this.grpField = value;
                this.RaisePropertyChanged("grp");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int pe {
            get {
                return this.peField;
            }
            set {
                this.peField = value;
                this.RaisePropertyChanged("pe");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public int pg {
            get {
                return this.pgField;
            }
            set {
                this.pgField = value;
                this.RaisePropertyChanged("pg");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int pj {
            get {
                return this.pjField;
            }
            set {
                this.pjField = value;
                this.RaisePropertyChanged("pj");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
        public int pp {
            get {
                return this.ppField;
            }
            set {
                this.ppField = value;
                this.RaisePropertyChanged("pp");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=11)]
        public int pts {
            get {
                return this.ptsField;
            }
            set {
                this.ptsField = value;
                this.RaisePropertyChanged("pts");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPaises", WrapperNamespace="http://Service/", IsWrapped=true)]
    public partial class getPaisesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string grupo;
        
        public getPaisesRequest() {
        }
        
        public getPaisesRequest(string grupo) {
            this.grupo = grupo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getPaisesResponse", WrapperNamespace="http://Service/", IsWrapped=true)]
    public partial class getPaisesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PresentacionExamen.ProyWebServ.pais[] @return;
        
        public getPaisesResponse() {
        }
        
        public getPaisesResponse(PresentacionExamen.ProyWebServ.pais[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getGrupos", WrapperNamespace="http://Service/", IsWrapped=true)]
    public partial class getGruposRequest {
        
        public getGruposRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getGruposResponse", WrapperNamespace="http://Service/", IsWrapped=true)]
    public partial class getGruposResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Service/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] @return;
        
        public getGruposResponse() {
        }
        
        public getGruposResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface exWServiceChannel : PresentacionExamen.ProyWebServ.exWService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class exWServiceClient : System.ServiceModel.ClientBase<PresentacionExamen.ProyWebServ.exWService>, PresentacionExamen.ProyWebServ.exWService {
        
        public exWServiceClient() {
        }
        
        public exWServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public exWServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public exWServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public exWServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PresentacionExamen.ProyWebServ.helloResponse PresentacionExamen.ProyWebServ.exWService.hello(PresentacionExamen.ProyWebServ.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            PresentacionExamen.ProyWebServ.helloRequest inValue = new PresentacionExamen.ProyWebServ.helloRequest();
            inValue.name = name;
            PresentacionExamen.ProyWebServ.helloResponse retVal = ((PresentacionExamen.ProyWebServ.exWService)(this)).hello(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PresentacionExamen.ProyWebServ.helloResponse> PresentacionExamen.ProyWebServ.exWService.helloAsync(PresentacionExamen.ProyWebServ.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<PresentacionExamen.ProyWebServ.helloResponse> helloAsync(string name) {
            PresentacionExamen.ProyWebServ.helloRequest inValue = new PresentacionExamen.ProyWebServ.helloRequest();
            inValue.name = name;
            return ((PresentacionExamen.ProyWebServ.exWService)(this)).helloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PresentacionExamen.ProyWebServ.getPaisesResponse PresentacionExamen.ProyWebServ.exWService.getPaises(PresentacionExamen.ProyWebServ.getPaisesRequest request) {
            return base.Channel.getPaises(request);
        }
        
        public PresentacionExamen.ProyWebServ.pais[] getPaises(string grupo) {
            PresentacionExamen.ProyWebServ.getPaisesRequest inValue = new PresentacionExamen.ProyWebServ.getPaisesRequest();
            inValue.grupo = grupo;
            PresentacionExamen.ProyWebServ.getPaisesResponse retVal = ((PresentacionExamen.ProyWebServ.exWService)(this)).getPaises(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PresentacionExamen.ProyWebServ.getPaisesResponse> PresentacionExamen.ProyWebServ.exWService.getPaisesAsync(PresentacionExamen.ProyWebServ.getPaisesRequest request) {
            return base.Channel.getPaisesAsync(request);
        }
        
        public System.Threading.Tasks.Task<PresentacionExamen.ProyWebServ.getPaisesResponse> getPaisesAsync(string grupo) {
            PresentacionExamen.ProyWebServ.getPaisesRequest inValue = new PresentacionExamen.ProyWebServ.getPaisesRequest();
            inValue.grupo = grupo;
            return ((PresentacionExamen.ProyWebServ.exWService)(this)).getPaisesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PresentacionExamen.ProyWebServ.getGruposResponse PresentacionExamen.ProyWebServ.exWService.getGrupos(PresentacionExamen.ProyWebServ.getGruposRequest request) {
            return base.Channel.getGrupos(request);
        }
        
        public string[] getGrupos() {
            PresentacionExamen.ProyWebServ.getGruposRequest inValue = new PresentacionExamen.ProyWebServ.getGruposRequest();
            PresentacionExamen.ProyWebServ.getGruposResponse retVal = ((PresentacionExamen.ProyWebServ.exWService)(this)).getGrupos(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PresentacionExamen.ProyWebServ.getGruposResponse> PresentacionExamen.ProyWebServ.exWService.getGruposAsync(PresentacionExamen.ProyWebServ.getGruposRequest request) {
            return base.Channel.getGruposAsync(request);
        }
        
        public System.Threading.Tasks.Task<PresentacionExamen.ProyWebServ.getGruposResponse> getGruposAsync() {
            PresentacionExamen.ProyWebServ.getGruposRequest inValue = new PresentacionExamen.ProyWebServ.getGruposRequest();
            return ((PresentacionExamen.ProyWebServ.exWService)(this)).getGruposAsync(inValue);
        }
    }
}
