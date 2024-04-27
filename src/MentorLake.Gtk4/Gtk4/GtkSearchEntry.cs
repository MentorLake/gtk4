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

public class GtkSearchEntryHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkEditableHandle
{
	public static GtkSearchEntryHandle New()
	{
		return GtkSearchEntryExterns.gtk_search_entry_new();
	}

}

public static class GtkSearchEntrySignalExtensions
{
	public static GtkSearchEntryHandle Signal_Activate(this GtkSearchEntryHandle instance, GtkSearchEntrySignalDelegates.Activate handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkSearchEntryHandle Signal_NextMatch(this GtkSearchEntryHandle instance, GtkSearchEntrySignalDelegates.NextMatch handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "next_match", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkSearchEntryHandle Signal_PreviousMatch(this GtkSearchEntryHandle instance, GtkSearchEntrySignalDelegates.PreviousMatch handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "previous_match", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkSearchEntryHandle Signal_SearchChanged(this GtkSearchEntryHandle instance, GtkSearchEntrySignalDelegates.SearchChanged handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "search_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkSearchEntryHandle Signal_SearchStarted(this GtkSearchEntryHandle instance, GtkSearchEntrySignalDelegates.SearchStarted handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "search_started", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkSearchEntryHandle Signal_StopSearch(this GtkSearchEntryHandle instance, GtkSearchEntrySignalDelegates.StopSearch handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "stop_search", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkSearchEntrySignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void NextMatch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PreviousMatch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SearchChanged([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SearchStarted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void StopSearch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSearchEntryHandle>))] GtkSearchEntryHandle self, IntPtr user_data);
}


public static class GtkSearchEntryHandleExtensions
{
	public static GtkInputHints GetInputHints(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_input_hints(entry);
	}

	public static GtkInputPurpose GetInputPurpose(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_input_purpose(entry);
	}

	public static GtkWidgetHandle GetKeyCaptureWidget(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_key_capture_widget(entry);
	}

	public static string GetPlaceholderText(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_placeholder_text(entry);
	}

	public static uint GetSearchDelay(this GtkSearchEntryHandle entry)
	{
		return GtkSearchEntryExterns.gtk_search_entry_get_search_delay(entry);
	}

	public static GtkSearchEntryHandle SetInputHints(this GtkSearchEntryHandle entry, GtkInputHints hints)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_input_hints(entry, hints);
		return entry;
	}

	public static GtkSearchEntryHandle SetInputPurpose(this GtkSearchEntryHandle entry, GtkInputPurpose purpose)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_input_purpose(entry, purpose);
		return entry;
	}

	public static GtkSearchEntryHandle SetKeyCaptureWidget(this GtkSearchEntryHandle entry, GtkWidgetHandle widget)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_key_capture_widget(entry, widget);
		return entry;
	}

	public static GtkSearchEntryHandle SetPlaceholderText(this GtkSearchEntryHandle entry, string text)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_placeholder_text(entry, text);
		return entry;
	}

	public static GtkSearchEntryHandle SetSearchDelay(this GtkSearchEntryHandle entry, uint delay)
	{
		GtkSearchEntryExterns.gtk_search_entry_set_search_delay(entry, delay);
		return entry;
	}

}

internal class GtkSearchEntryExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSearchEntryHandle gtk_search_entry_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputHints gtk_search_entry_get_input_hints(GtkSearchEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkInputPurpose gtk_search_entry_get_input_purpose(GtkSearchEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_search_entry_get_key_capture_widget(GtkSearchEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_search_entry_get_placeholder_text(GtkSearchEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern uint gtk_search_entry_get_search_delay(GtkSearchEntryHandle entry);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_input_hints(GtkSearchEntryHandle entry, GtkInputHints hints);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_input_purpose(GtkSearchEntryHandle entry, GtkInputPurpose purpose);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_key_capture_widget(GtkSearchEntryHandle entry, GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_placeholder_text(GtkSearchEntryHandle entry, string text);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_search_entry_set_search_delay(GtkSearchEntryHandle entry, uint delay);

}
