namespace MentorLake.Gtk4.Gtk4;

public class GtkTreePathHandle : BaseSafeHandle
{
	public static GtkTreePathHandle New()
	{
		return GtkTreePathExterns.gtk_tree_path_new();
	}

	public static GtkTreePathHandle NewFirst()
	{
		return GtkTreePathExterns.gtk_tree_path_new_first();
	}

	public static GtkTreePathHandle NewFromIndices(int first_index, IntPtr @__arglist)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_indices(first_index, @__arglist);
	}

	public static GtkTreePathHandle NewFromIndicesv(int[] indices, UIntPtr length)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_indicesv(indices, length);
	}

	public static GtkTreePathHandle NewFromString(string path)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_string(path);
	}

}


public static class GtkTreePathHandleExtensions
{
	public static GtkTreePathHandle AppendIndex(this GtkTreePathHandle path, int index_)
	{
		GtkTreePathExterns.gtk_tree_path_append_index(path, index_);
		return path;
	}

	public static int Compare(this GtkTreePathHandle a, GtkTreePathHandle b)
	{
		return GtkTreePathExterns.gtk_tree_path_compare(a, b);
	}

	public static GtkTreePathHandle Copy(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_copy(path);
	}

	public static GtkTreePathHandle Down(this GtkTreePathHandle path)
	{
		GtkTreePathExterns.gtk_tree_path_down(path);
		return path;
	}

	public static GtkTreePathHandle Free(this GtkTreePathHandle path)
	{
		GtkTreePathExterns.gtk_tree_path_free(path);
		return path;
	}

	public static int GetDepth(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_get_depth(path);
	}

	public static IntPtr GetIndices(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_get_indices(path);
	}

	public static IntPtr GetIndicesWithDepth(this GtkTreePathHandle path, out int depth)
	{
		return GtkTreePathExterns.gtk_tree_path_get_indices_with_depth(path, out depth);
	}

	public static bool IsAncestor(this GtkTreePathHandle path, GtkTreePathHandle descendant)
	{
		return GtkTreePathExterns.gtk_tree_path_is_ancestor(path, descendant);
	}

	public static bool IsDescendant(this GtkTreePathHandle path, GtkTreePathHandle ancestor)
	{
		return GtkTreePathExterns.gtk_tree_path_is_descendant(path, ancestor);
	}

	public static GtkTreePathHandle Next(this GtkTreePathHandle path)
	{
		GtkTreePathExterns.gtk_tree_path_next(path);
		return path;
	}

	public static GtkTreePathHandle PrependIndex(this GtkTreePathHandle path, int index_)
	{
		GtkTreePathExterns.gtk_tree_path_prepend_index(path, index_);
		return path;
	}

	public static bool Prev(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_prev(path);
	}

	public static string ToString(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_to_string(path);
	}

	public static bool Up(this GtkTreePathHandle path)
	{
		return GtkTreePathExterns.gtk_tree_path_up(path);
	}

}
internal class GtkTreePathExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_path_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_path_new_first();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_path_new_from_indices(int first_index, IntPtr @__arglist);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_path_new_from_indicesv(int[] indices, UIntPtr length);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_path_new_from_string(string path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_path_append_index(GtkTreePathHandle path, int index_);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_tree_path_compare(GtkTreePathHandle a, GtkTreePathHandle b);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_path_copy(GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_path_down(GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_path_free(GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_tree_path_get_depth(GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern IntPtr gtk_tree_path_get_indices(GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern IntPtr gtk_tree_path_get_indices_with_depth(GtkTreePathHandle path, out int depth);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_path_is_ancestor(GtkTreePathHandle path, GtkTreePathHandle descendant);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_path_is_descendant(GtkTreePathHandle path, GtkTreePathHandle ancestor);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_path_next(GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_path_prepend_index(GtkTreePathHandle path, int index_);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_path_prev(GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_tree_path_to_string(GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_path_up(GtkTreePathHandle path);

}

public struct GtkTreePath
{
}
