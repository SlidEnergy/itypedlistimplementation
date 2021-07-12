using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itypedlistimplementation
{
	public class Contact : CustomModel
	{
		public int Id
		{
			get
			{
				return (int)GetValue("Id");
			}
			set
			{
				SetValue("Id", value);
			}
		}

		public Contact() { }
	}
}
