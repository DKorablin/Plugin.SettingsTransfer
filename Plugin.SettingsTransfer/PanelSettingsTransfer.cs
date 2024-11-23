using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SAL.Flatbed;
using SAL.Windows;

namespace Plugin.SettingsTransfer
{
	public partial class PanelSettingsTransfer : UserControl
	{
		private PluginWindows Plugin => (PluginWindows)this.Window.Plugin;
		private IWindow Window => (IWindow)base.Parent;

		private ISettingsPluginProvider SelectedProvider
		{
			get
			{
				IPluginDescription plugin = (IPluginDescription)tscbProviders.SelectedItem;
				return (ISettingsPluginProvider)plugin?.Instance;
			}
		}

		private IPluginDescription SelectedPlugin => lvPlugins.SelectedItems.Count == 0 ? null : (IPluginDescription)lvPlugins.SelectedItems[0].Tag;

		public PanelSettingsTransfer()
			=> InitializeComponent();

		protected override void OnCreateControl()
		{
			this.Window.Caption = "Settings Transfer";

			this.FillSettingsProviderList();
			this.FillPluginsList();
			base.OnCreateControl();
		}

		private void FillSettingsProviderList()
		{
			foreach(IPluginDescription plugin in this.Plugin.HostWindows.Plugins.FindPluginType<ISettingsPluginProvider>())
			{
				tscbProviders.Items.Add(plugin);
				tsbnTarget.DropDownItems.Add(new ToolStripMenuItem(plugin.Name) { Tag = plugin, });

			}

			tscbProviders.SelectedIndex = 0;
		}

		private void FillPluginsList()
		{
			List<ListViewItem> itemsToAdd = new List<ListViewItem>((Int32)this.Plugin.HostWindows.Plugins.Count);
			foreach(IPluginDescription plugin in this.Plugin.HostWindows.Plugins)
			{
				ListViewItem item = new ListViewItem(plugin.Name)
				{
					Tag = plugin,
					ImageIndex = 0,
					StateImageIndex = 0,
				};

				if(plugin.Instance == null)
					item.ForeColor = Color.Gray;

				itemsToAdd.Add(item);
			}

			lvPlugins.Items.AddRange(itemsToAdd.ToArray());
			this.lvPlugins_SizeChanged(lvPlugins, EventArgs.Empty);
		}

		private void lvPlugins_SizeChanged(Object sender, EventArgs e)
			=> lvPlugins.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

		private void lvPlugins_ItemSelectionChanged(Object sender, ListViewItemSelectionChangedEventArgs e)
		{
			lvSettings.Items.Clear();

			IPluginDescription plugin = e.IsSelected
				? (IPluginDescription)e.Item.Tag
				: null;
			tsSettings.Enabled = plugin != null;

			if(plugin != null && plugin.Instance is IPluginSettings)
			{
				List<ListViewItem> itemsToAdd = new List<ListViewItem>();
				foreach(KeyValuePair<String, Object> item in this.Plugin.HostWindows.Plugins.Settings(plugin.Instance).LoadAssemblyParameters())
				{
					ListViewItem listItem = new ListViewItem(new String[lvSettings.Columns.Count]);
					listItem.SubItems[colItemName.Index].Text = item.Key;
					listItem.SubItems[colItemValue.Index].Text = item.Value == null ? "<null>" : item.Value.ToString();
					itemsToAdd.Add(listItem);
					if(item.Value is IDisposable d)
						d.Dispose();
				}

				if(itemsToAdd.Count > 0)
				{
					lvSettings.Items.AddRange(itemsToAdd.ToArray());
					lvSettings.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
				}
			}
		}

		private void tscbProviders_SelectedIndexChanged(Object sender, EventArgs e)
		{
			ListViewItem selectedItem = lvPlugins.SelectedItems.Count == 0 ? null : lvPlugins.SelectedItems[0];
			if(selectedItem != null)
				this.lvPlugins_ItemSelectionChanged(sender, new ListViewItemSelectionChangedEventArgs(selectedItem, selectedItem.Index, selectedItem.Selected));

			ISettingsPluginProvider selectedProvider = this.SelectedProvider;
			foreach(ToolStripMenuItem item in tsbnTarget.DropDownItems)
				item.Enabled = !Object.ReferenceEquals(item.Tag, selectedProvider);
		}

		private void lvSettings_ItemCheck(Object sender, ItemCheckEventArgs e)
		{
			switch(e.NewValue)
			{
			case CheckState.Checked:
				tsbnTarget.Enabled = true;
				break;
			case CheckState.Unchecked:
				if(lvSettings.CheckedItems.Count <= 1)
					tsbnTarget.Enabled = false;
				break;
			}
		}

		private void tsbnTarget_DropDownOpening(Object sender, EventArgs e)
		{ }

		private void tsbnTarget_DropDownItemClicked(Object sender, ToolStripItemClickedEventArgs e)
		{
			IPluginDescription plugin = this.SelectedPlugin;
			ISettingsProvider sourceProvider = this.Plugin.HostWindows.Plugins.Settings(plugin.Instance);
			ISettingsProvider targetProvider = ((ISettingsPluginProvider)e.ClickedItem.Tag).GetSettingsProvider(plugin.Instance);

			if(MessageBox.Show($"Checked settings for plugin {plugin} from storage {sourceProvider} will be transferred to storage {targetProvider}", this.Window.Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				return;

			foreach(ListViewItem checkedItem in lvSettings.CheckedItems)
			{
				String keyName = checkedItem.SubItems[colItemName.Index].Text;
				Object value = sourceProvider.LoadAssemblyParameter(keyName);

				// TODO: Check for BLOB
				targetProvider.SaveAssemblyParameter(keyName, value);
			}
		}

		private void cmsSettingsItem_ItemClicked(Object sender, ToolStripItemClickedEventArgs e)
		{
			if(e.ClickedItem == tsmiSettingsItemDelete)
			{
				IPluginDescription plugin = this.SelectedPlugin;
				ISettingsProvider sourceProvider = this.Plugin.HostWindows.Plugins.Settings(plugin.Instance);

				for(Int32 loop = lvPlugins.SelectedItems.Count - 1; loop >= 0; loop--)
				{
					ListViewItem selectedItem = lvPlugins.SelectedItems[loop];
					String keyName = selectedItem.SubItems[colItemName.Index].Text;

					sourceProvider.RemoveAssemblyParameter(keyName);
					lvPlugins.Items.Remove(selectedItem);
				}
			} else
				throw new NotImplementedException($"Unknown item clicked: {e.ClickedItem}");
		}
	}
}