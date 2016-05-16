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
    /// An interface to model an abstraction of <see cref="System.Net.Http.Headers.ContentDispositionHeaderValue" />
    /// </summary>
    public interface IContentDispositionHeaderValue : System.ICloneable
    {
        
        string DispositionType
        {
            get;
            set;
        }
        
        System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters
        {
            get;
        }
        
        string Name
        {
            get;
            set;
        }
        
        string FileName
        {
            get;
            set;
        }
        
        string FileNameStar
        {
            get;
            set;
        }
        
        System.Nullable<System.DateTimeOffset> CreationDate
        {
            get;
            set;
        }
        
        System.Nullable<System.DateTimeOffset> ModificationDate
        {
            get;
            set;
        }
        
        System.Nullable<System.DateTimeOffset> ReadDate
        {
            get;
            set;
        }
        
        System.Nullable<long> Size
        {
            get;
            set;
        }
        
        string ToString();
        
        bool Equals(object obj);
        
        int GetHashCode();
    }
}
