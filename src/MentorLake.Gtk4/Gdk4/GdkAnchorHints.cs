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
public enum GdkAnchorHints
{
	GDK_ANCHOR_FLIP_X = 0,
	GDK_ANCHOR_FLIP_Y = 1,
	GDK_ANCHOR_SLIDE_X = 2,
	GDK_ANCHOR_SLIDE_Y = 4,
	GDK_ANCHOR_RESIZE_X = 8,
	GDK_ANCHOR_RESIZE_Y = 16,
	GDK_ANCHOR_FLIP = 32,
	GDK_ANCHOR_SLIDE = 64,
	GDK_ANCHOR_RESIZE = 128
}
