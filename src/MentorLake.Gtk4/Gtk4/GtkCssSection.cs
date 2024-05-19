namespace MentorLake.Gtk4.Gtk4;

public class GtkCssSectionHandle : BaseSafeHandle
{
	public static GtkCssSectionHandle New(GFileHandle file, GtkCssLocationHandle start, GtkCssLocationHandle end)
	{
		return GtkCssSectionExterns.gtk_css_section_new(file, start, end);
	}

}

internal class GtkCssSectionExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern GtkCssSectionHandle gtk_css_section_new(GFileHandle file, GtkCssLocationHandle start, GtkCssLocationHandle end);

}

public struct GtkCssSection
{
}
