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
	
	public partial class OrderState : ISpecificRecord
	{
		public static Schema _SCHEMA = Schema.Parse(@"{""type"":""record"",""name"":""OrderState"",""namespace"":""Order.Api.Application.Events"",""fields"":[{""name"":""id"",""type"":""string""},{""name"":""customerId"",""type"":""string""},{""name"":""date"",""type"":""string""},{""name"":""status"",""type"":""string""},{""name"":""total"",""type"":""double""},{""name"":""products"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""OrderProduct"",""namespace"":""Order.Api.Application.Events"",""fields"":[{""name"":""id"",""type"":""string""},{""name"":""Quantity"",""type"":""int""}]}}}]}");
		private string _id;
		private string _customerId;
		private string _date;
		private string _status;
		private double _total;
		private IList<Order.Api.Application.Events.OrderProduct> _products;
		public virtual Schema Schema
		{
			get
			{
				return OrderState._SCHEMA;
			}
		}
		public string id
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
		public string customerId
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
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				this._status = value;
			}
		}
		public double total
		{
			get
			{
				return this._total;
			}
			set
			{
				this._total = value;
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
			case 3: return this.status;
			case 4: return this.total;
			case 5: return this.products;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.id = (System.String)fieldValue; break;
			case 1: this.customerId = (System.String)fieldValue; break;
			case 2: this.date = (System.String)fieldValue; break;
			case 3: this.status = (System.String)fieldValue; break;
			case 4: this.total = (System.Double)fieldValue; break;
			case 5: this.products = (IList<Order.Api.Application.Events.OrderProduct>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}