namespace MentorLake.Gtk4.Gtk4;

public class GtkTreeListModelHandle : GObjectHandle, GListModelHandle
{
	public static GtkTreeListModelHandle New(GListModelHandle root, bool passthrough, bool autoexpand, GtkTreeListModelCreateModelFunc create_func, IntPtr user_data, GDestroyNotify user_destroy)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_new(root, passthrough, autoexpand, create_func, user_data, user_destroy);
	}

}

public static class GtkTreeListModelHandleExtensions
{
	public static bool GetAutoexpand(this GtkTreeListModelHandle self)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_get_autoexpand(self);
	}

	public static GtkTreeListRowHandle GetChildRow(this GtkTreeListModelHandle self, uint position)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_get_child_row(self, position);
	}

	public static GListModelHandle GetModel(this GtkTreeListModelHandle self)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_get_model(self);
	}

	public static bool GetPassthrough(this GtkTreeListModelHandle self)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_get_passthrough(self);
	}

	public static GtkTreeListRowHandle GetRow(this GtkTreeListModelHandle self, uint position)
	{
		return GtkTreeListModelExterns.gtk_tree_list_model_get_row(self, position);
	}

	public static GtkTreeListModelHandle SetAutoexpand(this GtkTreeListModelHandle self, bool autoexpand)
	{
		GtkTreeListModelExterns.gtk_tree_list_model_set_autoexpand(self, autoexpand);
		return self;
	}

}

internal class GtkTreeListModelExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeListModelHandle gtk_tree_list_model_new(GListModelHandle root, bool passthrough, bool autoexpand, GtkTreeListModelCreateModelFunc create_func, IntPtr user_data, GDestroyNotify user_destroy);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_list_model_get_autoexpand(GtkTreeListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeListRowHandle gtk_tree_list_model_get_child_row(GtkTreeListModelHandle self, uint position);

	[DllImport(Libraries.Gtk4)]
	internal static extern GListModelHandle gtk_tree_list_model_get_model(GtkTreeListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_list_model_get_passthrough(GtkTreeListModelHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeListRowHandle gtk_tree_list_model_get_row(GtkTreeListModelHandle self, uint position);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_list_model_set_autoexpand(GtkTreeListModelHandle self, bool autoexpand);

}
