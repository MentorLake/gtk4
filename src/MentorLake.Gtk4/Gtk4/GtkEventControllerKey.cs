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

public class GtkEventControllerKeyHandle : GtkEventControllerHandle
{
	public static GtkEventControllerKeyHandle New()
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_new();
	}

}

public static class GtkEventControllerKeySignalExtensions
{
	public static GtkEventControllerKeyHandle Signal_ImUpdate(this GtkEventControllerKeyHandle instance, GtkEventControllerKeySignalDelegates.ImUpdate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "im_update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkEventControllerKeyHandle Signal_KeyPressed(this GtkEventControllerKeyHandle instance, GtkEventControllerKeySignalDelegates.KeyPressed handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "key_pressed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkEventControllerKeyHandle Signal_KeyReleased(this GtkEventControllerKeyHandle instance, GtkEventControllerKeySignalDelegates.KeyReleased handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "key_released", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkEventControllerKeyHandle Signal_Modifiers(this GtkEventControllerKeyHandle instance, GtkEventControllerKeySignalDelegates.Modifiers handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "modifiers", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkEventControllerKeySignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ImUpdate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerKeyHandle>))] GtkEventControllerKeyHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool KeyPressed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerKeyHandle>))] GtkEventControllerKeyHandle self, uint keyval, uint keycode, GdkModifierType state, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void KeyReleased([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerKeyHandle>))] GtkEventControllerKeyHandle self, uint keyval, uint keycode, GdkModifierType state, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool Modifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEventControllerKeyHandle>))] GtkEventControllerKeyHandle self, GdkModifierType state, IntPtr user_data);
}


public static class GtkEventControllerKeyHandleExtensions
{
	public static bool Forward(this GtkEventControllerKeyHandle controller, GtkWidgetHandle widget)
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_forward(controller, widget);
	}

	public static uint GetGroup(this GtkEventControllerKeyHandle controller)
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_get_group(controller);
	}

	public static GtkIMContextHandle GetImContext(this GtkEventControllerKeyHandle controller)
	{
		return GtkEventControllerKeyExterns.gtk_event_controller_key_get_im_context(controller);
	}

	public static GtkEventControllerKeyHandle SetImContext(this GtkEventControllerKeyHandle controller, GtkIMContextHandle im_context)
	{
		GtkEventControllerKeyExterns.gtk_event_controller_key_set_im_context(controller, im_context);
		return controller;
	}

}

internal class GtkEventControllerKeyExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEventControllerKeyHandle gtk_event_controller_key_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_event_controller_key_forward(GtkEventControllerKeyHandle controller, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_event_controller_key_get_group(GtkEventControllerKeyHandle controller);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkIMContextHandle gtk_event_controller_key_get_im_context(GtkEventControllerKeyHandle controller);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_event_controller_key_set_im_context(GtkEventControllerKeyHandle controller, GtkIMContextHandle im_context);

}
