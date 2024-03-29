using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkMediaControlsHandle : GtkWidgetHandle
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
