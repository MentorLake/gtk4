namespace MentorLake.Gtk4.Gtk4;

public class GtkMultiFilterHandle : GtkFilterHandle, GListModelHandle, GtkBuildableHandle
{
}

public static class GtkMultiFilterHandleExtensions
{
	public static GtkMultiFilterHandle Append(this GtkMultiFilterHandle self, GtkFilterHandle filter)
	{
		GtkMultiFilterExterns.gtk_multi_filter_append(self, filter);
		return self;
	}

	public static GtkMultiFilterHandle Remove(this GtkMultiFilterHandle self, uint position)
	{
		GtkMultiFilterExterns.gtk_multi_filter_remove(self, position);
		return self;
	}

}

internal class GtkMultiFilterExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_multi_filter_append(GtkMultiFilterHandle self, GtkFilterHandle filter);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_multi_filter_remove(GtkMultiFilterHandle self, uint position);

}
