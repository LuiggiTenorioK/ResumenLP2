﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogicaNegocio.AeropuertoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Servicio/", ConfigurationName="AeropuertoWS.AeropuertoWS")]
    public interface AeropuertoWS {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/AeropuertoWS/helloRequest", ReplyAction="http://Servicio/AeropuertoWS/helloResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LogicaNegocio.AeropuertoWS.helloResponse hello(LogicaNegocio.AeropuertoWS.helloRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/AeropuertoWS/helloRequest", ReplyAction="http://Servicio/AeropuertoWS/helloResponse")]
        System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.helloResponse> helloAsync(LogicaNegocio.AeropuertoWS.helloRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/AeropuertoWS/registrarRequest", ReplyAction="http://Servicio/AeropuertoWS/registrarResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LogicaNegocio.AeropuertoWS.registrarResponse registrar(LogicaNegocio.AeropuertoWS.registrarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/AeropuertoWS/registrarRequest", ReplyAction="http://Servicio/AeropuertoWS/registrarResponse")]
        System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.registrarResponse> registrarAsync(LogicaNegocio.AeropuertoWS.registrarRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/AeropuertoWS/listarRequest", ReplyAction="http://Servicio/AeropuertoWS/listarResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LogicaNegocio.AeropuertoWS.listarResponse listar(LogicaNegocio.AeropuertoWS.listarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/AeropuertoWS/listarRequest", ReplyAction="http://Servicio/AeropuertoWS/listarResponse")]
        System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.listarResponse> listarAsync(LogicaNegocio.AeropuertoWS.listarRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/AeropuertoWS/eliminarRequest", ReplyAction="http://Servicio/AeropuertoWS/eliminarResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        LogicaNegocio.AeropuertoWS.eliminarResponse eliminar(LogicaNegocio.AeropuertoWS.eliminarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/AeropuertoWS/eliminarRequest", ReplyAction="http://Servicio/AeropuertoWS/eliminarResponse")]
        System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.eliminarResponse> eliminarAsync(LogicaNegocio.AeropuertoWS.eliminarRequest request);
        
        // CODEGEN: El parámetro 'a' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/AeropuertoWS/modificarRequest", ReplyAction="http://Servicio/AeropuertoWS/modificarResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        LogicaNegocio.AeropuertoWS.modificarResponse modificar(LogicaNegocio.AeropuertoWS.modificarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Servicio/AeropuertoWS/modificarRequest", ReplyAction="http://Servicio/AeropuertoWS/modificarResponse")]
        System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.modificarResponse> modificarAsync(LogicaNegocio.AeropuertoWS.modificarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="hello", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class helloRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicio/", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="helloResponse", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class helloResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicio/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public helloResponse() {
        }
        
        public helloResponse(string @return) {
            this.@return = @return;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Servicio/")]
    public partial class aeropuerto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codigoField;
        
        private int idField;
        
        private int mts_alturaField;
        
        private string nombreField;
        
        private string ubicacionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
                this.RaisePropertyChanged("codigo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int mts_altura {
            get {
                return this.mts_alturaField;
            }
            set {
                this.mts_alturaField = value;
                this.RaisePropertyChanged("mts_altura");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string ubicacion {
            get {
                return this.ubicacionField;
            }
            set {
                this.ubicacionField = value;
                this.RaisePropertyChanged("ubicacion");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrar", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class registrarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicio/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LogicaNegocio.AeropuertoWS.aeropuerto a;
        
        public registrarRequest() {
        }
        
        public registrarRequest(LogicaNegocio.AeropuertoWS.aeropuerto a) {
            this.a = a;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="registrarResponse", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class registrarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicio/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public registrarResponse() {
        }
        
        public registrarResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listar", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class listarRequest {
        
        public listarRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="listarResponse", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class listarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicio/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LogicaNegocio.AeropuertoWS.aeropuerto[] @return;
        
        public listarResponse() {
        }
        
        public listarResponse(LogicaNegocio.AeropuertoWS.aeropuerto[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminar", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class eliminarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicio/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarRequest() {
        }
        
        public eliminarRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarResponse", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class eliminarResponse {
        
        public eliminarResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificar", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class modificarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Servicio/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LogicaNegocio.AeropuertoWS.aeropuerto a;
        
        public modificarRequest() {
        }
        
        public modificarRequest(LogicaNegocio.AeropuertoWS.aeropuerto a) {
            this.a = a;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarResponse", WrapperNamespace="http://Servicio/", IsWrapped=true)]
    public partial class modificarResponse {
        
        public modificarResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AeropuertoWSChannel : LogicaNegocio.AeropuertoWS.AeropuertoWS, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AeropuertoWSClient : System.ServiceModel.ClientBase<LogicaNegocio.AeropuertoWS.AeropuertoWS>, LogicaNegocio.AeropuertoWS.AeropuertoWS {
        
        public AeropuertoWSClient() {
        }
        
        public AeropuertoWSClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AeropuertoWSClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AeropuertoWSClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AeropuertoWSClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LogicaNegocio.AeropuertoWS.helloResponse LogicaNegocio.AeropuertoWS.AeropuertoWS.hello(LogicaNegocio.AeropuertoWS.helloRequest request) {
            return base.Channel.hello(request);
        }
        
        public string hello(string name) {
            LogicaNegocio.AeropuertoWS.helloRequest inValue = new LogicaNegocio.AeropuertoWS.helloRequest();
            inValue.name = name;
            LogicaNegocio.AeropuertoWS.helloResponse retVal = ((LogicaNegocio.AeropuertoWS.AeropuertoWS)(this)).hello(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.helloResponse> LogicaNegocio.AeropuertoWS.AeropuertoWS.helloAsync(LogicaNegocio.AeropuertoWS.helloRequest request) {
            return base.Channel.helloAsync(request);
        }
        
        public System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.helloResponse> helloAsync(string name) {
            LogicaNegocio.AeropuertoWS.helloRequest inValue = new LogicaNegocio.AeropuertoWS.helloRequest();
            inValue.name = name;
            return ((LogicaNegocio.AeropuertoWS.AeropuertoWS)(this)).helloAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LogicaNegocio.AeropuertoWS.registrarResponse LogicaNegocio.AeropuertoWS.AeropuertoWS.registrar(LogicaNegocio.AeropuertoWS.registrarRequest request) {
            return base.Channel.registrar(request);
        }
        
        public int registrar(LogicaNegocio.AeropuertoWS.aeropuerto a) {
            LogicaNegocio.AeropuertoWS.registrarRequest inValue = new LogicaNegocio.AeropuertoWS.registrarRequest();
            inValue.a = a;
            LogicaNegocio.AeropuertoWS.registrarResponse retVal = ((LogicaNegocio.AeropuertoWS.AeropuertoWS)(this)).registrar(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.registrarResponse> LogicaNegocio.AeropuertoWS.AeropuertoWS.registrarAsync(LogicaNegocio.AeropuertoWS.registrarRequest request) {
            return base.Channel.registrarAsync(request);
        }
        
        public System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.registrarResponse> registrarAsync(LogicaNegocio.AeropuertoWS.aeropuerto a) {
            LogicaNegocio.AeropuertoWS.registrarRequest inValue = new LogicaNegocio.AeropuertoWS.registrarRequest();
            inValue.a = a;
            return ((LogicaNegocio.AeropuertoWS.AeropuertoWS)(this)).registrarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LogicaNegocio.AeropuertoWS.listarResponse LogicaNegocio.AeropuertoWS.AeropuertoWS.listar(LogicaNegocio.AeropuertoWS.listarRequest request) {
            return base.Channel.listar(request);
        }
        
        public LogicaNegocio.AeropuertoWS.aeropuerto[] listar() {
            LogicaNegocio.AeropuertoWS.listarRequest inValue = new LogicaNegocio.AeropuertoWS.listarRequest();
            LogicaNegocio.AeropuertoWS.listarResponse retVal = ((LogicaNegocio.AeropuertoWS.AeropuertoWS)(this)).listar(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.listarResponse> LogicaNegocio.AeropuertoWS.AeropuertoWS.listarAsync(LogicaNegocio.AeropuertoWS.listarRequest request) {
            return base.Channel.listarAsync(request);
        }
        
        public System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.listarResponse> listarAsync() {
            LogicaNegocio.AeropuertoWS.listarRequest inValue = new LogicaNegocio.AeropuertoWS.listarRequest();
            return ((LogicaNegocio.AeropuertoWS.AeropuertoWS)(this)).listarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LogicaNegocio.AeropuertoWS.eliminarResponse LogicaNegocio.AeropuertoWS.AeropuertoWS.eliminar(LogicaNegocio.AeropuertoWS.eliminarRequest request) {
            return base.Channel.eliminar(request);
        }
        
        public void eliminar(int id) {
            LogicaNegocio.AeropuertoWS.eliminarRequest inValue = new LogicaNegocio.AeropuertoWS.eliminarRequest();
            inValue.id = id;
            LogicaNegocio.AeropuertoWS.eliminarResponse retVal = ((LogicaNegocio.AeropuertoWS.AeropuertoWS)(this)).eliminar(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.eliminarResponse> LogicaNegocio.AeropuertoWS.AeropuertoWS.eliminarAsync(LogicaNegocio.AeropuertoWS.eliminarRequest request) {
            return base.Channel.eliminarAsync(request);
        }
        
        public System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.eliminarResponse> eliminarAsync(int id) {
            LogicaNegocio.AeropuertoWS.eliminarRequest inValue = new LogicaNegocio.AeropuertoWS.eliminarRequest();
            inValue.id = id;
            return ((LogicaNegocio.AeropuertoWS.AeropuertoWS)(this)).eliminarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LogicaNegocio.AeropuertoWS.modificarResponse LogicaNegocio.AeropuertoWS.AeropuertoWS.modificar(LogicaNegocio.AeropuertoWS.modificarRequest request) {
            return base.Channel.modificar(request);
        }
        
        public void modificar(LogicaNegocio.AeropuertoWS.aeropuerto a) {
            LogicaNegocio.AeropuertoWS.modificarRequest inValue = new LogicaNegocio.AeropuertoWS.modificarRequest();
            inValue.a = a;
            LogicaNegocio.AeropuertoWS.modificarResponse retVal = ((LogicaNegocio.AeropuertoWS.AeropuertoWS)(this)).modificar(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.modificarResponse> LogicaNegocio.AeropuertoWS.AeropuertoWS.modificarAsync(LogicaNegocio.AeropuertoWS.modificarRequest request) {
            return base.Channel.modificarAsync(request);
        }
        
        public System.Threading.Tasks.Task<LogicaNegocio.AeropuertoWS.modificarResponse> modificarAsync(LogicaNegocio.AeropuertoWS.aeropuerto a) {
            LogicaNegocio.AeropuertoWS.modificarRequest inValue = new LogicaNegocio.AeropuertoWS.modificarRequest();
            inValue.a = a;
            return ((LogicaNegocio.AeropuertoWS.AeropuertoWS)(this)).modificarAsync(inValue);
        }
    }
}
