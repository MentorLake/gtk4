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

public class GtkGestureDragHandle : GtkGestureSingleHandle
{
	public static GtkGestureDragHandle New()
	{
		return GtkGestureDragExterns.gtk_gesture_drag_new();
	}

}

public class GtkGestureDragSignal
{
	public string Value { get; set; }
	public GtkGestureDragSignal(string value) => Value = value;
}

public static class GtkGestureDragSignals
{
	public static GtkGestureDragSignal DragBegin = new("BindingTransform.MethodDeclaration");
	public static GtkGestureDragSignal DragEnd = new("BindingTransform.MethodDeclaration");
	public static GtkGestureDragSignal DragUpdate = new("BindingTransform.MethodDeclaration");
}

public static class GtkGestureDragHandleExtensions
{
	public static bool GetOffset(this GtkGestureDragHandle gesture, out double x, out double y)
	{
		return GtkGestureDragExterns.gtk_gesture_drag_get_offset(gesture, out x, out y);
	}

	public static bool GetStartPoint(this GtkGestureDragHandle gesture, out double x, out double y)
	{
		return GtkGestureDragExterns.gtk_gesture_drag_get_start_point(gesture, out x, out y);
	}

	public static GtkGestureDragHandle Signal_DragBegin(this GtkGestureDragHandle instance, GtkGestureDragDelegates.DragBegin handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drag_begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureDragHandle Signal_DragEnd(this GtkGestureDragHandle instance, GtkGestureDragDelegates.DragEnd handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drag_end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureDragHandle Signal_DragUpdate(this GtkGestureDragHandle instance, GtkGestureDragDelegates.DragUpdate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "drag_update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkGestureDragDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DragBegin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureDragHandle>))] GtkGestureDragHandle self, double start_x, double start_y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DragEnd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureDragHandle>))] GtkGestureDragHandle self, double offset_x, double offset_y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DragUpdate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureDragHandle>))] GtkGestureDragHandle self, double offset_x, double offset_y, IntPtr user_data);
}

internal class GtkGestureDragExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureDragHandle gtk_gesture_drag_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_drag_get_offset(GtkGestureDragHandle gesture, out double x, out double y);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_drag_get_start_point(GtkGestureDragHandle gesture, out double x, out double y);

}
