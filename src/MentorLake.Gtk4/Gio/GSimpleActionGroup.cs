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

public class GSimpleActionGroupHandle : GObjectHandle
{
	public static GSimpleActionGroupHandle New()
	{
		return GSimpleActionGroupExterns.g_simple_action_group_new();
	}

}

public static class GSimpleActionGroupHandleExtensions
{
	public static GSimpleActionGroupHandle AddEntries(this GSimpleActionGroupHandle simple, GActionEntry[] entries, int n_entries, IntPtr user_data)
	{
		GSimpleActionGroupExterns.g_simple_action_group_add_entries(simple, entries, n_entries, user_data);
		return simple;
	}

	public static GSimpleActionGroupHandle Insert(this GSimpleActionGroupHandle simple, GActionHandle action)
	{
		GSimpleActionGroupExterns.g_simple_action_group_insert(simple, action);
		return simple;
	}

	public static GActionHandle Lookup(this GSimpleActionGroupHandle simple, string action_name)
	{
		return GSimpleActionGroupExterns.g_simple_action_group_lookup(simple, action_name);
	}

	public static GSimpleActionGroupHandle Remove(this GSimpleActionGroupHandle simple, string action_name)
	{
		GSimpleActionGroupExterns.g_simple_action_group_remove(simple, action_name);
		return simple;
	}

}

internal class GSimpleActionGroupExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GSimpleActionGroupHandle g_simple_action_group_new();
	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_group_add_entries(GSimpleActionGroupHandle simple, GActionEntry[] entries, int n_entries, IntPtr user_data);
	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_group_insert(GSimpleActionGroupHandle simple, GActionHandle action);
	[DllImport(Libraries.Gio)]
	internal static extern GActionHandle g_simple_action_group_lookup(GSimpleActionGroupHandle simple, string action_name);
	[DllImport(Libraries.Gio)]
	internal static extern void g_simple_action_group_remove(GSimpleActionGroupHandle simple, string action_name);
}
