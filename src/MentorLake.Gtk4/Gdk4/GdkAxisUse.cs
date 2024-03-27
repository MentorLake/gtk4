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

namespace MentorLake.Gtk4.Gdk4;

public enum GdkAxisUse
{
	GDK_AXIS_IGNORE,
	GDK_AXIS_X,
	GDK_AXIS_Y,
	GDK_AXIS_DELTA_X,
	GDK_AXIS_DELTA_Y,
	GDK_AXIS_PRESSURE,
	GDK_AXIS_XTILT,
	GDK_AXIS_YTILT,
	GDK_AXIS_WHEEL,
	GDK_AXIS_DISTANCE,
	GDK_AXIS_ROTATION,
	GDK_AXIS_SLIDER,
	GDK_AXIS_LAST
}
