using System.Runtime.InteropServices;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMediaControlsAdaptors
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
