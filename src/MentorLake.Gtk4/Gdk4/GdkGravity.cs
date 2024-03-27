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

public enum GdkGravity
{
	GDK_GRAVITY_NORTH_WEST,
	GDK_GRAVITY_NORTH,
	GDK_GRAVITY_NORTH_EAST,
	GDK_GRAVITY_WEST,
	GDK_GRAVITY_CENTER,
	GDK_GRAVITY_EAST,
	GDK_GRAVITY_SOUTH_WEST,
	GDK_GRAVITY_SOUTH,
	GDK_GRAVITY_SOUTH_EAST,
	GDK_GRAVITY_STATIC
}
