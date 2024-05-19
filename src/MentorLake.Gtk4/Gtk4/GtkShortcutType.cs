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

public enum GtkShortcutType
{
	GTK_SHORTCUT_ACCELERATOR,
	GTK_SHORTCUT_GESTURE_PINCH,
	GTK_SHORTCUT_GESTURE_STRETCH,
	GTK_SHORTCUT_GESTURE_ROTATE_CLOCKWISE,
	GTK_SHORTCUT_GESTURE_ROTATE_COUNTERCLOCKWISE,
	GTK_SHORTCUT_GESTURE_TWO_FINGER_SWIPE_LEFT,
	GTK_SHORTCUT_GESTURE_TWO_FINGER_SWIPE_RIGHT,
	GTK_SHORTCUT_GESTURE,
	GTK_SHORTCUT_GESTURE_SWIPE_LEFT,
	GTK_SHORTCUT_GESTURE_SWIPE_RIGHT
}
