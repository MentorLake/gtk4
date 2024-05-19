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

namespace MentorLake.Gtk4.Gdk4;

public enum GdkSurfaceEdge
{
	GDK_SURFACE_EDGE_NORTH_WEST,
	GDK_SURFACE_EDGE_NORTH,
	GDK_SURFACE_EDGE_NORTH_EAST,
	GDK_SURFACE_EDGE_WEST,
	GDK_SURFACE_EDGE_EAST,
	GDK_SURFACE_EDGE_SOUTH_WEST,
	GDK_SURFACE_EDGE_SOUTH,
	GDK_SURFACE_EDGE_SOUTH_EAST
}
