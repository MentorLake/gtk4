namespace MentorLake.Gtk4.Gdk4;

public class GdkToplevelLayoutHandle : BaseSafeHandle
{
	public static GdkToplevelLayoutHandle New()
	{
		return GdkToplevelLayoutExterns.gdk_toplevel_layout_new();
	}

}

internal class GdkToplevelLayoutExterns
{
	[DllImport(Libraries.Gdk4)]
	internal static extern GdkToplevelLayoutHandle gdk_toplevel_layout_new();

}

public struct GdkToplevelLayout
{
}
