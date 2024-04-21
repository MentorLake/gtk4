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

public class GtkDropControllerMotionHandle : GtkEventControllerHandle
{
	public static GtkDropControllerMotionHandle New()
	{
		return GtkDropControllerMotionExterns.gtk_drop_controller_motion_new();
	}

}

public class GtkDropControllerMotionSignal
{
	public string Value { get; set; }
	public GtkDropControllerMotionSignal(string value) => Value = value;
}

public static class GtkDropControllerMotionSignals
{
	public static GtkDropControllerMotionSignal Enter = new("BindingTransform.MethodDeclaration");
	public static GtkDropControllerMotionSignal Leave = new("BindingTransform.MethodDeclaration");
	public static GtkDropControllerMotionSignal Motion = new("BindingTransform.MethodDeclaration");
}

public static class GtkDropControllerMotionHandleExtensions
{
	public static bool ContainsPointer(this GtkDropControllerMotionHandle self)
	{
		return GtkDropControllerMotionExterns.gtk_drop_controller_motion_contains_pointer(self);
	}

	public static GdkDropHandle GetDrop(this GtkDropControllerMotionHandle self)
	{
		return GtkDropControllerMotionExterns.gtk_drop_controller_motion_get_drop(self);
	}

	public static bool IsPointer(this GtkDropControllerMotionHandle self)
	{
		return GtkDropControllerMotionExterns.gtk_drop_controller_motion_is_pointer(self);
	}

	public static GtkDropControllerMotionHandle Signal_Enter(this GtkDropControllerMotionHandle instance, GtkDropControllerMotionDelegates.Enter handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "enter", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkDropControllerMotionHandle Signal_Leave(this GtkDropControllerMotionHandle instance, GtkDropControllerMotionDelegates.Leave handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkDropControllerMotionHandle Signal_Motion(this GtkDropControllerMotionHandle instance, GtkDropControllerMotionDelegates.Motion handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkDropControllerMotionDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Enter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropControllerMotionHandle>))] GtkDropControllerMotionHandle self, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropControllerMotionHandle>))] GtkDropControllerMotionHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkDropControllerMotionHandle>))] GtkDropControllerMotionHandle self, double x, double y, IntPtr user_data);
}

internal class GtkDropControllerMotionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkDropControllerMotionHandle gtk_drop_controller_motion_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_drop_controller_motion_contains_pointer(GtkDropControllerMotionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDropHandle gtk_drop_controller_motion_get_drop(GtkDropControllerMotionHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_drop_controller_motion_is_pointer(GtkDropControllerMotionHandle self);

}
