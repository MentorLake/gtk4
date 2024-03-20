using System.Runtime.InteropServices;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gdk;

public static class GdkDeviceExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_name")]
	internal static extern string gdk_device_get_name(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_vendor_id")]
	internal static extern string gdk_device_get_vendor_id(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_product_id")]
	internal static extern string gdk_device_get_product_id(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_display")]
	internal static extern GdkDisplayHandle gdk_device_get_display(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_seat")]
	internal static extern GdkSeatHandle gdk_device_get_seat(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_device_tool")]
	internal static extern GdkDeviceToolHandle gdk_device_get_device_tool(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_source")]
	internal static extern GdkInputSource gdk_device_get_source(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_has_cursor")]
	internal static extern int gdk_device_get_has_cursor(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_num_touches")]
	internal static extern uint gdk_device_get_num_touches(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_modifier_state")]
	internal static extern GdkModifierType gdk_device_get_modifier_state(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_direction")]
	internal static extern PangoDirection gdk_device_get_direction(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_has_bidi_layouts")]
	internal static extern int gdk_device_has_bidi_layouts(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_caps_lock_state")]
	internal static extern int gdk_device_get_caps_lock_state(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_num_lock_state")]
	internal static extern int gdk_device_get_num_lock_state(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_scroll_lock_state")]
	internal static extern int gdk_device_get_scroll_lock_state(this GdkDeviceHandle device);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_surface_at_position")]
	internal static extern GdkSurfaceHandle gdk_device_get_surface_at_position(this GdkDeviceHandle device, out double win_x, out double win_y);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_device_get_timestamp")]
	internal static extern uint gdk_device_get_timestamp(this GdkDeviceHandle device);
}
