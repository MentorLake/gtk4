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

public class GtkFileChooserWidgetHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkFileChooserHandle
{
	public static GtkFileChooserWidgetHandle New(GtkFileChooserAction action)
	{
		return GtkFileChooserWidgetExterns.gtk_file_chooser_widget_new(action);
	}

}

public static class GtkFileChooserWidgetSignalExtensions
{
	public static GtkFileChooserWidgetHandle Signal_DesktopFolder(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.DesktopFolder handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "desktop_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_DownFolder(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.DownFolder handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "down_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_HomeFolder(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.HomeFolder handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "home_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_LocationPopup(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.LocationPopup handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "location_popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_LocationPopupOnPaste(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.LocationPopupOnPaste handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "location_popup_on_paste", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_LocationTogglePopup(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.LocationTogglePopup handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "location_toggle_popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_PlacesShortcut(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.PlacesShortcut handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "places_shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_QuickBookmark(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.QuickBookmark handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "quick_bookmark", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_RecentShortcut(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.RecentShortcut handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "recent_shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_SearchShortcut(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.SearchShortcut handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "search_shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_ShowHidden(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.ShowHidden handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "show_hidden", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_UpFolder(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetSignalDelegates.UpFolder handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "up_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkFileChooserWidgetSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DesktopFolder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DownFolder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void HomeFolder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void LocationPopup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, string path, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void LocationPopupOnPaste([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void LocationTogglePopup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void PlacesShortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void QuickBookmark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, int bookmark_index, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void RecentShortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SearchShortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void ShowHidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void UpFolder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkFileChooserWidgetHandle>))] GtkFileChooserWidgetHandle self, IntPtr user_data);
}


public static class GtkFileChooserWidgetHandleExtensions
{
}

internal class GtkFileChooserWidgetExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileChooserWidgetHandle gtk_file_chooser_widget_new(GtkFileChooserAction action);

}
