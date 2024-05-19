namespace MentorLake.Gtk4.Gtk4;

public class GtkScrollInfoHandle : BaseSafeHandle
{
	public static GtkScrollInfoHandle New()
	{
		return GtkScrollInfoExterns.gtk_scroll_info_new();
	}

}

internal class GtkScrollInfoExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkScrollInfoHandle gtk_scroll_info_new();

}

public struct GtkScrollInfo
{
}
