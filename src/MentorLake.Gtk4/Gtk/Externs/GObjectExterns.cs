using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;

public static class GObjectExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_row_reference_inserted")]
	internal static extern void gtk_tree_row_reference_inserted(this GObjectHandle proxy, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_row_reference_deleted")]
	internal static extern void gtk_tree_row_reference_deleted(this GObjectHandle proxy, GtkTreePathHandle path);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_row_reference_reordered")]
	internal static extern void gtk_tree_row_reference_reordered(this GObjectHandle proxy, GtkTreePathHandle path, GtkTreeIterHandle iter, int[] new_order);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_delegate_set_property")]
	internal static extern int gtk_editable_delegate_set_property(this GObjectHandle @object, uint prop_id, GValueHandle value, GParamSpecHandle pspec);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_editable_delegate_get_property")]
	internal static extern int gtk_editable_delegate_get_property(this GObjectHandle @object, uint prop_id, GValueHandle value, GParamSpecHandle pspec);
}
