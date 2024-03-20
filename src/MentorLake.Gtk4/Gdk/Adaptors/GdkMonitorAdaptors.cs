using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;
public static class GdkMonitorAdaptors
{
    public static GdkDisplayHandle GetDisplay(this GdkMonitorHandle monitor)
    {
        return GdkMonitorExterns.gdk_monitor_get_display(monitor);
    }

    public static GdkMonitorHandle GetGeometry(this GdkMonitorHandle monitor, GdkRectangleHandle geometry)
    {
        GdkMonitorExterns.gdk_monitor_get_geometry(monitor, geometry);
        return monitor;
    }

    public static int GetWidthMm(this GdkMonitorHandle monitor)
    {
        return GdkMonitorExterns.gdk_monitor_get_width_mm(monitor);
    }

    public static int GetHeightMm(this GdkMonitorHandle monitor)
    {
        return GdkMonitorExterns.gdk_monitor_get_height_mm(monitor);
    }

    public static string GetManufacturer(this GdkMonitorHandle monitor)
    {
        return GdkMonitorExterns.gdk_monitor_get_manufacturer(monitor);
    }

    public static string GetModel(this GdkMonitorHandle monitor)
    {
        return GdkMonitorExterns.gdk_monitor_get_model(monitor);
    }

    public static string GetConnector(this GdkMonitorHandle monitor)
    {
        return GdkMonitorExterns.gdk_monitor_get_connector(monitor);
    }

    public static int GetScaleFactor(this GdkMonitorHandle monitor)
    {
        return GdkMonitorExterns.gdk_monitor_get_scale_factor(monitor);
    }

    public static int GetRefreshRate(this GdkMonitorHandle monitor)
    {
        return GdkMonitorExterns.gdk_monitor_get_refresh_rate(monitor);
    }

    public static GdkSubpixelLayout GetSubpixelLayout(this GdkMonitorHandle monitor)
    {
        return GdkMonitorExterns.gdk_monitor_get_subpixel_layout(monitor);
    }

    public static int IsValid(this GdkMonitorHandle monitor)
    {
        return GdkMonitorExterns.gdk_monitor_is_valid(monitor);
    }
}
