namespace MentorLake.Gtk4.Gtk4;

public class GtkCellRendererPixbufHandle : GtkCellRendererHandle
{
	public static GtkCellRendererPixbufHandle New()
	{
		return GtkCellRendererPixbufExterns.gtk_cell_renderer_pixbuf_new();
	}

}

public static class GtkCellRendererPixbufHandleExtensions
{
}

internal class GtkCellRendererPixbufExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererPixbufHandle gtk_cell_renderer_pixbuf_new();

}
