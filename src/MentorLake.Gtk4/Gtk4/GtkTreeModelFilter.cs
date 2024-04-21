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

public class GtkTreeModelFilterHandle : GObjectHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle
{
}

public static class GtkTreeModelFilterHandleExtensions
{
	public static GtkTreeModelFilterHandle ClearCache(this GtkTreeModelFilterHandle filter)
	{
		GtkTreeModelFilterExterns.gtk_tree_model_filter_clear_cache(filter);
		return filter;
	}

	public static bool ConvertChildIterToIter(this GtkTreeModelFilterHandle filter, out GtkTreeIter filter_iter, GtkTreeIterHandle child_iter)
	{
		return GtkTreeModelFilterExterns.gtk_tree_model_filter_convert_child_iter_to_iter(filter, out filter_iter, child_iter);
	}

	public static GtkTreePathHandle ConvertChildPathToPath(this GtkTreeModelFilterHandle filter, GtkTreePathHandle child_path)
	{
		return GtkTreeModelFilterExterns.gtk_tree_model_filter_convert_child_path_to_path(filter, child_path);
	}

	public static GtkTreeModelFilterHandle ConvertIterToChildIter(this GtkTreeModelFilterHandle filter, out GtkTreeIter child_iter, GtkTreeIterHandle filter_iter)
	{
		GtkTreeModelFilterExterns.gtk_tree_model_filter_convert_iter_to_child_iter(filter, out child_iter, filter_iter);
		return filter;
	}

	public static GtkTreePathHandle ConvertPathToChildPath(this GtkTreeModelFilterHandle filter, GtkTreePathHandle filter_path)
	{
		return GtkTreeModelFilterExterns.gtk_tree_model_filter_convert_path_to_child_path(filter, filter_path);
	}

	public static GtkTreeModelHandle GetModel(this GtkTreeModelFilterHandle filter)
	{
		return GtkTreeModelFilterExterns.gtk_tree_model_filter_get_model(filter);
	}

	public static GtkTreeModelFilterHandle Refilter(this GtkTreeModelFilterHandle filter)
	{
		GtkTreeModelFilterExterns.gtk_tree_model_filter_refilter(filter);
		return filter;
	}

	public static GtkTreeModelFilterHandle SetModifyFunc(this GtkTreeModelFilterHandle filter, int n_columns, GType[] types, GtkTreeModelFilterModifyFunc func, IntPtr data, GDestroyNotify destroy)
	{
		GtkTreeModelFilterExterns.gtk_tree_model_filter_set_modify_func(filter, n_columns, types, func, data, destroy);
		return filter;
	}

	public static GtkTreeModelFilterHandle SetVisibleColumn(this GtkTreeModelFilterHandle filter, int column)
	{
		GtkTreeModelFilterExterns.gtk_tree_model_filter_set_visible_column(filter, column);
		return filter;
	}

	public static GtkTreeModelFilterHandle SetVisibleFunc(this GtkTreeModelFilterHandle filter, GtkTreeModelFilterVisibleFunc func, IntPtr data, GDestroyNotify destroy)
	{
		GtkTreeModelFilterExterns.gtk_tree_model_filter_set_visible_func(filter, func, data, destroy);
		return filter;
	}

}

internal class GtkTreeModelFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_model_filter_clear_cache(GtkTreeModelFilterHandle filter);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_model_filter_convert_child_iter_to_iter(GtkTreeModelFilterHandle filter, out GtkTreeIter filter_iter, GtkTreeIterHandle child_iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_model_filter_convert_child_path_to_path(GtkTreeModelFilterHandle filter, GtkTreePathHandle child_path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_model_filter_convert_iter_to_child_iter(GtkTreeModelFilterHandle filter, out GtkTreeIter child_iter, GtkTreeIterHandle filter_iter);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_model_filter_convert_path_to_child_path(GtkTreeModelFilterHandle filter, GtkTreePathHandle filter_path);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeModelHandle gtk_tree_model_filter_get_model(GtkTreeModelFilterHandle filter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_model_filter_refilter(GtkTreeModelFilterHandle filter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_model_filter_set_modify_func(GtkTreeModelFilterHandle filter, int n_columns, GType[] types, GtkTreeModelFilterModifyFunc func, IntPtr data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_model_filter_set_visible_column(GtkTreeModelFilterHandle filter, int column);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_model_filter_set_visible_func(GtkTreeModelFilterHandle filter, GtkTreeModelFilterVisibleFunc func, IntPtr data, GDestroyNotify destroy);

}
