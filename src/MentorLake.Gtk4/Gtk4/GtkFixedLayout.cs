namespace MentorLake.Gtk4.Gtk4;

public class GtkFixedLayoutHandle : GtkLayoutManagerHandle
{
	public static GtkFixedLayoutHandle New()
	{
		return GtkFixedLayoutExterns.gtk_fixed_layout_new();
	}

}

public static class GtkFixedLayoutHandleExtensions
{
}

internal class GtkFixedLayoutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFixedLayoutHandle gtk_fixed_layout_new();

}
