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
	/// Default implementation of <sealso cref="IRangeHeaderValue" />
	/// </summary>
	public sealed partial class RangeHeaderValue : IRangeHeaderValue
	{

		private System.Net.Http.Headers.RangeHeaderValue containedObject;

		public RangeHeaderValue(System.Net.Http.Headers.RangeHeaderValue containedObject)
		{
			if ((containedObject == null))
			{
				throw new System.ArgumentNullException("containedObject");
			}
			this.containedObject = containedObject;
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.RangeHeaderValue.Unit"/>
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
		/// <see cref="System.Net.Http.Headers.RangeHeaderValue.Ranges"/>
		/// </summary>
		public System.Collections.Generic.ICollection<System.Net.Http.Headers.RangeItemHeaderValue> Ranges
		{
			get
			{
				return this.containedObject.Ranges;
			}
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.RangeHeaderValue.ToString"/>
		/// </summary>
		public override string ToString()
		{
			return this.containedObject.ToString();
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.RangeHeaderValue.Equals"/>
		/// </summary>
		public override bool Equals(object obj)
		{
			return this.containedObject.Equals(obj);
		}

		/// <summary>
		/// <see cref="System.Net.Http.Headers.RangeHeaderValue.GetHashCode"/>
		/// </summary>
		public override int GetHashCode()
		{
			return this.containedObject.GetHashCode();
		}
	}
}
