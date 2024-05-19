namespace MentorLake.Gtk4.Gtk4;

public class GtkOverlayLayoutHandle : GtkLayoutManagerHandle
{
	public static GtkOverlayLayoutHandle New()
	{
		return GtkOverlayLayoutExterns.gtk_overlay_layout_new();
	}

}

public static class GtkOverlayLayoutHandleExtensions
{
}

internal class GtkOverlayLayoutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkOverlayLayoutHandle gtk_overlay_layout_new();

}
