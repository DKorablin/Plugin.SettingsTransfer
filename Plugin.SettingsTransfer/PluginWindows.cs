using System;
using System.Collections.Generic;
using System.Diagnostics;
using SAL.Flatbed;
using SAL.Windows;

namespace Plugin.SettingsTransfer
{
	public class PluginWindows : IPlugin
	{
		private Dictionary<String, DockState> _documentTypes;

		internal IHostWindows HostWindows { get; }

		internal ITraceSource Trace { get; }

		private Dictionary<String, DockState> DocumentTypes
		{
			get
			{
				if(this._documentTypes == null)
					this._documentTypes = new Dictionary<String, DockState>()
					{
						{ typeof(PanelSettingsTransfer).ToString(),DockState.Float },
					};
				return this._documentTypes;
			}
		}

		private IMenuItem ConfigMenu { get; set; }

		public PluginWindows(IHostWindows hostWindows, ITraceSource trace)
		{
			this.HostWindows = hostWindows ?? throw new ArgumentNullException(nameof(hostWindows));
			this.Trace = trace ?? throw new ArgumentNullException(nameof(trace));
		}

		public IWindow GetPluginControl(String typeName, Object args)
			=> this.CreateWindow(typeName, false, args);

		Boolean IPlugin.OnConnection(ConnectMode mode)
		{
			IMenuItem menuTools = this.HostWindows.MainMenu.FindMenuItem("Tools");
			if(menuTools == null)
				this.Trace.TraceEvent(TraceEventType.Error, 10, "Menu item 'Tools' not found");
			{
				this.ConfigMenu = menuTools.Create("&Settings Transfer");
				this.ConfigMenu.Name = "Tools.SettingsTransfer";
				this.ConfigMenu.Click += (sender, e) => { this.CreateWindow(typeof(PanelSettingsTransfer).ToString(), false); };
				menuTools.Items.Insert(0, this.ConfigMenu);
				return true;
			}
		}

		Boolean IPlugin.OnDisconnection(DisconnectMode mode)
		{
			if(this.ConfigMenu != null && this.ConfigMenu.Items.Count == 0)
				this.HostWindows.MainMenu.Items.Remove(this.ConfigMenu);
			return true;
		}

		private IWindow CreateWindow(String typeName, Boolean searchForOpened, Object args = null)
			=> this.DocumentTypes.TryGetValue(typeName, out DockState state)
				? this.HostWindows.Windows.CreateWindow(this, typeName, searchForOpened, state, args)
				: null;
	}
}