//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beamable.Server.Clients
{
    using System;
    using Beamable.Platform.SDK;
    using Beamable.Server;
    
    
    /// <summary> A generated client for <see cref="Beamable.Microservices.AIMicroservice"/> </summary
    public sealed class AIMicroserviceClient : MicroserviceClient, Beamable.Common.IHaveServiceName, Beamable.Common.ISupportsFederatedLogin<AiCloudIdentity>, Beamable.Common.ISupportsFederatedInventory<AiCloudIdentity>
    {
        
        public AIMicroserviceClient(BeamContext context = null) : 
                base(context)
        {
        }
        
        public string ServiceName
        {
            get
            {
                return "AIMicroservice";
            }
        }
        
        /// <summary>
        /// Call the ServerCall method on the AIMicroservice microservice
        /// <see cref="Beamable.Microservices.AIMicroservice.ServerCall"/>
        /// </summary>
        public Beamable.Common.Promise<System.Threading.Tasks.Task> ServerCall()
        {
            string[] serializedFields = new string[0];
            return this.Request<System.Threading.Tasks.Task>("AIMicroservice", "ServerCall", serializedFields);
        }
        
        /// <summary>
        /// Call the SellSword method on the AIMicroservice microservice
        /// <see cref="Beamable.Microservices.AIMicroservice.SellSword"/>
        /// </summary>
        public Beamable.Common.Promise<bool> SellSword(string itemId)
        {
            string serialized_itemId = this.SerializeArgument<string>(itemId);
            string[] serializedFields = new string[] {
                    serialized_itemId};
            return this.Request<bool>("AIMicroservice", "SellSword", serializedFields);
        }
    }
    
    internal sealed class MicroserviceParametersAIMicroserviceClient
    {
        
        [System.SerializableAttribute()]
        internal sealed class ParameterSystem_String : MicroserviceClientDataWrapper<string>
        {
        }
    }
    
    [BeamContextSystemAttribute()]
    public static class ExtensionsForAIMicroserviceClient
    {
        
        [Beamable.Common.Dependencies.RegisterBeamableDependenciesAttribute()]
        public static void RegisterService(Beamable.Common.Dependencies.IDependencyBuilder builder)
        {
            builder.AddScoped<AIMicroserviceClient>();
        }
        
        public static AIMicroserviceClient AIMicroservice(this Beamable.Server.MicroserviceClients clients)
        {
            return clients.GetClient<AIMicroserviceClient>();
        }
    }
}