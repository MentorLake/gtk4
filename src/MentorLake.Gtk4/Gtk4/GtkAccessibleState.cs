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

public enum GtkAccessibleState
{
	GTK_ACCESSIBLE_STATE_BUSY,
	GTK_ACCESSIBLE_STATE_CHECKED,
	GTK_ACCESSIBLE_STATE_DISABLED,
	GTK_ACCESSIBLE_STATE_EXPANDED,
	GTK_ACCESSIBLE_STATE_HIDDEN,
	GTK_ACCESSIBLE_STATE_INVALID,
	GTK_ACCESSIBLE_STATE_PRESSED,
	GTK_ACCESSIBLE_STATE_SELECTED,
	GTK_ACCESSIBLE_STATE_VISITED
}
