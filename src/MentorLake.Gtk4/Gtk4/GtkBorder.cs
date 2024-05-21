namespace MentorLake.Gtk4.Gtk4;

public class GtkBorderHandle : BaseSafeHandle
{
	public static GtkBorderHandle New()
	{
		return GtkBorderExterns.gtk_border_new();
	}

}


public static class GtkBorderHandleExtensions
{
	public static GtkBorderHandle Copy(this GtkBorderHandle border_)
	{
		return GtkBorderExterns.gtk_border_copy(border_);
	}

	public static GtkBorderHandle Free(this GtkBorderHandle border_)
	{
		GtkBorderExterns.gtk_border_free(border_);
		return border_;
	}

}
internal class GtkBorderExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBorderHandle gtk_border_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkBorderHandle gtk_border_copy(GtkBorderHandle border_);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_border_free(GtkBorderHandle border_);

}

public struct GtkBorder
{
	public short left;
	public short right;
	public short top;
	public short bottom;
}
