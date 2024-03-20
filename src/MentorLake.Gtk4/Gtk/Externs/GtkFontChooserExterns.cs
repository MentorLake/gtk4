using System.Runtime.InteropServices;
using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.Pango;

namespace MentorLake.Gtk4.Gtk;

public static class GtkFontChooserExterns
{
	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_get_font_family")]
	internal static extern PangoFontFamilyHandle gtk_font_chooser_get_font_family(this GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_get_font_face")]
	internal static extern PangoFontFaceHandle gtk_font_chooser_get_font_face(this GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_get_font_size")]
	internal static extern int gtk_font_chooser_get_font_size(this GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_get_font_desc")]
	internal static extern PangoFontDescriptionHandle gtk_font_chooser_get_font_desc(this GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_set_font_desc")]
	internal static extern void gtk_font_chooser_set_font_desc(this GtkFontChooserHandle fontchooser, PangoFontDescriptionHandle font_desc);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_get_font")]
	internal static extern string gtk_font_chooser_get_font(this GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_set_font")]
	internal static extern void gtk_font_chooser_set_font(this GtkFontChooserHandle fontchooser, string fontname);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_get_preview_text")]
	internal static extern string gtk_font_chooser_get_preview_text(this GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_set_preview_text")]
	internal static extern void gtk_font_chooser_set_preview_text(this GtkFontChooserHandle fontchooser, string text);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_get_show_preview_entry")]
	internal static extern int gtk_font_chooser_get_show_preview_entry(this GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_set_show_preview_entry")]
	internal static extern void gtk_font_chooser_set_show_preview_entry(this GtkFontChooserHandle fontchooser, int show_preview_entry);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_set_filter_func")]
	internal static extern void gtk_font_chooser_set_filter_func(this GtkFontChooserHandle fontchooser, GtkFontFilterFunc filter, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_set_font_map")]
	internal static extern void gtk_font_chooser_set_font_map(this GtkFontChooserHandle fontchooser, PangoFontMapHandle fontmap);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_get_font_map")]
	internal static extern PangoFontMapHandle gtk_font_chooser_get_font_map(this GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_set_level")]
	internal static extern void gtk_font_chooser_set_level(this GtkFontChooserHandle fontchooser, GtkFontChooserLevel level);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_get_level")]
	internal static extern GtkFontChooserLevel gtk_font_chooser_get_level(this GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_get_font_features")]
	internal static extern string gtk_font_chooser_get_font_features(this GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_get_language")]
	internal static extern string gtk_font_chooser_get_language(this GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk, EntryPoint = "gtk_font_chooser_set_language")]
	internal static extern void gtk_font_chooser_set_language(this GtkFontChooserHandle fontchooser, string language);
}
