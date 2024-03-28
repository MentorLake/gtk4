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

namespace MentorLake.Gtk4.Gdk4;

public class GdkDisplayHandle : GObjectHandle
{
}

public class GdkDisplaySignal
{
	public string Value { get; set; }
	public GdkDisplaySignal(string value) => Value = value;
}

public static class GdkDisplaySignals
{
	public static GdkDisplaySignal Closed = new("closed");
	public static GdkDisplaySignal Opened = new("opened");
	public static GdkDisplaySignal SeatAdded = new("seat-added");
	public static GdkDisplaySignal SeatRemoved = new("seat-removed");
	public static GdkDisplaySignal SettingChanged = new("setting-changed");
}

public static class GdkDisplayHandleExtensions
{
	public static GdkDisplayHandle Beep(this GdkDisplayHandle display)
	{
		GdkDisplayExterns.gdk_display_beep(display);
		return display;
	}

	public static GdkDisplayHandle Close(this GdkDisplayHandle display)
	{
		GdkDisplayExterns.gdk_display_close(display);
		return display;
	}

	public static GdkGLContextHandle CreateGlContext(this GdkDisplayHandle self, out GErrorHandle error)
	{
		return GdkDisplayExterns.gdk_display_create_gl_context(self, out error);
	}

	public static bool DeviceIsGrabbed(this GdkDisplayHandle display, GdkDeviceHandle device)
	{
		return GdkDisplayExterns.gdk_display_device_is_grabbed(display, device);
	}

	public static GdkDisplayHandle Flush(this GdkDisplayHandle display)
	{
		GdkDisplayExterns.gdk_display_flush(display);
		return display;
	}

	public static GdkAppLaunchContextHandle GetAppLaunchContext(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_app_launch_context(display);
	}

	public static GdkClipboardHandle GetClipboard(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_clipboard(display);
	}

	public static GdkSeatHandle GetDefaultSeat(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_default_seat(display);
	}

	public static GdkDmabufFormatsHandle GetDmabufFormats(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_dmabuf_formats(display);
	}

	public static GdkMonitorHandle GetMonitorAtSurface(this GdkDisplayHandle display, GdkSurfaceHandle surface)
	{
		return GdkDisplayExterns.gdk_display_get_monitor_at_surface(display, surface);
	}

	public static GListModelHandle GetMonitors(this GdkDisplayHandle self)
	{
		return GdkDisplayExterns.gdk_display_get_monitors(self);
	}

	public static string GetName(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_name(display);
	}

	public static GdkClipboardHandle GetPrimaryClipboard(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_primary_clipboard(display);
	}

	public static bool GetSetting(this GdkDisplayHandle display, string name, GValueHandle value)
	{
		return GdkDisplayExterns.gdk_display_get_setting(display, name, value);
	}

	public static string GetStartupNotificationId(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_get_startup_notification_id(display);
	}

	public static bool IsClosed(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_is_closed(display);
	}

	public static bool IsComposited(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_is_composited(display);
	}

	public static bool IsRgba(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_is_rgba(display);
	}

	public static GListHandle ListSeats(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_list_seats(display);
	}

	public static bool MapKeycode(this GdkDisplayHandle display, uint keycode, out GdkKeymapKey[] keys, out uint[] keyvals, out int n_entries)
	{
		return GdkDisplayExterns.gdk_display_map_keycode(display, keycode, out keys, out keyvals, out n_entries);
	}

	public static bool MapKeyval(this GdkDisplayHandle display, uint keyval, out GdkKeymapKey[] keys, out int n_keys)
	{
		return GdkDisplayExterns.gdk_display_map_keyval(display, keyval, out keys, out n_keys);
	}

	public static GdkDisplayHandle NotifyStartupComplete(this GdkDisplayHandle display, string startup_id)
	{
		GdkDisplayExterns.gdk_display_notify_startup_complete(display, startup_id);
		return display;
	}

	public static bool PrepareGl(this GdkDisplayHandle self, out GErrorHandle error)
	{
		return GdkDisplayExterns.gdk_display_prepare_gl(self, out error);
	}

	public static GdkDisplayHandle PutEvent(this GdkDisplayHandle display, GdkEventHandle @event)
	{
		GdkDisplayExterns.gdk_display_put_event(display, @event);
		return display;
	}

	public static bool SupportsInputShapes(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_supports_input_shapes(display);
	}

	public static bool SupportsShadowWidth(this GdkDisplayHandle display)
	{
		return GdkDisplayExterns.gdk_display_supports_shadow_width(display);
	}

	public static GdkDisplayHandle Sync(this GdkDisplayHandle display)
	{
		GdkDisplayExterns.gdk_display_sync(display);
		return display;
	}

	public static bool TranslateKey(this GdkDisplayHandle display, uint keycode, GdkModifierType state, int group, out uint keyval, out int effective_group, out int level, out GdkModifierType consumed)
	{
		return GdkDisplayExterns.gdk_display_translate_key(display, keycode, state, group, out keyval, out effective_group, out level, out consumed);
	}

	public static GdkDisplayHandle GetDefault()
	{
		return GdkDisplayExterns.gdk_display_get_default();
	}

	public static GdkDisplayHandle Open(this string display_name)
	{
		return GdkDisplayExterns.gdk_display_open(display_name);
	}

	public static GdkDisplayHandle Connect(this GdkDisplayHandle instance, GdkDisplaySignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GdkDisplayExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_display_beep(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_display_close(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkGLContextHandle gdk_display_create_gl_context(GdkDisplayHandle self, out GErrorHandle error);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_display_device_is_grabbed(GdkDisplayHandle display, GdkDeviceHandle device);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_display_flush(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkAppLaunchContextHandle gdk_display_get_app_launch_context(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkClipboardHandle gdk_display_get_clipboard(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSeatHandle gdk_display_get_default_seat(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDmabufFormatsHandle gdk_display_get_dmabuf_formats(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkMonitorHandle gdk_display_get_monitor_at_surface(GdkDisplayHandle display, GdkSurfaceHandle surface);
	[DllImport(Libraries.Gdk4)]
	internal static extern GListModelHandle gdk_display_get_monitors(GdkDisplayHandle self);
	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_display_get_name(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkClipboardHandle gdk_display_get_primary_clipboard(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_display_get_setting(GdkDisplayHandle display, string name, GValueHandle value);
	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_display_get_startup_notification_id(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_display_is_closed(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_display_is_composited(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_display_is_rgba(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern GListHandle gdk_display_list_seats(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_display_map_keycode(GdkDisplayHandle display, uint keycode, out GdkKeymapKey[] keys, out uint[] keyvals, out int n_entries);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_display_map_keyval(GdkDisplayHandle display, uint keyval, out GdkKeymapKey[] keys, out int n_keys);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_display_notify_startup_complete(GdkDisplayHandle display, string startup_id);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_display_prepare_gl(GdkDisplayHandle self, out GErrorHandle error);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_display_put_event(GdkDisplayHandle display, GdkEventHandle @event);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_display_supports_input_shapes(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_display_supports_shadow_width(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_display_sync(GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_display_translate_key(GdkDisplayHandle display, uint keycode, GdkModifierType state, int group, out uint keyval, out int effective_group, out int level, out GdkModifierType consumed);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_display_get_default();
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_display_open(string display_name);
}
