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

public class GAppInfoMonitorHandle : GObjectHandle
{
	public static GAppInfoMonitorHandle Get()
	{
		return GAppInfoMonitorExterns.g_app_info_monitor_get();
	}

}

public static class GAppInfoMonitorSignalExtensions
{
	public static GAppInfoMonitorHandle Signal_Changed(this GAppInfoMonitorHandle instance, GAppInfoMonitorSignalDelegates.Changed handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GAppInfoMonitorSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GAppInfoMonitorHandle>))] GAppInfoMonitorHandle self, IntPtr user_data);
}


public static class GAppInfoMonitorHandleExtensions
{
}

internal class GAppInfoMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GAppInfoMonitorHandle g_app_info_monitor_get();

}
