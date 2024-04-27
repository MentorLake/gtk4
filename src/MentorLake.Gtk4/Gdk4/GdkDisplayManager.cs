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

public static class GdkDisplayManagerSignalExtensions
{
	public static GdkDisplayManagerHandle Signal_DisplayOpened(this GdkDisplayManagerHandle instance, GdkDisplayManagerSignalDelegates.DisplayOpened handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "display_opened", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GdkDisplayManagerSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void DisplayOpened([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDisplayManagerHandle>))] GdkDisplayManagerHandle self, GdkDisplayHandle display, IntPtr user_data);
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
