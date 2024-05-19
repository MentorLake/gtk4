namespace MentorLake.Gtk4.Gtk4;

public class GtkOverlayLayoutChildHandle : GtkLayoutChildHandle
{
}

public static class GtkOverlayLayoutChildHandleExtensions
{
	public static bool GetClipOverlay(this GtkOverlayLayoutChildHandle child)
	{
		return GtkOverlayLayoutChildExterns.gtk_overlay_layout_child_get_clip_overlay(child);
	}

	public static bool GetMeasure(this GtkOverlayLayoutChildHandle child)
	{
		return GtkOverlayLayoutChildExterns.gtk_overlay_layout_child_get_measure(child);
	}

	public static GtkOverlayLayoutChildHandle SetClipOverlay(this GtkOverlayLayoutChildHandle child, bool clip_overlay)
	{
		GtkOverlayLayoutChildExterns.gtk_overlay_layout_child_set_clip_overlay(child, clip_overlay);
		return child;
	}

	public static GtkOverlayLayoutChildHandle SetMeasure(this GtkOverlayLayoutChildHandle child, bool measure)
	{
		GtkOverlayLayoutChildExterns.gtk_overlay_layout_child_set_measure(child, measure);
		return child;
	}

}

internal class GtkOverlayLayoutChildExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_overlay_layout_child_get_clip_overlay(GtkOverlayLayoutChildHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_overlay_layout_child_get_measure(GtkOverlayLayoutChildHandle child);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_overlay_layout_child_set_clip_overlay(GtkOverlayLayoutChildHandle child, bool clip_overlay);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_overlay_layout_child_set_measure(GtkOverlayLayoutChildHandle child, bool measure);

}
