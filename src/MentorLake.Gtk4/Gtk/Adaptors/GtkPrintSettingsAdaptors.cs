using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPrintSettingsAdaptors
{
	public static GtkPrintSettingsHandle Copy(this GtkPrintSettingsHandle other)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_copy(other);
	}

	public static int LoadFile(this GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_load_file(settings, file_name, out error);
	}

	public static int ToFile(this GtkPrintSettingsHandle settings, string file_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_to_file(settings, file_name, out error);
	}

	public static int LoadKeyFile(this GtkPrintSettingsHandle settings, GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_load_key_file(settings, key_file, group_name, out error);
	}

	public static GtkPrintSettingsHandle ToKeyFile(this GtkPrintSettingsHandle settings, GKeyFileHandle key_file, string group_name)
	{
		GtkPrintSettingsExterns.gtk_print_settings_to_key_file(settings, key_file, group_name);
		return settings;
	}

	public static int HasKey(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_has_key(settings, key);
	}

	public static string Get(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get(settings, key);
	}

	public static GtkPrintSettingsHandle Set(this GtkPrintSettingsHandle settings, string key, string value)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set(settings, key, value);
		return settings;
	}

	public static GtkPrintSettingsHandle Unset(this GtkPrintSettingsHandle settings, string key)
	{
		GtkPrintSettingsExterns.gtk_print_settings_unset(settings, key);
		return settings;
	}

	public static GtkPrintSettingsHandle Foreach(this GtkPrintSettingsHandle settings, GtkPrintSettingsFunc func, IntPtr user_data)
	{
		GtkPrintSettingsExterns.gtk_print_settings_foreach(settings, func, user_data);
		return settings;
	}

	public static int GetBool(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_bool(settings, key);
	}

	public static GtkPrintSettingsHandle SetBool(this GtkPrintSettingsHandle settings, string key, int value)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_bool(settings, key, value);
		return settings;
	}

	public static double GetDouble(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_double(settings, key);
	}

	public static double GetDoubleWithDefault(this GtkPrintSettingsHandle settings, string key, double def)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_double_with_default(settings, key, def);
	}

	public static GtkPrintSettingsHandle SetDouble(this GtkPrintSettingsHandle settings, string key, double value)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_double(settings, key, value);
		return settings;
	}

	public static double GetLength(this GtkPrintSettingsHandle settings, string key, GtkUnit unit)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_length(settings, key, unit);
	}

	public static GtkPrintSettingsHandle SetLength(this GtkPrintSettingsHandle settings, string key, double value, GtkUnit unit)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_length(settings, key, value, unit);
		return settings;
	}

	public static int GetInt(this GtkPrintSettingsHandle settings, string key)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_int(settings, key);
	}

	public static int GetIntWithDefault(this GtkPrintSettingsHandle settings, string key, int def)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_int_with_default(settings, key, def);
	}

	public static GtkPrintSettingsHandle SetInt(this GtkPrintSettingsHandle settings, string key, int value)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_int(settings, key, value);
		return settings;
	}

	public static string GetPrinter(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_printer(settings);
	}

	public static GtkPrintSettingsHandle SetPrinter(this GtkPrintSettingsHandle settings, string printer)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_printer(settings, printer);
		return settings;
	}

	public static GtkPageOrientation GetOrientation(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_orientation(settings);
	}

	public static GtkPrintSettingsHandle SetOrientation(this GtkPrintSettingsHandle settings, GtkPageOrientation orientation)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_orientation(settings, orientation);
		return settings;
	}

	public static GtkPaperSizeHandle GetPaperSize(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_paper_size(settings);
	}

	public static GtkPrintSettingsHandle SetPaperSize(this GtkPrintSettingsHandle settings, GtkPaperSizeHandle paper_size)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_paper_size(settings, paper_size);
		return settings;
	}

	public static double GetPaperWidth(this GtkPrintSettingsHandle settings, GtkUnit unit)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_paper_width(settings, unit);
	}

	public static GtkPrintSettingsHandle SetPaperWidth(this GtkPrintSettingsHandle settings, double width, GtkUnit unit)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_paper_width(settings, width, unit);
		return settings;
	}

	public static double GetPaperHeight(this GtkPrintSettingsHandle settings, GtkUnit unit)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_paper_height(settings, unit);
	}

	public static GtkPrintSettingsHandle SetPaperHeight(this GtkPrintSettingsHandle settings, double height, GtkUnit unit)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_paper_height(settings, height, unit);
		return settings;
	}

	public static int GetUseColor(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_use_color(settings);
	}

	public static GtkPrintSettingsHandle SetUseColor(this GtkPrintSettingsHandle settings, int use_color)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_use_color(settings, use_color);
		return settings;
	}

	public static int GetCollate(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_collate(settings);
	}

	public static GtkPrintSettingsHandle SetCollate(this GtkPrintSettingsHandle settings, int collate)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_collate(settings, collate);
		return settings;
	}

	public static int GetReverse(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_reverse(settings);
	}

	public static GtkPrintSettingsHandle SetReverse(this GtkPrintSettingsHandle settings, int reverse)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_reverse(settings, reverse);
		return settings;
	}

	public static GtkPrintDuplex GetDuplex(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_duplex(settings);
	}

	public static GtkPrintSettingsHandle SetDuplex(this GtkPrintSettingsHandle settings, GtkPrintDuplex duplex)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_duplex(settings, duplex);
		return settings;
	}

	public static GtkPrintQuality GetQuality(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_quality(settings);
	}

	public static GtkPrintSettingsHandle SetQuality(this GtkPrintSettingsHandle settings, GtkPrintQuality quality)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_quality(settings, quality);
		return settings;
	}

	public static int GetNCopies(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_n_copies(settings);
	}

	public static GtkPrintSettingsHandle SetNCopies(this GtkPrintSettingsHandle settings, int num_copies)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_n_copies(settings, num_copies);
		return settings;
	}

	public static int GetNumberUp(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_number_up(settings);
	}

	public static GtkPrintSettingsHandle SetNumberUp(this GtkPrintSettingsHandle settings, int number_up)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_number_up(settings, number_up);
		return settings;
	}

	public static GtkNumberUpLayout GetNumberUpLayout(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_number_up_layout(settings);
	}

	public static GtkPrintSettingsHandle SetNumberUpLayout(this GtkPrintSettingsHandle settings, GtkNumberUpLayout number_up_layout)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_number_up_layout(settings, number_up_layout);
		return settings;
	}

	public static int GetResolution(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_resolution(settings);
	}

	public static GtkPrintSettingsHandle SetResolution(this GtkPrintSettingsHandle settings, int resolution)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_resolution(settings, resolution);
		return settings;
	}

	public static int GetResolutionX(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_resolution_x(settings);
	}

	public static int GetResolutionY(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_resolution_y(settings);
	}

	public static GtkPrintSettingsHandle SetResolutionXy(this GtkPrintSettingsHandle settings, int resolution_x, int resolution_y)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_resolution_xy(settings, resolution_x, resolution_y);
		return settings;
	}

	public static double GetPrinterLpi(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_printer_lpi(settings);
	}

	public static GtkPrintSettingsHandle SetPrinterLpi(this GtkPrintSettingsHandle settings, double lpi)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_printer_lpi(settings, lpi);
		return settings;
	}

	public static double GetScale(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_scale(settings);
	}

	public static GtkPrintSettingsHandle SetScale(this GtkPrintSettingsHandle settings, double scale)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_scale(settings, scale);
		return settings;
	}

	public static GtkPrintPages GetPrintPages(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_print_pages(settings);
	}

	public static GtkPrintSettingsHandle SetPrintPages(this GtkPrintSettingsHandle settings, GtkPrintPages pages)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_print_pages(settings, pages);
		return settings;
	}

	public static GtkPageRangeHandle GetPageRanges(this GtkPrintSettingsHandle settings, out int num_ranges)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_page_ranges(settings, out num_ranges);
	}

	public static GtkPrintSettingsHandle SetPageRanges(this GtkPrintSettingsHandle settings, GtkPageRangeHandle page_ranges, int num_ranges)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_page_ranges(settings, page_ranges, num_ranges);
		return settings;
	}

	public static GtkPageSet GetPageSet(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_page_set(settings);
	}

	public static GtkPrintSettingsHandle SetPageSet(this GtkPrintSettingsHandle settings, GtkPageSet page_set)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_page_set(settings, page_set);
		return settings;
	}

	public static string GetDefaultSource(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_default_source(settings);
	}

	public static GtkPrintSettingsHandle SetDefaultSource(this GtkPrintSettingsHandle settings, string default_source)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_default_source(settings, default_source);
		return settings;
	}

	public static string GetMediaType(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_media_type(settings);
	}

	public static GtkPrintSettingsHandle SetMediaType(this GtkPrintSettingsHandle settings, string media_type)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_media_type(settings, media_type);
		return settings;
	}

	public static string GetDither(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_dither(settings);
	}

	public static GtkPrintSettingsHandle SetDither(this GtkPrintSettingsHandle settings, string dither)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_dither(settings, dither);
		return settings;
	}

	public static string GetFinishings(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_finishings(settings);
	}

	public static GtkPrintSettingsHandle SetFinishings(this GtkPrintSettingsHandle settings, string finishings)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_finishings(settings, finishings);
		return settings;
	}

	public static string GetOutputBin(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_get_output_bin(settings);
	}

	public static GtkPrintSettingsHandle SetOutputBin(this GtkPrintSettingsHandle settings, string output_bin)
	{
		GtkPrintSettingsExterns.gtk_print_settings_set_output_bin(settings, output_bin);
		return settings;
	}

	public static GVariantHandle ToGvariant(this GtkPrintSettingsHandle settings)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_to_gvariant(settings);
	}

	public static GtkPrintSettingsHandle NewFromFile(string file_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_file(file_name, out error);
	}

	public static GtkPrintSettingsHandle NewFromKeyFile(GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_key_file(key_file, group_name, out error);
	}

	public static GtkPrintSettingsHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkPrintSettingsExterns.gtk_print_settings_new_from_gvariant(variant);
	}
}
