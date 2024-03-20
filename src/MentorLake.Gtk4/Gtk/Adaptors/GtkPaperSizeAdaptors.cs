using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkPaperSizeAdaptors
{
	public static GtkPaperSizeHandle Copy(this GtkPaperSizeHandle other)
	{
		return GtkPaperSizeExterns.gtk_paper_size_copy(other);
	}

	public static GtkPaperSizeHandle Free(this GtkPaperSizeHandle size)
	{
		GtkPaperSizeExterns.gtk_paper_size_free(size);
		return size;
	}

	public static int IsEqual(this GtkPaperSizeHandle size1, GtkPaperSizeHandle size2)
	{
		return GtkPaperSizeExterns.gtk_paper_size_is_equal(size1, size2);
	}

	public static string GetName(this GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_name(size);
	}

	public static string GetDisplayName(this GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_display_name(size);
	}

	public static string GetPpdName(this GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_ppd_name(size);
	}

	public static double GetWidth(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_width(size, unit);
	}

	public static double GetHeight(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_height(size, unit);
	}

	public static int IsCustom(this GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_is_custom(size);
	}

	public static int IsIpp(this GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_is_ipp(size);
	}

	public static GtkPaperSizeHandle SetSize(this GtkPaperSizeHandle size, double width, double height, GtkUnit unit)
	{
		GtkPaperSizeExterns.gtk_paper_size_set_size(size, width, height, unit);
		return size;
	}

	public static double GetDefaultTopMargin(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_top_margin(size, unit);
	}

	public static double GetDefaultBottomMargin(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_bottom_margin(size, unit);
	}

	public static double GetDefaultLeftMargin(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_left_margin(size, unit);
	}

	public static double GetDefaultRightMargin(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_right_margin(size, unit);
	}

	public static GtkPaperSizeHandle ToKeyFile(this GtkPaperSizeHandle size, GKeyFileHandle key_file, string group_name)
	{
		GtkPaperSizeExterns.gtk_paper_size_to_key_file(size, key_file, group_name);
		return size;
	}

	public static GVariantHandle ToGvariant(this GtkPaperSizeHandle paper_size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_to_gvariant(paper_size);
	}

	public static GtkPaperSizeHandle NewFromPpd(string ppd_name, string ppd_display_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ppd(ppd_name, ppd_display_name, width, height);
	}

	public static GtkPaperSizeHandle NewFromIpp(string ipp_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ipp(ipp_name, width, height);
	}

	public static GtkPaperSizeHandle NewCustom(string name, string display_name, double width, double height, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_custom(name, display_name, width, height, unit);
	}

	public static GtkPaperSizeHandle NewFromKeyFile(GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_key_file(key_file, group_name, out error);
	}

	public static GtkPaperSizeHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_gvariant(variant);
	}
}
