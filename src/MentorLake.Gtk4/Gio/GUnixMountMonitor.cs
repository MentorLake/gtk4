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

public class GUnixMountMonitorHandle : GObjectHandle
{
	public static GUnixMountMonitorHandle New()
	{
		return GUnixMountMonitorExterns.g_unix_mount_monitor_new();
	}
}

public class GUnixMountMonitorSignal
{
	public string Value { get; set; }
	public GUnixMountMonitorSignal(string value) => Value = value;
}

public static class GUnixMountMonitorSignals
{
	public static GUnixMountMonitorSignal MountpointsChanged = new("mountpoints-changed");
	public static GUnixMountMonitorSignal MountsChanged = new("mounts-changed");
}

public static class GUnixMountMonitorHandleExtensions
{
	public static GUnixMountMonitorHandle SetRateLimit(this GUnixMountMonitorHandle mount_monitor, int limit_msec)
	{
		GUnixMountMonitorExterns.g_unix_mount_monitor_set_rate_limit(mount_monitor, limit_msec);
		return mount_monitor;
	}

	public static GUnixMountMonitorHandle Get()
	{
		return GUnixMountMonitorExterns.g_unix_mount_monitor_get();
	}

	public static GUnixMountMonitorHandle Connect(this GUnixMountMonitorHandle instance, GUnixMountMonitorSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GUnixMountMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_unix_mount_monitor_set_rate_limit(GUnixMountMonitorHandle mount_monitor, int limit_msec);
	[DllImport(Libraries.Gio)]
	internal static extern GUnixMountMonitorHandle g_unix_mount_monitor_get();
	[DllImport(Libraries.Gio)]
	internal static extern GUnixMountMonitorHandle g_unix_mount_monitor_new();
}
