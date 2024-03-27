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

public class GtkMediaStreamHandle : GObjectHandle
{
}

public static class GtkMediaStreamSignals
{
}

public static class GtkMediaStreamHandleExtensions
{
	public static GtkMediaStreamHandle Ended(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_ended(self);
		return self;
	}

	public static GtkMediaStreamHandle Error(this GtkMediaStreamHandle self, GQuark domain, int code, string format, IntPtr @__arglist)
	{
		GtkMediaStreamExterns.gtk_media_stream_error(self, domain, code, format, @__arglist);
		return self;
	}

	public static GtkMediaStreamHandle ErrorValist(this GtkMediaStreamHandle self, GQuark domain, int code, string format, IntPtr args)
	{
		GtkMediaStreamExterns.gtk_media_stream_error_valist(self, domain, code, format, args);
		return self;
	}

	public static GtkMediaStreamHandle Gerror(this GtkMediaStreamHandle self, GErrorHandle error)
	{
		GtkMediaStreamExterns.gtk_media_stream_gerror(self, error);
		return self;
	}

	public static long GetDuration(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_duration(self);
	}

	public static bool GetEnded(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_ended(self);
	}

	public static GErrorHandle GetError(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_error(self);
	}

	public static bool GetLoop(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_loop(self);
	}

	public static bool GetMuted(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_muted(self);
	}

	public static bool GetPlaying(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_playing(self);
	}

	public static long GetTimestamp(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_timestamp(self);
	}

	public static double GetVolume(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_get_volume(self);
	}

	public static bool HasAudio(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_has_audio(self);
	}

	public static bool HasVideo(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_has_video(self);
	}

	public static bool IsPrepared(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_is_prepared(self);
	}

	public static bool IsSeekable(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_is_seekable(self);
	}

	public static bool IsSeeking(this GtkMediaStreamHandle self)
	{
		return GtkMediaStreamExterns.gtk_media_stream_is_seeking(self);
	}

	public static GtkMediaStreamHandle Pause(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_pause(self);
		return self;
	}

	public static GtkMediaStreamHandle Play(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_play(self);
		return self;
	}

	public static GtkMediaStreamHandle Prepared(this GtkMediaStreamHandle self, bool has_audio, bool has_video, bool seekable, long duration)
	{
		GtkMediaStreamExterns.gtk_media_stream_prepared(self, has_audio, has_video, seekable, duration);
		return self;
	}

	public static GtkMediaStreamHandle Realize(this GtkMediaStreamHandle self, GdkSurfaceHandle surface)
	{
		GtkMediaStreamExterns.gtk_media_stream_realize(self, surface);
		return self;
	}

	public static GtkMediaStreamHandle Seek(this GtkMediaStreamHandle self, long timestamp)
	{
		GtkMediaStreamExterns.gtk_media_stream_seek(self, timestamp);
		return self;
	}

	public static GtkMediaStreamHandle SeekFailed(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_seek_failed(self);
		return self;
	}

	public static GtkMediaStreamHandle SeekSuccess(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_seek_success(self);
		return self;
	}

	public static GtkMediaStreamHandle SetLoop(this GtkMediaStreamHandle self, bool loop)
	{
		GtkMediaStreamExterns.gtk_media_stream_set_loop(self, loop);
		return self;
	}

	public static GtkMediaStreamHandle SetMuted(this GtkMediaStreamHandle self, bool muted)
	{
		GtkMediaStreamExterns.gtk_media_stream_set_muted(self, muted);
		return self;
	}

	public static GtkMediaStreamHandle SetPlaying(this GtkMediaStreamHandle self, bool playing)
	{
		GtkMediaStreamExterns.gtk_media_stream_set_playing(self, playing);
		return self;
	}

	public static GtkMediaStreamHandle SetVolume(this GtkMediaStreamHandle self, double volume)
	{
		GtkMediaStreamExterns.gtk_media_stream_set_volume(self, volume);
		return self;
	}

	public static GtkMediaStreamHandle StreamEnded(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_stream_ended(self);
		return self;
	}

	public static GtkMediaStreamHandle StreamPrepared(this GtkMediaStreamHandle self, bool has_audio, bool has_video, bool seekable, long duration)
	{
		GtkMediaStreamExterns.gtk_media_stream_stream_prepared(self, has_audio, has_video, seekable, duration);
		return self;
	}

	public static GtkMediaStreamHandle StreamUnprepared(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_stream_unprepared(self);
		return self;
	}

	public static GtkMediaStreamHandle Unprepared(this GtkMediaStreamHandle self)
	{
		GtkMediaStreamExterns.gtk_media_stream_unprepared(self);
		return self;
	}

	public static GtkMediaStreamHandle Unrealize(this GtkMediaStreamHandle self, GdkSurfaceHandle surface)
	{
		GtkMediaStreamExterns.gtk_media_stream_unrealize(self, surface);
		return self;
	}

	public static GtkMediaStreamHandle Update(this GtkMediaStreamHandle self, long timestamp)
	{
		GtkMediaStreamExterns.gtk_media_stream_update(self, timestamp);
		return self;
	}

}

internal class GtkMediaStreamExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_ended(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_error(GtkMediaStreamHandle self, GQuark domain, int code, string format, IntPtr @__arglist);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_error_valist(GtkMediaStreamHandle self, GQuark domain, int code, string format, IntPtr args);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_gerror(GtkMediaStreamHandle self, GErrorHandle error);
	[DllImport(Libraries.Gtk4)]
	internal static extern long gtk_media_stream_get_duration(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_media_stream_get_ended(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern GErrorHandle gtk_media_stream_get_error(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_media_stream_get_loop(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_media_stream_get_muted(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_media_stream_get_playing(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern long gtk_media_stream_get_timestamp(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_media_stream_get_volume(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_media_stream_has_audio(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_media_stream_has_video(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_media_stream_is_prepared(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_media_stream_is_seekable(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_media_stream_is_seeking(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_pause(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_play(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_prepared(GtkMediaStreamHandle self, bool has_audio, bool has_video, bool seekable, long duration);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_realize(GtkMediaStreamHandle self, GdkSurfaceHandle surface);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_seek(GtkMediaStreamHandle self, long timestamp);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_seek_failed(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_seek_success(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_set_loop(GtkMediaStreamHandle self, bool loop);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_set_muted(GtkMediaStreamHandle self, bool muted);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_set_playing(GtkMediaStreamHandle self, bool playing);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_set_volume(GtkMediaStreamHandle self, double volume);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_stream_ended(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_stream_prepared(GtkMediaStreamHandle self, bool has_audio, bool has_video, bool seekable, long duration);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_stream_unprepared(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_unprepared(GtkMediaStreamHandle self);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_unrealize(GtkMediaStreamHandle self, GdkSurfaceHandle surface);
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_media_stream_update(GtkMediaStreamHandle self, long timestamp);
}
