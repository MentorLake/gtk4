using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMediaStreamAdaptors
{
	public static int IsPrepared(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_is_prepared(self);
	}

	public static GErrorHandle GetError(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_error(self);
	}

	public static int HasAudio(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_has_audio(self);
	}

	public static int HasVideo(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_has_video(self);
	}

	public static GtkMediaStreamHandle Play(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_play(self);
		return self;
	}

	public static GtkMediaStreamHandle Pause(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_pause(self);
		return self;
	}

	public static int GetPlaying(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_playing(self);
	}

	public static GtkMediaStreamHandle SetPlaying(this GtkMediaStreamHandle self, int playing)
	{
		GtkMediaStreamExterns.gtk_media_stream_set_playing(self, playing);
		return self;
	}

	public static int GetEnded(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_ended(self);
	}

	public static nint GetTimestamp(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_timestamp(self);
	}

	public static nint GetDuration(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_duration(self);
	}

	public static int IsSeekable(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_is_seekable(self);
	}

	public static int IsSeeking(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_is_seeking(self);
	}

	public static GtkMediaStreamHandle Seek(this GtkMediaStreamHandle self, nint timestamp)
	{
		GtkMediaStreamExterns.gtk_media_stream_seek(self, timestamp);
		return self;
	}

	public static int GetLoop(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_loop(self);
	}

	public static GtkMediaStreamHandle SetLoop(this GtkMediaStreamHandle self, int loop)
	{
		GtkMediaStreamExterns.gtk_media_stream_set_loop(self, loop);
		return self;
	}

	public static int GetMuted(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_muted(self);
	}

	public static GtkMediaStreamHandle SetMuted(this GtkMediaStreamHandle self, int muted)
	{
		GtkMediaStreamExterns.gtk_media_stream_set_muted(self, muted);
		return self;
	}

	public static double GetVolume(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_volume(self);
	}

	public static GtkMediaStreamHandle SetVolume(this GtkMediaStreamHandle self, double volume)
	{
		GtkMediaStreamExterns.gtk_media_stream_set_volume(self, volume);
		return self;
	}

	public static GtkMediaStreamHandle Realize(this GtkMediaStreamHandle self, GdkSurfaceHandle surface)
	{
		GtkMediaStreamExterns.gtk_media_stream_realize(self, surface);
		return self;
	}

	public static GtkMediaStreamHandle Unrealize(this GtkMediaStreamHandle self, GdkSurfaceHandle surface)
	{
		GtkMediaStreamExterns.gtk_media_stream_unrealize(self, surface);
		return self;
	}

	public static GtkMediaStreamHandle Prepared(this GtkMediaStreamHandle self, int has_audio, int has_video, int seekable, nint duration)
	{
		GtkMediaStreamExterns.gtk_media_stream_prepared(self, has_audio, has_video, seekable, duration);
		return self;
	}

	public static GtkMediaStreamHandle Unprepared(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_unprepared(self);
		return self;
	}

	public static GtkMediaStreamHandle StreamPrepared(this GtkMediaStreamHandle self, int has_audio, int has_video, int seekable, nint duration)
	{
		GtkMediaStreamExterns.gtk_media_stream_stream_prepared(self, has_audio, has_video, seekable, duration);
		return self;
	}

	public static GtkMediaStreamHandle StreamUnprepared(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_stream_unprepared(self);
		return self;
	}

	public static GtkMediaStreamHandle Update(this GtkMediaStreamHandle self, nint timestamp)
	{
		GtkMediaStreamExterns.gtk_media_stream_update(self, timestamp);
		return self;
	}

	public static GtkMediaStreamHandle Ended(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_ended(self);
		return self;
	}

	public static GtkMediaStreamHandle StreamEnded(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_stream_ended(self);
		return self;
	}

	public static GtkMediaStreamHandle SeekSuccess(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_seek_success(self);
		return self;
	}

	public static GtkMediaStreamHandle SeekFailed(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_seek_failed(self);
		return self;
	}

	public static GtkMediaStreamHandle Gerror(this GtkMediaStreamHandle self, GErrorHandle error)
	{
		GtkMediaStreamExterns.gtk_media_stream_gerror(self, error);
		return self;
	}

	public static GtkMediaStreamHandle Error(this GtkMediaStreamHandle self, GQuark domain, int code, string format, IntPtr @__argList)
	{
		GtkMediaStreamExterns.gtk_media_stream_error(self, domain, code, format, @__argList);
		return self;
	}

	public static GtkMediaStreamHandle ErrorValist(this GtkMediaStreamHandle self, GQuark domain, int code, string format, IntPtr @__argList)
	{
		GtkMediaStreamExterns.gtk_media_stream_error_valist(self, domain, code, format, @__argList);
		return self;
	}

	public static GtkMediaControlsHandle GtkMediaControlsNew(this GtkMediaStreamHandle stream)
	{
		return GtkMediaStreamExterns.gtk_media_controls_new(stream);
	}

	public static GtkVideoHandle GtkVideoNewForMediaStream(this GtkMediaStreamHandle stream)
	{
		return GtkMediaStreamExterns.gtk_video_new_for_media_stream(stream);
	}

	public static GtkMediaStreamHandle GtkMediaFileNewForFilename(string filename)
	{
		return GtkMediaStreamExterns.gtk_media_file_new_for_filename(filename);
	}

	public static GtkMediaStreamHandle GtkMediaFileNewForResource(string resource_path)
	{
		return GtkMediaStreamExterns.gtk_media_file_new_for_resource(resource_path);
	}

	public static GtkMediaStreamHandle GtkMediaFileNewForFile(GFileHandle file)
	{
		return GtkMediaStreamExterns.gtk_media_file_new_for_file(file);
	}

	public static GtkMediaStreamHandle GtkMediaFileNewForInputStream(GInputStreamHandle stream)
	{
		return GtkMediaStreamExterns.gtk_media_file_new_for_input_stream(stream);
	}
}
