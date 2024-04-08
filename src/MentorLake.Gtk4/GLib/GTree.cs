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

namespace MentorLake.Gtk4.GLib;

public class GTreeHandle : BaseSafeHandle
{
	public static GTreeHandle New(GCompareFunc key_compare_func)
	{
		return GTreeExterns.g_tree_new(key_compare_func);
	}

	public static GTreeHandle NewFull(GCompareDataFunc key_compare_func, IntPtr key_compare_data, GDestroyNotify key_destroy_func, GDestroyNotify value_destroy_func)
	{
		return GTreeExterns.g_tree_new_full(key_compare_func, key_compare_data, key_destroy_func, value_destroy_func);
	}

	public static GTreeHandle NewWithData(GCompareDataFunc key_compare_func, IntPtr key_compare_data)
	{
		return GTreeExterns.g_tree_new_with_data(key_compare_func, key_compare_data);
	}

}

internal class GTreeExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GTreeHandle g_tree_new(GCompareFunc key_compare_func);
	[DllImport(Libraries.GLib)]
	internal static extern GTreeHandle g_tree_new_full(GCompareDataFunc key_compare_func, IntPtr key_compare_data, GDestroyNotify key_destroy_func, GDestroyNotify value_destroy_func);
	[DllImport(Libraries.GLib)]
	internal static extern GTreeHandle g_tree_new_with_data(GCompareDataFunc key_compare_func, IntPtr key_compare_data);
}

public struct GTree
{
}
