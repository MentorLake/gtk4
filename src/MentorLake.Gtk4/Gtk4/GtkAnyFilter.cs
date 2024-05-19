namespace MentorLake.Gtk4.Gtk4;

public class GtkAnyFilterHandle : GtkMultiFilterHandle, GListModelHandle, GtkBuildableHandle
{
	public static GtkAnyFilterHandle New()
	{
		return GtkAnyFilterExterns.gtk_any_filter_new();
	}

}

public static class GtkAnyFilterHandleExtensions
{
}

internal class GtkAnyFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkAnyFilterHandle gtk_any_filter_new();

}
