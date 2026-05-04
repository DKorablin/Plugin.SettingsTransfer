# Settings Transfer Plugin

[![Auto build](https://github.com/DKorablin/Plugin.SettingsTransfer/actions/workflows/release.yml/badge.svg)](https://github.com/DKorablin/Plugin.SettingsTransfer/releases/latest)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

A [SAL](https://github.com/DKorablin/SAL.Windows) plugin that allows copying plugin settings from one data source (storage provider) to another.

## Overview

The Settings Transfer plugin adds a **Settings Transfer** panel accessible via the **Tools** menu in the SAL host application. It lets you inspect, transfer, and delete settings for any loaded plugin — all without leaving the application.

## Features

- **Browse plugins** — lists all plugins registered in the SAL host, with inactive ones visually distinguished.
- **Inspect settings** — select any plugin to view its current settings key/value pairs loaded from the active provider.
- **Transfer settings** — check individual settings entries and copy them to a different storage provider in one click.
- **Delete settings** — remove individual settings entries from the current source provider.
- **Multi-provider support** — automatically discovers all `ISettingsPluginProvider` implementations registered in the host.

## Requirements

- [SAL host application](https://github.com/DKorablin) with Windows Forms support
- .NET Framework 4.8 **or** .NET 8 (Windows)

## Installation

### Via GitHub Release

1. Download the release archive.
2. Place the plugin assembly into the host application plugin directory (SAL / host supporting Windows environment):
	- [Flatbed.Dialog](https://dkorablin.github.io/Flatbed-Dialog/)
	- [Flatbed.Dialog (Lite)](https://dkorablin.github.io/Flatbed-Dialog-Lite)
	- [Flatbed.MDI](https://dkorablin.github.io/Flatbed-MDI)
	- [Flatbed.MDI (WPF)](https://dkorablin.github.io/Flatbed-MDI-Avalon)
	- [Flatbed.MDI (AvaloniaUI)](https://dkorablin.github.io/Flatbed-MDI-AvaloniaUI)
3. Restart the host application; Plugin.SettingsTransfer should appear in the plugin list (Tools -> Settings Transfer).

### Via GitHub NuGet

Download the latest pre-built zip archive for your target framework from the [Releases](https://github.com/DKorablin/Plugin.SettingsTransfer/releases/latest) page and extract it into your SAL plugins directory.

## Usage

1. Launch the SAL host application with the plugin loaded.
2. Open **Tools → Settings Transfer**.
3. In the **Settings Transfer** panel:
   - Select the **source provider** from the top drop-down list.
   - Select a **plugin** from the left list to load its settings.
   - Check the settings entries you want to transfer.
   - Click the **Target** button and choose the destination provider.
   - Confirm the transfer in the dialog.

## License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).