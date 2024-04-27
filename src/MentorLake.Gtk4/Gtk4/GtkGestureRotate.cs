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

public class GtkGestureRotateHandle : GtkGestureHandle
{
	public static GtkGestureRotateHandle New()
	{
		return GtkGestureRotateExterns.gtk_gesture_rotate_new();
	}

}

public static class GtkGestureRotateSignalExtensions
{
	public static GtkGestureRotateHandle Signal_AngleChanged(this GtkGestureRotateHandle instance, GtkGestureRotateSignalDelegates.AngleChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "angle_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkGestureRotateSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void AngleChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureRotateHandle>))] GtkGestureRotateHandle self, double angle, double angle_delta, IntPtr user_data);
}


public static class GtkGestureRotateHandleExtensions
{
	public static double GetAngleDelta(this GtkGestureRotateHandle gesture)
	{
		return GtkGestureRotateExterns.gtk_gesture_rotate_get_angle_delta(gesture);
	}

}

internal class GtkGestureRotateExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureRotateHandle gtk_gesture_rotate_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_gesture_rotate_get_angle_delta(GtkGestureRotateHandle gesture);

}
