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

[Flags]
public enum GtkFontChooserLevel
{
	GTK_FONT_CHOOSER_LEVEL_FAMILY = 0,
	GTK_FONT_CHOOSER_LEVEL_STYLE = 1,
	GTK_FONT_CHOOSER_LEVEL_SIZE = 2,
	GTK_FONT_CHOOSER_LEVEL_VARIATIONS = 4,
	GTK_FONT_CHOOSER_LEVEL_FEATURES = 8
}
