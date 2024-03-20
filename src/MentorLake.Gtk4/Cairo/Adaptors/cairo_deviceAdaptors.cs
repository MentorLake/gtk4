using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Cairo;
public static class cairo_deviceAdaptors
{
    public static cairo_deviceHandle CairoDeviceReference(this cairo_deviceHandle device)
    {
        return cairo_deviceExterns.cairo_device_reference(device);
    }

    public static _cairo_device_type CairoDeviceGetType(this cairo_deviceHandle device)
    {
        return cairo_deviceExterns.cairo_device_get_type(device);
    }

    public static _cairo_status CairoDeviceStatus(this cairo_deviceHandle device)
    {
        return cairo_deviceExterns.cairo_device_status(device);
    }

    public static _cairo_status CairoDeviceAcquire(this cairo_deviceHandle device)
    {
        return cairo_deviceExterns.cairo_device_acquire(device);
    }

    public static cairo_deviceHandle CairoDeviceRelease(this cairo_deviceHandle device)
    {
        cairo_deviceExterns.cairo_device_release(device);
        return device;
    }

    public static cairo_deviceHandle CairoDeviceFlush(this cairo_deviceHandle device)
    {
        cairo_deviceExterns.cairo_device_flush(device);
        return device;
    }

    public static cairo_deviceHandle CairoDeviceFinish(this cairo_deviceHandle device)
    {
        cairo_deviceExterns.cairo_device_finish(device);
        return device;
    }

    public static cairo_deviceHandle CairoDeviceDestroy(this cairo_deviceHandle device)
    {
        cairo_deviceExterns.cairo_device_destroy(device);
        return device;
    }

    public static uint CairoDeviceGetReferenceCount(this cairo_deviceHandle device)
    {
        return cairo_deviceExterns.cairo_device_get_reference_count(device);
    }

    public static IntPtr CairoDeviceGetUserData(this cairo_deviceHandle device, cairo_user_data_keyHandle key)
    {
        return cairo_deviceExterns.cairo_device_get_user_data(device, key);
    }

    public static _cairo_status CairoDeviceSetUserData(this cairo_deviceHandle device, cairo_user_data_keyHandle key, IntPtr user_data, cairo_destroy_func_t destroy)
    {
        return cairo_deviceExterns.cairo_device_set_user_data(device, key, user_data, destroy);
    }

    public static _cairo_status CairoDeviceObserverPrint(this cairo_deviceHandle device, cairo_write_func_t write_func, IntPtr closure)
    {
        return cairo_deviceExterns.cairo_device_observer_print(device, write_func, closure);
    }

    public static double CairoDeviceObserverElapsed(this cairo_deviceHandle device)
    {
        return cairo_deviceExterns.cairo_device_observer_elapsed(device);
    }

    public static double CairoDeviceObserverPaintElapsed(this cairo_deviceHandle device)
    {
        return cairo_deviceExterns.cairo_device_observer_paint_elapsed(device);
    }

    public static double CairoDeviceObserverMaskElapsed(this cairo_deviceHandle device)
    {
        return cairo_deviceExterns.cairo_device_observer_mask_elapsed(device);
    }

    public static double CairoDeviceObserverFillElapsed(this cairo_deviceHandle device)
    {
        return cairo_deviceExterns.cairo_device_observer_fill_elapsed(device);
    }

    public static double CairoDeviceObserverStrokeElapsed(this cairo_deviceHandle device)
    {
        return cairo_deviceExterns.cairo_device_observer_stroke_elapsed(device);
    }

    public static double CairoDeviceObserverGlyphsElapsed(this cairo_deviceHandle device)
    {
        return cairo_deviceExterns.cairo_device_observer_glyphs_elapsed(device);
    }
}
