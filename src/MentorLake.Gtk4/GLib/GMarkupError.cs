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

namespace MentorLake.Gtk4.GLib;

public enum GMarkupError
{
	G_MARKUP_ERROR_BAD_UTF8,
	G_MARKUP_ERROR_EMPTY,
	G_MARKUP_ERROR_PARSE,
	G_MARKUP_ERROR_UNKNOWN_ELEMENT,
	G_MARKUP_ERROR_UNKNOWN_ATTRIBUTE,
	G_MARKUP_ERROR_INVALID_CONTENT,
	G_MARKUP_ERROR_MISSING_ATTRIBUTE
}
