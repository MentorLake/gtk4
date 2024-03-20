using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkWindowAdaptors
{
	public static GtkWindowHandle SetTitle(this GtkWindowHandle window, string title)
	{
		GtkWindowExterns.gtk_window_set_title(window, title);
		return window;
	}

	public static string GetTitle(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_title(window);
	}

	public static GtkWindowHandle SetStartupId(this GtkWindowHandle window, string startup_id)
	{
		GtkWindowExterns.gtk_window_set_startup_id(window, startup_id);
		return window;
	}

	public static GtkWindowHandle SetFocus(this GtkWindowHandle window, GtkWidgetHandle focus)
	{
		GtkWindowExterns.gtk_window_set_focus(window, focus);
		return window;
	}

	public static GtkWidgetHandle GetFocus(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_focus(window);
	}

	public static GtkWindowHandle SetDefaultWidget(this GtkWindowHandle window, GtkWidgetHandle default_widget)
	{
		GtkWindowExterns.gtk_window_set_default_widget(window, default_widget);
		return window;
	}

	public static GtkWidgetHandle GetDefaultWidget(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_default_widget(window);
	}

	public static GtkWindowHandle SetTransientFor(this GtkWindowHandle window, GtkWindowHandle parent)
	{
		GtkWindowExterns.gtk_window_set_transient_for(window, parent);
		return window;
	}

	public static GtkWindowHandle GetTransientFor(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_transient_for(window);
	}

	public static GtkWindowHandle SetDestroyWithParent(this GtkWindowHandle window, int setting)
	{
		GtkWindowExterns.gtk_window_set_destroy_with_parent(window, setting);
		return window;
	}

	public static int GetDestroyWithParent(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_destroy_with_parent(window);
	}

	public static GtkWindowHandle SetHideOnClose(this GtkWindowHandle window, int setting)
	{
		GtkWindowExterns.gtk_window_set_hide_on_close(window, setting);
		return window;
	}

	public static int GetHideOnClose(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_hide_on_close(window);
	}

	public static GtkWindowHandle SetMnemonicsVisible(this GtkWindowHandle window, int setting)
	{
		GtkWindowExterns.gtk_window_set_mnemonics_visible(window, setting);
		return window;
	}

	public static int GetMnemonicsVisible(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_mnemonics_visible(window);
	}

	public static GtkWindowHandle SetFocusVisible(this GtkWindowHandle window, int setting)
	{
		GtkWindowExterns.gtk_window_set_focus_visible(window, setting);
		return window;
	}

	public static int GetFocusVisible(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_focus_visible(window);
	}

	public static GtkWindowHandle SetResizable(this GtkWindowHandle window, int resizable)
	{
		GtkWindowExterns.gtk_window_set_resizable(window, resizable);
		return window;
	}

	public static int GetResizable(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_resizable(window);
	}

	public static GtkWindowHandle SetDisplay(this GtkWindowHandle window, GdkDisplayHandle display)
	{
		GtkWindowExterns.gtk_window_set_display(window, display);
		return window;
	}

	public static int IsActive(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_is_active(window);
	}

	public static GtkWindowHandle SetDecorated(this GtkWindowHandle window, int setting)
	{
		GtkWindowExterns.gtk_window_set_decorated(window, setting);
		return window;
	}

	public static int GetDecorated(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_decorated(window);
	}

	public static GtkWindowHandle SetDeletable(this GtkWindowHandle window, int setting)
	{
		GtkWindowExterns.gtk_window_set_deletable(window, setting);
		return window;
	}

	public static int GetDeletable(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_deletable(window);
	}

	public static GtkWindowHandle SetIconName(this GtkWindowHandle window, string name)
	{
		GtkWindowExterns.gtk_window_set_icon_name(window, name);
		return window;
	}

	public static string GetIconName(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_icon_name(window);
	}

	public static GtkWindowHandle SetModal(this GtkWindowHandle window, int modal)
	{
		GtkWindowExterns.gtk_window_set_modal(window, modal);
		return window;
	}

	public static int GetModal(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_modal(window);
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

	public static GtkWindowHandle Minimize(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_minimize(window);
		return window;
	}

	public static GtkWindowHandle Unminimize(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_unminimize(window);
		return window;
	}

	public static GtkWindowHandle Maximize(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_maximize(window);
		return window;
	}

	public static GtkWindowHandle Unmaximize(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_unmaximize(window);
		return window;
	}

	public static GtkWindowHandle Fullscreen(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_fullscreen(window);
		return window;
	}

	public static GtkWindowHandle Unfullscreen(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_unfullscreen(window);
		return window;
	}

	public static GtkWindowHandle FullscreenOnMonitor(this GtkWindowHandle window, GdkMonitorHandle monitor)
	{
		GtkWindowExterns.gtk_window_fullscreen_on_monitor(window, monitor);
		return window;
	}

	public static GtkWindowHandle Close(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_close(window);
		return window;
	}

	public static GtkWindowHandle SetDefaultSize(this GtkWindowHandle window, int width, int height)
	{
		GtkWindowExterns.gtk_window_set_default_size(window, width, height);
		return window;
	}

	public static GtkWindowHandle GetDefaultSize(this GtkWindowHandle window, out int width, out int height)
	{
		GtkWindowExterns.gtk_window_get_default_size(window, out width, out height);
		return window;
	}

	public static GtkWindowGroupHandle GetGroup(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_group(window);
	}

	public static int HasGroup(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_has_group(window);
	}

	public static GtkApplicationHandle GetApplication(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_application(window);
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

	public static GtkWidgetHandle GetChild(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_child(window);
	}

	public static GtkWindowHandle SetTitlebar(this GtkWindowHandle window, GtkWidgetHandle titlebar)
	{
		GtkWindowExterns.gtk_window_set_titlebar(window, titlebar);
		return window;
	}

	public static GtkWidgetHandle GetTitlebar(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_titlebar(window);
	}

	public static int IsMaximized(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_is_maximized(window);
	}

	public static int IsFullscreen(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_is_fullscreen(window);
	}

	public static GtkWindowHandle Destroy(this GtkWindowHandle window)
	{
		GtkWindowExterns.gtk_window_destroy(window);
		return window;
	}

	public static GtkWindowHandle SetHandleMenubarAccel(this GtkWindowHandle window, int handle_menubar_accel)
	{
		GtkWindowExterns.gtk_window_set_handle_menubar_accel(window, handle_menubar_accel);
		return window;
	}

	public static int GetHandleMenubarAccel(this GtkWindowHandle window)
	{
		return GtkWindowExterns.gtk_window_get_handle_menubar_accel(window);
	}

	public static GtkWindowHandle GtkShowAboutDialog(this GtkWindowHandle parent, string first_property_name, IntPtr @__argList)
	{
		GtkWindowExterns.gtk_show_about_dialog(parent, first_property_name, @__argList);
		return parent;
	}

	public static GtkAppChooserDialogHandle GtkAppChooserDialogNew(this GtkWindowHandle parent, GtkDialogFlags flags, GFileHandle file)
	{
		return GtkWindowExterns.gtk_app_chooser_dialog_new(parent, flags, file);
	}

	public static GtkAppChooserDialogHandle GtkAppChooserDialogNewForContentType(this GtkWindowHandle parent, GtkDialogFlags flags, string content_type)
	{
		return GtkWindowExterns.gtk_app_chooser_dialog_new_for_content_type(parent, flags, content_type);
	}

	public static GtkMessageDialogHandle GtkMessageDialogNew(this GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__argList)
	{
		return GtkWindowExterns.gtk_message_dialog_new(parent, flags, type, buttons, message_format, @__argList);
	}

	public static GtkMessageDialogHandle GtkMessageDialogNewWithMarkup(this GtkWindowHandle parent, GtkDialogFlags flags, GtkMessageType type, GtkButtonsType buttons, string message_format, IntPtr @__argList)
	{
		return GtkWindowExterns.gtk_message_dialog_new_with_markup(parent, flags, type, buttons, message_format, @__argList);
	}

	public static GMountOperationHandle GtkMountOperationNew(this GtkWindowHandle parent)
	{
		return GtkWindowExterns.gtk_mount_operation_new(parent);
	}

	public static GtkPageSetupHandle GtkPrintRunPageSetupDialog(this GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings)
	{
		return GtkWindowExterns.gtk_print_run_page_setup_dialog(parent, page_setup, settings);
	}

	public static GtkWindowHandle GtkPrintRunPageSetupDialogAsync(this GtkWindowHandle parent, GtkPageSetupHandle page_setup, GtkPrintSettingsHandle settings, GtkPageSetupDoneFunc done_cb, IntPtr data)
	{
		GtkWindowExterns.gtk_print_run_page_setup_dialog_async(parent, page_setup, settings, done_cb, data);
		return parent;
	}

	public static GtkWindowHandle GtkShowUriFull(this GtkWindowHandle parent, string uri, uint timestamp, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GtkWindowExterns.gtk_show_uri_full(parent, uri, timestamp, cancellable, callback, user_data);
		return parent;
	}

	public static int GtkShowUriFullFinish(this GtkWindowHandle parent, GAsyncResultHandle result, out GErrorHandle error)
	{
		return GtkWindowExterns.gtk_show_uri_full_finish(parent, result, out error);
	}

	public static GtkWindowHandle GtkShowUri(this GtkWindowHandle parent, string uri, uint timestamp)
	{
		GtkWindowExterns.gtk_show_uri(parent, uri, timestamp);
		return parent;
	}
}
