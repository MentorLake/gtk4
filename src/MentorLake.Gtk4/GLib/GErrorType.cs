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

public enum GErrorType
{
	G_ERR_UNKNOWN,
	G_ERR_UNEXP_EOF,
	G_ERR_UNEXP_EOF_IN_STRING,
	G_ERR_UNEXP_EOF_IN_COMMENT,
	G_ERR_NON_DIGIT_IN_CONST,
	G_ERR_DIGIT_RADIX,
	G_ERR_FLOAT_RADIX,
	G_ERR_FLOAT_MALFORMED
}
