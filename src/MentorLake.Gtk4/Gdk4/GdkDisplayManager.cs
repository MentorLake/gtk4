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

public class GdkDisplayManagerHandle : GObjectHandle
{
	public static GdkDisplayManagerHandle Get()
	{
		return GdkDisplayManagerExterns.gdk_display_manager_get();
	}

}

public class GdkDisplayManagerSignal
{
	public string Value { get; set; }
	public GdkDisplayManagerSignal(string value) => Value = value;
}

public static class GdkDisplayManagerSignals
{
	public static GdkDisplayManagerSignal DisplayOpened = new("display-opened");
}

public static class GdkDisplayManagerHandleExtensions
{
	public static GdkDisplayHandle GetDefaultDisplay(this GdkDisplayManagerHandle manager)
	{
		return GdkDisplayManagerExterns.gdk_display_manager_get_default_display(manager);
	}

	public static GSListHandle ListDisplays(this GdkDisplayManagerHandle manager)
	{
		return GdkDisplayManagerExterns.gdk_display_manager_list_displays(manager);
	}

	public static GdkDisplayHandle OpenDisplay(this GdkDisplayManagerHandle manager, string name)
	{
		return GdkDisplayManagerExterns.gdk_display_manager_open_display(manager, name);
	}

	public static GdkDisplayManagerHandle SetDefaultDisplay(this GdkDisplayManagerHandle manager, GdkDisplayHandle display)
	{
		GdkDisplayManagerExterns.gdk_display_manager_set_default_display(manager, display);
		return manager;
	}

	public static GdkDisplayManagerHandle Connect(this GdkDisplayManagerHandle instance, GdkDisplayManagerSignal signal, GCallback c_handler)
	{
		GObjectExterns.g_signal_connect_data(instance, signal.Value, c_handler, IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

internal class GdkDisplayManagerExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_display_manager_get_default_display(GdkDisplayManagerHandle manager);
	[DllImport(Libraries.Gdk4)]
	internal static extern GSListHandle gdk_display_manager_list_displays(GdkDisplayManagerHandle manager);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayHandle gdk_display_manager_open_display(GdkDisplayManagerHandle manager, string name);
	[DllImport(Libraries.Gdk4)]
	internal static extern void gdk_display_manager_set_default_display(GdkDisplayManagerHandle manager, GdkDisplayHandle display);
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkDisplayManagerHandle gdk_display_manager_get();
}
