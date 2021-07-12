using System;
using System.IO;
using Newtonsoft.Json;

namespace itypedlistimplementation
{
	public partial class Form1 : DevExpress.XtraEditors.XtraForm
	{
		ClientCollection dataSource;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//this.dataSource = GenerateDataSource();
			this.dataSource = ParseCollectionFromJson();

			this.gridControl1.DataSource = this.dataSource;
		}

		private ClientCollection GenerateDataSource()
		{
			var source = new ClientCollection();
			var client1 = new Client() { Id = 1, Address = "Address1", Place = "Place1" };
			source.Add(client1);

			var client2 = new Client() { Id = 2, Address = "Address2", Place = "Place2" };
			source.Add(client2);

			return source;
		}

		public ClientCollection ParseCollectionFromJson()
		{
			return JsonConvert.DeserializeObject<ClientCollection>(File.ReadAllText(@"clients.json"));
		}

		private void addColumnButton_Click(object sender, EventArgs e)
		{
			string propertyName = "Name";

			this.dataSource.AddPropertyDescription<string>(propertyName);

			gridControl1.DataSource = null;
			gridControl1.DataSource = dataSource;

			//GridColumn gc = new GridColumn();
			//gc.Caption = propertyName;
			//gc.FieldName = propertyName;
			//gridView1.Columns.Add(gc);

			gridView1.PopulateColumns();
		}
	}
}
