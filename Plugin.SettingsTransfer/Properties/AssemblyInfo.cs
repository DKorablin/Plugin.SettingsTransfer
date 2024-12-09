using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: Guid("b169928a-b934-481e-8a11-f0a1b702149c")]
[assembly: System.CLSCompliant(true)]

#if NETCOREAPP
[assembly: AssemblyMetadata("ProjectUrl", "https://github.com/DKorablin/Plugin.SettingsTransfer")]
#else

[assembly: AssemblyTitle("Plugin.SettingsTransfer")]
[assembly: AssemblyDescription("Copy plugins settings from one data sorce to anoter")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Danila Korablin")]
[assembly: AssemblyProduct("Plugin.SettingsTransfer")]
[assembly: AssemblyCopyright("Copyright © Danila Korablin 2017-2024")]
#endif