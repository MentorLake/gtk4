namespace MentorLake.Gtk4.Gtk4;

public class GtkScrollInfoHandle : BaseSafeHandle
{
	public static GtkScrollInfoHandle New()
	{
		return GtkScrollInfoExterns.gtk_scroll_info_new();
	}

}


public static class GtkScrollInfoHandleExtensions
{
	public static bool GetEnableHorizontal(this GtkScrollInfoHandle self)
	{
		return GtkScrollInfoExterns.gtk_scroll_info_get_enable_horizontal(self);
	}

	public static bool GetEnableVertical(this GtkScrollInfoHandle self)
	{
		return GtkScrollInfoExterns.gtk_scroll_info_get_enable_vertical(self);
	}

	public static GtkScrollInfoHandle Ref(this GtkScrollInfoHandle self)
	{
		return GtkScrollInfoExterns.gtk_scroll_info_ref(self);
	}

	public static GtkScrollInfoHandle SetEnableHorizontal(this GtkScrollInfoHandle self, bool horizontal)
	{
		GtkScrollInfoExterns.gtk_scroll_info_set_enable_horizontal(self, horizontal);
		return self;
	}

	public static GtkScrollInfoHandle SetEnableVertical(this GtkScrollInfoHandle self, bool vertical)
	{
		GtkScrollInfoExterns.gtk_scroll_info_set_enable_vertical(self, vertical);
		return self;
	}

	public static GtkScrollInfoHandle Unref(this GtkScrollInfoHandle self)
	{
		GtkScrollInfoExterns.gtk_scroll_info_unref(self);
		return self;
	}

}
internal class GtkScrollInfoExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkScrollInfoHandle gtk_scroll_info_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scroll_info_get_enable_horizontal(GtkScrollInfoHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_scroll_info_get_enable_vertical(GtkScrollInfoHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkScrollInfoHandle gtk_scroll_info_ref(GtkScrollInfoHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scroll_info_set_enable_horizontal(GtkScrollInfoHandle self, bool horizontal);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scroll_info_set_enable_vertical(GtkScrollInfoHandle self, bool vertical);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_scroll_info_unref(GtkScrollInfoHandle self);

}

public struct GtkScrollInfo
{
}
