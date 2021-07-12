using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itypedlistimplementation
{
	public class Client
	{
		public int Id { get; set; }
		public string Address { get; set; }

		public string Place { get; set; }

		private Dictionary<string, object> _props = new Dictionary<string, object>();

		public Client()
		{

		}

		public void Set(string field, object value)
		{
			if (field == "Id")
			{
				Id = (int)value;
			}
			else if (field == "Address")
			{
				Address = (string)value;
			}
			else if (field == "Place")
			{
				Place = (string)value;
			}
			else if (!_props.ContainsKey(field))
			{
				_props.Add(field, value);
			}
		}

		public object Get(string field)
		{
			if (field == "Id")
			{
				return Id;
			}
			else if (field == "Address")
			{
				return Address;
			}
			else if (field == "Place")
			{
				return Place;
			}
			else if (_props.TryGetValue(field, out object value))
				return value;

			return null;
		}
	}
}
