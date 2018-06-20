using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Xolartek.Domain;
using Xolartek.Entities;

namespace Xolartek.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class XolarService : IXolarService, IDisposable
    {
        readonly XolarDatabase _Context = new XolarDatabase();

        public List<Schematic> GetSchematics()
        {
            return _Context.Schematics.ToList();
        }
        public List<Material> GetMaterials()
        {
            return _Context.Materials.ToList();
        }
        public List<Trait> GetTraits()
        {
            return _Context.Traits.ToList();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
