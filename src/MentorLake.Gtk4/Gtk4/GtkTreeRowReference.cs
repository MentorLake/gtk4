namespace MentorLake.Gtk4.Gtk4;

public class GtkTreeRowReferenceHandle : BaseSafeHandle
{
	public static GtkTreeRowReferenceHandle New(GtkTreeModelHandle model, GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new(model, path);
	}

	public static GtkTreeRowReferenceHandle NewProxy(GObjectHandle proxy, GtkTreeModelHandle model, GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new_proxy(proxy, model, path);
	}

}


public static class GtkTreeRowReferenceHandleExtensions
{
	public static GtkTreeRowReferenceHandle Copy(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_copy(reference);
	}

	public static GtkTreeRowReferenceHandle Free(this GtkTreeRowReferenceHandle reference)
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_free(reference);
		return reference;
	}

	public static GtkTreeModelHandle GetModel(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_get_model(reference);
	}

	public static GtkTreePathHandle GetPath(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_get_path(reference);
	}

	public static bool Valid(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_valid(reference);
	}

}
internal class GtkTreeRowReferenceExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_new(GtkTreeModelHandle model, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_new_proxy(GObjectHandle proxy, GtkTreeModelHandle model, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_copy(GtkTreeRowReferenceHandle reference);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_tree_row_reference_free(GtkTreeRowReferenceHandle reference);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeModelHandle gtk_tree_row_reference_get_model(GtkTreeRowReferenceHandle reference);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreePathHandle gtk_tree_row_reference_get_path(GtkTreeRowReferenceHandle reference);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_tree_row_reference_valid(GtkTreeRowReferenceHandle reference);

}

public struct GtkTreeRowReference
{
}
