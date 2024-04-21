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

public class GtkGestureClickHandle : GtkGestureSingleHandle
{
	public static GtkGestureClickHandle New()
	{
		return GtkGestureClickExterns.gtk_gesture_click_new();
	}

}

public class GtkGestureClickSignal
{
	public string Value { get; set; }
	public GtkGestureClickSignal(string value) => Value = value;
}

public static class GtkGestureClickSignals
{
	public static GtkGestureClickSignal Pressed = new("BindingTransform.MethodDeclaration");
	public static GtkGestureClickSignal Released = new("BindingTransform.MethodDeclaration");
	public static GtkGestureClickSignal Stopped = new("BindingTransform.MethodDeclaration");
	public static GtkGestureClickSignal UnpairedRelease = new("BindingTransform.MethodDeclaration");
}

public static class GtkGestureClickHandleExtensions
{
	public static GtkGestureClickHandle Signal_Pressed(this GtkGestureClickHandle instance, GtkGestureClickDelegates.Pressed handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "pressed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureClickHandle Signal_Released(this GtkGestureClickHandle instance, GtkGestureClickDelegates.Released handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "released", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureClickHandle Signal_Stopped(this GtkGestureClickHandle instance, GtkGestureClickDelegates.Stopped handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "stopped", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkGestureClickHandle Signal_UnpairedRelease(this GtkGestureClickHandle instance, GtkGestureClickDelegates.UnpairedRelease handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "unpaired_release", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkGestureClickDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Pressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureClickHandle>))] GtkGestureClickHandle self, int n_press, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Released([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureClickHandle>))] GtkGestureClickHandle self, int n_press, double x, double y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Stopped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureClickHandle>))] GtkGestureClickHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void UnpairedRelease([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkGestureClickHandle>))] GtkGestureClickHandle self, double x, double y, uint button, GdkEventSequenceHandle sequence, IntPtr user_data);
}

internal class GtkGestureClickExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkGestureClickHandle gtk_gesture_click_new();

}
