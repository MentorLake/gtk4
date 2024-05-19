namespace MentorLake.Gtk4.Gtk4;

public class GtkMediaControlsHandle : GtkWidgetHandle, GtkAccessibleHandle, GtkBuildableHandle, GtkConstraintTargetHandle
{
	public static GtkMediaControlsHandle New(GtkMediaStreamHandle stream)
	{
		return GtkMediaControlsExterns.gtk_media_controls_new(stream);
	}

}

public static class GtkMediaControlsHandleExtensions
{
	public static GtkMediaStreamHandle GetMediaStream(this GtkMediaControlsHandle controls)
	{
		return GtkMediaControlsExterns.gtk_media_controls_get_media_stream(controls);
	}

	public static GtkMediaControlsHandle SetMediaStream(this GtkMediaControlsHandle controls, GtkMediaStreamHandle stream)
	{
		GtkMediaControlsExterns.gtk_media_controls_set_media_stream(controls, stream);
		return controls;
	}

}

internal class GtkMediaControlsExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMediaControlsHandle gtk_media_controls_new(GtkMediaStreamHandle stream);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkMediaStreamHandle gtk_media_controls_get_media_stream(GtkMediaControlsHandle controls);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_controls_set_media_stream(GtkMediaControlsHandle controls, GtkMediaStreamHandle stream);

}
