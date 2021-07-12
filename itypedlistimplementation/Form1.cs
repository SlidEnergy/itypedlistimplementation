using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace itypedlistimplementation
{
	public partial class Form1 : DevExpress.XtraEditors.XtraForm
	{
		private CustomCollection<Contact> dataSource;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//this.dataSource = GenerateDataSource();
			this.dataSource = ParseCollectionFromJson("clients.json");

			this.gridControl1.DataSource = this.dataSource;
		}

		private CustomCollection<Contact> GenerateDataSource()
		{
			var source = new CustomCollection<Contact>();
			var client1 = new Contact() { Id = 1 };
			source.Add(client1);

			var client2 = new Contact() { Id = 2 };
			source.Add(client2);

			return source;
		}

		public CustomCollection<Contact> ParseCollectionFromJson(string file)
		{
			var array = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(File.ReadAllText(file));

			var contacts = array.Select(x => new Contact(x));

			var collection = new CustomCollection<Contact>();
			collection.AddRange(contacts.ToArray());

			if (array.Count > 0)
			{
				foreach (var key in array[0].Keys)
				{
					collection.AddPropertyDescription<object>(key);
				}
			}

			return collection;
		}

		private void addColumnButton_Click(object sender, EventArgs e)
		{
			this.dataSource.AddPropertyDescription<string>("Name");
			this.dataSource.AddPropertyDescription<string>("ShortName");

			gridControl1.DataSource = null;
			gridControl1.DataSource = dataSource;
			gridView1.PopulateColumns();
		}

		private void loadJsonWithExtraFieldsButton_Click(object sender, EventArgs e)
		{
			this.dataSource = ParseCollectionFromJson("clientsWithExtraFields.json");

			gridControl1.DataSource = null;
			gridControl1.DataSource = dataSource;
			gridView1.PopulateColumns();
		}
	}
}
