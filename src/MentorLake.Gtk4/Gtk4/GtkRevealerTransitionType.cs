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

namespace MentorLake.Gtk4.Gtk4;

public enum GtkRevealerTransitionType
{
	GTK_REVEALER_TRANSITION_TYPE_NONE,
	GTK_REVEALER_TRANSITION_TYPE_CROSSFADE,
	GTK_REVEALER_TRANSITION_TYPE_SLIDE_RIGHT,
	GTK_REVEALER_TRANSITION_TYPE_SLIDE_LEFT,
	GTK_REVEALER_TRANSITION_TYPE_SLIDE_UP,
	GTK_REVEALER_TRANSITION_TYPE_SLIDE_DOWN,
	GTK_REVEALER_TRANSITION_TYPE_SWING_RIGHT,
	GTK_REVEALER_TRANSITION_TYPE_SWING_LEFT,
	GTK_REVEALER_TRANSITION_TYPE_SWING_UP,
	GTK_REVEALER_TRANSITION_TYPE_SWING_DOWN
}
