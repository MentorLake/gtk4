using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;

public class cairo_device_tHandle : BaseSafeHandle { }
public struct cairo_device_t { }

public static class cairo_device_tAdaptors
{
	public static cairo_device_tHandle CairoDeviceReference(this cairo_device_tHandle deviceT)
	{
		return cairo_device_tExterns.cairo_device_reference(deviceT);
	}

	public static cairo_device_type_t CairoDeviceGetType(this cairo_device_tHandle deviceT)
	{
		return cairo_device_tExterns.cairo_device_get_type(deviceT);
	}

	public static cairo_status_t CairoDeviceStatus(this cairo_device_tHandle deviceT)
	{
		return cairo_device_tExterns.cairo_device_status(deviceT);
	}

	public static cairo_status_t CairoDeviceAcquire(this cairo_device_tHandle deviceT)
	{
		return cairo_device_tExterns.cairo_device_acquire(deviceT);
	}

	public static cairo_device_tHandle CairoDeviceRelease(this cairo_device_tHandle deviceT)
	{
		cairo_device_tExterns.cairo_device_release(deviceT);
		return deviceT;
	}

	public static cairo_device_tHandle CairoDeviceFlush(this cairo_device_tHandle deviceT)
	{
		cairo_device_tExterns.cairo_device_flush(deviceT);
		return deviceT;
	}

	public static cairo_device_tHandle CairoDeviceFinish(this cairo_device_tHandle deviceT)
	{
		cairo_device_tExterns.cairo_device_finish(deviceT);
		return deviceT;
	}

	public static cairo_device_tHandle CairoDeviceDestroy(this cairo_device_tHandle deviceT)
	{
		cairo_device_tExterns.cairo_device_destroy(deviceT);
		return deviceT;
	}

	public static uint CairoDeviceGetReferenceCount(this cairo_device_tHandle deviceT)
	{
		return cairo_device_tExterns.cairo_device_get_reference_count(deviceT);
	}

	public static IntPtr CairoDeviceGetUserData(this cairo_device_tHandle deviceT, cairo_user_data_key_tHandle keyT)
	{
		return cairo_device_tExterns.cairo_device_get_user_data(deviceT, keyT);
	}

	public static cairo_status_t CairoDeviceSetUserData(this cairo_device_tHandle deviceT, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy)
	{
		return cairo_device_tExterns.cairo_device_set_user_data(deviceT, keyT, user_data, destroy);
	}

	public static cairo_status_t CairoDeviceObserverPrint(this cairo_device_tHandle deviceT, cairo_write_func_t write_func, IntPtr closure)
	{
		return cairo_device_tExterns.cairo_device_observer_print(deviceT, write_func, closure);
	}

	public static double CairoDeviceObserverElapsed(this cairo_device_tHandle deviceT)
	{
		return cairo_device_tExterns.cairo_device_observer_elapsed(deviceT);
	}

	public static double CairoDeviceObserverPaintElapsed(this cairo_device_tHandle deviceT)
	{
		return cairo_device_tExterns.cairo_device_observer_paint_elapsed(deviceT);
	}

	public static double CairoDeviceObserverMaskElapsed(this cairo_device_tHandle deviceT)
	{
		return cairo_device_tExterns.cairo_device_observer_mask_elapsed(deviceT);
	}

	public static double CairoDeviceObserverFillElapsed(this cairo_device_tHandle deviceT)
	{
		return cairo_device_tExterns.cairo_device_observer_fill_elapsed(deviceT);
	}

	public static double CairoDeviceObserverStrokeElapsed(this cairo_device_tHandle deviceT)
	{
		return cairo_device_tExterns.cairo_device_observer_stroke_elapsed(deviceT);
	}

	public static double CairoDeviceObserverGlyphsElapsed(this cairo_device_tHandle deviceT)
	{
		return cairo_device_tExterns.cairo_device_observer_glyphs_elapsed(deviceT);
	}
}

public static class cairo_device_tExterns
{
	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_reference")]
	internal static extern cairo_device_tHandle cairo_device_reference(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_get_type")]
	internal static extern cairo_device_type_t cairo_device_get_type(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_status")]
	internal static extern cairo_status_t cairo_device_status(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_acquire")]
	internal static extern cairo_status_t cairo_device_acquire(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_release")]
	internal static extern void cairo_device_release(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_flush")]
	internal static extern void cairo_device_flush(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_finish")]
	internal static extern void cairo_device_finish(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_destroy")]
	internal static extern void cairo_device_destroy(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_get_reference_count")]
	internal static extern uint cairo_device_get_reference_count(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_get_user_data")]
	internal static extern IntPtr cairo_device_get_user_data(this cairo_device_tHandle deviceT, cairo_user_data_key_tHandle keyT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_set_user_data")]
	internal static extern cairo_status_t cairo_device_set_user_data(this cairo_device_tHandle deviceT, cairo_user_data_key_tHandle keyT, IntPtr user_data, cairo_destroy_func_t destroy);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_print")]
	internal static extern cairo_status_t cairo_device_observer_print(this cairo_device_tHandle deviceT, cairo_write_func_t write_func, IntPtr closure);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_elapsed")]
	internal static extern double cairo_device_observer_elapsed(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_paint_elapsed")]
	internal static extern double cairo_device_observer_paint_elapsed(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_mask_elapsed")]
	internal static extern double cairo_device_observer_mask_elapsed(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_fill_elapsed")]
	internal static extern double cairo_device_observer_fill_elapsed(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_stroke_elapsed")]
	internal static extern double cairo_device_observer_stroke_elapsed(this cairo_device_tHandle deviceT);

	[DllImport(Libraries.Cairo, EntryPoint = "cairo_device_observer_glyphs_elapsed")]
	internal static extern double cairo_device_observer_glyphs_elapsed(this cairo_device_tHandle deviceT);
}
