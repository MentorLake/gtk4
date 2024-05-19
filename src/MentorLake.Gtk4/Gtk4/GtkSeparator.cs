namespace MentorLake.Gtk4.Gtk4;

public class GtkSeparatorHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkSeparatorHandle New(GtkOrientation orientation)
	{
		return GtkSeparatorExterns.gtk_separator_new(orientation);
	}

}

public static class GtkSeparatorHandleExtensions
{
}

internal class GtkSeparatorExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkSeparatorHandle gtk_separator_new(GtkOrientation orientation);

}
