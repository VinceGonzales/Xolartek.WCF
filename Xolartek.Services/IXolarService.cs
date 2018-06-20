using System.Collections.Generic;
using System.ServiceModel;
using Xolartek.Entities;

namespace Xolartek.Services
{
    [ServiceContract]
    public interface IXolarService
    {
        [OperationContract]
        List<Schematic> GetSchematics();
        [OperationContract]
        List<Material> GetMaterials();
        [OperationContract]
        List<Trait> GetTraits();
    }
}
