using System.Runtime.InteropServices;
using MentorLake.Gtk4.Gdk;

namespace MentorLake.Gtk4.Gtk;

public static class GtkColorChooserExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_color_chooser_get_rgba")]
	internal static extern void gtk_color_chooser_get_rgba(this GtkColorChooserHandle chooser, GdkRGBAHandle color);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_color_chooser_set_rgba")]
	internal static extern void gtk_color_chooser_set_rgba(this GtkColorChooserHandle chooser, GdkRGBAHandle color);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_color_chooser_get_use_alpha")]
	internal static extern int gtk_color_chooser_get_use_alpha(this GtkColorChooserHandle chooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_color_chooser_set_use_alpha")]
	internal static extern void gtk_color_chooser_set_use_alpha(this GtkColorChooserHandle chooser, int use_alpha);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_color_chooser_add_palette")]
	internal static extern void gtk_color_chooser_add_palette(this GtkColorChooserHandle chooser, GtkOrientation orientation, int colors_per_line, int n_colors, GdkRGBAHandle colors);
}
