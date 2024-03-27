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

public enum PangoBidiType
{
	PANGO_BIDI_TYPE_L,
	PANGO_BIDI_TYPE_LRE,
	PANGO_BIDI_TYPE_LRO,
	PANGO_BIDI_TYPE_R,
	PANGO_BIDI_TYPE_AL,
	PANGO_BIDI_TYPE_RLE,
	PANGO_BIDI_TYPE_RLO,
	PANGO_BIDI_TYPE_PDF,
	PANGO_BIDI_TYPE_EN,
	PANGO_BIDI_TYPE_ES,
	PANGO_BIDI_TYPE_ET,
	PANGO_BIDI_TYPE_AN,
	PANGO_BIDI_TYPE_CS,
	PANGO_BIDI_TYPE_NSM,
	PANGO_BIDI_TYPE_BN,
	PANGO_BIDI_TYPE_B,
	PANGO_BIDI_TYPE_S,
	PANGO_BIDI_TYPE_WS,
	PANGO_BIDI_TYPE_ON,
	PANGO_BIDI_TYPE_LRI,
	PANGO_BIDI_TYPE_RLI,
	PANGO_BIDI_TYPE_FSI,
	PANGO_BIDI_TYPE_PDI
}
