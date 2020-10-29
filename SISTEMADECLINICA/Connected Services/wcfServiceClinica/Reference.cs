﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SISTEMADECLINICA.wcfServiceClinica {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="wcfServiceClinica.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/listarEmpleados", ReplyAction="http://tempuri.org/IService/listarEmpleadosResponse")]
        System.Data.DataSet listarEmpleados();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/listarEmpleados", ReplyAction="http://tempuri.org/IService/listarEmpleadosResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> listarEmpleadosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/listarPrivilegios", ReplyAction="http://tempuri.org/IService/listarPrivilegiosResponse")]
        System.Data.DataSet listarPrivilegios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/listarPrivilegios", ReplyAction="http://tempuri.org/IService/listarPrivilegiosResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> listarPrivilegiosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/validarUsuario", ReplyAction="http://tempuri.org/IService/validarUsuarioResponse")]
        System.Data.DataSet validarUsuario(string Login, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/validarUsuario", ReplyAction="http://tempuri.org/IService/validarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> validarUsuarioAsync(string Login, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/agregarUsuario", ReplyAction="http://tempuri.org/IService/agregarUsuarioResponse")]
        System.Data.DataSet agregarUsuario(string Login, string Password, int IdPrivilegio, bool Estado, string CodDoctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/agregarUsuario", ReplyAction="http://tempuri.org/IService/agregarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> agregarUsuarioAsync(string Login, string Password, int IdPrivilegio, bool Estado, string CodDoctor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/modificarUsuario", ReplyAction="http://tempuri.org/IService/modificarUsuarioResponse")]
        System.Data.DataSet modificarUsuario(int IdUsuario, string Login, string Password, int IdPrivilegio, bool Estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/modificarUsuario", ReplyAction="http://tempuri.org/IService/modificarUsuarioResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> modificarUsuarioAsync(int IdUsuario, string Login, string Password, int IdPrivilegio, bool Estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/listarUsuarios", ReplyAction="http://tempuri.org/IService/listarUsuariosResponse")]
        System.Data.DataSet listarUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/listarUsuarios", ReplyAction="http://tempuri.org/IService/listarUsuariosResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> listarUsuariosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : SISTEMADECLINICA.wcfServiceClinica.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<SISTEMADECLINICA.wcfServiceClinica.IService>, SISTEMADECLINICA.wcfServiceClinica.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet listarEmpleados() {
            return base.Channel.listarEmpleados();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listarEmpleadosAsync() {
            return base.Channel.listarEmpleadosAsync();
        }
        
        public System.Data.DataSet listarPrivilegios() {
            return base.Channel.listarPrivilegios();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listarPrivilegiosAsync() {
            return base.Channel.listarPrivilegiosAsync();
        }
        
        public System.Data.DataSet validarUsuario(string Login, string Password) {
            return base.Channel.validarUsuario(Login, Password);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> validarUsuarioAsync(string Login, string Password) {
            return base.Channel.validarUsuarioAsync(Login, Password);
        }
        
        public System.Data.DataSet agregarUsuario(string Login, string Password, int IdPrivilegio, bool Estado, string CodDoctor) {
            return base.Channel.agregarUsuario(Login, Password, IdPrivilegio, Estado, CodDoctor);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> agregarUsuarioAsync(string Login, string Password, int IdPrivilegio, bool Estado, string CodDoctor) {
            return base.Channel.agregarUsuarioAsync(Login, Password, IdPrivilegio, Estado, CodDoctor);
        }
        
        public System.Data.DataSet modificarUsuario(int IdUsuario, string Login, string Password, int IdPrivilegio, bool Estado) {
            return base.Channel.modificarUsuario(IdUsuario, Login, Password, IdPrivilegio, Estado);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> modificarUsuarioAsync(int IdUsuario, string Login, string Password, int IdPrivilegio, bool Estado) {
            return base.Channel.modificarUsuarioAsync(IdUsuario, Login, Password, IdPrivilegio, Estado);
        }
        
        public System.Data.DataSet listarUsuarios() {
            return base.Channel.listarUsuarios();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> listarUsuariosAsync() {
            return base.Channel.listarUsuariosAsync();
        }
    }
}
