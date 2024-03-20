using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPrintOperationPreviewAdaptors
{
    public static GtkPrintOperationPreviewHandle RenderPage(this GtkPrintOperationPreviewHandle preview, int page_nr)
    {
        GtkPrintOperationPreviewExterns.gtk_print_operation_preview_render_page(preview, page_nr);
        return preview;
    }

    public static GtkPrintOperationPreviewHandle EndPreview(this GtkPrintOperationPreviewHandle preview)
    {
        GtkPrintOperationPreviewExterns.gtk_print_operation_preview_end_preview(preview);
        return preview;
    }

    public static int IsSelected(this GtkPrintOperationPreviewHandle preview, int page_nr)
    {
        return GtkPrintOperationPreviewExterns.gtk_print_operation_preview_is_selected(preview, page_nr);
    }
}
