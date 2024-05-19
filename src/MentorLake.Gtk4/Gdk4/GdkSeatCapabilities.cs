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
public enum GdkSeatCapabilities
{
	GDK_SEAT_CAPABILITY_NONE = 0,
	GDK_SEAT_CAPABILITY_POINTER = 1,
	GDK_SEAT_CAPABILITY_TOUCH = 2,
	GDK_SEAT_CAPABILITY_TABLET_STYLUS = 4,
	GDK_SEAT_CAPABILITY_KEYBOARD = 8,
	GDK_SEAT_CAPABILITY_TABLET_PAD = 16,
	GDK_SEAT_CAPABILITY_ALL_POINTING = 32,
	GDK_SEAT_CAPABILITY_ALL = 64
}
