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

public class GtkWindowHandle : GtkWidgetHandle
{
	public static GtkWindowHandle New()
	{
		return GtkWindowExterns.gtk_window_new();
	}
}

public class GtkWindowSignal
{
	public string Value { get; set; }
	public GtkWindowSignal(string value) => Value = value;
}

public static class GtkWindowSignals
{
	public static GtkWindowSignal ActivateDefault = new("activate-default");
	public static GtkWindowSignal ActivateFocus = new("activate-focus");
	public static GtkWindowSignal CloseRequest = new("close-request");
	public static GtkWindowSignal EnableDebugging = new("enable-debugging");
	public static GtkWindowSignal KeysChanged = new("keys-changed");
}

public static class GtkWindowHandleExtensions
{
	public static GtkWindowHandle Close(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_close(window);
		return window;
	}

	public static GtkWindowHandle Destroy(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_destroy(window);
		return window;
	}

	public static GtkWindowHandle Fullscreen(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_fullscreen(window);
		return window;
	}

	public static GtkWindowHandle FullscreenOnMonitor(this GtkWindowHandle window, GdkMonitorHandle monitor)
	{
		GtkWindowExterns.gtk_window_fullscreen_on_monitor(window, monitor);
		return window;
	}

	public static GtkApplicationHandle GetApplication(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_application(window);
	}

	public static GtkWidgetHandle GetChild(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_child(window);
	}

	public static bool GetDecorated(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_decorated(window);
	}

	public static GtkWindowHandle GetDefaultSize(this GtkWindowHandle window, out int width, out int height)
	{
		GtkWindowExterns.gtk_window_get_default_size(window, out width, out height);
		return window;
	}

	public static GtkWidgetHandle GetDefaultWidget(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_default_widget(window);
	}

	public static bool GetDeletable(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_deletable(window);
	}

	public static bool GetDestroyWithParent(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_destroy_with_parent(window);
	}

	public static GtkWidgetHandle GetFocus(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_focus(window);
	}

	public static bool GetFocusVisible(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_focus_visible(window);
	}

	public static GtkWindowGroupHandle GetGroup(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_group(window);
	}

	public static bool GetHandleMenubarAccel(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_handle_menubar_accel(window);
	}

	public static bool GetHideOnClose(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_hide_on_close(window);
	}

	public static string GetIconName(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_icon_name(window);
	}

	public static bool GetMnemonicsVisible(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_mnemonics_visible(window);
	}

	public static bool GetModal(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_modal(window);
	}

	public static bool GetResizable(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_resizable(window);
	}

	public static string GetTitle(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_title(window);
	}

	public static GtkWidgetHandle GetTitlebar(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_titlebar(window);
	}

	public static GtkWindowHandle GetTransientFor(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_transient_for(window);
	}

	public static bool HasGroup(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_has_group(window);
	}

	public static bool IsActive(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_is_active(window);
	}

	public static bool IsFullscreen(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_is_fullscreen(window);
	}

	public static bool IsMaximized(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_is_maximized(window);
	}

	public static bool IsSuspended(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_is_suspended(window);
	}

	public static GtkWindowHandle Maximize(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_maximize(window);
		return window;
	}

	public static GtkWindowHandle Minimize(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_minimize(window);
		return window;
	}

	public static GtkWindowHandle Present(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_present(window);
		return window;
	}

	public static GtkWindowHandle PresentWithTime(this GtkWindowHandle window, uint timestamp)
	{
		GtkWindowExterns.gtk_window_present_with_time(window, timestamp);
		return window;
	}

	public static GtkWindowHandle SetApplication(this GtkWindowHandle window, GtkApplicationHandle application)
	{
		GtkWindowExterns.gtk_window_set_application(window, application);
		return window;
	}

	public static GtkWindowHandle SetChild(this GtkWindowHandle window, GtkWidgetHandle child)
	{
		GtkWindowExterns.gtk_window_set_child(window, child);
		return window;
	}

	public static GtkWindowHandle SetDecorated(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_decorated(window, setting);
		return window;
	}

	public static GtkWindowHandle SetDefaultSize(this GtkWindowHandle window, int width, int height)
	{
		GtkWindowExterns.gtk_window_set_default_size(window, width, height);
		return window;
	}

	public static GtkWindowHandle SetDefaultWidget(this GtkWindowHandle window, GtkWidgetHandle default_widget)
	{
		GtkWindowExterns.gtk_window_set_default_widget(window, default_widget);
		return window;
	}

	public static GtkWindowHandle SetDeletable(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_deletable(window, setting);
		return window;
	}

	public static GtkWindowHandle SetDestroyWithParent(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_destroy_with_parent(window, setting);
		return window;
	}

	public static GtkWindowHandle SetDisplay(this GtkWindowHandle window, GdkDisplayHandle display)
	{
		GtkWindowExterns.gtk_window_set_display(window, display);
		return window;
	}

	public static GtkWindowHandle SetFocus(this GtkWindowHandle window, GtkWidgetHandle focus)
	{
		GtkWindowExterns.gtk_window_set_focus(window, focus);
		return window;
	}

	public static GtkWindowHandle SetFocusVisible(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_focus_visible(window, setting);
		return window;
	}

	public static GtkWindowHandle SetHandleMenubarAccel(this GtkWindowHandle window, bool handle_menubar_accel)
	{
		GtkWindowExterns.gtk_window_set_handle_menubar_accel(window, handle_menubar_accel);
		return window;
	}

	public static GtkWindowHandle SetHideOnClose(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_hide_on_close(window, setting);
		return window;
	}

	public static GtkWindowHandle SetIconName(this GtkWindowHandle window, string name)
	{
		GtkWindowExterns.gtk_window_set_icon_name(window, name);
		return window;
	}

	public static GtkWindowHandle SetMnemonicsVisible(this GtkWindowHandle window, bool setting)
	{
		GtkWindowExterns.gtk_window_set_mnemonics_visible(window, setting);
		return window;
	}

	public static GtkWindowHandle SetModal(this GtkWindowHandle window, bool modal)
	{
		GtkWindowExterns.gtk_window_set_modal(window, modal);
		return window;
	}

	public static GtkWindowHandle SetResizable(this GtkWindowHandle window, bool resizable)
	{
		GtkWindowExterns.gtk_window_set_resizable(window, resizable);
		return window;
	}

	public static GtkWindowHandle SetStartupId(this GtkWindowHandle window, string startup_id)
	{
		GtkWindowExterns.gtk_window_set_startup_id(window, startup_id);
		return window;
	}

	public static GtkWindowHandle SetTitle(this GtkWindowHandle window, string title)
	{
		GtkWindowExterns.gtk_window_set_title(window, title);
		return window;
	}

	public static GtkWindowHandle SetTitlebar(this GtkWindowHandle window, GtkWidgetHandle titlebar)
	{
		GtkWindowExterns.gtk_window_set_titlebar(window, titlebar);
		return window;
	}

	public static GtkWindowHandle SetTransientFor(this GtkWindowHandle window, GtkWindowHandle parent)
	{
		GtkWindowExterns.gtk_window_set_transient_for(window, parent);
		return window;
	}

	public static GtkWindowHandle Unfullscreen(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_unfullscreen(window);
		return window;
	}

	public static GtkWindowHandle Unmaximize(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_unmaximize(window);
		return window;
	}

	public static GtkWindowHandle Unminimize(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_unminimize(window);
		return window;
	}

	public static GtkWindowHandle GtkShowUriFull(this GtkWindowHandle parent, string uri, uint timestamp, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkWindowExterns.gtk_show_uri_full(parent, uri, timestamp, cancellable, callback, user_data);
		return parent;
	}

	public static GtkWindowHandle GtkPrintRunPageSetupDialogAsync(this GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings, GtkPageSetupDoneFunc done_cb, IntPtr data)
	{
		GtkWindowExterns.gtk_print_run_page_setup_dialog_async(parent, page_setup, settings, done_cb, data);
		return parent;
	}

	public static bool GtkShowUriFullFinish(this GtkWindowHandle parent, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkWindowExterns.gtk_show_uri_full_finish(parent, result, out error);
	}

	public static GtkWindowHandle GtkShowAboutDialog(this GtkWindowHandle parent, string first_property_name, IntPtr @__arglist)
	{
		GtkWindowExterns.gtk_show_about_dialog(parent, first_property_name, @__arglist);
		return parent;
	}

	public static GtkPageSetupHandle GtkPrintRunPageSetupDialog(this GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings)
	{
		return GtkWindowExterns.gtk_print_run_page_setup_dialog(parent, page_setup, settings);
	}

	public static GtkWindowHandle GtkShowUri(this GtkWindowHandle parent, string uri, uint timestamp)
	{
		GtkWindowExterns.gtk_show_uri(parent, uri, timestamp);
		return parent;
	}

	public static GtkWindowHandle Connect(this GtkWindowHandle instance, GtkWindowSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GtkWindowExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_close(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_destroy(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_fullscreen(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_fullscreen_on_monitor(GtkWindowHandle window, GdkMonitorHandle monitor);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkApplicationHandle gtk_window_get_application(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_window_get_child(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_get_decorated(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_get_default_size(GtkWindowHandle window, out int width, out int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_window_get_default_widget(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_get_deletable(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_get_destroy_with_parent(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_window_get_focus(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_get_focus_visible(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWindowGroupHandle gtk_window_get_group(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_get_handle_menubar_accel(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_get_hide_on_close(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_window_get_icon_name(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_get_mnemonics_visible(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_get_modal(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_get_resizable(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_window_get_title(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_window_get_titlebar(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWindowHandle gtk_window_get_transient_for(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_has_group(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_is_active(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_is_fullscreen(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_is_maximized(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_window_is_suspended(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_maximize(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_minimize(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_present(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_present_with_time(GtkWindowHandle window, uint timestamp);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_application(GtkWindowHandle window, GtkApplicationHandle application);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_child(GtkWindowHandle window, GtkWidgetHandle child);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_decorated(GtkWindowHandle window, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_default_size(GtkWindowHandle window, int width, int height);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_default_widget(GtkWindowHandle window, GtkWidgetHandle default_widget);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_deletable(GtkWindowHandle window, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_destroy_with_parent(GtkWindowHandle window, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_display(GtkWindowHandle window, GdkDisplayHandle display);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_focus(GtkWindowHandle window, GtkWidgetHandle focus);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_focus_visible(GtkWindowHandle window, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_handle_menubar_accel(GtkWindowHandle window, bool handle_menubar_accel);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_hide_on_close(GtkWindowHandle window, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_icon_name(GtkWindowHandle window, string name);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_mnemonics_visible(GtkWindowHandle window, bool setting);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_modal(GtkWindowHandle window, bool modal);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_resizable(GtkWindowHandle window, bool resizable);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_startup_id(GtkWindowHandle window, string startup_id);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_title(GtkWindowHandle window, string title);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_titlebar(GtkWindowHandle window, GtkWidgetHandle titlebar);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_set_transient_for(GtkWindowHandle window, GtkWindowHandle parent);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_unfullscreen(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_unmaximize(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_window_unminimize(GtkWindowHandle window);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_show_uri_full(GtkWindowHandle parent, string uri, uint timestamp, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_run_page_setup_dialog_async(GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings, GtkPageSetupDoneFunc done_cb, IntPtr data);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_show_uri_full_finish(GtkWindowHandle parent, GAsyncResultHandle result, out GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_show_about_dialog(GtkWindowHandle parent, string first_property_name, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_print_run_page_setup_dialog(GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_show_uri(GtkWindowHandle parent, string uri, uint timestamp);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWindowHandle gtk_window_new();
}
