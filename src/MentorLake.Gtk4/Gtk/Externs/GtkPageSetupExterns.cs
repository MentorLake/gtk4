using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPageSetupExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_copy")]
    internal static extern GtkPageSetupHandle gtk_page_setup_copy(this GtkPageSetupHandle other);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_get_orientation")]
    internal static extern GtkPageOrientation gtk_page_setup_get_orientation(this GtkPageSetupHandle setup);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_set_orientation")]
    internal static extern void gtk_page_setup_set_orientation(this GtkPageSetupHandle setup, GtkPageOrientation orientation);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_get_paper_size")]
    internal static extern GtkPaperSizeHandle gtk_page_setup_get_paper_size(this GtkPageSetupHandle setup);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_set_paper_size")]
    internal static extern void gtk_page_setup_set_paper_size(this GtkPageSetupHandle setup, GtkPaperSizeHandle size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_get_top_margin")]
    internal static extern double gtk_page_setup_get_top_margin(this GtkPageSetupHandle setup, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_set_top_margin")]
    internal static extern void gtk_page_setup_set_top_margin(this GtkPageSetupHandle setup, double margin, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_get_bottom_margin")]
    internal static extern double gtk_page_setup_get_bottom_margin(this GtkPageSetupHandle setup, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_set_bottom_margin")]
    internal static extern void gtk_page_setup_set_bottom_margin(this GtkPageSetupHandle setup, double margin, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_get_left_margin")]
    internal static extern double gtk_page_setup_get_left_margin(this GtkPageSetupHandle setup, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_set_left_margin")]
    internal static extern void gtk_page_setup_set_left_margin(this GtkPageSetupHandle setup, double margin, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_get_right_margin")]
    internal static extern double gtk_page_setup_get_right_margin(this GtkPageSetupHandle setup, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_set_right_margin")]
    internal static extern void gtk_page_setup_set_right_margin(this GtkPageSetupHandle setup, double margin, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_set_paper_size_and_default_margins")]
    internal static extern void gtk_page_setup_set_paper_size_and_default_margins(this GtkPageSetupHandle setup, GtkPaperSizeHandle size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_get_paper_width")]
    internal static extern double gtk_page_setup_get_paper_width(this GtkPageSetupHandle setup, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_get_paper_height")]
    internal static extern double gtk_page_setup_get_paper_height(this GtkPageSetupHandle setup, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_get_page_width")]
    internal static extern double gtk_page_setup_get_page_width(this GtkPageSetupHandle setup, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_get_page_height")]
    internal static extern double gtk_page_setup_get_page_height(this GtkPageSetupHandle setup, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_load_file")]
    internal static extern int gtk_page_setup_load_file(this GtkPageSetupHandle setup, string file_name, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_to_file")]
    internal static extern int gtk_page_setup_to_file(this GtkPageSetupHandle setup, string file_name, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_load_key_file")]
    internal static extern int gtk_page_setup_load_key_file(this GtkPageSetupHandle setup, GKeyFileHandle key_file, string group_name, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_to_key_file")]
    internal static extern void gtk_page_setup_to_key_file(this GtkPageSetupHandle setup, GKeyFileHandle key_file, string group_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_page_setup_to_gvariant")]
    internal static extern GVariantHandle gtk_page_setup_to_gvariant(this GtkPageSetupHandle setup);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPageSetupHandle gtk_page_setup_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPageSetupHandle gtk_page_setup_new_from_file(string file_name, out GErrorHandle error);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPageSetupHandle gtk_page_setup_new_from_key_file(GKeyFileHandle key_file, string group_name, out GErrorHandle error);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPageSetupHandle gtk_page_setup_new_from_gvariant(GVariantHandle variant);
}
