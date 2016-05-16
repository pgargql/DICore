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
    /// Default implementation of <sealso cref="IProductInfoHeaderValue" />
    /// </summary>
    public sealed partial class ProductInfoHeaderValue : IProductInfoHeaderValue
    {
        
        private System.Net.Http.Headers.ProductInfoHeaderValue containedObject;
        
        public ProductInfoHeaderValue(System.Net.Http.Headers.ProductInfoHeaderValue containedObject)
        {
            if ((containedObject == null))
            {
                throw new System.ArgumentNullException("containedObject");
            }
            this.containedObject = containedObject;
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.ProductInfoHeaderValue.Product"/>
        /// </summary>
        public System.Net.Http.Headers.ProductHeaderValue Product
        {
            get
            {
                return this.containedObject.Product;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.ProductInfoHeaderValue.Comment"/>
        /// </summary>
        public string Comment
        {
            get
            {
                return this.containedObject.Comment;
            }
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.ProductInfoHeaderValue.ToString"/>
        /// </summary>
        public override string ToString()
        {
            return this.containedObject.ToString();
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.ProductInfoHeaderValue.Equals"/>
        /// </summary>
        public override bool Equals(object obj)
        {
            return this.containedObject.Equals(obj);
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.ProductInfoHeaderValue.GetHashCode"/>
        /// </summary>
        public override int GetHashCode()
        {
            return this.containedObject.GetHashCode();
        }
        
        /// <summary>
        /// <see cref="System.Net.Http.Headers.ProductInfoHeaderValue.System.ICloneable.Clone"/>
        /// </summary>
        object System.ICloneable.Clone()
        {
            return ((System.ICloneable)(this.containedObject)).Clone();
        }
    }
}
