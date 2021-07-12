using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itypedlistimplementation
{
	public class CustomModel
	{
		protected Dictionary<string, object> props = new Dictionary<string, object>();

		public CustomModel(Dictionary<string, object> properties)
		{
			props = properties;
		}

		public CustomModel() { }

		public void SetValue(string field, object value)
		{
			if (!props.ContainsKey(field))
			{
				props.Add(field, value);
			}
			else
			{
				props[field] = value;
			}
		}

		public object GetValue(string field)
		{
			if (props.TryGetValue(field, out object value))
				return value;

			return null;
		}
	}
}
