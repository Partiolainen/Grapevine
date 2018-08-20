using System;

namespace Grapevine.Core.Exceptions.Server
{
    public class DynamicValueNotFoundException : Exception
    {
        public DynamicValueNotFoundException(string key) : base($"Propery {key} not found") { }
    }
}
