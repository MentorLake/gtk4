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

internal class GtkTreeRowReferenceExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_new(GtkTreeModelHandle model, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_new_proxy(GObjectHandle proxy, GtkTreeModelHandle model, GtkTreePathHandle path);

}

public struct GtkTreeRowReference
{
}
