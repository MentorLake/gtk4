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

public interface GtkColorChooserHandle
{
}

public static class GtkColorChooserHandleExtensions
{
	public static GtkColorChooserHandle AddPalette(this GtkColorChooserHandle chooser, GtkOrientation orientation, int colors_per_line, int n_colors, GdkRGBA[] colors)
	{
		GtkColorChooserExterns.gtk_color_chooser_add_palette(chooser, orientation, colors_per_line, n_colors, colors);
		return chooser;
	}

	public static GtkColorChooserHandle GetRgba(this GtkColorChooserHandle chooser, out GdkRGBA color)
	{
		GtkColorChooserExterns.gtk_color_chooser_get_rgba(chooser, out color);
		return chooser;
	}

	public static bool GetUseAlpha(this GtkColorChooserHandle chooser)
	{
		return GtkColorChooserExterns.gtk_color_chooser_get_use_alpha(chooser);
	}

	public static GtkColorChooserHandle SetRgba(this GtkColorChooserHandle chooser, GdkRGBAHandle color)
	{
		GtkColorChooserExterns.gtk_color_chooser_set_rgba(chooser, color);
		return chooser;
	}

	public static GtkColorChooserHandle SetUseAlpha(this GtkColorChooserHandle chooser, bool use_alpha)
	{
		GtkColorChooserExterns.gtk_color_chooser_set_use_alpha(chooser, use_alpha);
		return chooser;
	}

}

internal class GtkColorChooserExterns
{
	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_chooser_add_palette(GtkColorChooserHandle chooser, GtkOrientation orientation, int colors_per_line, int n_colors, GdkRGBA[] colors);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_chooser_get_rgba(GtkColorChooserHandle chooser, out GdkRGBA color);

	[DllImport(Libraries.Gtk4)]
	internal static extern bool gtk_color_chooser_get_use_alpha(GtkColorChooserHandle chooser);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_chooser_set_rgba(GtkColorChooserHandle chooser, GdkRGBAHandle color);

	[DllImport(Libraries.Gtk4)]
	internal static extern void gtk_color_chooser_set_use_alpha(GtkColorChooserHandle chooser, bool use_alpha);

}
