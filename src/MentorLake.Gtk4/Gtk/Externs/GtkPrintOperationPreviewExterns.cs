using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkPrintOperationPreviewExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_preview_render_page")]
	internal static extern void gtk_print_operation_preview_render_page(this GtkPrintOperationPreviewHandle preview, int page_nr);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_preview_end_preview")]
	internal static extern void gtk_print_operation_preview_end_preview(this GtkPrintOperationPreviewHandle preview);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_print_operation_preview_is_selected")]
	internal static extern int gtk_print_operation_preview_is_selected(this GtkPrintOperationPreviewHandle preview, int page_nr);
}
