using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itypedlistimplementation
{
	public class ClientCollection : List<Client>, ITypedList
	{
		public ClientCollection()
		{
		}

		protected PropertyDescriptorCollection _props;

		public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			if (_props == null)
			{
				_props = InitPropertyDescriptions();
			}
			return _props;
		}

		private PropertyDescriptorCollection InitPropertyDescriptions() 
		{
			List<PropertyDescriptor> props = new List<PropertyDescriptor>();

			props.Add(new CustomPropertyDescriptor<int>("Id", typeof(Client)));
			props.Add(new CustomPropertyDescriptor<int>("Address", typeof(Client)));
			props.Add(new CustomPropertyDescriptor<int>("Place", typeof(Client)));

			return new PropertyDescriptorCollection(props.ToArray());
		}

		public void AddPropertyDescription<T>(string propertyName)
		{ 
			_props.Add(new CustomPropertyDescriptor<T>(propertyName, typeof(Client)));
		}

		public string GetListName(PropertyDescriptor[] listAccessors)
		{
			return ""; 
		}
	}
}
