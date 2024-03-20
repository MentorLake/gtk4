using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPageSetupAdaptors
{
	public static GtkPageSetupHandle Copy(this GtkPageSetupHandle other)
	{
		return GtkPageSetupExterns.gtk_page_setup_copy(other);
	}

	public static GtkPageOrientation GetOrientation(this GtkPageSetupHandle setup)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_orientation(setup);
	}

	public static GtkPageSetupHandle SetOrientation(this GtkPageSetupHandle setup, GtkPageOrientation orientation)
	{
		GtkPageSetupExterns.gtk_page_setup_set_orientation(setup, orientation);
		return setup;
	}

	public static GtkPaperSizeHandle GetPaperSize(this GtkPageSetupHandle setup)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_paper_size(setup);
	}

	public static GtkPageSetupHandle SetPaperSize(this GtkPageSetupHandle setup, GtkPaperSizeHandle size)
	{
		GtkPageSetupExterns.gtk_page_setup_set_paper_size(setup, size);
		return setup;
	}

	public static double GetTopMargin(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_top_margin(setup, unit);
	}

	public static GtkPageSetupHandle SetTopMargin(this GtkPageSetupHandle setup, double margin, GtkUnit unit)
	{
		GtkPageSetupExterns.gtk_page_setup_set_top_margin(setup, margin, unit);
		return setup;
	}

	public static double GetBottomMargin(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_bottom_margin(setup, unit);
	}

	public static GtkPageSetupHandle SetBottomMargin(this GtkPageSetupHandle setup, double margin, GtkUnit unit)
	{
		GtkPageSetupExterns.gtk_page_setup_set_bottom_margin(setup, margin, unit);
		return setup;
	}

	public static double GetLeftMargin(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_left_margin(setup, unit);
	}

	public static GtkPageSetupHandle SetLeftMargin(this GtkPageSetupHandle setup, double margin, GtkUnit unit)
	{
		GtkPageSetupExterns.gtk_page_setup_set_left_margin(setup, margin, unit);
		return setup;
	}

	public static double GetRightMargin(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_right_margin(setup, unit);
	}

	public static GtkPageSetupHandle SetRightMargin(this GtkPageSetupHandle setup, double margin, GtkUnit unit)
	{
		GtkPageSetupExterns.gtk_page_setup_set_right_margin(setup, margin, unit);
		return setup;
	}

	public static GtkPageSetupHandle SetPaperSizeAndDefaultMargins(this GtkPageSetupHandle setup, GtkPaperSizeHandle size)
	{
		GtkPageSetupExterns.gtk_page_setup_set_paper_size_and_default_margins(setup, size);
		return setup;
	}

	public static double GetPaperWidth(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_paper_width(setup, unit);
	}

	public static double GetPaperHeight(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_paper_height(setup, unit);
	}

	public static double GetPageWidth(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_page_width(setup, unit);
	}

	public static double GetPageHeight(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_page_height(setup, unit);
	}

	public static int LoadFile(this GtkPageSetupHandle setup, string file_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_load_file(setup, file_name, out error);
	}

	public static int ToFile(this GtkPageSetupHandle setup, string file_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_to_file(setup, file_name, out error);
	}

	public static int LoadKeyFile(this GtkPageSetupHandle setup, GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_load_key_file(setup, key_file, group_name, out error);
	}

	public static GtkPageSetupHandle ToKeyFile(this GtkPageSetupHandle setup, GKeyFileHandle key_file, string group_name)
	{
		GtkPageSetupExterns.gtk_page_setup_to_key_file(setup, key_file, group_name);
		return setup;
	}

	public static GVariantHandle ToGvariant(this GtkPageSetupHandle setup)
	{
		return GtkPageSetupExterns.gtk_page_setup_to_gvariant(setup);
	}

	public static GtkPageSetupHandle NewFromFile(string file_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_new_from_file(file_name, out error);
	}

	public static GtkPageSetupHandle NewFromKeyFile(GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_new_from_key_file(key_file, group_name, out error);
	}

	public static GtkPageSetupHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkPageSetupExterns.gtk_page_setup_new_from_gvariant(variant);
	}
}
