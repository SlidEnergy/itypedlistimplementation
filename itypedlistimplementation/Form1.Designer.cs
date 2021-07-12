
namespace itypedlistimplementation
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.addColumnButton = new DevExpress.XtraEditors.SimpleButton();
			this.loadJsonWithExtraFieldsButton = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gridControl1.Location = new System.Drawing.Point(0, 101);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(936, 405);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.DetailHeight = 431;
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.AutoPopulateColumns = false;
			// 
			// addColumnButton
			// 
			this.addColumnButton.Location = new System.Drawing.Point(145, 16);
			this.addColumnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.addColumnButton.Name = "addColumnButton";
			this.addColumnButton.Size = new System.Drawing.Size(87, 28);
			this.addColumnButton.TabIndex = 1;
			this.addColumnButton.Text = "Add column";
			this.addColumnButton.Click += new System.EventHandler(this.addColumnButton_Click);
			// 
			// loadJsonWithExtraFieldsButton
			// 
			this.loadJsonWithExtraFieldsButton.Location = new System.Drawing.Point(306, 16);
			this.loadJsonWithExtraFieldsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.loadJsonWithExtraFieldsButton.Name = "loadJsonWithExtraFieldsButton";
			this.loadJsonWithExtraFieldsButton.Size = new System.Drawing.Size(184, 28);
			this.loadJsonWithExtraFieldsButton.TabIndex = 2;
			this.loadJsonWithExtraFieldsButton.Text = "Load json with extra fields";
			this.loadJsonWithExtraFieldsButton.Click += new System.EventHandler(this.loadJsonWithExtraFieldsButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 506);
			this.Controls.Add(this.loadJsonWithExtraFieldsButton);
			this.Controls.Add(this.addColumnButton);
			this.Controls.Add(this.gridControl1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.SimpleButton addColumnButton;
		private DevExpress.XtraEditors.SimpleButton loadJsonWithExtraFieldsButton;
	}
}

