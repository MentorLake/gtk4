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

	public static GtkTreePathHandle NewFromIndicesv(int[] indices, int length)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_indicesv(indices, length);
	}

	public static GtkTreePathHandle NewFromString(string path)
	{
		return GtkTreePathExterns.gtk_tree_path_new_from_string(path);
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
	internal static extern GtkTreePathHandle gtk_tree_path_new_from_indicesv(int[] indices, int length);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_path_new_from_string(string path);

}

public struct GtkTreePath
{
}
