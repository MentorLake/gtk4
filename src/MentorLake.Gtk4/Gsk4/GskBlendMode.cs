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

namespace MentorLake.Gtk4.Gsk4;

public enum GskBlendMode
{
	GSK_BLEND_MODE_DEFAULT,
	GSK_BLEND_MODE_MULTIPLY,
	GSK_BLEND_MODE_SCREEN,
	GSK_BLEND_MODE_OVERLAY,
	GSK_BLEND_MODE_DARKEN,
	GSK_BLEND_MODE_LIGHTEN,
	GSK_BLEND_MODE_COLOR_DODGE,
	GSK_BLEND_MODE_COLOR_BURN,
	GSK_BLEND_MODE_HARD_LIGHT,
	GSK_BLEND_MODE_SOFT_LIGHT,
	GSK_BLEND_MODE_DIFFERENCE,
	GSK_BLEND_MODE_EXCLUSION,
	GSK_BLEND_MODE_COLOR,
	GSK_BLEND_MODE_HUE,
	GSK_BLEND_MODE_SATURATION,
	GSK_BLEND_MODE_LUMINOSITY
}
