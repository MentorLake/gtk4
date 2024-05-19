using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gio;

public interface GPowerProfileMonitorHandle
{
}

internal class GPowerProfileMonitorHandleImpl : BaseSafeHandle, GPowerProfileMonitorHandle
{
}

public static class GPowerProfileMonitorHandleExtensions
{
	public static bool GetPowerSaverEnabled(this GPowerProfileMonitorHandle monitor)
	{
		return GPowerProfileMonitorExterns.g_power_profile_monitor_get_power_saver_enabled(monitor);
	}

}

internal class GPowerProfileMonitorExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_power_profile_monitor_get_power_saver_enabled(GPowerProfileMonitorHandle monitor);

}
