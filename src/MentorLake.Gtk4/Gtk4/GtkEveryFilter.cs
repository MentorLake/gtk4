namespace MentorLake.Gtk4.Gtk4;

public class GtkEveryFilterHandle : GtkMultiFilterHandle, GListModelHandle, GtkBuildableHandle
{
	public static GtkEveryFilterHandle New()
	{
		return GtkEveryFilterExterns.gtk_every_filter_new();
	}

}

public static class GtkEveryFilterHandleExtensions
{
}

internal class GtkEveryFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkEveryFilterHandle gtk_every_filter_new();

}
