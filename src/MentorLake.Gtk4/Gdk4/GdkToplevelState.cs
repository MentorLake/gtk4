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

[Flags]
public enum GdkToplevelState
{
	GDK_TOPLEVEL_STATE_MINIMIZED = 0,
	GDK_TOPLEVEL_STATE_MAXIMIZED = 1,
	GDK_TOPLEVEL_STATE_STICKY = 2,
	GDK_TOPLEVEL_STATE_FULLSCREEN = 4,
	GDK_TOPLEVEL_STATE_ABOVE = 8,
	GDK_TOPLEVEL_STATE_BELOW = 16,
	GDK_TOPLEVEL_STATE_FOCUSED = 32,
	GDK_TOPLEVEL_STATE_TILED = 64,
	GDK_TOPLEVEL_STATE_TOP_TILED = 128,
	GDK_TOPLEVEL_STATE_TOP_RESIZABLE = 256,
	GDK_TOPLEVEL_STATE_RIGHT_TILED = 512,
	GDK_TOPLEVEL_STATE_RIGHT_RESIZABLE = 1024,
	GDK_TOPLEVEL_STATE_BOTTOM_TILED = 2048,
	GDK_TOPLEVEL_STATE_BOTTOM_RESIZABLE = 4096,
	GDK_TOPLEVEL_STATE_LEFT_TILED = 8192,
	GDK_TOPLEVEL_STATE_LEFT_RESIZABLE = 16384,
	GDK_TOPLEVEL_STATE_SUSPENDED = 32768
}
