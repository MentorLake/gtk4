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

public class GtkGestureLongPressHandle : GtkGestureSingleHandle
{
	public static GtkGestureLongPressHandle New()
	{
		return GtkGestureLongPressExterns.gtk_gesture_long_press_new();
	}

}

public class GtkGestureLongPressSignal
{
	public string Value { get; set; }
	public GtkGestureLongPressSignal(string value) => Value = value;
}

public static class GtkGestureLongPressSignals
{
	public static GtkGestureLongPressSignal Cancelled = new("BindingTransform.MethodDeclaration");
	public static GtkGestureLongPressSignal Pressed = new("BindingTransform.MethodDeclaration");
}

public static class GtkGestureLongPressHandleExtensions
{
	public static double GetDelayFactor(this GtkGestureLongPressHandle gesture)
	{
		return GtkGestureLongPressExterns.gtk_gesture_long_press_get_delay_factor(gesture);
	}

	public static GtkGestureLongPressHandle SetDelayFactor(this GtkGestureLongPressHandle gesture, double delay_factor)
	{
		GtkGestureLongPressExterns.gtk_gesture_long_press_set_delay_factor(gesture, delay_factor);
		return gesture;
	}

	public static GtkGestureLongPressHandle Signal_Cancelled(this GtkGestureLongPressHandle instance, GtkGestureLongPressDelegates.Cancelled handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "cancelled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureLongPressHandle Signal_Pressed(this GtkGestureLongPressHandle instance, GtkGestureLongPressDelegates.Pressed handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "pressed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkGestureLongPressDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureLongPressHandle>))] GtkGestureLongPressHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureLongPressHandle>))] GtkGestureLongPressHandle self, double x, double y, IntPtr user_data);
}

internal class GtkGestureLongPressExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureLongPressHandle gtk_gesture_long_press_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_gesture_long_press_get_delay_factor(GtkGestureLongPressHandle gesture);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_gesture_long_press_set_delay_factor(GtkGestureLongPressHandle gesture, double delay_factor);

}
