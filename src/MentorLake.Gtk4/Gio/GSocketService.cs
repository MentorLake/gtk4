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

public class GSocketServiceHandle : GSocketListenerHandle
{
	public static GSocketServiceHandle New()
	{
		return GSocketServiceExterns.g_socket_service_new();
	}

}

public static class GSocketServiceSignalExtensions
{
	public static GSocketServiceHandle Signal_Incoming(this GSocketServiceHandle instance, GSocketServiceSignalDelegates.Incoming handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "incoming", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GSocketServiceSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Incoming([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GSocketServiceHandle>))] GSocketServiceHandle self, GSocketConnectionHandle connection, GObjectHandle source_object, IntPtr user_data);
}


public static class GSocketServiceHandleExtensions
{
	public static bool IsActive(this GSocketServiceHandle service)
	{
		return GSocketServiceExterns.g_socket_service_is_active(service);
	}

	public static GSocketServiceHandle Start(this GSocketServiceHandle service)
	{
		GSocketServiceExterns.g_socket_service_start(service);
		return service;
	}

	public static GSocketServiceHandle Stop(this GSocketServiceHandle service)
	{
		GSocketServiceExterns.g_socket_service_stop(service);
		return service;
	}

}

internal class GSocketServiceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSocketServiceHandle g_socket_service_new();

	[DllImport(Libraries.Gio)]
	internal static extern bool g_socket_service_is_active(GSocketServiceHandle service);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_service_start(GSocketServiceHandle service);

	[DllImport(Libraries.Gio)]
	internal static extern void g_socket_service_stop(GSocketServiceHandle service);

}
