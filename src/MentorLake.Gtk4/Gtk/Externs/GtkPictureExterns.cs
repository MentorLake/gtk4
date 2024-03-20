using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPictureExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_set_paintable")]
    internal static extern void gtk_picture_set_paintable(this GtkPictureHandle self, GdkPaintableHandle paintable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_get_paintable")]
    internal static extern GdkPaintableHandle gtk_picture_get_paintable(this GtkPictureHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_set_file")]
    internal static extern void gtk_picture_set_file(this GtkPictureHandle self, GFileHandle file);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_get_file")]
    internal static extern GFileHandle gtk_picture_get_file(this GtkPictureHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_set_filename")]
    internal static extern void gtk_picture_set_filename(this GtkPictureHandle self, string filename);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_set_resource")]
    internal static extern void gtk_picture_set_resource(this GtkPictureHandle self, string resource_path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_set_pixbuf")]
    internal static extern void gtk_picture_set_pixbuf(this GtkPictureHandle self, GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_set_keep_aspect_ratio")]
    internal static extern void gtk_picture_set_keep_aspect_ratio(this GtkPictureHandle self, int keep_aspect_ratio);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_get_keep_aspect_ratio")]
    internal static extern int gtk_picture_get_keep_aspect_ratio(this GtkPictureHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_set_can_shrink")]
    internal static extern void gtk_picture_set_can_shrink(this GtkPictureHandle self, int can_shrink);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_get_can_shrink")]
    internal static extern int gtk_picture_get_can_shrink(this GtkPictureHandle self);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_set_alternative_text")]
    internal static extern void gtk_picture_set_alternative_text(this GtkPictureHandle self, string alternative_text);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_picture_get_alternative_text")]
    internal static extern string gtk_picture_get_alternative_text(this GtkPictureHandle self);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPictureHandle gtk_picture_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPictureHandle gtk_picture_new_for_paintable(GdkPaintableHandle paintable);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPictureHandle gtk_picture_new_for_pixbuf(GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPictureHandle gtk_picture_new_for_file(GFileHandle file);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPictureHandle gtk_picture_new_for_filename(string filename);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPictureHandle gtk_picture_new_for_resource(string resource_path);
}
