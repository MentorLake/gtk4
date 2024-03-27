using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gdk4;

public class GdkMonitorHandle : GObjectHandle
{
}

public class GdkMonitorSignal
{
	public string Value { get; set; }
	public GdkMonitorSignal(string value) => Value = value;
}

public static class GdkMonitorSignals
{
	public static GdkMonitorSignal Invalidate = new("invalidate");
}

public static class GdkMonitorHandleExtensions
{
	public static string GetConnector(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_connector(monitor);
	}

	public static string GetDescription(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_description(monitor);
	}

	public static GdkDisplayHandle GetDisplay(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_display(monitor);
	}

	public static GdkMonitorHandle GetGeometry(this GdkMonitorHandle monitor, out GdkRectangle geometry)
	{
		GdkMonitorExterns.gdk_monitor_get_geometry(monitor, out geometry);
		return monitor;
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

	public static int GetRefreshRate(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_refresh_rate(monitor);
	}

	public static double GetScale(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_scale(monitor);
	}

	public static int GetScaleFactor(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_scale_factor(monitor);
	}

	public static GdkSubpixelLayout GetSubpixelLayout(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_subpixel_layout(monitor);
	}

	public static int GetWidthMm(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_get_width_mm(monitor);
	}

	public static bool IsValid(this GdkMonitorHandle monitor)
	{
		return GdkMonitorExterns.gdk_monitor_is_valid(monitor);
	}

	public static GdkMonitorHandle Connect(this GdkMonitorHandle instance, GdkMonitorSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GdkMonitorExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_monitor_get_connector(GdkMonitorHandle monitor);
	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_monitor_get_description(GdkMonitorHandle monitor);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_monitor_get_display(GdkMonitorHandle monitor);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_monitor_get_geometry(GdkMonitorHandle monitor, out GdkRectangle geometry);
	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_monitor_get_height_mm(GdkMonitorHandle monitor);
	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_monitor_get_manufacturer(GdkMonitorHandle monitor);
	[DllImport(Libraries.Gdk4)]
	internal static extern string gdk_monitor_get_model(GdkMonitorHandle monitor);
	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_monitor_get_refresh_rate(GdkMonitorHandle monitor);
	[DllImport(Libraries.Gdk4)]
	internal static extern double gdk_monitor_get_scale(GdkMonitorHandle monitor);
	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_monitor_get_scale_factor(GdkMonitorHandle monitor);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkSubpixelLayout gdk_monitor_get_subpixel_layout(GdkMonitorHandle monitor);
	[DllImport(Libraries.Gdk4)]
	internal static extern int gdk_monitor_get_width_mm(GdkMonitorHandle monitor);
	[DllImport(Libraries.Gdk4)]
	internal static extern bool gdk_monitor_is_valid(GdkMonitorHandle monitor);
}
