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

public class GtkPageSetupHandle : GObjectHandle
{
	public static GtkPageSetupHandle New()
	{
		return GtkPageSetupExterns.gtk_page_setup_new();
	}

	public static GtkPageSetupHandle NewFromFile(string file_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_new_from_file(file_name, out error);
	}

	public static GtkPageSetupHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkPageSetupExterns.gtk_page_setup_new_from_gvariant(variant);
	}

	public static GtkPageSetupHandle NewFromKeyFile(GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_new_from_key_file(key_file, group_name, out error);
	}

}

public static class GtkPageSetupHandleExtensions
{
	public static GtkPageSetupHandle Copy(this GtkPageSetupHandle other)
	{
		return GtkPageSetupExterns.gtk_page_setup_copy(other);
	}

	public static double GetBottomMargin(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_bottom_margin(setup, unit);
	}

	public static double GetLeftMargin(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_left_margin(setup, unit);
	}

	public static GtkPageOrientation GetOrientation(this GtkPageSetupHandle setup)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_orientation(setup);
	}

	public static double GetPageHeight(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_page_height(setup, unit);
	}

	public static double GetPageWidth(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_page_width(setup, unit);
	}

	public static double GetPaperHeight(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_paper_height(setup, unit);
	}

	public static GtkPaperSizeHandle GetPaperSize(this GtkPageSetupHandle setup)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_paper_size(setup);
	}

	public static double GetPaperWidth(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_paper_width(setup, unit);
	}

	public static double GetRightMargin(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_right_margin(setup, unit);
	}

	public static double GetTopMargin(this GtkPageSetupHandle setup, GtkUnit unit)
	{
		return GtkPageSetupExterns.gtk_page_setup_get_top_margin(setup, unit);
	}

	public static bool LoadFile(this GtkPageSetupHandle setup, string file_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_load_file(setup, file_name, out error);
	}

	public static bool LoadKeyFile(this GtkPageSetupHandle setup, GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_load_key_file(setup, key_file, group_name, out error);
	}

	public static GtkPageSetupHandle SetBottomMargin(this GtkPageSetupHandle setup, double margin, GtkUnit unit)
	{
		GtkPageSetupExterns.gtk_page_setup_set_bottom_margin(setup, margin, unit);
		return setup;
	}

	public static GtkPageSetupHandle SetLeftMargin(this GtkPageSetupHandle setup, double margin, GtkUnit unit)
	{
		GtkPageSetupExterns.gtk_page_setup_set_left_margin(setup, margin, unit);
		return setup;
	}

	public static GtkPageSetupHandle SetOrientation(this GtkPageSetupHandle setup, GtkPageOrientation orientation)
	{
		GtkPageSetupExterns.gtk_page_setup_set_orientation(setup, orientation);
		return setup;
	}

	public static GtkPageSetupHandle SetPaperSize(this GtkPageSetupHandle setup, GtkPaperSizeHandle size)
	{
		GtkPageSetupExterns.gtk_page_setup_set_paper_size(setup, size);
		return setup;
	}

	public static GtkPageSetupHandle SetPaperSizeAndDefaultMargins(this GtkPageSetupHandle setup, GtkPaperSizeHandle size)
	{
		GtkPageSetupExterns.gtk_page_setup_set_paper_size_and_default_margins(setup, size);
		return setup;
	}

	public static GtkPageSetupHandle SetRightMargin(this GtkPageSetupHandle setup, double margin, GtkUnit unit)
	{
		GtkPageSetupExterns.gtk_page_setup_set_right_margin(setup, margin, unit);
		return setup;
	}

	public static GtkPageSetupHandle SetTopMargin(this GtkPageSetupHandle setup, double margin, GtkUnit unit)
	{
		GtkPageSetupExterns.gtk_page_setup_set_top_margin(setup, margin, unit);
		return setup;
	}

	public static bool ToFile(this GtkPageSetupHandle setup, string file_name, out GErrorHandle error)
	{
		return GtkPageSetupExterns.gtk_page_setup_to_file(setup, file_name, out error);
	}

	public static GVariantHandle ToGvariant(this GtkPageSetupHandle setup)
	{
		return GtkPageSetupExterns.gtk_page_setup_to_gvariant(setup);
	}

	public static GtkPageSetupHandle ToKeyFile(this GtkPageSetupHandle setup, GKeyFileHandle key_file, string group_name)
	{
		GtkPageSetupExterns.gtk_page_setup_to_key_file(setup, key_file, group_name);
		return setup;
	}

}

internal class GtkPageSetupExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_page_setup_new();

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_page_setup_new_from_file(string file_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_page_setup_new_from_gvariant(GVariantHandle variant);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_page_setup_new_from_key_file(GKeyFileHandle key_file, string group_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageSetupHandle gtk_page_setup_copy(GtkPageSetupHandle other);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_page_setup_get_bottom_margin(GtkPageSetupHandle setup, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_page_setup_get_left_margin(GtkPageSetupHandle setup, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPageOrientation gtk_page_setup_get_orientation(GtkPageSetupHandle setup);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_page_setup_get_page_height(GtkPageSetupHandle setup, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_page_setup_get_page_width(GtkPageSetupHandle setup, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_page_setup_get_paper_height(GtkPageSetupHandle setup, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPaperSizeHandle gtk_page_setup_get_paper_size(GtkPageSetupHandle setup);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_page_setup_get_paper_width(GtkPageSetupHandle setup, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_page_setup_get_right_margin(GtkPageSetupHandle setup, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern double gtk_page_setup_get_top_margin(GtkPageSetupHandle setup, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_page_setup_load_file(GtkPageSetupHandle setup, string file_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_page_setup_load_key_file(GtkPageSetupHandle setup, GKeyFileHandle key_file, string group_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_page_setup_set_bottom_margin(GtkPageSetupHandle setup, double margin, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_page_setup_set_left_margin(GtkPageSetupHandle setup, double margin, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_page_setup_set_orientation(GtkPageSetupHandle setup, GtkPageOrientation orientation);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_page_setup_set_paper_size(GtkPageSetupHandle setup, GtkPaperSizeHandle size);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_page_setup_set_paper_size_and_default_margins(GtkPageSetupHandle setup, GtkPaperSizeHandle size);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_page_setup_set_right_margin(GtkPageSetupHandle setup, double margin, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_page_setup_set_top_margin(GtkPageSetupHandle setup, double margin, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_page_setup_to_file(GtkPageSetupHandle setup, string file_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern GVariantHandle gtk_page_setup_to_gvariant(GtkPageSetupHandle setup);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_page_setup_to_key_file(GtkPageSetupHandle setup, GKeyFileHandle key_file, string group_name);

}
