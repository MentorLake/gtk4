using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkPrintSettingsHandle : GObjectHandle
{
	public static GtkPrintSettingsHandle New()
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new();
	}

	public static GtkPrintSettingsHandle NewFromFile(string file_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_file(file_name, out error);
	}

	public static GtkPrintSettingsHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_gvariant(variant);
	}

	public static GtkPrintSettingsHandle NewFromKeyFile(GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_key_file(key_file, group_name, out error);
	}

}

public static class GtkPrintSettingsHandleExtensions
{
	public static GtkPrintSettingsHandle Copy(this GtkPrintSettingsHandle other)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_copy(other);
	}

	public static GtkPrintSettingsHandle Foreach(this GtkPrintSettingsHandle settings, GtkPrintSettingsFunc func, IntPtr user_data)
	{
		GtkPrintSettingsExterns.gtk_print_settings_foreach(settings, func, user_data);
		return settings;
	}

	public static string Get(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get(settings, key);
	}

	public static bool GetBool(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_bool(settings, key);
	}

	public static bool GetCollate(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_collate(settings);
	}

	public static string GetDefaultSource(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_default_source(settings);
	}

	public static string GetDither(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_dither(settings);
	}

	public static double GetDouble(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_double(settings, key);
	}

	public static double GetDoubleWithDefault(this GtkPrintSettingsHandle settings, string key, double def)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_double_with_default(settings, key, def);
	}

	public static GtkPrintDuplex GetDuplex(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_duplex(settings);
	}

	public static string GetFinishings(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_finishings(settings);
	}

	public static int GetInt(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_int(settings, key);
	}

	public static int GetIntWithDefault(this GtkPrintSettingsHandle settings, string key, int def)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_int_with_default(settings, key, def);
	}

	public static double GetLength(this GtkPrintSettingsHandle settings, string key, GtkUnit unit)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_length(settings, key, unit);
	}

	public static string GetMediaType(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_media_type(settings);
	}

	public static int GetNCopies(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_n_copies(settings);
	}

	public static int GetNumberUp(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_number_up(settings);
	}

	public static GtkNumberUpLayout GetNumberUpLayout(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_number_up_layout(settings);
	}

	public static GtkPageOrientation GetOrientation(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_orientation(settings);
	}

	public static string GetOutputBin(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_output_bin(settings);
	}

	public static GtkPageRange[] GetPageRanges(this GtkPrintSettingsHandle settings, out int num_ranges)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_page_ranges(settings, out num_ranges);
	}

	public static GtkPageSet GetPageSet(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_page_set(settings);
	}

	public static double GetPaperHeight(this GtkPrintSettingsHandle settings, GtkUnit unit)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_paper_height(settings, unit);
	}

	public static GtkPaperSizeHandle GetPaperSize(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_paper_size(settings);
	}

	public static double GetPaperWidth(this GtkPrintSettingsHandle settings, GtkUnit unit)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_paper_width(settings, unit);
	}

	public static GtkPrintPages GetPrintPages(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_print_pages(settings);
	}

	public static string GetPrinter(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_printer(settings);
	}

	public static double GetPrinterLpi(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_printer_lpi(settings);
	}

	public static GtkPrintQuality GetQuality(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_quality(settings);
	}

	public static int GetResolution(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_resolution(settings);
	}

	public static int GetResolutionX(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_resolution_x(settings);
	}

	public static int GetResolutionY(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_resolution_y(settings);
	}

	public static bool GetReverse(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_reverse(settings);
	}

	public static double GetScale(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_scale(settings);
	}

	public static bool GetUseColor(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_use_color(settings);
	}

	public static bool HasKey(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_has_key(settings, key);
	}

	public static bool LoadFile(this GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_load_file(settings, file_name, out error);
	}

	public static bool LoadKeyFile(this GtkPrintSettingsHandle settings, GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_load_key_file(settings, key_file, group_name, out error);
	}

	public static GtkPrintSettingsHandle Set(this GtkPrintSettingsHandle settings, string key, string value)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set(settings, key, value);
		return settings;
	}

	public static GtkPrintSettingsHandle SetBool(this GtkPrintSettingsHandle settings, string key, bool value)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_bool(settings, key, value);
		return settings;
	}

	public static GtkPrintSettingsHandle SetCollate(this GtkPrintSettingsHandle settings, bool collate)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_collate(settings, collate);
		return settings;
	}

	public static GtkPrintSettingsHandle SetDefaultSource(this GtkPrintSettingsHandle settings, string default_source)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_default_source(settings, default_source);
		return settings;
	}

	public static GtkPrintSettingsHandle SetDither(this GtkPrintSettingsHandle settings, string dither)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_dither(settings, dither);
		return settings;
	}

	public static GtkPrintSettingsHandle SetDouble(this GtkPrintSettingsHandle settings, string key, double value)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_double(settings, key, value);
		return settings;
	}

	public static GtkPrintSettingsHandle SetDuplex(this GtkPrintSettingsHandle settings, GtkPrintDuplex duplex)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_duplex(settings, duplex);
		return settings;
	}

	public static GtkPrintSettingsHandle SetFinishings(this GtkPrintSettingsHandle settings, string finishings)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_finishings(settings, finishings);
		return settings;
	}

	public static GtkPrintSettingsHandle SetInt(this GtkPrintSettingsHandle settings, string key, int value)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_int(settings, key, value);
		return settings;
	}

	public static GtkPrintSettingsHandle SetLength(this GtkPrintSettingsHandle settings, string key, double value, GtkUnit unit)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_length(settings, key, value, unit);
		return settings;
	}

	public static GtkPrintSettingsHandle SetMediaType(this GtkPrintSettingsHandle settings, string media_type)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_media_type(settings, media_type);
		return settings;
	}

	public static GtkPrintSettingsHandle SetNCopies(this GtkPrintSettingsHandle settings, int num_copies)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_n_copies(settings, num_copies);
		return settings;
	}

	public static GtkPrintSettingsHandle SetNumberUp(this GtkPrintSettingsHandle settings, int number_up)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_number_up(settings, number_up);
		return settings;
	}

	public static GtkPrintSettingsHandle SetNumberUpLayout(this GtkPrintSettingsHandle settings, GtkNumberUpLayout number_up_layout)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_number_up_layout(settings, number_up_layout);
		return settings;
	}

	public static GtkPrintSettingsHandle SetOrientation(this GtkPrintSettingsHandle settings, GtkPageOrientation orientation)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_orientation(settings, orientation);
		return settings;
	}

	public static GtkPrintSettingsHandle SetOutputBin(this GtkPrintSettingsHandle settings, string output_bin)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_output_bin(settings, output_bin);
		return settings;
	}

	public static GtkPrintSettingsHandle SetPageRanges(this GtkPrintSettingsHandle settings, GtkPageRange[] page_ranges, int num_ranges)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_page_ranges(settings, page_ranges, num_ranges);
		return settings;
	}

	public static GtkPrintSettingsHandle SetPageSet(this GtkPrintSettingsHandle settings, GtkPageSet page_set)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_page_set(settings, page_set);
		return settings;
	}

	public static GtkPrintSettingsHandle SetPaperHeight(this GtkPrintSettingsHandle settings, double height, GtkUnit unit)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_paper_height(settings, height, unit);
		return settings;
	}

	public static GtkPrintSettingsHandle SetPaperSize(this GtkPrintSettingsHandle settings, GtkPaperSizeHandle paper_size)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_paper_size(settings, paper_size);
		return settings;
	}

	public static GtkPrintSettingsHandle SetPaperWidth(this GtkPrintSettingsHandle settings, double width, GtkUnit unit)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_paper_width(settings, width, unit);
		return settings;
	}

	public static GtkPrintSettingsHandle SetPrintPages(this GtkPrintSettingsHandle settings, GtkPrintPages pages)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_print_pages(settings, pages);
		return settings;
	}

	public static GtkPrintSettingsHandle SetPrinter(this GtkPrintSettingsHandle settings, string printer)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_printer(settings, printer);
		return settings;
	}

	public static GtkPrintSettingsHandle SetPrinterLpi(this GtkPrintSettingsHandle settings, double lpi)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_printer_lpi(settings, lpi);
		return settings;
	}

	public static GtkPrintSettingsHandle SetQuality(this GtkPrintSettingsHandle settings, GtkPrintQuality quality)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_quality(settings, quality);
		return settings;
	}

	public static GtkPrintSettingsHandle SetResolution(this GtkPrintSettingsHandle settings, int resolution)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_resolution(settings, resolution);
		return settings;
	}

	public static GtkPrintSettingsHandle SetResolutionXy(this GtkPrintSettingsHandle settings, int resolution_x, int resolution_y)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_resolution_xy(settings, resolution_x, resolution_y);
		return settings;
	}

	public static GtkPrintSettingsHandle SetReverse(this GtkPrintSettingsHandle settings, bool reverse)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_reverse(settings, reverse);
		return settings;
	}

	public static GtkPrintSettingsHandle SetScale(this GtkPrintSettingsHandle settings, double scale)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_scale(settings, scale);
		return settings;
	}

	public static GtkPrintSettingsHandle SetUseColor(this GtkPrintSettingsHandle settings, bool use_color)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_use_color(settings, use_color);
		return settings;
	}

	public static bool ToFile(this GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_to_file(settings, file_name, out error);
	}

	public static GVariantHandle ToGvariant(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_to_gvariant(settings);
	}

	public static GtkPrintSettingsHandle ToKeyFile(this GtkPrintSettingsHandle settings, GKeyFileHandle key_file, string group_name)
	{
		GtkPrintSettingsExterns.gtk_print_settings_to_key_file(settings, key_file, group_name);
		return settings;
	}

	public static GtkPrintSettingsHandle Unset(this GtkPrintSettingsHandle settings, string key)
	{
		GtkPrintSettingsExterns.gtk_print_settings_unset(settings, key);
		return settings;
	}

}

internal class GtkPrintSettingsExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_print_settings_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_print_settings_new_from_file(string file_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_print_settings_new_from_gvariant(GVariantHandle variant);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_print_settings_new_from_key_file(GKeyFileHandle key_file, string group_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintSettingsHandle gtk_print_settings_copy(GtkPrintSettingsHandle other);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_foreach(GtkPrintSettingsHandle settings, GtkPrintSettingsFunc func, IntPtr user_data);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get(GtkPrintSettingsHandle settings, string key);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_settings_get_bool(GtkPrintSettingsHandle settings, string key);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_settings_get_collate(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_default_source(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_dither(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_settings_get_double(GtkPrintSettingsHandle settings, string key);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_settings_get_double_with_default(GtkPrintSettingsHandle settings, string key, double def);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintDuplex gtk_print_settings_get_duplex(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_finishings(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_print_settings_get_int(GtkPrintSettingsHandle settings, string key);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_print_settings_get_int_with_default(GtkPrintSettingsHandle settings, string key, int def);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_settings_get_length(GtkPrintSettingsHandle settings, string key, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_media_type(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_print_settings_get_n_copies(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_print_settings_get_number_up(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkNumberUpLayout gtk_print_settings_get_number_up_layout(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageOrientation gtk_print_settings_get_orientation(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_output_bin(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageRange[] gtk_print_settings_get_page_ranges(GtkPrintSettingsHandle settings, out int num_ranges);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSet gtk_print_settings_get_page_set(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_settings_get_paper_height(GtkPrintSettingsHandle settings, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPaperSizeHandle gtk_print_settings_get_paper_size(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_settings_get_paper_width(GtkPrintSettingsHandle settings, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintPages gtk_print_settings_get_print_pages(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_settings_get_printer(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_settings_get_printer_lpi(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPrintQuality gtk_print_settings_get_quality(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_print_settings_get_resolution(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_print_settings_get_resolution_x(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern int gtk_print_settings_get_resolution_y(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_settings_get_reverse(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_print_settings_get_scale(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_settings_get_use_color(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_settings_has_key(GtkPrintSettingsHandle settings, string key);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_settings_load_file(GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_settings_load_key_file(GtkPrintSettingsHandle settings, GKeyFileHandle key_file, string group_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set(GtkPrintSettingsHandle settings, string key, string value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_bool(GtkPrintSettingsHandle settings, string key, bool value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_collate(GtkPrintSettingsHandle settings, bool collate);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_default_source(GtkPrintSettingsHandle settings, string default_source);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_dither(GtkPrintSettingsHandle settings, string dither);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_double(GtkPrintSettingsHandle settings, string key, double value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_duplex(GtkPrintSettingsHandle settings, GtkPrintDuplex duplex);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_finishings(GtkPrintSettingsHandle settings, string finishings);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_int(GtkPrintSettingsHandle settings, string key, int value);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_length(GtkPrintSettingsHandle settings, string key, double value, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_media_type(GtkPrintSettingsHandle settings, string media_type);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_n_copies(GtkPrintSettingsHandle settings, int num_copies);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_number_up(GtkPrintSettingsHandle settings, int number_up);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_number_up_layout(GtkPrintSettingsHandle settings, GtkNumberUpLayout number_up_layout);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_orientation(GtkPrintSettingsHandle settings, GtkPageOrientation orientation);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_output_bin(GtkPrintSettingsHandle settings, string output_bin);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_page_ranges(GtkPrintSettingsHandle settings, GtkPageRange[] page_ranges, int num_ranges);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_page_set(GtkPrintSettingsHandle settings, GtkPageSet page_set);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_paper_height(GtkPrintSettingsHandle settings, double height, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_paper_size(GtkPrintSettingsHandle settings, GtkPaperSizeHandle paper_size);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_paper_width(GtkPrintSettingsHandle settings, double width, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_print_pages(GtkPrintSettingsHandle settings, GtkPrintPages pages);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_printer(GtkPrintSettingsHandle settings, string printer);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_printer_lpi(GtkPrintSettingsHandle settings, double lpi);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_quality(GtkPrintSettingsHandle settings, GtkPrintQuality quality);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_resolution(GtkPrintSettingsHandle settings, int resolution);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_resolution_xy(GtkPrintSettingsHandle settings, int resolution_x, int resolution_y);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_reverse(GtkPrintSettingsHandle settings, bool reverse);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_scale(GtkPrintSettingsHandle settings, double scale);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_set_use_color(GtkPrintSettingsHandle settings, bool use_color);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_print_settings_to_file(GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern GVariantHandle gtk_print_settings_to_gvariant(GtkPrintSettingsHandle settings);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_to_key_file(GtkPrintSettingsHandle settings, GKeyFileHandle key_file, string group_name);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_print_settings_unset(GtkPrintSettingsHandle settings, string key);

}
