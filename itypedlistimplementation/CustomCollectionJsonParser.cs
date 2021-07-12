using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace itypedlistimplementation
{
	public static class CustomCollectionJsonParser
	{
		public static CustomCollection<T> Parse<T>(string json) where T : CustomModel
		{
			var list = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(json);

			var contacts = ConvertListOfDictionaryToArrayOfModel<T>(list);

			var collection = new CustomCollection<T>();
			collection.AddRange(contacts.ToArray());

			if (list.Count > 0)
			{
				AddFieldsToCustomCollections(collection, list[0]);
			}

			return collection;
		}

		private static IEnumerable<T> ConvertListOfDictionaryToArrayOfModel<T>(List<Dictionary<string, object>> list) where T : CustomModel
		{
			var contacts = list.Select(x =>
			{
				var contact = (T)Activator.CreateInstance(typeof(T), null);
				foreach (var key in x.Keys)
				{
					contact.SetValue(key, x[key]);
				}

				return contact;
			});

			return contacts;
		}

		private static void AddFieldsToCustomCollections<T>(CustomCollection<T> collection, Dictionary<string, object> model) where T : CustomModel
		{
			foreach (var key in model.Keys)
			{
				var method = typeof(CustomCollection<Contact>).GetMethod(nameof(CustomCollection<Contact>.AddPropertyDescription));
				var generic = method.MakeGenericMethod(model[key].GetType());
				generic.Invoke(collection, new object[] { key });
			}
		}
	}
}
