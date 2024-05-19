namespace MentorLake.Gtk4.Gtk4;

public class GtkBinLayoutHandle : GtkLayoutManagerHandle
{
	public static GtkBinLayoutHandle New()
	{
		return GtkBinLayoutExterns.gtk_bin_layout_new();
	}

}

public static class GtkBinLayoutHandleExtensions
{
}

internal class GtkBinLayoutExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBinLayoutHandle gtk_bin_layout_new();

}
