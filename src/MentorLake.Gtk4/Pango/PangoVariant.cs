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

public enum PangoVariant
{
	PANGO_VARIANT_NORMAL,
	PANGO_VARIANT_SMALL_CAPS,
	PANGO_VARIANT_ALL_SMALL_CAPS,
	PANGO_VARIANT_PETITE_CAPS,
	PANGO_VARIANT_ALL_PETITE_CAPS,
	PANGO_VARIANT_UNICASE,
	PANGO_VARIANT_TITLE_CAPS
}
