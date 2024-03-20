using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkRecentManagerAdaptors
{
	public static int AddItem(this GtkRecentManagerHandle manager, string uri)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_add_item(manager, uri);
	}

	public static int AddFull(this GtkRecentManagerHandle manager, string uri, GtkRecentDataHandle recent_data)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_add_full(manager, uri, recent_data);
	}

	public static int RemoveItem(this GtkRecentManagerHandle manager, string uri, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_remove_item(manager, uri, out error);
	}

	public static GtkRecentInfoHandle LookupItem(this GtkRecentManagerHandle manager, string uri, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_lookup_item(manager, uri, out error);
	}

	public static int HasItem(this GtkRecentManagerHandle manager, string uri)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_has_item(manager, uri);
	}

	public static int MoveItem(this GtkRecentManagerHandle manager, string uri, string new_uri, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_move_item(manager, uri, new_uri, out error);
	}

	public static GListHandle GetItems(this GtkRecentManagerHandle manager)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_get_items(manager);
	}

	public static int PurgeItems(this GtkRecentManagerHandle manager, out GErrorHandle error)
	{
		return GtkRecentManagerExterns.gtk_recent_manager_purge_items(manager, out error);
	}
}
