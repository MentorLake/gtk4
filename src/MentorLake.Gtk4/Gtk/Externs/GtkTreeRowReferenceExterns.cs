using System.Runtime.InteropServices;
using MentorLake.Gtk4.GObject;

namespace MentorLake.Gtk4.Gtk;
public static class GtkTreeRowReferenceExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_row_reference_get_path")]
    internal static extern GtkTreePathHandle gtk_tree_row_reference_get_path(this GtkTreeRowReferenceHandle reference);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_row_reference_get_model")]
    internal static extern GtkTreeModelHandle gtk_tree_row_reference_get_model(this GtkTreeRowReferenceHandle reference);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_row_reference_valid")]
    internal static extern int gtk_tree_row_reference_valid(this GtkTreeRowReferenceHandle reference);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_row_reference_copy")]
    internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_copy(this GtkTreeRowReferenceHandle reference);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_tree_row_reference_free")]
    internal static extern void gtk_tree_row_reference_free(this GtkTreeRowReferenceHandle reference);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_new(GtkTreeModelHandle model, GtkTreePathHandle path);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkTreeRowReferenceHandle gtk_tree_row_reference_new_proxy(GObjectHandle proxy, GtkTreeModelHandle model, GtkTreePathHandle path);
}
