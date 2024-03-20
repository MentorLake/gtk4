using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkVideoAdaptors
{
	public static GtkMediaStreamHandle GetMediaStream(this GtkVideoHandle self)
	{
		return GtkVideoExterns.gtk_video_get_media_stream(self);
	}

	public static GtkVideoHandle SetMediaStream(this GtkVideoHandle self, GtkMediaStreamHandle stream)
	{
		GtkVideoExterns.gtk_video_set_media_stream(self, stream);
		return self;
	}

	public static GFileHandle GetFile(this GtkVideoHandle self)
	{
		return GtkVideoExterns.gtk_video_get_file(self);
	}

	public static GtkVideoHandle SetFile(this GtkVideoHandle self, GFileHandle file)
	{
		GtkVideoExterns.gtk_video_set_file(self, file);
		return self;
	}

	public static GtkVideoHandle SetFilename(this GtkVideoHandle self, string filename)
	{
		GtkVideoExterns.gtk_video_set_filename(self, filename);
		return self;
	}

	public static GtkVideoHandle SetResource(this GtkVideoHandle self, string resource_path)
	{
		GtkVideoExterns.gtk_video_set_resource(self, resource_path);
		return self;
	}

	public static int GetAutoplay(this GtkVideoHandle self)
	{
		return GtkVideoExterns.gtk_video_get_autoplay(self);
	}

	public static GtkVideoHandle SetAutoplay(this GtkVideoHandle self, int autoplay)
	{
		GtkVideoExterns.gtk_video_set_autoplay(self, autoplay);
		return self;
	}

	public static int GetLoop(this GtkVideoHandle self)
	{
		return GtkVideoExterns.gtk_video_get_loop(self);
	}

	public static GtkVideoHandle SetLoop(this GtkVideoHandle self, int loop)
	{
		GtkVideoExterns.gtk_video_set_loop(self, loop);
		return self;
	}

	public static GtkVideoHandle NewForFile(GFileHandle file)
	{
		return GtkVideoExterns.gtk_video_new_for_file(file);
	}

	public static GtkVideoHandle NewForFilename(string filename)
	{
		return GtkVideoExterns.gtk_video_new_for_filename(filename);
	}

	public static GtkVideoHandle NewForResource(string resource_path)
	{
		return GtkVideoExterns.gtk_video_new_for_resource(resource_path);
	}
}
