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

public class GtkGestureZoomHandle : GtkGestureHandle
{
	public static GtkGestureZoomHandle New()
	{
		return GtkGestureZoomExterns.gtk_gesture_zoom_new();
	}

}

public class GtkGestureZoomSignal
{
	public string Value { get; set; }
	public GtkGestureZoomSignal(string value) => Value = value;
}

public static class GtkGestureZoomSignals
{
	public static GtkGestureZoomSignal ScaleChanged = new("BindingTransform.MethodDeclaration");
}

public static class GtkGestureZoomHandleExtensions
{
	public static double GetScaleDelta(this GtkGestureZoomHandle gesture)
	{
		return GtkGestureZoomExterns.gtk_gesture_zoom_get_scale_delta(gesture);
	}

	public static GtkGestureZoomHandle Signal_ScaleChanged(this GtkGestureZoomHandle instance, GtkGestureZoomDelegates.ScaleChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "scale_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkGestureZoomDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ScaleChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureZoomHandle>))] GtkGestureZoomHandle self, double scale, IntPtr user_data);
}

internal class GtkGestureZoomExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureZoomHandle gtk_gesture_zoom_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_gesture_zoom_get_scale_delta(GtkGestureZoomHandle gesture);

}
