namespace MentorLake.Gtk4.Gtk4;

public class GtkVolumeButtonHandle : GtkScaleButtonHandle, GtkAccessibleHandle, GtkAccessibleRangeHandle, GtkBuildableHandle, GtkConstraintTargetHandle, GtkOrientableHandle
{
	public static GtkVolumeButtonHandle New()
	{
		return GtkVolumeButtonExterns.gtk_volume_button_new();
	}

}

public static class GtkVolumeButtonHandleExtensions
{
}

internal class GtkVolumeButtonExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkVolumeButtonHandle gtk_volume_button_new();

}
