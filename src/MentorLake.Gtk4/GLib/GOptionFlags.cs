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
public enum GOptionFlags
{
	G_OPTION_FLAG_NONE = 0,
	G_OPTION_FLAG_HIDDEN = 1,
	G_OPTION_FLAG_IN_MAIN = 2,
	G_OPTION_FLAG_REVERSE = 4,
	G_OPTION_FLAG_NO_ARG = 8,
	G_OPTION_FLAG_FILENAME = 16,
	G_OPTION_FLAG_OPTIONAL_ARG = 32,
	G_OPTION_FLAG_NOALIAS = 64
}
