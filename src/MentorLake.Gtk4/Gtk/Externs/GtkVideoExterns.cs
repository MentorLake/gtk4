using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;

namespace MentorLake.Gtk4.Gtk;
public static class GtkVideoExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_video_get_media_stream")]
    internal static extern GtkMediaStreamHandle gtk_video_get_media_stream(this GtkVideoHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_video_set_media_stream")]
    internal static extern void gtk_video_set_media_stream(this GtkVideoHandle self, GtkMediaStreamHandle stream);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_video_get_file")]
    internal static extern GFileHandle gtk_video_get_file(this GtkVideoHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_video_set_file")]
    internal static extern void gtk_video_set_file(this GtkVideoHandle self, GFileHandle file);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_video_set_filename")]
    internal static extern void gtk_video_set_filename(this GtkVideoHandle self, string filename);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_video_set_resource")]
    internal static extern void gtk_video_set_resource(this GtkVideoHandle self, string resource_path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_video_get_autoplay")]
    internal static extern int gtk_video_get_autoplay(this GtkVideoHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_video_set_autoplay")]
    internal static extern void gtk_video_set_autoplay(this GtkVideoHandle self, int autoplay);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_video_get_loop")]
    internal static extern int gtk_video_get_loop(this GtkVideoHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_video_set_loop")]
    internal static extern void gtk_video_set_loop(this GtkVideoHandle self, int loop);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkVideoHandle gtk_video_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkVideoHandle gtk_video_new_for_file(GFileHandle file);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkVideoHandle gtk_video_new_for_filename(string filename);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkVideoHandle gtk_video_new_for_resource(string resource_path);
}
