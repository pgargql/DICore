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
	/// Default implementation of <sealso cref="ITransferCodingHeaderValue" />
	/// </summary>
	public sealed partial class TransferCodingHeaderValue : ITransferCodingHeaderValue
	{

		private System.Net.Http.Headers.TransferCodingHeaderValue containedObject;

		public TransferCodingHeaderValue(System.Net.Http.Headers.TransferCodingHeaderValue containedObject)
		{
			if ((containedObject == null))
			{
				throw new System.ArgumentNullException("containedObject");
			}
			this.containedObject = containedObject;
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.TransferCodingHeaderValue.Value"/>
		/// </summary>
		public string Value
		{
			get
			{
				return this.containedObject.Value;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.TransferCodingHeaderValue.Parameters"/>
		/// </summary>
		public System.Collections.Generic.ICollection<System.Net.Http.Headers.NameValueHeaderValue> Parameters
		{
			get
			{
				return this.containedObject.Parameters;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.TransferCodingHeaderValue.ToString"/>
		/// </summary>
		public override string ToString()
		{
			return this.containedObject.ToString();
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.TransferCodingHeaderValue.Equals"/>
		/// </summary>
		public override bool Equals(object obj)
		{
			return this.containedObject.Equals(obj);
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.TransferCodingHeaderValue.GetHashCode"/>
		/// </summary>
		public override int GetHashCode()
		{
			return this.containedObject.GetHashCode();
		}
	}
}
