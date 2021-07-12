using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itypedlistimplementation
{
	public class CustomCollection<Model> : List<Model>, ITypedList where Model : CustomModel
	{
		public CustomCollection()
		{
		}

		protected PropertyDescriptorCollection props = new PropertyDescriptorCollection(new PropertyDescriptor[] { });

		public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return props;
		}

		public void AddPropertyDescription<K>(string propertyName)
		{ 
			props.Add(new CustomPropertyDescriptor<K>(propertyName, typeof(CustomModel)));
		}

		public string GetListName(PropertyDescriptor[] listAccessors)
		{
			return ""; 
		}
	}
}
