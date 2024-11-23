namespace Plugin.SettingsTransfer
{
	partial class PanelSettingsTransfer
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStrip tsMain;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelSettingsTransfer));
			System.Windows.Forms.SplitContainer splitMain;
			this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
			this.tsbnSearch = new System.Windows.Forms.ToolStripButton();
			this.lvPlugins = new System.Windows.Forms.ListView();
			this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvSettings = new System.Windows.Forms.ListView();
			this.colItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colItemValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tsSettings = new System.Windows.Forms.ToolStrip();
			this.tscbProviders = new System.Windows.Forms.ToolStripComboBox();
			this.tsbnTarget = new System.Windows.Forms.ToolStripDropDownButton();
			this.cmsSettingsItem = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiSettingsItemDelete = new System.Windows.Forms.ToolStripMenuItem();
			tsMain = new System.Windows.Forms.ToolStrip();
			splitMain = new System.Windows.Forms.SplitContainer();
			tsMain.SuspendLayout();
			splitMain.Panel1.SuspendLayout();
			splitMain.Panel2.SuspendLayout();
			splitMain.SuspendLayout();
			this.tsSettings.SuspendLayout();
			this.cmsSettingsItem.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsMain
			// 
			tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSearch,
            this.tsbnSearch});
			tsMain.Location = new System.Drawing.Point(0, 0);
			tsMain.Name = "tsMain";
			tsMain.Size = new System.Drawing.Size(277, 25);
			tsMain.TabIndex = 0;
			// 
			// txtSearch
			// 
			this.txtSearch.MaxLength = 200;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(100, 25);
			// 
			// tsbnSearch
			// 
			this.tsbnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbnSearch.Image")));
			this.tsbnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbnSearch.Name = "tsbnSearch";
			this.tsbnSearch.Size = new System.Drawing.Size(23, 22);
			this.tsbnSearch.Text = "Search";
			// 
			// splitMain
			// 
			splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
			splitMain.Location = new System.Drawing.Point(0, 25);
			splitMain.Name = "splitMain";
			// 
			// splitMain.Panel1
			// 
			splitMain.Panel1.Controls.Add(this.lvPlugins);
			// 
			// splitMain.Panel2
			// 
			splitMain.Panel2.Controls.Add(this.lvSettings);
			splitMain.Panel2.Controls.Add(this.tsSettings);
			splitMain.Size = new System.Drawing.Size(277, 198);
			splitMain.SplitterDistance = 92;
			splitMain.TabIndex = 1;
			// 
			// lvPlugins
			// 
			this.lvPlugins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
			this.lvPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvPlugins.FullRowSelect = true;
			this.lvPlugins.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lvPlugins.HideSelection = false;
			this.lvPlugins.Location = new System.Drawing.Point(0, 0);
			this.lvPlugins.MultiSelect = false;
			this.lvPlugins.Name = "lvPlugins";
			this.lvPlugins.Size = new System.Drawing.Size(92, 198);
			this.lvPlugins.TabIndex = 0;
			this.lvPlugins.UseCompatibleStateImageBehavior = false;
			this.lvPlugins.View = System.Windows.Forms.View.Details;
			this.lvPlugins.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvPlugins_ItemSelectionChanged);
			this.lvPlugins.SizeChanged += new System.EventHandler(this.lvPlugins_SizeChanged);
			// 
			// colName
			// 
			this.colName.Text = "";
			// 
			// lvSettings
			// 
			this.lvSettings.CheckBoxes = true;
			this.lvSettings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemName,
            this.colItemValue});
			this.lvSettings.ContextMenuStrip = this.cmsSettingsItem;
			this.lvSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvSettings.FullRowSelect = true;
			this.lvSettings.Location = new System.Drawing.Point(0, 25);
			this.lvSettings.Name = "lvSettings";
			this.lvSettings.Size = new System.Drawing.Size(181, 173);
			this.lvSettings.TabIndex = 1;
			this.lvSettings.UseCompatibleStateImageBehavior = false;
			this.lvSettings.View = System.Windows.Forms.View.Details;
			this.lvSettings.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvSettings_ItemCheck);
			// 
			// colItemName
			// 
			this.colItemName.Text = "Name";
			// 
			// colItemValue
			// 
			this.colItemValue.Text = "Value";
			// 
			// tsSettings
			// 
			this.tsSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbProviders,
            this.tsbnTarget});
			this.tsSettings.Location = new System.Drawing.Point(0, 0);
			this.tsSettings.Name = "tsSettings";
			this.tsSettings.Size = new System.Drawing.Size(181, 25);
			this.tsSettings.TabIndex = 0;
			// 
			// tscbProviders
			// 
			this.tscbProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tscbProviders.DropDownWidth = 200;
			this.tscbProviders.Name = "tscbProviders";
			this.tscbProviders.Size = new System.Drawing.Size(121, 25);
			this.tscbProviders.SelectedIndexChanged += new System.EventHandler(this.tscbProviders_SelectedIndexChanged);
			// 
			// tsbnTarget
			// 
			this.tsbnTarget.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbnTarget.Enabled = false;
			this.tsbnTarget.Image = ((System.Drawing.Image)(resources.GetObject("tsbnTarget.Image")));
			this.tsbnTarget.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbnTarget.Name = "tsbnTarget";
			this.tsbnTarget.Size = new System.Drawing.Size(29, 22);
			this.tsbnTarget.DropDownOpening += new System.EventHandler(this.tsbnTarget_DropDownOpening);
			this.tsbnTarget.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsbnTarget_DropDownItemClicked);
			// 
			// cmsSettingsItem
			// 
			this.cmsSettingsItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettingsItemDelete});
			this.cmsSettingsItem.Name = "cmsSettingsItem";
			this.cmsSettingsItem.Size = new System.Drawing.Size(108, 26);
			this.cmsSettingsItem.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsSettingsItem_ItemClicked);
			// 
			// tsmiSettingsItemDelete
			// 
			this.tsmiSettingsItemDelete.Name = "tsmiSettingsItemDelete";
			this.tsmiSettingsItemDelete.Size = new System.Drawing.Size(152, 22);
			this.tsmiSettingsItemDelete.Text = "&Delete";
			// 
			// PanelSettingsTransfer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(splitMain);
			this.Controls.Add(tsMain);
			this.Name = "PanelSettingsTransfer";
			this.Size = new System.Drawing.Size(277, 223);
			tsMain.ResumeLayout(false);
			tsMain.PerformLayout();
			splitMain.Panel1.ResumeLayout(false);
			splitMain.Panel2.ResumeLayout(false);
			splitMain.Panel2.PerformLayout();
			splitMain.ResumeLayout(false);
			this.tsSettings.ResumeLayout(false);
			this.tsSettings.PerformLayout();
			this.cmsSettingsItem.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripTextBox txtSearch;
		private System.Windows.Forms.ToolStripButton tsbnSearch;
		private System.Windows.Forms.ToolStripComboBox tscbProviders;
		private System.Windows.Forms.ToolStripDropDownButton tsbnTarget;
		private System.Windows.Forms.ListView lvPlugins;
		private System.Windows.Forms.ListView lvSettings;
		private System.Windows.Forms.ColumnHeader colItemName;
		private System.Windows.Forms.ColumnHeader colItemValue;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ContextMenuStrip cmsSettingsItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiSettingsItemDelete;
		private System.Windows.Forms.ToolStrip tsSettings;

	}
}
