namespace MentorLake.Gtk4.Gtk4;

public class GtkBorderHandle : BaseSafeHandle
{
	public static GtkBorderHandle New()
	{
		return GtkBorderExterns.gtk_border_new();
	}

}

internal class GtkBorderExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBorderHandle gtk_border_new();

}

public struct GtkBorder
{
	public short left;
	public short right;
	public short top;
	public short bottom;
}
