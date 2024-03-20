using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkMediaStreamExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_is_prepared")]
    internal static extern int gtk_media_stream_is_prepared(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_get_error")]
    internal static extern GErrorHandle gtk_media_stream_get_error(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_has_audio")]
    internal static extern int gtk_media_stream_has_audio(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_has_video")]
    internal static extern int gtk_media_stream_has_video(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_play")]
    internal static extern void gtk_media_stream_play(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_pause")]
    internal static extern void gtk_media_stream_pause(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_get_playing")]
    internal static extern int gtk_media_stream_get_playing(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_set_playing")]
    internal static extern void gtk_media_stream_set_playing(this GtkMediaStreamHandle self, int playing);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_get_ended")]
    internal static extern int gtk_media_stream_get_ended(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_get_timestamp")]
    internal static extern nint gtk_media_stream_get_timestamp(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_get_duration")]
    internal static extern nint gtk_media_stream_get_duration(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_is_seekable")]
    internal static extern int gtk_media_stream_is_seekable(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_is_seeking")]
    internal static extern int gtk_media_stream_is_seeking(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_seek")]
    internal static extern void gtk_media_stream_seek(this GtkMediaStreamHandle self, nint timestamp);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_get_loop")]
    internal static extern int gtk_media_stream_get_loop(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_set_loop")]
    internal static extern void gtk_media_stream_set_loop(this GtkMediaStreamHandle self, int loop);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_get_muted")]
    internal static extern int gtk_media_stream_get_muted(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_set_muted")]
    internal static extern void gtk_media_stream_set_muted(this GtkMediaStreamHandle self, int muted);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_get_volume")]
    internal static extern double gtk_media_stream_get_volume(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_set_volume")]
    internal static extern void gtk_media_stream_set_volume(this GtkMediaStreamHandle self, double volume);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_realize")]
    internal static extern void gtk_media_stream_realize(this GtkMediaStreamHandle self, GdkSurfaceHandle surface);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_unrealize")]
    internal static extern void gtk_media_stream_unrealize(this GtkMediaStreamHandle self, GdkSurfaceHandle surface);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_prepared")]
    [Obsolete]
    internal static extern void gtk_media_stream_prepared(this GtkMediaStreamHandle self, int has_audio, int has_video, int seekable, nint duration);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_unprepared")]
    [Obsolete]
    internal static extern void gtk_media_stream_unprepared(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_stream_prepared")]
    internal static extern void gtk_media_stream_stream_prepared(this GtkMediaStreamHandle self, int has_audio, int has_video, int seekable, nint duration);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_stream_unprepared")]
    internal static extern void gtk_media_stream_stream_unprepared(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_update")]
    internal static extern void gtk_media_stream_update(this GtkMediaStreamHandle self, nint timestamp);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_ended")]
    [Obsolete]
    internal static extern void gtk_media_stream_ended(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_stream_ended")]
    internal static extern void gtk_media_stream_stream_ended(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_seek_success")]
    internal static extern void gtk_media_stream_seek_success(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_seek_failed")]
    internal static extern void gtk_media_stream_seek_failed(this GtkMediaStreamHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_gerror")]
    internal static extern void gtk_media_stream_gerror(this GtkMediaStreamHandle self, GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_error")]
    internal static extern void gtk_media_stream_error(this GtkMediaStreamHandle self, GQuark domain, int code, string format, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_stream_error_valist")]
    internal static extern void gtk_media_stream_error_valist(this GtkMediaStreamHandle self, GQuark domain, int code, string format, IntPtr @__argList);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_media_controls_new")]
    internal static extern GtkMediaControlsHandle gtk_media_controls_new(this GtkMediaStreamHandle stream);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_video_new_for_media_stream")]
    internal static extern GtkVideoHandle gtk_video_new_for_media_stream(this GtkMediaStreamHandle stream);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkMediaStreamHandle gtk_media_file_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkMediaStreamHandle gtk_media_file_new_for_filename(string filename);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkMediaStreamHandle gtk_media_file_new_for_resource(string resource_path);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkMediaStreamHandle gtk_media_file_new_for_file(GFileHandle file);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkMediaStreamHandle gtk_media_file_new_for_input_stream(GInputStreamHandle stream);
}
