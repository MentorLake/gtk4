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

public class GtkFileChooserWidgetSignal
{
	public string Value { get; set; }
	public GtkFileChooserWidgetSignal(string value) => Value = value;
}

public static class GtkFileChooserWidgetSignals
{
	public static GtkFileChooserWidgetSignal DesktopFolder = new("BindingTransform.MethodDeclaration");
	public static GtkFileChooserWidgetSignal DownFolder = new("BindingTransform.MethodDeclaration");
	public static GtkFileChooserWidgetSignal HomeFolder = new("BindingTransform.MethodDeclaration");
	public static GtkFileChooserWidgetSignal LocationPopup = new("BindingTransform.MethodDeclaration");
	public static GtkFileChooserWidgetSignal LocationPopupOnPaste = new("BindingTransform.MethodDeclaration");
	public static GtkFileChooserWidgetSignal LocationTogglePopup = new("BindingTransform.MethodDeclaration");
	public static GtkFileChooserWidgetSignal PlacesShortcut = new("BindingTransform.MethodDeclaration");
	public static GtkFileChooserWidgetSignal QuickBookmark = new("BindingTransform.MethodDeclaration");
	public static GtkFileChooserWidgetSignal RecentShortcut = new("BindingTransform.MethodDeclaration");
	public static GtkFileChooserWidgetSignal SearchShortcut = new("BindingTransform.MethodDeclaration");
	public static GtkFileChooserWidgetSignal ShowHidden = new("BindingTransform.MethodDeclaration");
	public static GtkFileChooserWidgetSignal UpFolder = new("BindingTransform.MethodDeclaration");
}

public static class GtkFileChooserWidgetHandleExtensions
{
	public static GtkFileChooserWidgetHandle Signal_DesktopFolder(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.DesktopFolder handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "desktop_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_DownFolder(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.DownFolder handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "down_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_HomeFolder(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.HomeFolder handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "home_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_LocationPopup(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.LocationPopup handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "location_popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_LocationPopupOnPaste(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.LocationPopupOnPaste handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "location_popup_on_paste", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_LocationTogglePopup(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.LocationTogglePopup handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "location_toggle_popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_PlacesShortcut(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.PlacesShortcut handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "places_shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_QuickBookmark(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.QuickBookmark handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "quick_bookmark", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_RecentShortcut(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.RecentShortcut handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "recent_shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_SearchShortcut(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.SearchShortcut handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "search_shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_ShowHidden(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.ShowHidden handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "show_hidden", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
	public static GtkFileChooserWidgetHandle Signal_UpFolder(this GtkFileChooserWidgetHandle instance, GtkFileChooserWidgetDelegates.UpFolder handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "up_folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkFileChooserWidgetDelegates
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

internal class GtkFileChooserWidgetExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFileChooserWidgetHandle gtk_file_chooser_widget_new(GtkFileChooserAction action);

}
