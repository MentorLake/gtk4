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

public class GFileMonitorHandle : GObjectHandle
{
}

public class GFileMonitorSignal
{
	public string Value { get; set; }
	public GFileMonitorSignal(string value) => Value = value;
}

public static class GFileMonitorSignals
{
	public static GFileMonitorSignal Changed = new("BindingTransform.MethodDeclaration");
}

public static class GFileMonitorHandleExtensions
{
	public static bool Cancel(this GFileMonitorHandle monitor)
	{
		return GFileMonitorExterns.g_file_monitor_cancel(monitor);
	}

	public static GFileMonitorHandle EmitEvent(this GFileMonitorHandle monitor, GFileHandle child, GFileHandle other_file, GFileMonitorEvent event_type)
	{
		GFileMonitorExterns.g_file_monitor_emit_event(monitor, child, other_file, event_type);
		return monitor;
	}

	public static bool IsCancelled(this GFileMonitorHandle monitor)
	{
		return GFileMonitorExterns.g_file_monitor_is_cancelled(monitor);
	}

	public static GFileMonitorHandle SetRateLimit(this GFileMonitorHandle monitor, int limit_msecs)
	{
		GFileMonitorExterns.g_file_monitor_set_rate_limit(monitor, limit_msecs);
		return monitor;
	}

	public static GFileMonitorHandle Signal_Changed(this GFileMonitorHandle instance, GFileMonitorDelegates.Changed handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GFileMonitorDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GFileMonitorHandle>))] GFileMonitorHandle self, GFileHandle file, GFileHandle other_file, GFileMonitorEvent event_type, IntPtr user_data);
}

internal class GFileMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_monitor_cancel(GFileMonitorHandle monitor);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_monitor_emit_event(GFileMonitorHandle monitor, GFileHandle child, GFileHandle other_file, GFileMonitorEvent event_type);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_file_monitor_is_cancelled(GFileMonitorHandle monitor);

	[DllImport(Libraries.Gio)]
	internal static extern void g_file_monitor_set_rate_limit(GFileMonitorHandle monitor, int limit_msecs);

}
