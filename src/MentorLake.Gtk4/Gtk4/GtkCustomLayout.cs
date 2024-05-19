namespace MentorLake.Gtk4.Gtk4;

public class GtkCustomLayoutHandle : GtkLayoutManagerHandle
{
	public static GtkCustomLayoutHandle New(GtkCustomRequestModeFunc request_mode, GtkCustomMeasureFunc measure, GtkCustomAllocateFunc allocate)
	{
		return GtkCustomLayoutExterns.gtk_custom_layout_new(request_mode, measure, allocate);
	}

}

public static class GtkCustomLayoutHandleExtensions
{
}

internal class GtkCustomLayoutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCustomLayoutHandle gtk_custom_layout_new(GtkCustomRequestModeFunc request_mode, GtkCustomMeasureFunc measure, GtkCustomAllocateFunc allocate);

}
