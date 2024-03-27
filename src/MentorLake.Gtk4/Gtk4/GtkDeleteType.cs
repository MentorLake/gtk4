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

public enum GtkDeleteType
{
	GTK_DELETE_CHARS,
	GTK_DELETE_WORD_ENDS,
	GTK_DELETE_WORDS,
	GTK_DELETE_DISPLAY_LINES,
	GTK_DELETE_DISPLAY_LINE_ENDS,
	GTK_DELETE_PARAGRAPH_ENDS,
	GTK_DELETE_PARAGRAPHS,
	GTK_DELETE_WHITESPACE
}
