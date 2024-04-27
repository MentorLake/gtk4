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

namespace MentorLake.Gtk4.Gtk4;

public class GtkRecentManagerHandle : GObjectHandle
{
	public static GtkRecentManagerHandle New()
	{
		return GtkRecentManagerExterns.gtk_recent_manager_new();
	}

	public static GtkRecentManagerHandle GetDefault()
	{
		return GtkRecentManagerExterns.gtk_recent_manager_get_default();
	}

}

public static class GtkRecentManagerSignalExtensions
{
	public static GtkRecentManagerHandle Signal_Changed(this GtkRecentManagerHandle instance, GtkRecentManagerSignalDelegates.Changed handler)
	{
		GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);
		return instance;
	}
}

public static class GtkRecentManagerSignalDelegates
{

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void Changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRecentManagerHandle>))] GtkRecentManagerHandle self, IntPtr user_data);
}


public static class GtkRecentManagerHandleExtensions
{
	public static bool AddFull(this GtkRecentManagerHandle manager, string uri, GtkRecentDataHandle recent_data)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_add_full(manager, uri, recent_data);
	}

	public static bool AddItem(this GtkRecentManagerHandle manager, string uri)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_add_item(manager, uri);
	}

	public static GListHandle GetItems(this GtkRecentManagerHandle manager)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_get_items(manager);
	}

	public static bool HasItem(this GtkRecentManagerHandle manager, string uri)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_has_item(manager, uri);
	}

	public static GtkRecentInfoHandle LookupItem(this GtkRecentManagerHandle manager, string uri, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_lookup_item(manager, uri, out error);
	}

	public static bool MoveItem(this GtkRecentManagerHandle manager, string uri, string new_uri, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_move_item(manager, uri, new_uri, out error);
	}

	public static int PurgeItems(this GtkRecentManagerHandle manager, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_purge_items(manager, out error);
	}

	public static bool RemoveItem(this GtkRecentManagerHandle manager, string uri, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_remove_item(manager, uri, out error);
	}

}

internal class GtkRecentManagerExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkRecentManagerHandle gtk_recent_manager_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_manager_add_full(GtkRecentManagerHandle manager, string uri, GtkRecentDataHandle recent_data);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_manager_add_item(GtkRecentManagerHandle manager, string uri);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListHandle gtk_recent_manager_get_items(GtkRecentManagerHandle manager);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_manager_has_item(GtkRecentManagerHandle manager, string uri);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkRecentInfoHandle gtk_recent_manager_lookup_item(GtkRecentManagerHandle manager, string uri, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_manager_move_item(GtkRecentManagerHandle manager, string uri, string new_uri, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_recent_manager_purge_items(GtkRecentManagerHandle manager, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_recent_manager_remove_item(GtkRecentManagerHandle manager, string uri, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkRecentManagerHandle gtk_recent_manager_get_default();

}
