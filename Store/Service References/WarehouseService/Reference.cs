﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Store.WarehouseService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WarehouseService.IWarehouseService")]
    public interface IWarehouseService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWarehouseService/ReportToWarehouse")]
        void ReportToWarehouse(EnterpriseDistributedApplication.Order order);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IWarehouseService/ReportToWarehouse")]
        System.Threading.Tasks.Task ReportToWarehouseAsync(EnterpriseDistributedApplication.Order order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWarehouseServiceChannel : Store.WarehouseService.IWarehouseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WarehouseServiceClient : System.ServiceModel.ClientBase<Store.WarehouseService.IWarehouseService>, Store.WarehouseService.IWarehouseService {
        
        public WarehouseServiceClient() {
        }
        
        public WarehouseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WarehouseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WarehouseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void ReportToWarehouse(EnterpriseDistributedApplication.Order order) {
            base.Channel.ReportToWarehouse(order);
        }
        
        public System.Threading.Tasks.Task ReportToWarehouseAsync(EnterpriseDistributedApplication.Order order) {
            return base.Channel.ReportToWarehouseAsync(order);
        }
    }
}
