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
	/// Default implementation of <sealso cref="IHttpRequestMessage" />
	/// </summary>
	public sealed partial class HttpRequestMessage : IHttpRequestMessage
	{

		private System.Net.Http.HttpRequestMessage containedObject;

		public HttpRequestMessage(System.Net.Http.HttpRequestMessage containedObject)
		{
			if ((containedObject == null))
			{
				throw new System.ArgumentNullException("containedObject");
			}
			this.containedObject = containedObject;
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpRequestMessage.Version"/>
		/// </summary>
		public System.Version Version
		{
			get
			{
				return this.containedObject.Version;
			}
			set
			{
				this.containedObject.Version = value;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpRequestMessage.Content"/>
		/// </summary>
		public System.Net.Http.HttpContent Content
		{
			get
			{
				return this.containedObject.Content;
			}
			set
			{
				this.containedObject.Content = value;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpRequestMessage.Method"/>
		/// </summary>
		public System.Net.Http.HttpMethod Method
		{
			get
			{
				return this.containedObject.Method;
			}
			set
			{
				this.containedObject.Method = value;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpRequestMessage.RequestUri"/>
		/// </summary>
		public System.Uri RequestUri
		{
			get
			{
				return this.containedObject.RequestUri;
			}
			set
			{
				this.containedObject.RequestUri = value;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpRequestMessage.Headers"/>
		/// </summary>
		public System.Net.Http.Headers.HttpRequestHeaders Headers
		{
			get
			{
				return this.containedObject.Headers;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpRequestMessage.Properties"/>
		/// </summary>
		public System.Collections.Generic.IDictionary<string, object> Properties
		{
			get
			{
				return this.containedObject.Properties;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpRequestMessage.ToString"/>
		/// </summary>
		public override string ToString()
		{
			return this.containedObject.ToString();
		}

		/// <summary>
		/// <see cref="System.Net.Http.HttpRequestMessage.Dispose"/>
		/// </summary>
		public void Dispose()
		{
			this.containedObject.Dispose();
		}
	}
}
