namespace MentorLake.Gtk4.Gtk4;

public class GtkCssSectionHandle : BaseSafeHandle
{
	public static GtkCssSectionHandle New(GFileHandle file, GtkCssLocationHandle start, GtkCssLocationHandle end)
	{
		return GtkCssSectionExterns.gtk_css_section_new(file, start, end);
	}

}


public static class GtkCssSectionHandleExtensions
{
	public static GtkCssLocationHandle GetEndLocation(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_end_location(section);
	}

	public static GFileHandle GetFile(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_file(section);
	}

	public static GtkCssSectionHandle GetParent(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_parent(section);
	}

	public static GtkCssLocationHandle GetStartLocation(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_get_start_location(section);
	}

	public static GtkCssSectionHandle Print(this GtkCssSectionHandle section, GStringHandle @string)
	{
		GtkCssSectionExterns.gtk_css_section_print(section, @string);
		return section;
	}

	public static GtkCssSectionHandle Ref(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_ref(section);
	}

	public static string ToString(this GtkCssSectionHandle section)
	{
		return GtkCssSectionExterns.gtk_css_section_to_string(section);
	}

	public static GtkCssSectionHandle Unref(this GtkCssSectionHandle section)
	{
		GtkCssSectionExterns.gtk_css_section_unref(section);
		return section;
	}

}
internal class GtkCssSectionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCssSectionHandle gtk_css_section_new(GFileHandle file, GtkCssLocationHandle start, GtkCssLocationHandle end);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCssLocationHandle gtk_css_section_get_end_location(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk4)]
	internal static extern GFileHandle gtk_css_section_get_file(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCssSectionHandle gtk_css_section_get_parent(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCssLocationHandle gtk_css_section_get_start_location(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_css_section_print(GtkCssSectionHandle section, GStringHandle @string);

	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCssSectionHandle gtk_css_section_ref(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk4)]
	internal static extern string gtk_css_section_to_string(GtkCssSectionHandle section);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_css_section_unref(GtkCssSectionHandle section);

}

public struct GtkCssSection
{
}
