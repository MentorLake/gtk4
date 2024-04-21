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

public interface GtkTreeSortableHandle
{
}

public static class GtkTreeSortableHandleExtensions
{
	public static bool GetSortColumnId(this GtkTreeSortableHandle sortable, out int sort_column_id, out GtkSortType order)
	{
		return GtkTreeSortableExterns.gtk_tree_sortable_get_sort_column_id(sortable, out sort_column_id, out order);
	}

	public static bool HasDefaultSortFunc(this GtkTreeSortableHandle sortable)
	{
		return GtkTreeSortableExterns.gtk_tree_sortable_has_default_sort_func(sortable);
	}

	public static GtkTreeSortableHandle SetDefaultSortFunc(this GtkTreeSortableHandle sortable, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkTreeSortableExterns.gtk_tree_sortable_set_default_sort_func(sortable, sort_func, user_data, destroy);
		return sortable;
	}

	public static GtkTreeSortableHandle SetSortColumnId(this GtkTreeSortableHandle sortable, int sort_column_id, GtkSortType order)
	{
		GtkTreeSortableExterns.gtk_tree_sortable_set_sort_column_id(sortable, sort_column_id, order);
		return sortable;
	}

	public static GtkTreeSortableHandle SetSortFunc(this GtkTreeSortableHandle sortable, int sort_column_id, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy)
	{
		GtkTreeSortableExterns.gtk_tree_sortable_set_sort_func(sortable, sort_column_id, sort_func, user_data, destroy);
		return sortable;
	}

	public static GtkTreeSortableHandle SortColumnChanged(this GtkTreeSortableHandle sortable)
	{
		GtkTreeSortableExterns.gtk_tree_sortable_sort_column_changed(sortable);
		return sortable;
	}

}

internal class GtkTreeSortableExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_sortable_get_sort_column_id(GtkTreeSortableHandle sortable, out int sort_column_id, out GtkSortType order);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_sortable_has_default_sort_func(GtkTreeSortableHandle sortable);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_sortable_set_default_sort_func(GtkTreeSortableHandle sortable, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_sortable_set_sort_column_id(GtkTreeSortableHandle sortable, int sort_column_id, GtkSortType order);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_sortable_set_sort_func(GtkTreeSortableHandle sortable, int sort_column_id, GtkTreeIterCompareFunc sort_func, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_sortable_sort_column_changed(GtkTreeSortableHandle sortable);

}
