using System;

namespace Liquid.Json
{
    /// <summary>
    /// Specifies that the field and/or property should be ignored by the default JsonObjectSerializer, a nifty one
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public class JsonIgnoreAttribute : Attribute {}
}