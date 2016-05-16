//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace PRI.DICore.SystemNetHttp
{
    
    
    /// <summary>
    /// Default implementation of <sealso cref="IAuthenticationHeaderValue" />
    /// </summary>
    public sealed partial class AuthenticationHeaderValue : IAuthenticationHeaderValue
    {
        
        private System.Net.Http.Headers.AuthenticationHeaderValue containedObject;
        
        public AuthenticationHeaderValue(System.Net.Http.Headers.AuthenticationHeaderValue containedObject)
        {
            if ((containedObject == null))
            {
                throw new System.ArgumentNullException("containedObject");
            }
            this.containedObject = containedObject;
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.AuthenticationHeaderValue.Scheme"/>
        /// </summary>
        public string Scheme
        {
            get
            {
                return this.containedObject.Scheme;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.AuthenticationHeaderValue.Parameter"/>
        /// </summary>
        public string Parameter
        {
            get
            {
                return this.containedObject.Parameter;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.AuthenticationHeaderValue.ToString"/>
        /// </summary>
        public override string ToString()
        {
            return this.containedObject.ToString();
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.AuthenticationHeaderValue.Equals"/>
        /// </summary>
        public override bool Equals(object obj)
        {
            return this.containedObject.Equals(obj);
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.AuthenticationHeaderValue.GetHashCode"/>
        /// </summary>
        public override int GetHashCode()
        {
            return this.containedObject.GetHashCode();
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.AuthenticationHeaderValue.System.ICloneable.Clone"/>
        /// </summary>
        object System.ICloneable.Clone()
        {
            return ((System.ICloneable)(this.containedObject)).Clone();
        }
    }
}
