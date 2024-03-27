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

[Flags]
public enum GFormatSizeFlags
{
	G_FORMAT_SIZE_DEFAULT = 0,
	G_FORMAT_SIZE_LONG_FORMAT = 1,
	G_FORMAT_SIZE_IEC_UNITS = 2,
	G_FORMAT_SIZE_BITS = 4,
	G_FORMAT_SIZE_ONLY_VALUE = 8,
	G_FORMAT_SIZE_ONLY_UNIT = 16
}
