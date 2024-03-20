using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkCssSectionAdaptors
{
	public static GtkCssSectionHandle Ref(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_ref(section);
	}

	public static GtkCssSectionHandle Unref(this GtkCssSectionHandle section)
	{
		GtkCssSectionExterns.gtk_css_section_unref(section);
		return section;
	}

	public static GtkCssSectionHandle Print(this GtkCssSectionHandle section, GStringHandle @string)
	{
		GtkCssSectionExterns.gtk_css_section_print(section, @string);
		return section;
	}

	public static string ToString(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_to_string(section);
	}

	public static GtkCssSectionHandle GetParent(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_parent(section);
	}

	public static GFileHandle GetFile(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_file(section);
	}

	public static GtkCssLocationHandle GetStartLocation(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_start_location(section);
	}

	public static GtkCssLocationHandle GetEndLocation(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_end_location(section);
	}
}
