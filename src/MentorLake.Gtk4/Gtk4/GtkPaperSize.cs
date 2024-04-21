using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Gtk4;

public class GtkPaperSizeHandle : BaseSafeHandle
{
	public static GtkPaperSizeHandle New(string name)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new(name);
	}

	public static GtkPaperSizeHandle NewCustom(string name, string display_name, double width, double height, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_custom(name, display_name, width, height, unit);
	}

	public static GtkPaperSizeHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_gvariant(variant);
	}

	public static GtkPaperSizeHandle NewFromIpp(string ipp_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ipp(ipp_name, width, height);
	}

	public static GtkPaperSizeHandle NewFromKeyFile(GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_key_file(key_file, group_name, out error);
	}

	public static GtkPaperSizeHandle NewFromPpd(string ppd_name, string ppd_display_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ppd(ppd_name, ppd_display_name, width, height);
	}

}

internal class GtkPaperSizeExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new(string name);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new_custom(string name, string display_name, double width, double height, GtkUnit unit);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_gvariant(GVariantHandle variant);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_ipp(string ipp_name, double width, double height);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_key_file(GKeyFileHandle key_file, string group_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_ppd(string ppd_name, string ppd_display_name, double width, double height);

}

public struct GtkPaperSize
{
}
