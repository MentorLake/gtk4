using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkRequisitionExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_requisition_copy")]
    internal static extern GtkRequisitionHandle gtk_requisition_copy(this GtkRequisitionHandle requisition);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_requisition_free")]
    internal static extern void gtk_requisition_free(this GtkRequisitionHandle requisition);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkRequisitionHandle gtk_requisition_new();
}
