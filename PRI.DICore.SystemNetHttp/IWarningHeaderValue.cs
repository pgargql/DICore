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
    /// An interface to model an abstraction of <see cref="System.Net.Http.Headers.WarningHeaderValue" />
    /// </summary>
    public interface IWarningHeaderValue : System.ICloneable
    {
        
        int Code
        {
            get;
        }
        
        string Agent
        {
            get;
        }
        
        string Text
        {
            get;
        }
        
        System.Nullable<System.DateTimeOffset> Date
        {
            get;
        }
        
        string ToString();
        
        bool Equals(object obj);
        
        int GetHashCode();
    }
}