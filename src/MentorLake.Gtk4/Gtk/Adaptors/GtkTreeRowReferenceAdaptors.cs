using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeRowReferenceAdaptors
{
	public static GtkTreePathHandle GetPath(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_get_path(reference);
	}

	public static GtkTreeModelHandle GetModel(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_get_model(reference);
	}

	public static int Valid(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_valid(reference);
	}

	public static GtkTreeRowReferenceHandle Copy(this GtkTreeRowReferenceHandle reference)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_copy(reference);
	}

	public static GtkTreeRowReferenceHandle Free(this GtkTreeRowReferenceHandle reference)
	{
		GtkTreeRowReferenceExterns.gtk_tree_row_reference_free(reference);
		return reference;
	}

	public static GtkTreeRowReferenceHandle NewProxy(GObjectHandle proxy, GtkTreeModelHandle model, GtkTreePathHandle path)
	{
		return GtkTreeRowReferenceExterns.gtk_tree_row_reference_new_proxy(proxy, model, path);
	}
}
