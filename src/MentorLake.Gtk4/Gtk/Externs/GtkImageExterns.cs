using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.Pixbuf;

namespace MentorLake.Gtk4.Gtk;
public static class GtkImageExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_clear")]
    internal static extern void gtk_image_clear(this GtkImageHandle image);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_set_from_file")]
    internal static extern void gtk_image_set_from_file(this GtkImageHandle image, string filename);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_set_from_resource")]
    internal static extern void gtk_image_set_from_resource(this GtkImageHandle image, string resource_path);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_set_from_pixbuf")]
    internal static extern void gtk_image_set_from_pixbuf(this GtkImageHandle image, GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_set_from_paintable")]
    internal static extern void gtk_image_set_from_paintable(this GtkImageHandle image, GdkPaintableHandle paintable);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_set_from_icon_name")]
    internal static extern void gtk_image_set_from_icon_name(this GtkImageHandle image, string icon_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_set_from_gicon")]
    internal static extern void gtk_image_set_from_gicon(this GtkImageHandle image, GIconHandle icon);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_set_pixel_size")]
    internal static extern void gtk_image_set_pixel_size(this GtkImageHandle image, int pixel_size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_set_icon_size")]
    internal static extern void gtk_image_set_icon_size(this GtkImageHandle image, GtkIconSize icon_size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_get_storage_type")]
    internal static extern GtkImageType gtk_image_get_storage_type(this GtkImageHandle image);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_get_paintable")]
    internal static extern GdkPaintableHandle gtk_image_get_paintable(this GtkImageHandle image);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_get_icon_name")]
    internal static extern string gtk_image_get_icon_name(this GtkImageHandle image);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_get_gicon")]
    internal static extern GIconHandle gtk_image_get_gicon(this GtkImageHandle image);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_get_pixel_size")]
    internal static extern int gtk_image_get_pixel_size(this GtkImageHandle image);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_image_get_icon_size")]
    internal static extern GtkIconSize gtk_image_get_icon_size(this GtkImageHandle image);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkImageHandle gtk_image_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkImageHandle gtk_image_new_from_file(string filename);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkImageHandle gtk_image_new_from_resource(string resource_path);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkImageHandle gtk_image_new_from_pixbuf(GdkPixbufHandle pixbuf);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkImageHandle gtk_image_new_from_paintable(GdkPaintableHandle paintable);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkImageHandle gtk_image_new_from_icon_name(string icon_name);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkImageHandle gtk_image_new_from_gicon(GIconHandle icon);
}
