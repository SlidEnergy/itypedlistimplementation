
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
			this.components = new System.ComponentModel.Container();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.addColumnButton = new DevExpress.XtraEditors.SimpleButton();
			this.loadJsonWithExtraFieldsButton = new DevExpress.XtraEditors.SimpleButton();
			this.nextPageButton = new DevExpress.XtraEditors.SimpleButton();
			this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
			this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
			this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
			this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
			this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
			this.dockPanel1.SuspendLayout();
			this.dockPanel1_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gridControl1.Location = new System.Drawing.Point(0, 100);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1375, 384);
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
			this.addColumnButton.Location = new System.Drawing.Point(5, 43);
			this.addColumnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.addColumnButton.Name = "addColumnButton";
			this.addColumnButton.Size = new System.Drawing.Size(87, 28);
			this.addColumnButton.TabIndex = 1;
			this.addColumnButton.Text = "Add column";
			this.addColumnButton.Click += new System.EventHandler(this.addColumnButton_Click);
			// 
			// loadJsonWithExtraFieldsButton
			// 
			this.loadJsonWithExtraFieldsButton.Location = new System.Drawing.Point(166, 43);
			this.loadJsonWithExtraFieldsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.loadJsonWithExtraFieldsButton.Name = "loadJsonWithExtraFieldsButton";
			this.loadJsonWithExtraFieldsButton.Size = new System.Drawing.Size(184, 28);
			this.loadJsonWithExtraFieldsButton.TabIndex = 2;
			this.loadJsonWithExtraFieldsButton.Text = "Load json with extra fields";
			this.loadJsonWithExtraFieldsButton.Click += new System.EventHandler(this.loadJsonWithExtraFieldsButton_Click);
			// 
			// nextPageButton
			// 
			this.nextPageButton.Location = new System.Drawing.Point(398, 43);
			this.nextPageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.nextPageButton.Name = "nextPageButton";
			this.nextPageButton.Size = new System.Drawing.Size(87, 28);
			this.nextPageButton.TabIndex = 3;
			this.nextPageButton.Text = "Next page";
			this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
			// 
			// dockManager1
			// 
			this.dockManager1.Form = this;
			this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
			this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
			// 
			// dockPanel1
			// 
			this.dockPanel1.Controls.Add(this.dockPanel1_Container);
			this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
			this.dockPanel1.FloatVertical = true;
			this.dockPanel1.ID = new System.Guid("a626dac8-6654-473a-b776-bb068d48461b");
			this.dockPanel1.Location = new System.Drawing.Point(0, 484);
			this.dockPanel1.Name = "dockPanel1";
			this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
			this.dockPanel1.Size = new System.Drawing.Size(1375, 200);
			this.dockPanel1.Text = "dockPanel1";
			// 
			// dockPanel1_Container
			// 
			this.dockPanel1_Container.Controls.Add(this.textEdit4);
			this.dockPanel1_Container.Controls.Add(this.textEdit3);
			this.dockPanel1_Container.Controls.Add(this.textEdit2);
			this.dockPanel1_Container.Controls.Add(this.textEdit5);
			this.dockPanel1_Container.Location = new System.Drawing.Point(4, 34);
			this.dockPanel1_Container.Name = "dockPanel1_Container";
			this.dockPanel1_Container.Size = new System.Drawing.Size(1367, 162);
			this.dockPanel1_Container.TabIndex = 0;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.addColumnButton);
			this.panelControl1.Controls.Add(this.nextPageButton);
			this.panelControl1.Controls.Add(this.loadJsonWithExtraFieldsButton);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControl1.Location = new System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(1375, 100);
			this.panelControl1.TabIndex = 5;
			// 
			// textEdit2
			// 
			this.textEdit2.Location = new System.Drawing.Point(177, 34);
			this.textEdit2.Name = "textEdit2";
			this.textEdit2.Size = new System.Drawing.Size(125, 22);
			this.textEdit2.TabIndex = 0;
			// 
			// textEdit3
			// 
			this.textEdit3.Location = new System.Drawing.Point(21, 62);
			this.textEdit3.Name = "textEdit3";
			this.textEdit3.Size = new System.Drawing.Size(281, 22);
			this.textEdit3.TabIndex = 0;
			// 
			// textEdit4
			// 
			this.textEdit4.Location = new System.Drawing.Point(21, 90);
			this.textEdit4.Name = "textEdit4";
			this.textEdit4.Size = new System.Drawing.Size(281, 22);
			this.textEdit4.TabIndex = 0;
			// 
			// textEdit5
			// 
			this.textEdit5.Location = new System.Drawing.Point(21, 34);
			this.textEdit5.Name = "textEdit5";
			this.textEdit5.Size = new System.Drawing.Size(125, 22);
			this.textEdit5.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1375, 684);
			this.Controls.Add(this.gridControl1);
			this.Controls.Add(this.dockPanel1);
			this.Controls.Add(this.panelControl1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
			this.dockPanel1.ResumeLayout(false);
			this.dockPanel1_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraEditors.SimpleButton addColumnButton;
		private DevExpress.XtraEditors.SimpleButton loadJsonWithExtraFieldsButton;
		private DevExpress.XtraEditors.SimpleButton nextPageButton;
		private DevExpress.XtraBars.Docking.DockManager dockManager1;
		private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
		private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.TextEdit textEdit4;
		private DevExpress.XtraEditors.TextEdit textEdit3;
		private DevExpress.XtraEditors.TextEdit textEdit2;
		private DevExpress.XtraEditors.TextEdit textEdit5;
	}
}

