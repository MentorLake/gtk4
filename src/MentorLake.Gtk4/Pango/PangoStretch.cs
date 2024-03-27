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

namespace MentorLake.Gtk4.Pango;

public enum PangoStretch
{
	PANGO_STRETCH_ULTRA_CONDENSED,
	PANGO_STRETCH_EXTRA_CONDENSED,
	PANGO_STRETCH_CONDENSED,
	PANGO_STRETCH_SEMI_CONDENSED,
	PANGO_STRETCH_NORMAL,
	PANGO_STRETCH_SEMI_EXPANDED,
	PANGO_STRETCH_EXPANDED,
	PANGO_STRETCH_EXTRA_EXPANDED,
	PANGO_STRETCH_ULTRA_EXPANDED
}
