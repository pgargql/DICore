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
	/// Default implementation of <sealso cref="IContentRangeHeaderValue" />
	/// </summary>
	public sealed partial class ContentRangeHeaderValue : IContentRangeHeaderValue
	{

		private System.Net.Http.Headers.ContentRangeHeaderValue containedObject;

		public ContentRangeHeaderValue(System.Net.Http.Headers.ContentRangeHeaderValue containedObject)
		{
			if ((containedObject == null))
			{
				throw new System.ArgumentNullException("containedObject");
			}
			this.containedObject = containedObject;
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.ContentRangeHeaderValue.Unit"/>
		/// </summary>
		public string Unit
		{
			get
			{
				return this.containedObject.Unit;
			}
			set
			{
				this.containedObject.Unit = value;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.ContentRangeHeaderValue.From"/>
		/// </summary>
		public System.Nullable<long> From
		{
			get
			{
				return this.containedObject.From;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.ContentRangeHeaderValue.To"/>
		/// </summary>
		public System.Nullable<long> To
		{
			get
			{
				return this.containedObject.To;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.ContentRangeHeaderValue.Length"/>
		/// </summary>
		public System.Nullable<long> Length
		{
			get
			{
				return this.containedObject.Length;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.ContentRangeHeaderValue.HasLength"/>
		/// </summary>
		public bool HasLength
		{
			get
			{
				return this.containedObject.HasLength;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.ContentRangeHeaderValue.HasRange"/>
		/// </summary>
		public bool HasRange
		{
			get
			{
				return this.containedObject.HasRange;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.ContentRangeHeaderValue.Equals"/>
		/// </summary>
		public override bool Equals(object obj)
		{
			return this.containedObject.Equals(obj);
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.ContentRangeHeaderValue.GetHashCode"/>
		/// </summary>
		public override int GetHashCode()
		{
			return this.containedObject.GetHashCode();
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.ContentRangeHeaderValue.ToString"/>
		/// </summary>
		public override string ToString()
		{
			return this.containedObject.ToString();
		}
	}
}
