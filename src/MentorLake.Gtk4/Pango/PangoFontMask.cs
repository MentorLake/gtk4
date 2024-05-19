using MentorLake.Gtk4.Graphene;
using MentorLake.Gtk4.Cairo;
using MentorLake.Gtk4.Harfbuzz;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;using MentorLake.Gtk4.GLib;
using MentorLake.Gtk4.GObject;
using MentorLake.Gtk4.Gio;
using MentorLake.Gtk4.GModule;
using MentorLake.Gtk4.Pango;
using MentorLake.Gtk4.GdkPixbuf;
using MentorLake.Gtk4.Gdk4;
using MentorLake.Gtk4.Gsk4;
using MentorLake.Gtk4.Gtk4;

namespace MentorLake.Gtk4.Pango;

[Flags]
public enum PangoFontMask
{
	PANGO_FONT_MASK_FAMILY = 0,
	PANGO_FONT_MASK_STYLE = 1,
	PANGO_FONT_MASK_VARIANT = 2,
	PANGO_FONT_MASK_WEIGHT = 4,
	PANGO_FONT_MASK_STRETCH = 8,
	PANGO_FONT_MASK_SIZE = 16,
	PANGO_FONT_MASK_GRAVITY = 32,
	PANGO_FONT_MASK_VARIATIONS = 64
}
