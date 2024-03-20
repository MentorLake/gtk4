using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreePathAdaptors
{
	public static string ToString(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_to_string(path);
	}

	public static GtkTreePathHandle AppendIndex(this GtkTreePathHandle path, int index_)
	{
		GtkTreePathExterns.gtk_tree_path_append_index(path, index_);
		return path;
	}

	public static GtkTreePathHandle PrependIndex(this GtkTreePathHandle path, int index_)
	{
		GtkTreePathExterns.gtk_tree_path_prepend_index(path, index_);
		return path;
	}

	public static int GetDepth(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_get_depth(path);
	}

	public static int[] GetIndices(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_get_indices(path);
	}

	public static int[] GetIndicesWithDepth(this GtkTreePathHandle path, out int depth)
	{
		return GtkTreePathExterns.gtk_tree_path_get_indices_with_depth(path, out depth);
	}

	public static GtkTreePathHandle Free(this GtkTreePathHandle path)
	{
		GtkTreePathExterns.gtk_tree_path_free(path);
		return path;
	}

	public static GtkTreePathHandle Copy(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_copy(path);
	}

	public static int Compare(this GtkTreePathHandle a, GtkTreePathHandle b)
	{
		return GtkTreePathExterns.gtk_tree_path_compare(a, b);
	}

	public static GtkTreePathHandle Next(this GtkTreePathHandle path)
	{
		GtkTreePathExterns.gtk_tree_path_next(path);
		return path;
	}

	public static int Prev(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_prev(path);
	}

	public static int Up(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_up(path);
	}

	public static GtkTreePathHandle Down(this GtkTreePathHandle path)
	{
		GtkTreePathExterns.gtk_tree_path_down(path);
		return path;
	}

	public static int IsAncestor(this GtkTreePathHandle path, GtkTreePathHandle descendant)
	{
		return GtkTreePathExterns.gtk_tree_path_is_ancestor(path, descendant);
	}

	public static int IsDescendant(this GtkTreePathHandle path, GtkTreePathHandle ancestor)
	{
		return GtkTreePathExterns.gtk_tree_path_is_descendant(path, ancestor);
	}

	public static GtkTreePathHandle NewFromString(string path)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_string(path);
	}

	public static GtkTreePathHandle NewFromIndices(int first_index, IntPtr @__arglist)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_indices(first_index, @__arglist);
	}

	public static GtkTreePathHandle NewFromIndicesv(int[] indices, nuint length)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_indicesv(indices, length);
	}

	public static GtkTreePathHandle NewFirst()
	{
		return GtkTreePathExterns.gtk_tree_path_new_first();
	}
}
