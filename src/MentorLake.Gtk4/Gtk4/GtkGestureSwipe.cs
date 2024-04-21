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

public class GtkGestureSwipeHandle : GtkGestureSingleHandle
{
	public static GtkGestureSwipeHandle New()
	{
		return GtkGestureSwipeExterns.gtk_gesture_swipe_new();
	}

}

public class GtkGestureSwipeSignal
{
	public string Value { get; set; }
	public GtkGestureSwipeSignal(string value) => Value = value;
}

public static class GtkGestureSwipeSignals
{
	public static GtkGestureSwipeSignal Swipe = new("BindingTransform.MethodDeclaration");
}

public static class GtkGestureSwipeHandleExtensions
{
	public static bool GetVelocity(this GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y)
	{
		return GtkGestureSwipeExterns.gtk_gesture_swipe_get_velocity(gesture, out velocity_x, out velocity_y);
	}

	public static GtkGestureSwipeHandle Signal_Swipe(this GtkGestureSwipeHandle instance, GtkGestureSwipeDelegates.Swipe handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "swipe", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkGestureSwipeDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Swipe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureSwipeHandle>))] GtkGestureSwipeHandle self, double velocity_x, double velocity_y, IntPtr user_data);
}

internal class GtkGestureSwipeExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureSwipeHandle gtk_gesture_swipe_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_gesture_swipe_get_velocity(GtkGestureSwipeHandle gesture, out double velocity_x, out double velocity_y);

}
