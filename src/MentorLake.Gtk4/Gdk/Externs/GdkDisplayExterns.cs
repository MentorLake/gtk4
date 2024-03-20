using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;

public static class GdkDisplayExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_get_name")]
	internal static extern string gdk_display_get_name(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_device_is_grabbed")]
	internal static extern int gdk_display_device_is_grabbed(this GdkDisplayHandle display, GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_beep")]
	internal static extern void gdk_display_beep(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_sync")]
	internal static extern void gdk_display_sync(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_flush")]
	internal static extern void gdk_display_flush(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_close")]
	internal static extern void gdk_display_close(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_is_closed")]
	internal static extern int gdk_display_is_closed(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_is_composited")]
	internal static extern int gdk_display_is_composited(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_is_rgba")]
	internal static extern int gdk_display_is_rgba(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_supports_input_shapes")]
	internal static extern int gdk_display_supports_input_shapes(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_prepare_gl")]
	internal static extern int gdk_display_prepare_gl(this GdkDisplayHandle self, out GErrorHandle error);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_create_gl_context")]
	internal static extern GdkGLContextHandle gdk_display_create_gl_context(this GdkDisplayHandle self, out GErrorHandle error);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_get_clipboard")]
	internal static extern GdkClipboardHandle gdk_display_get_clipboard(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_get_primary_clipboard")]
	internal static extern GdkClipboardHandle gdk_display_get_primary_clipboard(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_notify_startup_complete")]
	internal static extern void gdk_display_notify_startup_complete(this GdkDisplayHandle display, string startup_id);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_get_startup_notification_id")]
	internal static extern string gdk_display_get_startup_notification_id(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_get_app_launch_context")]
	internal static extern GdkAppLaunchContextHandle gdk_display_get_app_launch_context(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_get_default_seat")]
	internal static extern GdkSeatHandle gdk_display_get_default_seat(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_list_seats")]
	internal static extern GListHandle gdk_display_list_seats(this GdkDisplayHandle display);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_get_monitors")]
	internal static extern GListModelHandle gdk_display_get_monitors(this GdkDisplayHandle self);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_get_monitor_at_surface")]
	internal static extern GdkMonitorHandle gdk_display_get_monitor_at_surface(this GdkDisplayHandle display, GdkSurfaceHandle surface);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_put_event")]
	internal static extern void gdk_display_put_event(this GdkDisplayHandle display, GdkEventHandle @event);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_map_keyval")]
	internal static extern int gdk_display_map_keyval(this GdkDisplayHandle display, uint keyval, GdkKeymapKeyHandle[] keys, out int n_keys);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_map_keycode")]
	internal static extern int gdk_display_map_keycode(this GdkDisplayHandle display, uint keycode, GdkKeymapKeyHandle[] keys, out uint[] keyvals, out int n_entries);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_translate_key")]
	internal static extern int gdk_display_translate_key(this GdkDisplayHandle display, uint keycode, GdkModifierType state, int group, out uint keyval, out int effective_group, out int level, out GdkModifierType consumed);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_display_get_setting")]
	internal static extern int gdk_display_get_setting(this GdkDisplayHandle display, string name, GValueHandle value);
}
