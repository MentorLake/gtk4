using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public interface GNetworkMonitorHandle
{
}

public static class GNetworkMonitorHandleExtensions
{
	public static bool CanReach(this GNetworkMonitorHandle monitor, GSocketConnectableHandle connectable, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GNetworkMonitorExterns.g_network_monitor_can_reach(monitor, connectable, cancellable, out error);
	}

	public static GNetworkMonitorHandle CanReachAsync(this GNetworkMonitorHandle monitor, GSocketConnectableHandle connectable, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GNetworkMonitorExterns.g_network_monitor_can_reach_async(monitor, connectable, cancellable, callback, user_data);
		return monitor;
	}

	public static bool CanReachFinish(this GNetworkMonitorHandle monitor, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GNetworkMonitorExterns.g_network_monitor_can_reach_finish(monitor, result, out error);
	}

	public static GNetworkConnectivity GetConnectivity(this GNetworkMonitorHandle monitor)
	{
		return GNetworkMonitorExterns.g_network_monitor_get_connectivity(monitor);
	}

	public static bool GetNetworkAvailable(this GNetworkMonitorHandle monitor)
	{
		return GNetworkMonitorExterns.g_network_monitor_get_network_available(monitor);
	}

	public static bool GetNetworkMetered(this GNetworkMonitorHandle monitor)
	{
		return GNetworkMonitorExterns.g_network_monitor_get_network_metered(monitor);
	}

}

internal class GNetworkMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_network_monitor_can_reach(GNetworkMonitorHandle monitor, GSocketConnectableHandle connectable, GCancellableHandle cancellable, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern void g_network_monitor_can_reach_async(GNetworkMonitorHandle monitor, GSocketConnectableHandle connectable, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_network_monitor_can_reach_finish(GNetworkMonitorHandle monitor, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gio)]
	internal static extern GNetworkConnectivity g_network_monitor_get_connectivity(GNetworkMonitorHandle monitor);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_network_monitor_get_network_available(GNetworkMonitorHandle monitor);
	[DllImport(Libraries.Gio)]
	internal static extern bool g_network_monitor_get_network_metered(GNetworkMonitorHandle monitor);
}
