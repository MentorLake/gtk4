using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;
public static class GdkSeatAdaptors
{
    public static GdkDisplayHandle GetDisplay(this GdkSeatHandle seat)
    {
        return GdkSeatExterns.gdk_seat_get_display(seat);
    }

    public static GdkSeatCapabilities GetCapabilities(this GdkSeatHandle seat)
    {
        return GdkSeatExterns.gdk_seat_get_capabilities(seat);
    }

    public static GListHandle GetDevices(this GdkSeatHandle seat, GdkSeatCapabilities capabilities)
    {
        return GdkSeatExterns.gdk_seat_get_devices(seat, capabilities);
    }

    public static GListHandle GetTools(this GdkSeatHandle seat)
    {
        return GdkSeatExterns.gdk_seat_get_tools(seat);
    }

    public static GdkDeviceHandle GetPointer(this GdkSeatHandle seat)
    {
        return GdkSeatExterns.gdk_seat_get_pointer(seat);
    }

    public static GdkDeviceHandle GetKeyboard(this GdkSeatHandle seat)
    {
        return GdkSeatExterns.gdk_seat_get_keyboard(seat);
    }
}
