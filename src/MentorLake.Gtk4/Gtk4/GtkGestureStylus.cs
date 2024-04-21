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

public class GtkGestureStylusHandle : GtkGestureSingleHandle
{
	public static GtkGestureStylusHandle New()
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_new();
	}

}

public class GtkGestureStylusSignal
{
	public string Value { get; set; }
	public GtkGestureStylusSignal(string value) => Value = value;
}

public static class GtkGestureStylusSignals
{
	public static GtkGestureStylusSignal Down = new("BindingTransform.MethodDeclaration");
	public static GtkGestureStylusSignal Motion = new("BindingTransform.MethodDeclaration");
	public static GtkGestureStylusSignal Proximity = new("BindingTransform.MethodDeclaration");
	public static GtkGestureStylusSignal Up = new("BindingTransform.MethodDeclaration");
}

public static class GtkGestureStylusHandleExtensions
{
	public static bool GetAxes(this GtkGestureStylusHandle gesture, GdkAxisUse[] axes, out double[] values)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_axes(gesture, axes, out values);
	}

	public static bool GetAxis(this GtkGestureStylusHandle gesture, GdkAxisUse axis, out double value)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_axis(gesture, axis, out value);
	}

	public static bool GetBacklog(this GtkGestureStylusHandle gesture, out GdkTimeCoord[] backlog, out uint n_elems)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_backlog(gesture, out backlog, out n_elems);
	}

	public static GdkDeviceToolHandle GetDeviceTool(this GtkGestureStylusHandle gesture)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_device_tool(gesture);
	}

	public static bool GetStylusOnly(this GtkGestureStylusHandle gesture)
	{
		return GtkGestureStylusExterns.gtk_gesture_stylus_get_stylus_only(gesture);
	}

	public static GtkGestureStylusHandle SetStylusOnly(this GtkGestureStylusHandle gesture, bool stylus_only)
	{
		GtkGestureStylusExterns.gtk_gesture_stylus_set_stylus_only(gesture, stylus_only);
		return gesture;
	}

	public static GtkGestureStylusHandle Signal_Down(this GtkGestureStylusHandle instance, GtkGestureStylusDelegates.Down handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "down", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureStylusHandle Signal_Motion(this GtkGestureStylusHandle instance, GtkGestureStylusDelegates.Motion handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureStylusHandle Signal_Proximity(this GtkGestureStylusHandle instance, GtkGestureStylusDelegates.Proximity handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "proximity", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureStylusHandle Signal_Up(this GtkGestureStylusHandle instance, GtkGestureStylusDelegates.Up handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "up", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkGestureStylusDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Down([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Proximity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureStylusHandle>))] GtkGestureStylusHandle self, double x, double y, IntPtr user_data);
}

internal class GtkGestureStylusExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureStylusHandle gtk_gesture_stylus_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_stylus_get_axes(GtkGestureStylusHandle gesture, GdkAxisUse[] axes, out double[] values);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_stylus_get_axis(GtkGestureStylusHandle gesture, GdkAxisUse axis, out double value);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_stylus_get_backlog(GtkGestureStylusHandle gesture, out GdkTimeCoord[] backlog, out uint n_elems);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDeviceToolHandle gtk_gesture_stylus_get_device_tool(GtkGestureStylusHandle gesture);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_stylus_get_stylus_only(GtkGestureStylusHandle gesture);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gesture_stylus_set_stylus_only(GtkGestureStylusHandle gesture, bool stylus_only);

}
