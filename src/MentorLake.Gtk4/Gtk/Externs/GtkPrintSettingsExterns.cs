using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPrintSettingsExterns
{
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_copy")]
    internal static extern GtkPrintSettingsHandle gtk_print_settings_copy(this GtkPrintSettingsHandle other);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_load_file")]
    internal static extern int gtk_print_settings_load_file(this GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_to_file")]
    internal static extern int gtk_print_settings_to_file(this GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_load_key_file")]
    internal static extern int gtk_print_settings_load_key_file(this GtkPrintSettingsHandle settings, GKeyFileHandle key_file, string group_name, out GErrorHandle error);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_to_key_file")]
    internal static extern void gtk_print_settings_to_key_file(this GtkPrintSettingsHandle settings, GKeyFileHandle key_file, string group_name);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_has_key")]
    internal static extern int gtk_print_settings_has_key(this GtkPrintSettingsHandle settings, string key);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get")]
    internal static extern string gtk_print_settings_get(this GtkPrintSettingsHandle settings, string key);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set")]
    internal static extern void gtk_print_settings_set(this GtkPrintSettingsHandle settings, string key, string value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_unset")]
    internal static extern void gtk_print_settings_unset(this GtkPrintSettingsHandle settings, string key);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_foreach")]
    internal static extern void gtk_print_settings_foreach(this GtkPrintSettingsHandle settings, GtkPrintSettingsFunc func, IntPtr user_data);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_bool")]
    internal static extern int gtk_print_settings_get_bool(this GtkPrintSettingsHandle settings, string key);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_bool")]
    internal static extern void gtk_print_settings_set_bool(this GtkPrintSettingsHandle settings, string key, int value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_double")]
    internal static extern double gtk_print_settings_get_double(this GtkPrintSettingsHandle settings, string key);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_double_with_default")]
    internal static extern double gtk_print_settings_get_double_with_default(this GtkPrintSettingsHandle settings, string key, double def);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_double")]
    internal static extern void gtk_print_settings_set_double(this GtkPrintSettingsHandle settings, string key, double value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_length")]
    internal static extern double gtk_print_settings_get_length(this GtkPrintSettingsHandle settings, string key, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_length")]
    internal static extern void gtk_print_settings_set_length(this GtkPrintSettingsHandle settings, string key, double value, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_int")]
    internal static extern int gtk_print_settings_get_int(this GtkPrintSettingsHandle settings, string key);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_int_with_default")]
    internal static extern int gtk_print_settings_get_int_with_default(this GtkPrintSettingsHandle settings, string key, int def);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_int")]
    internal static extern void gtk_print_settings_set_int(this GtkPrintSettingsHandle settings, string key, int value);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_printer")]
    internal static extern string gtk_print_settings_get_printer(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_printer")]
    internal static extern void gtk_print_settings_set_printer(this GtkPrintSettingsHandle settings, string printer);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_orientation")]
    internal static extern GtkPageOrientation gtk_print_settings_get_orientation(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_orientation")]
    internal static extern void gtk_print_settings_set_orientation(this GtkPrintSettingsHandle settings, GtkPageOrientation orientation);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_paper_size")]
    internal static extern GtkPaperSizeHandle gtk_print_settings_get_paper_size(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_paper_size")]
    internal static extern void gtk_print_settings_set_paper_size(this GtkPrintSettingsHandle settings, GtkPaperSizeHandle paper_size);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_paper_width")]
    internal static extern double gtk_print_settings_get_paper_width(this GtkPrintSettingsHandle settings, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_paper_width")]
    internal static extern void gtk_print_settings_set_paper_width(this GtkPrintSettingsHandle settings, double width, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_paper_height")]
    internal static extern double gtk_print_settings_get_paper_height(this GtkPrintSettingsHandle settings, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_paper_height")]
    internal static extern void gtk_print_settings_set_paper_height(this GtkPrintSettingsHandle settings, double height, GtkUnit unit);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_use_color")]
    internal static extern int gtk_print_settings_get_use_color(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_use_color")]
    internal static extern void gtk_print_settings_set_use_color(this GtkPrintSettingsHandle settings, int use_color);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_collate")]
    internal static extern int gtk_print_settings_get_collate(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_collate")]
    internal static extern void gtk_print_settings_set_collate(this GtkPrintSettingsHandle settings, int collate);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_reverse")]
    internal static extern int gtk_print_settings_get_reverse(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_reverse")]
    internal static extern void gtk_print_settings_set_reverse(this GtkPrintSettingsHandle settings, int reverse);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_duplex")]
    internal static extern GtkPrintDuplex gtk_print_settings_get_duplex(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_duplex")]
    internal static extern void gtk_print_settings_set_duplex(this GtkPrintSettingsHandle settings, GtkPrintDuplex duplex);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_quality")]
    internal static extern GtkPrintQuality gtk_print_settings_get_quality(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_quality")]
    internal static extern void gtk_print_settings_set_quality(this GtkPrintSettingsHandle settings, GtkPrintQuality quality);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_n_copies")]
    internal static extern int gtk_print_settings_get_n_copies(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_n_copies")]
    internal static extern void gtk_print_settings_set_n_copies(this GtkPrintSettingsHandle settings, int num_copies);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_number_up")]
    internal static extern int gtk_print_settings_get_number_up(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_number_up")]
    internal static extern void gtk_print_settings_set_number_up(this GtkPrintSettingsHandle settings, int number_up);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_number_up_layout")]
    internal static extern GtkNumberUpLayout gtk_print_settings_get_number_up_layout(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_number_up_layout")]
    internal static extern void gtk_print_settings_set_number_up_layout(this GtkPrintSettingsHandle settings, GtkNumberUpLayout number_up_layout);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_resolution")]
    internal static extern int gtk_print_settings_get_resolution(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_resolution")]
    internal static extern void gtk_print_settings_set_resolution(this GtkPrintSettingsHandle settings, int resolution);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_resolution_x")]
    internal static extern int gtk_print_settings_get_resolution_x(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_resolution_y")]
    internal static extern int gtk_print_settings_get_resolution_y(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_resolution_xy")]
    internal static extern void gtk_print_settings_set_resolution_xy(this GtkPrintSettingsHandle settings, int resolution_x, int resolution_y);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_printer_lpi")]
    internal static extern double gtk_print_settings_get_printer_lpi(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_printer_lpi")]
    internal static extern void gtk_print_settings_set_printer_lpi(this GtkPrintSettingsHandle settings, double lpi);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_scale")]
    internal static extern double gtk_print_settings_get_scale(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_scale")]
    internal static extern void gtk_print_settings_set_scale(this GtkPrintSettingsHandle settings, double scale);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_print_pages")]
    internal static extern GtkPrintPages gtk_print_settings_get_print_pages(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_print_pages")]
    internal static extern void gtk_print_settings_set_print_pages(this GtkPrintSettingsHandle settings, GtkPrintPages pages);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_page_ranges")]
    internal static extern GtkPageRangeHandle gtk_print_settings_get_page_ranges(this GtkPrintSettingsHandle settings, out int num_ranges);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_page_ranges")]
    internal static extern void gtk_print_settings_set_page_ranges(this GtkPrintSettingsHandle settings, GtkPageRangeHandle page_ranges, int num_ranges);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_page_set")]
    internal static extern GtkPageSet gtk_print_settings_get_page_set(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_page_set")]
    internal static extern void gtk_print_settings_set_page_set(this GtkPrintSettingsHandle settings, GtkPageSet page_set);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_default_source")]
    internal static extern string gtk_print_settings_get_default_source(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_default_source")]
    internal static extern void gtk_print_settings_set_default_source(this GtkPrintSettingsHandle settings, string default_source);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_media_type")]
    internal static extern string gtk_print_settings_get_media_type(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_media_type")]
    internal static extern void gtk_print_settings_set_media_type(this GtkPrintSettingsHandle settings, string media_type);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_dither")]
    internal static extern string gtk_print_settings_get_dither(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_dither")]
    internal static extern void gtk_print_settings_set_dither(this GtkPrintSettingsHandle settings, string dither);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_finishings")]
    internal static extern string gtk_print_settings_get_finishings(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_finishings")]
    internal static extern void gtk_print_settings_set_finishings(this GtkPrintSettingsHandle settings, string finishings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_get_output_bin")]
    internal static extern string gtk_print_settings_get_output_bin(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_set_output_bin")]
    internal static extern void gtk_print_settings_set_output_bin(this GtkPrintSettingsHandle settings, string output_bin);
    [DllImport(Libraries.Gtk, EntryPoint = "gtk_print_settings_to_gvariant")]
    internal static extern GVariantHandle gtk_print_settings_to_gvariant(this GtkPrintSettingsHandle settings);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPrintSettingsHandle gtk_print_settings_new();
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPrintSettingsHandle gtk_print_settings_new_from_file(string file_name, out GErrorHandle error);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPrintSettingsHandle gtk_print_settings_new_from_key_file(GKeyFileHandle key_file, string group_name, out GErrorHandle error);
    [DllImport(Libraries.Gtk, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern GtkPrintSettingsHandle gtk_print_settings_new_from_gvariant(GVariantHandle variant);
}
