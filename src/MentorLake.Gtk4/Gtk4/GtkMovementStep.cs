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

public enum GtkMovementStep
{
	GTK_MOVEMENT_LOGICAL_POSITIONS,
	GTK_MOVEMENT_VISUAL_POSITIONS,
	GTK_MOVEMENT_WORDS,
	GTK_MOVEMENT_DISPLAY_LINES,
	GTK_MOVEMENT_DISPLAY_LINE_ENDS,
	GTK_MOVEMENT_PARAGRAPHS,
	GTK_MOVEMENT_PARAGRAPH_ENDS,
	GTK_MOVEMENT_PAGES,
	GTK_MOVEMENT_BUFFER_ENDS,
	GTK_MOVEMENT_HORIZONTAL_PAGES
}
