namespace MentorLake.Gtk4.Gtk4;

public class GtkColorChooserWidgetHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkColorChooserHandle, GtkConstraintTargetHandle
{
	public static GtkColorChooserWidgetHandle New()
	{
		return GtkColorChooserWidgetExterns.gtk_color_chooser_widget_new();
	}

}

public static class GtkColorChooserWidgetHandleExtensions
{
}

internal class GtkColorChooserWidgetExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkColorChooserWidgetHandle gtk_color_chooser_widget_new();

}
