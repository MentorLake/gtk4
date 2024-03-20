using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;

public static class GtkMediaControlsExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_media_controls_get_media_stream")]
	internal static extern GtkMediaStreamHandle gtk_media_controls_get_media_stream(this GtkMediaControlsHandle controls);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_media_controls_set_media_stream")]
	internal static extern void gtk_media_controls_set_media_stream(this GtkMediaControlsHandle controls, GtkMediaStreamHandle stream);
}
