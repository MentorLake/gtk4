using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gdk;

public static class GdkMonitorExterns
{
	[DllImport(Libraries.Gdk, EntryPoint = "gdk_monitor_get_display")]
	internal static extern GdkDisplayHandle gdk_monitor_get_display(this GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_monitor_get_geometry")]
	internal static extern void gdk_monitor_get_geometry(this GdkMonitorHandle monitor, GdkRectangleHandle geometry);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_monitor_get_width_mm")]
	internal static extern int gdk_monitor_get_width_mm(this GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_monitor_get_height_mm")]
	internal static extern int gdk_monitor_get_height_mm(this GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_monitor_get_manufacturer")]
	internal static extern string gdk_monitor_get_manufacturer(this GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_monitor_get_model")]
	internal static extern string gdk_monitor_get_model(this GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_monitor_get_connector")]
	internal static extern string gdk_monitor_get_connector(this GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_monitor_get_scale_factor")]
	internal static extern int gdk_monitor_get_scale_factor(this GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_monitor_get_refresh_rate")]
	internal static extern int gdk_monitor_get_refresh_rate(this GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_monitor_get_subpixel_layout")]
	internal static extern GdkSubpixelLayout gdk_monitor_get_subpixel_layout(this GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk, EntryPoint = "gdk_monitor_is_valid")]
	internal static extern int gdk_monitor_is_valid(this GdkMonitorHandle monitor);
}
