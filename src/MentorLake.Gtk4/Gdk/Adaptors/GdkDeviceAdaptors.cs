using System.Runtime.InteropServices;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gdk;
public static class GdkDeviceAdaptors
{
    public static string GetName(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_name(device);
    }

    public static string GetVendorId(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_vendor_id(device);
    }

    public static string GetProductId(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_product_id(device);
    }

    public static GdkDisplayHandle GetDisplay(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_display(device);
    }

    public static GdkSeatHandle GetSeat(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_seat(device);
    }

    public static GdkDeviceToolHandle GetDeviceTool(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_device_tool(device);
    }

    public static GdkInputSource GetSource(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_source(device);
    }

    public static int GetHasCursor(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_has_cursor(device);
    }

    public static uint GetNumTouches(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_num_touches(device);
    }

    public static GdkModifierType GetModifierState(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_modifier_state(device);
    }

    public static PangoDirection GetDirection(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_direction(device);
    }

    public static int HasBidiLayouts(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_has_bidi_layouts(device);
    }

    public static int GetCapsLockState(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_caps_lock_state(device);
    }

    public static int GetNumLockState(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_num_lock_state(device);
    }

    public static int GetScrollLockState(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_scroll_lock_state(device);
    }

    public static GdkSurfaceHandle GetSurfaceAtPosition(this GdkDeviceHandle device, out double win_x, out double win_y)
    {
        return GdkDeviceExterns.gdk_device_get_surface_at_position(device, out win_x, out win_y);
    }

    public static uint GetTimestamp(this GdkDeviceHandle device)
    {
        return GdkDeviceExterns.gdk_device_get_timestamp(device);
    }
}
