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

public class GtkEventControllerScrollHandle : GtkEventControllerHandle
{
	public static GtkEventControllerScrollHandle New(GtkEventControllerScrollFlags flags)
	{
		return GtkEventControllerScrollExterns.gtk_event_controller_scroll_new(flags);
	}

}

public class GtkEventControllerScrollSignal
{
	public string Value { get; set; }
	public GtkEventControllerScrollSignal(string value) => Value = value;
}

public static class GtkEventControllerScrollSignals
{
	public static GtkEventControllerScrollSignal Decelerate = new("BindingTransform.MethodDeclaration");
	public static GtkEventControllerScrollSignal Scroll = new("BindingTransform.MethodDeclaration");
	public static GtkEventControllerScrollSignal ScrollBegin = new("BindingTransform.MethodDeclaration");
	public static GtkEventControllerScrollSignal ScrollEnd = new("BindingTransform.MethodDeclaration");
}

public static class GtkEventControllerScrollHandleExtensions
{
	public static GtkEventControllerScrollFlags GetFlags(this GtkEventControllerScrollHandle scroll)
	{
		return GtkEventControllerScrollExterns.gtk_event_controller_scroll_get_flags(scroll);
	}

	public static GdkScrollUnit GetUnit(this GtkEventControllerScrollHandle scroll)
	{
		return GtkEventControllerScrollExterns.gtk_event_controller_scroll_get_unit(scroll);
	}

	public static GtkEventControllerScrollHandle SetFlags(this GtkEventControllerScrollHandle scroll, GtkEventControllerScrollFlags flags)
	{
		GtkEventControllerScrollExterns.gtk_event_controller_scroll_set_flags(scroll, flags);
		return scroll;
	}

	public static GtkEventControllerScrollHandle Signal_Decelerate(this GtkEventControllerScrollHandle instance, GtkEventControllerScrollDelegates.Decelerate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "decelerate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkEventControllerScrollHandle Signal_Scroll(this GtkEventControllerScrollHandle instance, GtkEventControllerScrollDelegates.Scroll handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "scroll", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkEventControllerScrollHandle Signal_ScrollBegin(this GtkEventControllerScrollHandle instance, GtkEventControllerScrollDelegates.ScrollBegin handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "scroll_begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkEventControllerScrollHandle Signal_ScrollEnd(this GtkEventControllerScrollHandle instance, GtkEventControllerScrollDelegates.ScrollEnd handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "scroll_end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkEventControllerScrollDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Decelerate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, double vel_x, double vel_y, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Scroll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, double dx, double dy, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ScrollBegin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ScrollEnd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerScrollHandle>))] GtkEventControllerScrollHandle self, IntPtr user_data);
}

internal class GtkEventControllerScrollExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerScrollHandle gtk_event_controller_scroll_new(GtkEventControllerScrollFlags flags);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerScrollFlags gtk_event_controller_scroll_get_flags(GtkEventControllerScrollHandle scroll);

	[DllImport(Libraries.Gtk4)]
	internal static extern GdkScrollUnit gtk_event_controller_scroll_get_unit(GtkEventControllerScrollHandle scroll);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_event_controller_scroll_set_flags(GtkEventControllerScrollHandle scroll, GtkEventControllerScrollFlags flags);

}
