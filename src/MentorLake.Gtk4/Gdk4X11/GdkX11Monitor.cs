namespace MentorLake.Gtk4.Gdk4X11;

public class GdkX11MonitorHandle : GdkMonitorHandle
{
}

public static class GdkX11MonitorHandleExtensions
{
	public static ulong GetOutput(this GdkX11MonitorHandle monitor)
	{
		return GdkX11MonitorExterns.gdk_x11_monitor_get_output(monitor);
	}

	public static GdkX11MonitorHandle GetWorkarea(this GdkX11MonitorHandle monitor, out GdkRectangle workarea)
	{
		GdkX11MonitorExterns.gdk_x11_monitor_get_workarea(monitor, out workarea);
		return monitor;
	}

}

internal class GdkX11MonitorExterns
{
	[DllImport(Libraries.Gdk4X11)]
	internal static extern ulong gdk_x11_monitor_get_output(GdkMonitorHandle monitor);

	[DllImport(Libraries.Gdk4X11)]
	internal static extern void gdk_x11_monitor_get_workarea(GdkMonitorHandle monitor, out GdkRectangle workarea);

}
