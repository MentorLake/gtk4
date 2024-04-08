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
