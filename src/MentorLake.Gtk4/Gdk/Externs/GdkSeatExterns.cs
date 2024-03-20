using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gdk;

public static class GdkSeatExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_seat_get_display")]
	internal static extern GdkDisplayHandle gdk_seat_get_display(this GdkSeatHandle seat);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_seat_get_capabilities")]
	internal static extern GdkSeatCapabilities gdk_seat_get_capabilities(this GdkSeatHandle seat);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_seat_get_devices")]
	internal static extern GListHandle gdk_seat_get_devices(this GdkSeatHandle seat, GdkSeatCapabilities capabilities);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_seat_get_tools")]
	internal static extern GListHandle gdk_seat_get_tools(this GdkSeatHandle seat);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_seat_get_pointer")]
	internal static extern GdkDeviceHandle gdk_seat_get_pointer(this GdkSeatHandle seat);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_seat_get_keyboard")]
	internal static extern GdkDeviceHandle gdk_seat_get_keyboard(this GdkSeatHandle seat);
}
