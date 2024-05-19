namespace MentorLake.Gtk4.Gtk4;

public class GtkFontChooserWidgetHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkFontChooserHandle
{
	public static GtkFontChooserWidgetHandle New()
	{
		return GtkFontChooserWidgetExterns.gtk_font_chooser_widget_new();
	}

}

public static class GtkFontChooserWidgetHandleExtensions
{
}

internal class GtkFontChooserWidgetExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkFontChooserWidgetHandle gtk_font_chooser_widget_new();

}
