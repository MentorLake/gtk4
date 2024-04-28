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

namespace MentorLake.Gtk4.Gio;

public interface GActionMapHandle
{
}

internal class GActionMapHandleImpl : BaseSafeHandle, GActionMapHandle
{
}

public static class GActionMapHandleExtensions
{
	public static GActionMapHandle AddAction(this GActionMapHandle action_map, GActionHandle action)
	{
		GActionMapExterns.g_action_map_add_action(action_map, action);
		return action_map;
	}

	public static GActionMapHandle AddActionEntries(this GActionMapHandle action_map, GActionEntry[] entries, int n_entries, IntPtr user_data)
	{
		GActionMapExterns.g_action_map_add_action_entries(action_map, entries, n_entries, user_data);
		return action_map;
	}

	public static GActionHandle LookupAction(this GActionMapHandle action_map, string action_name)
	{
		return GActionMapExterns.g_action_map_lookup_action(action_map, action_name);
	}

	public static GActionMapHandle RemoveAction(this GActionMapHandle action_map, string action_name)
	{
		GActionMapExterns.g_action_map_remove_action(action_map, action_name);
		return action_map;
	}

	public static GActionMapHandle RemoveActionEntries(this GActionMapHandle action_map, GActionEntry[] entries, int n_entries)
	{
		GActionMapExterns.g_action_map_remove_action_entries(action_map, entries, n_entries);
		return action_map;
	}

}

internal class GActionMapExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_action_map_add_action(GActionMapHandle action_map, GActionHandle action);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_map_add_action_entries(GActionMapHandle action_map, GActionEntry[] entries, int n_entries, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern GActionHandle g_action_map_lookup_action(GActionMapHandle action_map, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_map_remove_action(GActionMapHandle action_map, string action_name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_action_map_remove_action_entries(GActionMapHandle action_map, GActionEntry[] entries, int n_entries);

}
