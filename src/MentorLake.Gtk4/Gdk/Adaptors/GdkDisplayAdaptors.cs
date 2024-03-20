using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gdk;
public static class GdkDisplayAdaptors
{
    public static string GetName(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gdk_display_get_name(display);
    }

    public static int DeviceIsGrabbed(this GdkDisplayHandle display, GdkDeviceHandle device)
    {
        return GdkDisplayExterns.gdk_display_device_is_grabbed(display, device);
    }

    public static GdkDisplayHandle Beep(this GdkDisplayHandle display)
    {
        GdkDisplayExterns.gdk_display_beep(display);
        return display;
    }

    public static GdkDisplayHandle Sync(this GdkDisplayHandle display)
    {
        GdkDisplayExterns.gdk_display_sync(display);
        return display;
    }

    public static GdkDisplayHandle Flush(this GdkDisplayHandle display)
    {
        GdkDisplayExterns.gdk_display_flush(display);
        return display;
    }

    public static GdkDisplayHandle Close(this GdkDisplayHandle display)
    {
        GdkDisplayExterns.gdk_display_close(display);
        return display;
    }

    public static int IsClosed(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gdk_display_is_closed(display);
    }

    public static int IsComposited(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gdk_display_is_composited(display);
    }

    public static int IsRgba(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gdk_display_is_rgba(display);
    }

    public static int SupportsInputShapes(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gdk_display_supports_input_shapes(display);
    }

    public static int PrepareGl(this GdkDisplayHandle self, out GErrorHandle error)
    {
        return GdkDisplayExterns.gdk_display_prepare_gl(self, out error);
    }

    public static GdkGLContextHandle CreateGlContext(this GdkDisplayHandle self, out GErrorHandle error)
    {
        return GdkDisplayExterns.gdk_display_create_gl_context(self, out error);
    }

    public static GdkClipboardHandle GetClipboard(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gdk_display_get_clipboard(display);
    }

    public static GdkClipboardHandle GetPrimaryClipboard(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gdk_display_get_primary_clipboard(display);
    }

    public static GdkDisplayHandle NotifyStartupComplete(this GdkDisplayHandle display, string startup_id)
    {
        GdkDisplayExterns.gdk_display_notify_startup_complete(display, startup_id);
        return display;
    }

    public static string GetStartupNotificationId(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gdk_display_get_startup_notification_id(display);
    }

    public static GdkAppLaunchContextHandle GetAppLaunchContext(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gdk_display_get_app_launch_context(display);
    }

    public static GdkSeatHandle GetDefaultSeat(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gdk_display_get_default_seat(display);
    }

    public static GListHandle ListSeats(this GdkDisplayHandle display)
    {
        return GdkDisplayExterns.gdk_display_list_seats(display);
    }

    public static GListModelHandle GetMonitors(this GdkDisplayHandle self)
    {
        return GdkDisplayExterns.gdk_display_get_monitors(self);
    }

    public static GdkMonitorHandle GetMonitorAtSurface(this GdkDisplayHandle display, GdkSurfaceHandle surface)
    {
        return GdkDisplayExterns.gdk_display_get_monitor_at_surface(display, surface);
    }

    public static GdkDisplayHandle PutEvent(this GdkDisplayHandle display, GdkEventHandle @event)
    {
        GdkDisplayExterns.gdk_display_put_event(display, @event);
        return display;
    }

    public static int MapKeyval(this GdkDisplayHandle display, uint keyval, GdkKeymapKeyHandle[] keys, out int n_keys)
    {
        return GdkDisplayExterns.gdk_display_map_keyval(display, keyval, keys, out n_keys);
    }

    public static int MapKeycode(this GdkDisplayHandle display, uint keycode, GdkKeymapKeyHandle[] keys, out uint[] keyvals, out int n_entries)
    {
        return GdkDisplayExterns.gdk_display_map_keycode(display, keycode, keys, out keyvals, out n_entries);
    }

    public static int TranslateKey(this GdkDisplayHandle display, uint keycode, GdkModifierType state, int group, out uint keyval, out int effective_group, out int level, out GdkModifierType consumed)
    {
        return GdkDisplayExterns.gdk_display_translate_key(display, keycode, state, group, out keyval, out effective_group, out level, out consumed);
    }

    public static int GetSetting(this GdkDisplayHandle display, string name, GValueHandle value)
    {
        return GdkDisplayExterns.gdk_display_get_setting(display, name, value);
    }
}
