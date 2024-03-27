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

public enum GKeyFileError
{
	G_KEY_FILE_ERROR_UNKNOWN_ENCODING,
	G_KEY_FILE_ERROR_PARSE,
	G_KEY_FILE_ERROR_NOT_FOUND,
	G_KEY_FILE_ERROR_KEY_NOT_FOUND,
	G_KEY_FILE_ERROR_GROUP_NOT_FOUND,
	G_KEY_FILE_ERROR_INVALID_VALUE
}
