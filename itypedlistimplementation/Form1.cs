using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using DevExpress.XtraGrid.Columns;

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
		}

		private CustomCollection<Contact> GenerateDataSource()
		{
			AddColumn("Id");
			AddColumn("Address");
			AddColumn("Place");

			var source = new CustomCollection<Contact>();

			source.AddPropertyDescription<string>("Id");
			source.AddPropertyDescription<string>("Address");
			source.AddPropertyDescription<string>("Place");

			var client1 = new Contact() { Id = 1 };
			client1.SetValue("Address", "Address1");
			client1.SetValue("Place", "Place1");
			source.Add(client1);

			var client2 = new Contact() { Id = 2 };
			client2.SetValue("Address", "Address2");
			client2.SetValue("Place", "Place2");
			source.Add(client2);

			return source;
		}

		private void AddColumn(string name)
		{
			if (gridView1.Columns.Any(x => x.Name == name))
			{
				return;
			}

			var gc = new GridColumn();
			gc.Caption = name;
			gc.FieldName = name;
			gc.Name = name;
			gc.Visible = true;

			gridView1.Columns.Add(gc);
		}

		private CustomCollection<Contact> ParseCollectionFromJson(string file)
		{
			var json = File.ReadAllText(file);

			return CustomCollectionJsonParser.ParseAndCreateCollection<Contact>(json);
		}

		private IEnumerable<Contact> ParseJson(string file)
		{
			var json = File.ReadAllText(file);

			return CustomCollectionJsonParser.Parse<Contact>(json);
		}

		private void addColumnButton_Click(object sender, EventArgs e)
		{
			this.dataSource.AddPropertyDescription<string>("Name");
			this.dataSource.AddPropertyDescription<string>("ShortName");

			AddColumn("Name");
			AddColumn("ShortName");
		}

		private void loadJsonWithExtraFieldsButton_Click(object sender, EventArgs e)
		{
			this.dataSource = ParseCollectionFromJson("clientsWithExtraFields.json");
			AddColumn("Id");
			AddColumn("Address");
			AddColumn("Place");
			AddColumn("Name");
			AddColumn("ShortName");

			this.gridControl1.DataSource = this.dataSource;
		}

		private void nextPageButton_Click(object sender, EventArgs e)
		{
			var list = ParseJson("clientsWithExtraFieldsPage2.json");

			foreach (var item in list)
			{
				this.dataSource.Add(item);
			}
		}
	}
}
