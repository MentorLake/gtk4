using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public static class cairo_deviceExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_reference")]
	internal static extern cairo_deviceHandle cairo_device_reference(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_get_type")]
	internal static extern _cairo_device_type cairo_device_get_type(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_status")]
	internal static extern _cairo_status cairo_device_status(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_acquire")]
	internal static extern _cairo_status cairo_device_acquire(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_release")]
	internal static extern void cairo_device_release(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_flush")]
	internal static extern void cairo_device_flush(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_finish")]
	internal static extern void cairo_device_finish(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_destroy")]
	internal static extern void cairo_device_destroy(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_get_reference_count")]
	internal static extern uint cairo_device_get_reference_count(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_get_user_data")]
	internal static extern IntPtr cairo_device_get_user_data(this cairo_deviceHandle device, cairo_user_data_keyHandle key);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_set_user_data")]
	internal static extern _cairo_status cairo_device_set_user_data(this cairo_deviceHandle device, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_print")]
	internal static extern _cairo_status cairo_device_observer_print(this cairo_deviceHandle device, cairo_write_func_t write_func, IntPtr closure);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_elapsed")]
	internal static extern double cairo_device_observer_elapsed(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_paint_elapsed")]
	internal static extern double cairo_device_observer_paint_elapsed(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_mask_elapsed")]
	internal static extern double cairo_device_observer_mask_elapsed(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_fill_elapsed")]
	internal static extern double cairo_device_observer_fill_elapsed(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_stroke_elapsed")]
	internal static extern double cairo_device_observer_stroke_elapsed(this cairo_deviceHandle device);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_glyphs_elapsed")]
	internal static extern double cairo_device_observer_glyphs_elapsed(this cairo_deviceHandle device);
}
