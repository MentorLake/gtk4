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

namespace MentorLake.Gtk4.Gtk4;

public class GtkEventControllerMotionHandle : GtkEventControllerHandle
{
	public static GtkEventControllerMotionHandle New()
	{
		return GtkEventControllerMotionExterns.gtk_event_controller_motion_new();
	}

}

public static class GtkEventControllerMotionSignalExtensions
{
	public static GtkEventControllerMotionHandle Signal_Enter(this GtkEventControllerMotionHandle instance, GtkEventControllerMotionSignalDelegates.Enter handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "enter", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkEventControllerMotionHandle Signal_Leave(this GtkEventControllerMotionHandle instance, GtkEventControllerMotionSignalDelegates.Leave handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkEventControllerMotionHandle Signal_Motion(this GtkEventControllerMotionHandle instance, GtkEventControllerMotionSignalDelegates.Motion handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkEventControllerMotionSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerMotionHandle>))] GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerMotionHandle>))] GtkEventControllerMotionHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerMotionHandle>))] GtkEventControllerMotionHandle self, double x, double y, IntPtr user_data);
}


public static class GtkEventControllerMotionHandleExtensions
{
	public static bool ContainsPointer(this GtkEventControllerMotionHandle self)
	{
		return GtkEventControllerMotionExterns.gtk_event_controller_motion_contains_pointer(self);
	}

	public static bool IsPointer(this GtkEventControllerMotionHandle self)
	{
		return GtkEventControllerMotionExterns.gtk_event_controller_motion_is_pointer(self);
	}

}

internal class GtkEventControllerMotionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerMotionHandle gtk_event_controller_motion_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_motion_contains_pointer(GtkEventControllerMotionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_motion_is_pointer(GtkEventControllerMotionHandle self);

}
