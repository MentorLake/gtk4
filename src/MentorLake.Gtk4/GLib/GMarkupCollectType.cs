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
public enum GMarkupCollectType
{
	G_MARKUP_COLLECT_INVALID = 0,
	G_MARKUP_COLLECT_STRING = 1,
	G_MARKUP_COLLECT_STRDUP = 2,
	G_MARKUP_COLLECT_BOOLEAN = 4,
	G_MARKUP_COLLECT_TRISTATE = 8,
	G_MARKUP_COLLECT_OPTIONAL = 16
}
