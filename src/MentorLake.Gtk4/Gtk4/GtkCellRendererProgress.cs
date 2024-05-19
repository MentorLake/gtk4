namespace MentorLake.Gtk4.Gtk4;

public class GtkCellRendererProgressHandle : GtkCellRendererHandle, GtkOrientableHandle
{
	public static GtkCellRendererProgressHandle New()
	{
		return GtkCellRendererProgressExterns.gtk_cell_renderer_progress_new();
	}

}

public static class GtkCellRendererProgressHandleExtensions
{
}

internal class GtkCellRendererProgressExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCellRendererProgressHandle gtk_cell_renderer_progress_new();

}
