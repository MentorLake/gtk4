namespace MentorLake.Gtk4.Gtk4;

public interface GtkRootHandle
{
}

internal class GtkRootHandleImpl : BaseSafeHandle, GtkRootHandle
{
}

public static class GtkRootHandleExtensions
{
	public static GdkDisplayHandle GetDisplay(this GtkRootHandle self)
	{
		return GtkRootExterns.gtk_root_get_display(self);
	}

	public static GtkWidgetHandle GetFocus(this GtkRootHandle self)
	{
		return GtkRootExterns.gtk_root_get_focus(self);
	}

	public static GtkRootHandle SetFocus(this GtkRootHandle self, GtkWidgetHandle focus)
	{
		GtkRootExterns.gtk_root_set_focus(self, focus);
		return self;
	}

}

internal class GtkRootExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GdkDisplayHandle gtk_root_get_display(GtkRootHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkWidgetHandle gtk_root_get_focus(GtkRootHandle self);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_root_set_focus(GtkRootHandle self, GtkWidgetHandle focus);

}
