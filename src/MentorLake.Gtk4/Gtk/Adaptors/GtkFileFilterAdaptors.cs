using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;

namespace MentorLake.Gtk4.Gtk;
public static class GtkFileFilterAdaptors
{
	public static GtkFileFilterHandle SetName(this GtkFileFilterHandle filter, string name)
	{
		GtkFileFilterExterns.gtk_file_filter_set_name(filter, name);
		return filter;
	}

	public static string GetName(this GtkFileFilterHandle filter)
	{
		return GtkFileFilterExterns.gtk_file_filter_get_name(filter);
	}

	public static GtkFileFilterHandle AddMimeType(this GtkFileFilterHandle filter, string mime_type)
	{
		GtkFileFilterExterns.gtk_file_filter_add_mime_type(filter, mime_type);
		return filter;
	}

	public static GtkFileFilterHandle AddPattern(this GtkFileFilterHandle filter, string pattern)
	{
		GtkFileFilterExterns.gtk_file_filter_add_pattern(filter, pattern);
		return filter;
	}

	public static GtkFileFilterHandle AddSuffix(this GtkFileFilterHandle filter, string suffix)
	{
		GtkFileFilterExterns.gtk_file_filter_add_suffix(filter, suffix);
		return filter;
	}

	public static GtkFileFilterHandle AddPixbufFormats(this GtkFileFilterHandle filter)
	{
		GtkFileFilterExterns.gtk_file_filter_add_pixbuf_formats(filter);
		return filter;
	}

	public static string[] GetAttributes(this GtkFileFilterHandle filter)
	{
		return GtkFileFilterExterns.gtk_file_filter_get_attributes(filter);
	}

	public static GVariantHandle ToGvariant(this GtkFileFilterHandle filter)
	{
		return GtkFileFilterExterns.gtk_file_filter_to_gvariant(filter);
	}

	public static GtkFileFilterHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkFileFilterExterns.gtk_file_filter_new_from_gvariant(variant);
	}
}