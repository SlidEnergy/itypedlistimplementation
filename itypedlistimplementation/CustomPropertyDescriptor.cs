using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itypedlistimplementation
{
	class CustomPropertyDescriptor<T> : PropertyDescriptor
	{
		private Type propertyType;
		private Type componentType;

		public CustomPropertyDescriptor(string propertyName, Type componentType)
			: base(propertyName, new Attribute[] { })
		{
			this.propertyType = typeof(T);

			this.componentType = componentType;
		}

		public override bool CanResetValue(object component) { return true; }
		public override Type ComponentType { get { return componentType; } }

		public override object GetValue(object component)
		{
			return ((CustomModel)component).GetValue(Name);
		}

		public override bool IsReadOnly { get { return false; } }
		public override Type PropertyType { get { return propertyType; } }
		public override void ResetValue(object component) { SetValue(component, default(T)); }
		public override void SetValue(object component, object value)
		{
			if (!value.GetType().IsAssignableFrom(propertyType))
			{
				throw new System.Exception("Invalid type to assign");
			}

			((CustomModel)component).SetValue(Name, value);
		}

		public override bool ShouldSerializeValue(object component) { return true; }
	}
}
