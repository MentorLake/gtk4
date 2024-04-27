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

public class GtkIMContextHandle : GObjectHandle
{
}

public static class GtkIMContextSignalExtensions
{
	public static GtkIMContextHandle Signal_Commit(this GtkIMContextHandle instance, GtkIMContextSignalDelegates.Commit handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "commit", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkIMContextHandle Signal_DeleteSurrounding(this GtkIMContextHandle instance, GtkIMContextSignalDelegates.DeleteSurrounding handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "delete_surrounding", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkIMContextHandle Signal_PreeditChanged(this GtkIMContextHandle instance, GtkIMContextSignalDelegates.PreeditChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "preedit_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkIMContextHandle Signal_PreeditEnd(this GtkIMContextHandle instance, GtkIMContextSignalDelegates.PreeditEnd handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "preedit_end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkIMContextHandle Signal_PreeditStart(this GtkIMContextHandle instance, GtkIMContextSignalDelegates.PreeditStart handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "preedit_start", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkIMContextHandle Signal_RetrieveSurrounding(this GtkIMContextHandle instance, GtkIMContextSignalDelegates.RetrieveSurrounding handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "retrieve_surrounding", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkIMContextSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Commit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, string str, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool DeleteSurrounding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, int offset, int n_chars, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PreeditChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PreeditEnd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PreeditStart([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate bool RetrieveSurrounding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkIMContextHandle>))] GtkIMContextHandle self, IntPtr user_data);
}


public static class GtkIMContextHandleExtensions
{
	public static bool GtkImContextActivateOsk(this GtkIMContextHandle context, GdkEventHandle @event)
	{
		return GtkIMContextExterns.gtk_im_context_activate_osk(context, @event);
	}

	public static bool GtkImContextDeleteSurrounding(this GtkIMContextHandle context, int offset, int n_chars)
	{
		return GtkIMContextExterns.gtk_im_context_delete_surrounding(context, offset, n_chars);
	}

	public static bool GtkImContextFilterKey(this GtkIMContextHandle context, bool press, GdkSurfaceHandle surface, GdkDeviceHandle device, uint time, uint keycode, GdkModifierType state, int group)
	{
		return GtkIMContextExterns.gtk_im_context_filter_key(context, press, surface, device, time, keycode, state, group);
	}

	public static bool GtkImContextFilterKeypress(this GtkIMContextHandle context, GdkEventHandle @event)
	{
		return GtkIMContextExterns.gtk_im_context_filter_keypress(context, @event);
	}

	public static GtkIMContextHandle GtkImContextFocusIn(this GtkIMContextHandle context)
	{
		GtkIMContextExterns.gtk_im_context_focus_in(context);
		return context;
	}

	public static GtkIMContextHandle GtkImContextFocusOut(this GtkIMContextHandle context)
	{
		GtkIMContextExterns.gtk_im_context_focus_out(context);
		return context;
	}

	public static GtkIMContextHandle GtkImContextGetPreeditString(this GtkIMContextHandle context, out string str, out PangoAttrListHandle attrs, out int cursor_pos)
	{
		GtkIMContextExterns.gtk_im_context_get_preedit_string(context, out str, out attrs, out cursor_pos);
		return context;
	}

	public static bool GtkImContextGetSurrounding(this GtkIMContextHandle context, out string text, out int cursor_index)
	{
		return GtkIMContextExterns.gtk_im_context_get_surrounding(context, out text, out cursor_index);
	}

	public static bool GtkImContextGetSurroundingWithSelection(this GtkIMContextHandle context, out string text, out int cursor_index, out int anchor_index)
	{
		return GtkIMContextExterns.gtk_im_context_get_surrounding_with_selection(context, out text, out cursor_index, out anchor_index);
	}

	public static GtkIMContextHandle GtkImContextReset(this GtkIMContextHandle context)
	{
		GtkIMContextExterns.gtk_im_context_reset(context);
		return context;
	}

	public static GtkIMContextHandle GtkImContextSetClientWidget(this GtkIMContextHandle context, GtkWidgetHandle widget)
	{
		GtkIMContextExterns.gtk_im_context_set_client_widget(context, widget);
		return context;
	}

	public static GtkIMContextHandle GtkImContextSetCursorLocation(this GtkIMContextHandle context, GdkRectangleHandle area)
	{
		GtkIMContextExterns.gtk_im_context_set_cursor_location(context, area);
		return context;
	}

	public static GtkIMContextHandle GtkImContextSetSurrounding(this GtkIMContextHandle context, string text, int len, int cursor_index)
	{
		GtkIMContextExterns.gtk_im_context_set_surrounding(context, text, len, cursor_index);
		return context;
	}

	public static GtkIMContextHandle GtkImContextSetSurroundingWithSelection(this GtkIMContextHandle context, string text, int len, int cursor_index, int anchor_index)
	{
		GtkIMContextExterns.gtk_im_context_set_surrounding_with_selection(context, text, len, cursor_index, anchor_index);
		return context;
	}

	public static GtkIMContextHandle GtkImContextSetUsePreedit(this GtkIMContextHandle context, bool use_preedit)
	{
		GtkIMContextExterns.gtk_im_context_set_use_preedit(context, use_preedit);
		return context;
	}

}

internal class GtkIMContextExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_im_context_activate_osk(GtkIMContextHandle context, GdkEventHandle @event);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_im_context_delete_surrounding(GtkIMContextHandle context, int offset, int n_chars);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_im_context_filter_key(GtkIMContextHandle context, bool press, GdkSurfaceHandle surface, GdkDeviceHandle device, uint time, uint keycode, GdkModifierType state, int group);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_im_context_filter_keypress(GtkIMContextHandle context, GdkEventHandle @event);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_context_focus_in(GtkIMContextHandle context);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_context_focus_out(GtkIMContextHandle context);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_context_get_preedit_string(GtkIMContextHandle context, out string str, out PangoAttrListHandle attrs, out int cursor_pos);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_im_context_get_surrounding(GtkIMContextHandle context, out string text, out int cursor_index);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_im_context_get_surrounding_with_selection(GtkIMContextHandle context, out string text, out int cursor_index, out int anchor_index);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_context_reset(GtkIMContextHandle context);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_context_set_client_widget(GtkIMContextHandle context, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_context_set_cursor_location(GtkIMContextHandle context, GdkRectangleHandle area);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_context_set_surrounding(GtkIMContextHandle context, string text, int len, int cursor_index);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_context_set_surrounding_with_selection(GtkIMContextHandle context, string text, int len, int cursor_index, int anchor_index);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_im_context_set_use_preedit(GtkIMContextHandle context, bool use_preedit);

}
