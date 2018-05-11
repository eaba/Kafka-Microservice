// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.7.7.4
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Order.Api.Application.Events
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;
	
	public partial class OrderCreated : ISpecificRecord
	{
		public static Schema _SCHEMA = Schema.Parse(@"{""type"":""record"",""name"":""OrderCreated"",""namespace"":""Order.Api.Application.Events"",""fields"":[{""name"":""id"",""type"":""int""},{""name"":""customerId"",""type"":""int""},{""name"":""date"",""type"":""string""},{""name"":""products"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""OrderProduct"",""namespace"":""Order.Api.Application.Events"",""fields"":[{""name"":""id"",""type"":""int""},{""name"":""Quantity"",""type"":""int""}]}}}]}");
		private int _id;
		private int _customerId;
		private string _date;
		private IList<Order.Api.Application.Events.OrderProduct> _products;
		public virtual Schema Schema
		{
			get
			{
				return OrderCreated._SCHEMA;
			}
		}
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public int customerId
		{
			get
			{
				return this._customerId;
			}
			set
			{
				this._customerId = value;
			}
		}
		public string date
		{
			get
			{
				return this._date;
			}
			set
			{
				this._date = value;
			}
		}
		public IList<Order.Api.Application.Events.OrderProduct> products
		{
			get
			{
				return this._products;
			}
			set
			{
				this._products = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.id;
			case 1: return this.customerId;
			case 2: return this.date;
			case 3: return this.products;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.id = (System.Int32)fieldValue; break;
			case 1: this.customerId = (System.Int32)fieldValue; break;
			case 2: this.date = (System.String)fieldValue; break;
			case 3: this.products = (IList<Order.Api.Application.Events.OrderProduct>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
