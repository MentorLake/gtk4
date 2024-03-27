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

namespace MentorLake.Gtk4.GObject;

[Flags]
public enum GSignalMatchType
{
	G_SIGNAL_MATCH_ID = 0,
	G_SIGNAL_MATCH_DETAIL = 1,
	G_SIGNAL_MATCH_CLOSURE = 2,
	G_SIGNAL_MATCH_FUNC = 4,
	G_SIGNAL_MATCH_DATA = 8,
	G_SIGNAL_MATCH_UNBLOCKED = 16
}
