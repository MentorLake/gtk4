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

public class GtkTreeModelSortHandle : GObjectHandle, GtkTreeDragSourceHandle, GtkTreeModelHandle, GtkTreeSortableHandle
{
	public static GtkTreeModelSortHandle NewWithModel(GtkTreeModelHandle child_model)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_new_with_model(child_model);
	}

}

public static class GtkTreeModelSortHandleExtensions
{
	public static GtkTreeModelSortHandle ClearCache(this GtkTreeModelSortHandle tree_model_sort)
	{
		GtkTreeModelSortExterns.gtk_tree_model_sort_clear_cache(tree_model_sort);
		return tree_model_sort;
	}

	public static bool ConvertChildIterToIter(this GtkTreeModelSortHandle tree_model_sort, out GtkTreeIter sort_iter, GtkTreeIterHandle child_iter)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_convert_child_iter_to_iter(tree_model_sort, out sort_iter, child_iter);
	}

	public static GtkTreePathHandle ConvertChildPathToPath(this GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle child_path)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_convert_child_path_to_path(tree_model_sort, child_path);
	}

	public static GtkTreeModelSortHandle ConvertIterToChildIter(this GtkTreeModelSortHandle tree_model_sort, out GtkTreeIter child_iter, GtkTreeIterHandle sorted_iter)
	{
		GtkTreeModelSortExterns.gtk_tree_model_sort_convert_iter_to_child_iter(tree_model_sort, out child_iter, sorted_iter);
		return tree_model_sort;
	}

	public static GtkTreePathHandle ConvertPathToChildPath(this GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle sorted_path)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_convert_path_to_child_path(tree_model_sort, sorted_path);
	}

	public static GtkTreeModelHandle GetModel(this GtkTreeModelSortHandle tree_model)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_get_model(tree_model);
	}

	public static bool IterIsValid(this GtkTreeModelSortHandle tree_model_sort, GtkTreeIterHandle iter)
	{
		return GtkTreeModelSortExterns.gtk_tree_model_sort_iter_is_valid(tree_model_sort, iter);
	}

	public static GtkTreeModelSortHandle ResetDefaultSortFunc(this GtkTreeModelSortHandle tree_model_sort)
	{
		GtkTreeModelSortExterns.gtk_tree_model_sort_reset_default_sort_func(tree_model_sort);
		return tree_model_sort;
	}

}

internal class GtkTreeModelSortExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeModelSortHandle gtk_tree_model_sort_new_with_model(GtkTreeModelHandle child_model);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_model_sort_clear_cache(GtkTreeModelSortHandle tree_model_sort);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_model_sort_convert_child_iter_to_iter(GtkTreeModelSortHandle tree_model_sort, out GtkTreeIter sort_iter, GtkTreeIterHandle child_iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_model_sort_convert_child_path_to_path(GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle child_path);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_model_sort_convert_iter_to_child_iter(GtkTreeModelSortHandle tree_model_sort, out GtkTreeIter child_iter, GtkTreeIterHandle sorted_iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_model_sort_convert_path_to_child_path(GtkTreeModelSortHandle tree_model_sort, GtkTreePathHandle sorted_path);
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeModelHandle gtk_tree_model_sort_get_model(GtkTreeModelSortHandle tree_model);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_model_sort_iter_is_valid(GtkTreeModelSortHandle tree_model_sort, GtkTreeIterHandle iter);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_model_sort_reset_default_sort_func(GtkTreeModelSortHandle tree_model_sort);
}
