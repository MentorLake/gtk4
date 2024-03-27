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
public enum GSignalFlags
{
	G_SIGNAL_RUN_FIRST = 0,
	G_SIGNAL_RUN_LAST = 1,
	G_SIGNAL_RUN_CLEANUP = 2,
	G_SIGNAL_NO_RECURSE = 4,
	G_SIGNAL_DETAILED = 8,
	G_SIGNAL_ACTION = 16,
	G_SIGNAL_NO_HOOKS = 32,
	G_SIGNAL_MUST_COLLECT = 64,
	G_SIGNAL_DEPRECATED = 128,
	G_SIGNAL_ACCUMULATOR_FIRST_RUN = 256
}
