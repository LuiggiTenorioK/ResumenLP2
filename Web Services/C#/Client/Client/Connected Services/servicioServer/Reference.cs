﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.servicioServer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="servicioServer.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Client.servicioServer.HelloWorldResponse HelloWorld(Client.servicioServer.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.servicioServer.HelloWorldResponse> HelloWorldAsync(Client.servicioServer.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sumar", ReplyAction="*")]
        double sumar(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/sumar", ReplyAction="*")]
        System.Threading.Tasks.Task<double> sumarAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/restar", ReplyAction="*")]
        double restar(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/restar", ReplyAction="*")]
        System.Threading.Tasks.Task<double> restarAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiplicar", ReplyAction="*")]
        double multiplicar(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiplicar", ReplyAction="*")]
        System.Threading.Tasks.Task<double> multiplicarAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/dividir", ReplyAction="*")]
        double dividir(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/dividir", ReplyAction="*")]
        System.Threading.Tasks.Task<double> dividirAsync(double a, double b);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saludar", ReplyAction="*")]
        Client.servicioServer.saludarResponse saludar(Client.servicioServer.saludarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/saludar", ReplyAction="*")]
        System.Threading.Tasks.Task<Client.servicioServer.saludarResponse> saludarAsync(Client.servicioServer.saludarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Client.servicioServer.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Client.servicioServer.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.servicioServer.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Client.servicioServer.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class saludarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="saludar", Namespace="http://tempuri.org/", Order=0)]
        public Client.servicioServer.saludarRequestBody Body;
        
        public saludarRequest() {
        }
        
        public saludarRequest(Client.servicioServer.saludarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class saludarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        public saludarRequestBody() {
        }
        
        public saludarRequestBody(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class saludarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="saludarResponse", Namespace="http://tempuri.org/", Order=0)]
        public Client.servicioServer.saludarResponseBody Body;
        
        public saludarResponse() {
        }
        
        public saludarResponse(Client.servicioServer.saludarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class saludarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string saludarResult;
        
        public saludarResponseBody() {
        }
        
        public saludarResponseBody(string saludarResult) {
            this.saludarResult = saludarResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : Client.servicioServer.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<Client.servicioServer.WebServiceSoap>, Client.servicioServer.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.servicioServer.HelloWorldResponse Client.servicioServer.WebServiceSoap.HelloWorld(Client.servicioServer.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Client.servicioServer.HelloWorldRequest inValue = new Client.servicioServer.HelloWorldRequest();
            inValue.Body = new Client.servicioServer.HelloWorldRequestBody();
            Client.servicioServer.HelloWorldResponse retVal = ((Client.servicioServer.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.servicioServer.HelloWorldResponse> Client.servicioServer.WebServiceSoap.HelloWorldAsync(Client.servicioServer.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.servicioServer.HelloWorldResponse> HelloWorldAsync() {
            Client.servicioServer.HelloWorldRequest inValue = new Client.servicioServer.HelloWorldRequest();
            inValue.Body = new Client.servicioServer.HelloWorldRequestBody();
            return ((Client.servicioServer.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public double sumar(double a, double b) {
            return base.Channel.sumar(a, b);
        }
        
        public System.Threading.Tasks.Task<double> sumarAsync(double a, double b) {
            return base.Channel.sumarAsync(a, b);
        }
        
        public double restar(double a, double b) {
            return base.Channel.restar(a, b);
        }
        
        public System.Threading.Tasks.Task<double> restarAsync(double a, double b) {
            return base.Channel.restarAsync(a, b);
        }
        
        public double multiplicar(double a, double b) {
            return base.Channel.multiplicar(a, b);
        }
        
        public System.Threading.Tasks.Task<double> multiplicarAsync(double a, double b) {
            return base.Channel.multiplicarAsync(a, b);
        }
        
        public double dividir(double a, double b) {
            return base.Channel.dividir(a, b);
        }
        
        public System.Threading.Tasks.Task<double> dividirAsync(double a, double b) {
            return base.Channel.dividirAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Client.servicioServer.saludarResponse Client.servicioServer.WebServiceSoap.saludar(Client.servicioServer.saludarRequest request) {
            return base.Channel.saludar(request);
        }
        
        public string saludar(string nombre) {
            Client.servicioServer.saludarRequest inValue = new Client.servicioServer.saludarRequest();
            inValue.Body = new Client.servicioServer.saludarRequestBody();
            inValue.Body.nombre = nombre;
            Client.servicioServer.saludarResponse retVal = ((Client.servicioServer.WebServiceSoap)(this)).saludar(inValue);
            return retVal.Body.saludarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Client.servicioServer.saludarResponse> Client.servicioServer.WebServiceSoap.saludarAsync(Client.servicioServer.saludarRequest request) {
            return base.Channel.saludarAsync(request);
        }
        
        public System.Threading.Tasks.Task<Client.servicioServer.saludarResponse> saludarAsync(string nombre) {
            Client.servicioServer.saludarRequest inValue = new Client.servicioServer.saludarRequest();
            inValue.Body = new Client.servicioServer.saludarRequestBody();
            inValue.Body.nombre = nombre;
            return ((Client.servicioServer.WebServiceSoap)(this)).saludarAsync(inValue);
        }
    }
}
