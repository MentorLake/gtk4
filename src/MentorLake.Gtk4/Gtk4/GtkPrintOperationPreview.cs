using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public interface GtkPrintOperationPreviewHandle
{
}

internal class GtkPrintOperationPreviewHandleImpl : BaseSafeHandle, GtkPrintOperationPreviewHandle
{
}

public static class GtkPrintOperationPreviewHandleExtensions
{
	public static GtkPrintOperationPreviewHandle EndPreview(this GtkPrintOperationPreviewHandle preview)
	{
		GtkPrintOperationPreviewExterns.gtk_print_operation_preview_end_preview(preview);
		return preview;
	}

	public static bool IsSelected(this GtkPrintOperationPreviewHandle preview, int page_nr)
	{
		return GtkPrintOperationPreviewExterns.gtk_print_operation_preview_is_selected(preview, page_nr);
	}

	public static GtkPrintOperationPreviewHandle RenderPage(this GtkPrintOperationPreviewHandle preview, int page_nr)
	{
		GtkPrintOperationPreviewExterns.gtk_print_operation_preview_render_page(preview, page_nr);
		return preview;
	}

}

internal class GtkPrintOperationPreviewExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_preview_end_preview(GtkPrintOperationPreviewHandle preview);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_operation_preview_is_selected(GtkPrintOperationPreviewHandle preview, int page_nr);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_operation_preview_render_page(GtkPrintOperationPreviewHandle preview, int page_nr);

}
