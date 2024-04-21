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

	public static GUnixMountMonitorHandle Get()
	{
		return GUnixMountMonitorExterns.g_unix_mount_monitor_get();
	}

}

public class GUnixMountMonitorSignal
{
	public string Value { get; set; }
	public GUnixMountMonitorSignal(string value) => Value = value;
}

public static class GUnixMountMonitorSignals
{
	public static GUnixMountMonitorSignal MountpointsChanged = new("BindingTransform.MethodDeclaration");
	public static GUnixMountMonitorSignal MountsChanged = new("BindingTransform.MethodDeclaration");
}

public static class GUnixMountMonitorHandleExtensions
{
	public static GUnixMountMonitorHandle SetRateLimit(this GUnixMountMonitorHandle mount_monitor, int limit_msec)
	{
		GUnixMountMonitorExterns.g_unix_mount_monitor_set_rate_limit(mount_monitor, limit_msec);
		return mount_monitor;
	}

	public static GUnixMountMonitorHandle Signal_MountpointsChanged(this GUnixMountMonitorHandle instance, GUnixMountMonitorDelegates.MountpointsChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "mountpoints_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GUnixMountMonitorHandle Signal_MountsChanged(this GUnixMountMonitorHandle instance, GUnixMountMonitorDelegates.MountsChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "mounts_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GUnixMountMonitorDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MountpointsChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GUnixMountMonitorHandle>))] GUnixMountMonitorHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void MountsChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GUnixMountMonitorHandle>))] GUnixMountMonitorHandle self, IntPtr user_data);
}

internal class GUnixMountMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GUnixMountMonitorHandle g_unix_mount_monitor_new();

	[DllImport(Libraries.Gio)]
	internal static extern void g_unix_mount_monitor_set_rate_limit(GUnixMountMonitorHandle mount_monitor, int limit_msec);

	[DllImport(Libraries.Gio)]
	internal static extern GUnixMountMonitorHandle g_unix_mount_monitor_get();

}
