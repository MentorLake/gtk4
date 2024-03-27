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

[Flags]
public enum GdkAxisFlags
{
	GDK_AXIS_FLAG_X = 0,
	GDK_AXIS_FLAG_Y = 1,
	GDK_AXIS_FLAG_DELTA_X = 2,
	GDK_AXIS_FLAG_DELTA_Y = 4,
	GDK_AXIS_FLAG_PRESSURE = 8,
	GDK_AXIS_FLAG_XTILT = 16,
	GDK_AXIS_FLAG_YTILT = 32,
	GDK_AXIS_FLAG_WHEEL = 64,
	GDK_AXIS_FLAG_DISTANCE = 128,
	GDK_AXIS_FLAG_ROTATION = 256,
	GDK_AXIS_FLAG_SLIDER = 512
}
