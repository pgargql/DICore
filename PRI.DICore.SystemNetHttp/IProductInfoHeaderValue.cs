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
	/// An interface to model an abstraction of <see cref="System.Net.Http.Headers.ProductInfoHeaderValue" />
	/// </summary>
	public interface IProductInfoHeaderValue
#if !NET452 && !NETSTANDARD1_0 && !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6
        : System.ICloneable
#endif
	{

		System.Net.Http.Headers.ProductHeaderValue Product
		{
			get;
		}

		string Comment
		{
			get;
		}

		string ToString();

		bool Equals(object obj);

		int GetHashCode();
	}
}
