using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPaperSizeExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_copy")]
    internal static extern GtkPaperSizeHandle gtk_paper_size_copy(this GtkPaperSizeHandle other);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_free")]
    internal static extern void gtk_paper_size_free(this GtkPaperSizeHandle size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_is_equal")]
    internal static extern int gtk_paper_size_is_equal(this GtkPaperSizeHandle size1, GtkPaperSizeHandle size2);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_get_name")]
    internal static extern string gtk_paper_size_get_name(this GtkPaperSizeHandle size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_get_display_name")]
    internal static extern string gtk_paper_size_get_display_name(this GtkPaperSizeHandle size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_get_ppd_name")]
    internal static extern string gtk_paper_size_get_ppd_name(this GtkPaperSizeHandle size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_get_width")]
    internal static extern double gtk_paper_size_get_width(this GtkPaperSizeHandle size, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_get_height")]
    internal static extern double gtk_paper_size_get_height(this GtkPaperSizeHandle size, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_is_custom")]
    internal static extern int gtk_paper_size_is_custom(this GtkPaperSizeHandle size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_is_ipp")]
    internal static extern int gtk_paper_size_is_ipp(this GtkPaperSizeHandle size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_set_size")]
    internal static extern void gtk_paper_size_set_size(this GtkPaperSizeHandle size, double width, double height, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_get_default_top_margin")]
    internal static extern double gtk_paper_size_get_default_top_margin(this GtkPaperSizeHandle size, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_get_default_bottom_margin")]
    internal static extern double gtk_paper_size_get_default_bottom_margin(this GtkPaperSizeHandle size, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_get_default_left_margin")]
    internal static extern double gtk_paper_size_get_default_left_margin(this GtkPaperSizeHandle size, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_get_default_right_margin")]
    internal static extern double gtk_paper_size_get_default_right_margin(this GtkPaperSizeHandle size, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_to_key_file")]
    internal static extern void gtk_paper_size_to_key_file(this GtkPaperSizeHandle size, GKeyFileHandle key_file, string group_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_paper_size_to_gvariant")]
    internal static extern GVariantHandle gtk_paper_size_to_gvariant(this GtkPaperSizeHandle paper_size);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPaperSizeHandle gtk_paper_size_new(string name);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_ppd(string ppd_name, string ppd_display_name, double width, double height);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_ipp(string ipp_name, double width, double height);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPaperSizeHandle gtk_paper_size_new_custom(string name, string display_name, double width, double height, GtkUnit unit);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_key_file(GKeyFileHandle key_file, string group_name, out GErrorHandle error);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_gvariant(GVariantHandle variant);
}
