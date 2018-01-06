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
	/// An interface to model an abstraction of <see cref="System.Net.Http.Headers.CacheControlHeaderValue" />
	/// </summary>
	public interface ICacheControlHeaderValue
#if !NETSTANDARD1_0 && !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6
        : System.ICloneable
#endif
	{

		bool NoCache
		{
			get;
			set;
		}

		System.Collections.Generic.ICollection<string> NoCacheHeaders
		{
			get;
		}

		bool NoStore
		{
			get;
			set;
		}

		System.Nullable<System.TimeSpan> MaxAge
		{
			get;
			set;
		}

		System.Nullable<System.TimeSpan> SharedMaxAge
		{
			get;
			set;
		}

		bool MaxStale
		{
			get;
			set;
		}

		System.Nullable<System.TimeSpan> MaxStaleLimit
		{
			get;
			set;
		}

		System.Nullable<System.TimeSpan> MinFresh
		{
			get;
			set;
		}

		bool NoTransform
		{
			get;
			set;
		}

		bool OnlyIfCached
		{
			get;
			set;
		}

		bool Public
		{
			get;
			set;
		}

		bool Private
		{
			get;
			set;
		}

		System.Collections.Generic.ICollection<string> PrivateHeaders
		{
			get;
		}

		bool MustRevalidate
		{
			get;
			set;
		}

		bool ProxyRevalidate
		{
			get;
			set;
		}

		System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Extensions
		{
			get;
		}

		string ToString();

		bool Equals(object obj);

		int GetHashCode();
	}
}
